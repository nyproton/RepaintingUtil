using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EvilDICOM.Core;
using EvilDICOM.Core.Helpers;
using EvilDICOM.Core.Selection;
using System.IO;
using EvilDICOM.Core.Interfaces;
using EvilDICOM.Core.IO.Writing;
using EvilDICOM.Core.IO.Reading;
using System.Configuration;

namespace RepaintingUtil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.painted = false;
            this.border = 10;
            this.spotdiameter = 10;
            this.planOpened = this.planModified = this.planSaved = false;
            this.smallMUcap = Convert.ToDouble(ConfigurationManager.AppSettings.Get("smallMUcap"));
        }

        public DICOMObject plan { get; set; }
        public DICOMSelector sel { get; set; }
        public string filePlan { get; set; }

        public List<SpotMap> spotMaps { get; set; }
        public string currentBeam { get; set; }
        public int currentLayerIndex { get; set; }
        public float XMax { get; set; }
        public float YMax { get; set; }
        public float XMin { get; set; }
        public float YMin { get; set; }
        public float MeterWeightMax { get; set; }
        public float MeterWeightMin { get; set; }
        public float res { get; set; }
        public bool painted { get; set; }
        public float border { get; set; }
        public float spotdiameter { get; set; }
        public double MUMWratio { get; set; }
        public bool planOpened { get; set; }
        public bool planModified { get; set; }
        public bool planSaved { get; set; }
        public double smallMUcap { get; set; }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        this.filePlan = dialog.FileName;
                        this.plan = DICOMObject.Read(this.filePlan);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString() + "\nOpen DICOM file error.");
                    }
                    this.Text = "Repainting Utility - " + Path.GetFileName(this.filePlan);
                    toolStripStatusLabel1.Text = Path.GetFileName(this.filePlan) + " is Loaded.";
                    loadRTplan(plan);
                    planOpened = true;
                }
            }
        }

        private void loadRTplan(DICOMObject plan)
        {
            if (plan.SOPClass == EvilDICOM.Core.Enums.SOPClass.RTIonPlanStorage)
            {
                this.sel = plan.GetSelector();
                txtLastName.Text = this.sel.PatientName.LastName;
                txtFirstName.Text = this.sel.PatientName.FirstName;
                txtMedicalID.Text = this.sel.PatientID.Data;
                txtDOB.Text = ((DateTime)this.sel.PatientBirthDate.Data).ToString("MM/dd/yyyy");
                txtSex.Text = this.sel.PatientSex.Data;
                txtPlanID.Text = this.sel.RTPlanLabel.Data;
                txtFractions.Text = this.sel.FractionGroupSequence.Data_[0].FindFirst(TagHelper.NumberOfFractionsPlanned).DData.ToString();
                double dosefx = 0.0F;
                foreach (DICOMObject beam in this.sel.FractionGroupSequence.Data_[0].FindFirst(TagHelper.ReferencedBeamSequence).DData_)
                    dosefx += (double)beam.FindFirst(TagHelper.BeamDose).DData;
                txtDosefx.Text = (dosefx * 100).ToString("0.0") + " cGy";
                cbFields.Items.Clear();
                foreach (DICOMObject beam in this.sel.IonBeamSequence.Data_)
                    cbFields.Items.Add(beam.FindFirst(TagHelper.BeamName).DData.ToString());
            }
            else
            {
                MessageBox.Show("DICOM file is NOT RT Ion Plan.");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) //close
        {
            if (planOpened & planModified & !planSaved)
            {
                if (MessageBox.Show(String.Format("{0} modified but not saved, do you want to close?", Path.GetFileName(filePlan)), "Close?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    closePlan();
            }
            else
                closePlan();
        }

        private void closePlan()
        {


            this.plan = null;
            this.filePlan = "";
            spotMaps.Clear();
            currentBeam = "";
            planOpened = false;
            planModified = false;
            planSaved = false;
            painted = false;

            cbFields.Items.Clear();
            cbFields.Text = "";
            btnLoadField.Enabled = false;
            btnFirst.Enabled = false;
            btnLast.Enabled = false;
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
            splitToolStripMenuItem.Enabled = false;
            foreach (Control c in this.Controls)
                if (c.GetType() == typeof(GroupBox))
                    foreach (Control cc in c.Controls)
                        if (cc.GetType() == typeof(TextBox))
                            cc.Text = "";
            foreach (Control c in this.groupBox4.Controls)
                if (c.GetType() == typeof(GroupBox))
                    foreach (Control cc in c.Controls)
                        if (cc.GetType() == typeof(TextBox))
                            cc.Text = "";
            pictureBox1.BackgroundImage = null;
            pictureBox1.Image = null;
            toolStripStatusLabel1.Text = "No File";
            this.Text = "Repainting Utility - No File";
    }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (planOpened & planModified & !planSaved)
            {
                if (MessageBox.Show(String.Format("{0} modified but not saved, do you want to exit?", Path.GetFileName(filePlan)), "Exit?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else
                Application.Exit();
                    
        }

        private void cbFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.currentBeam = cbFields.SelectedItem.ToString();
            foreach (DICOMObject beam in this.sel.IonBeamSequence.DData_)
                if (beam.FindFirst(TagHelper.BeamName).DData.ToString() == this.currentBeam)
                {
                    int beamNo = (int)beam.FindFirst(TagHelper.BeamNumber).DData;
                    var fraction = this.sel.FractionGroupSequence.Data_[0];
                    foreach (DICOMObject b in fraction.FindFirst(TagHelper.ReferencedBeamSequence).DData_)
                        if ((int)b.FindFirst(TagHelper.ReferencedBeamNumber).DData == beamNo)
                        {
                            double MU = (double)b.FindFirst(TagHelper.BeamMeterset).DData;
                            this.MUMWratio = MU / (double)beam.FindFirst(TagHelper.FinalCumulativeMetersetWeight).DData;
                            txtMU.Text = MU.ToString();

                        }
                    List<DICOMObject> ioncps = (List<DICOMObject>)beam.FindFirst(TagHelper.IonControlPointSequence).DData_;
                    txtGantry.Text = ioncps[0].FindFirst(TagHelper.GantryAngle).DData.ToString() + "°";
                    txtCouch.Text = ioncps[0].FindFirst(TagHelper.PatientSupportAngle).DData.ToString() + "°";
                    txtSnout.Text = ioncps[0].FindFirst(TagHelper.SnoutPosition).DData.ToString() + "mm";
                    int rsNo = (int)beam.FindFirst(TagHelper.NumberOfRangeShifters).DData;
                    if (rsNo > 0)
                    {
                        List<DICOMObject> rs = (List<DICOMObject>)beam.FindFirst(TagHelper.RangeShifterSequence).DData_;
                        txtRS.Text = rs[0].FindFirst(TagHelper.RangeShifterID).DData.ToString();
                    }
                    else
                        txtRS.Text = "No range shift";
                    double topEn = (double)ioncps[0].FindFirst(TagHelper.NominalBeamEnergy).DData;
                    double botEn = (double)ioncps[ioncps.Count - 1].FindFirst(TagHelper.NominalBeamEnergy).DData;
                    txtEnergy.Text = String.Format("{0} - {1} MeV", topEn, botEn);
                    btnLoadField.Enabled = true;
                }
        }

        private void btnLoadField_Click(object sender, EventArgs e)
        {
            loadField();
        }

        private void loadField()
        {
            foreach (DICOMObject beam in this.sel.IonBeamSequence.DData_)
                if (beam.FindFirst(TagHelper.BeamName).DData.ToString() == this.currentBeam)
                {
                    List<DICOMObject> icps = (List<DICOMObject>)beam.FindFirst(TagHelper.IonControlPointSequence).DData_;
                    this.spotMaps = new List<SpotMap>();
                    for (int i = 0; i < icps.Count - 1; i += 2)
                        this.spotMaps.Add(new SpotMap(icps[i], icps[i + 1]));
                    XMax = YMax = MeterWeightMax = -1000;
                    XMin = YMin = MeterWeightMin = 1000;
                    foreach (SpotMap s in this.spotMaps)
                    {
                        if (s.X.Max() > XMax)
                            XMax = s.X.Max();
                        if (s.Y.Max() > YMax)
                            YMax = s.Y.Max();
                        if (s.X.Min() < XMin)
                            XMin = s.X.Min();
                        if (s.Y.Min() < YMin)
                            YMin = s.Y.Min();
                        if (s.MeterWeights.Max() > MeterWeightMax)
                            MeterWeightMax = s.MeterWeights.Max();
                        if (s.MeterWeights.Min() < MeterWeightMin)
                            MeterWeightMin = s.MeterWeights.Min();
                    }
                    this.currentLayerIndex = 0;
                    updateLayer(this.currentLayerIndex);

                    btnFirst.Enabled = true;
                    btnPrev.Enabled = true;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                    splitToolStripMenuItem.Enabled = true;
                }
        }

        private void updateLayer(int index)
        {
            txtLayerIndex.Text = this.spotMaps[index].LayerIndex.ToString();
            txtLayerEn.Text = this.spotMaps[index].NominalEnergy.ToString() + "MeV";
            txtLayerSpots.Text = this.spotMaps[index].ScanSpotNumber.ToString();
            txtLayerMaxMW.Text = this.spotMaps[index].MeterWeights.Max().ToString();
            txtLayerMaxMU.Text = (this.spotMaps[index].MeterWeights.Max() * this.MUMWratio).ToString();
            txtLayerMinMW.Text = this.spotMaps[index].MeterWeights.Min().ToString();
            txtLayerMinMU.Text = (this.spotMaps[index].MeterWeights.Min() * this.MUMWratio).ToString();

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            float xres = (bmp.Width - (this.border * 2)) / Math.Max(Math.Abs(XMax), Math.Abs(XMin)) / 2;
            float yres = (bmp.Height - (this.border * 2)) / Math.Max(Math.Abs(YMax), Math.Abs(YMin)) / 2;
            this.res = Math.Min(xres, yres);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                for (int i = 0; i < this.spotMaps[index].ScanSpotNumber; i++)
                {
                    float x = spotMaps[index].X[i] * this.res + pictureBox1.Width / 2 + border;
                    float y = pictureBox1.Height / 2 - spotMaps[index].Y[i] * this.res + border;
                    float MUfrac = (spotMaps[index].MeterWeights[i] - MeterWeightMin) / (MeterWeightMax - MeterWeightMin);
                    g.FillEllipse(new SolidBrush(rainbowColor(MUfrac)), x - this.spotdiameter / 2, y - this.spotdiameter / 2, this.spotdiameter, this.spotdiameter);
                }
            }
            pictureBox1.Image = null;
            pictureBox1.BackgroundImage = bmp;
            this.painted = true;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.currentLayerIndex = 0;
            updateLayer(this.currentLayerIndex);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.currentLayerIndex--;
            if (this.currentLayerIndex < 0)
                this.currentLayerIndex = 0;
            updateLayer(this.currentLayerIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.currentLayerIndex++;
            if (this.currentLayerIndex >= this.spotMaps.Count)
                this.currentLayerIndex = this.spotMaps.Count - 1;
            updateLayer(this.currentLayerIndex);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.currentLayerIndex = this.spotMaps.Count - 1;
            updateLayer(this.currentLayerIndex);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (painted)
            {
                if (e.X > this.border && e.X < pictureBox1.Width - this.border
                    && e.Y > this.border && e.Y < pictureBox1.Height - this.border)
                {
                    float spotx = (e.X - border - pictureBox1.Width / 2) / this.res;
                    float spoty = (pictureBox1.Height / 2 + border - e.Y) / this.res;
                    toolStripStatusLabel1.Text = String.Format("X: {0:0.000}   Y: {1:0.000}  px:{2}   py:{3} ", spotx, spoty, e.X, e.Y);
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (painted)
            {
                if (e.X > this.border && e.X < pictureBox1.Width - this.border
                    && e.Y > this.border && e.Y < pictureBox1.Height - this.border)
                {
                    float spotx = (e.X - border - pictureBox1.Width / 2) / this.res;
                    float spoty = (pictureBox1.Height / 2 + border - e.Y) / this.res;
                    float distMin = 1000;
                    int n = -1;
                    for (int i = 0; i < spotMaps[currentLayerIndex].ScanSpotNumber; i++)
                    {
                        float distance = (spotx - spotMaps[currentLayerIndex].X[i]) * (spotx - spotMaps[currentLayerIndex].X[i])
                            + (spoty - spotMaps[currentLayerIndex].Y[i]) * (spoty - spotMaps[currentLayerIndex].Y[i]);
                        if (distance < distMin)
                        {
                            distMin = distance;
                            n = i;
                        }
                    }
                    if (distMin < 10)
                    {
                        txtSpotX.Text = spotMaps[currentLayerIndex].X[n].ToString("0.000");
                        txtSpotY.Text = spotMaps[currentLayerIndex].Y[n].ToString("0.000");
                        txtSpotMW.Text = spotMaps[currentLayerIndex].MeterWeights[n].ToString("0.00000");
                        txtSpotMU.Text = (spotMaps[currentLayerIndex].MeterWeights[n] * this.MUMWratio).ToString("0.00000");

                        Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                        using (Graphics g = Graphics.FromImage(bmp))
                        {
                            float x = spotMaps[currentLayerIndex].X[n] * this.res + pictureBox1.Width / 2 + border;
                            float y = pictureBox1.Height / 2 - spotMaps[currentLayerIndex].Y[n] * this.res + border;
                            g.DrawEllipse(new Pen(Color.Yellow), x - this.spotdiameter / 2, y - this.spotdiameter / 2, this.spotdiameter, this.spotdiameter);
                        }
                        pictureBox1.Image = bmp;
                    }
                }
            }
        }

        private Color rainbowColor(float frac) //frac = (s-smin)/(smax-smin)
        {
            int r = 0, g = 0, b = 0;
            double a = (1 - frac) / 0.25;
            double X = Math.Floor(a);
            int Y = (int)Math.Floor(255 * (a - X));
            switch (X)
            {
                case 0: r = 255; g = Y; b = 0; break;
                case 1: r = 255 - Y; g = 255; b = 0; break;
                case 2: r = 0; g = 255; b = Y; break;
                case 3: r = 0; g = 255 - Y; b = 255; break;
                case 4: r = 0; g = 0; b = 255; break;
            }
            return Color.FromArgb(r, g, b);
        }

        private void splitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double currentEnergy = this.spotMaps[currentLayerIndex].NominalEnergy;
            SplitForm splitForm = new SplitForm(currentEnergy);
            splitForm.ShowDialog();
            if (splitForm.DialogResult == DialogResult.OK)
            {
                List<double> energies = new List<double>();
                energies.Add(currentEnergy);
                if (splitForm.energyUpflag)
                    energies.Add(splitForm.energyUp + currentEnergy);
                if (splitForm.energyDownflag)
                    energies.Add(currentEnergy - splitForm.energyDown);
                if (splitForm.HUthresholdflag)
                    splitEnergy(energies, splitForm.MUthreshold);
                else
                    splitEnergy(energies, -1.0);

                splitForm.Dispose();
            }
            else
                splitForm.Dispose();
        }

        private void splitEnergy(List<double> energies, double HUThreshold)
        {
            energies.Sort();
            energies.Reverse();
            SpotMap origSpotMap = this.spotMaps[this.currentLayerIndex];
            spotMaps.RemoveAt(this.currentLayerIndex);
            for (int i = 0; i < energies.Count; i++)
            {
                SpotMap sm = new SpotMap();
                sm.LayerIndex = this.currentLayerIndex + i;
                sm.NominalEnergy = energies[i];
                sm.SpotSizeX = origSpotMap.SpotSizeX;
                sm.SpotSizeY = origSpotMap.SpotSizeY;
                List<float> x = new List<float>();
                List<float> y = new List<float>();
                List<float> mw = new List<float>();
                for (int j = 0; j < origSpotMap.ScanSpotNumber; j++)
                {
                    if (sm.NominalEnergy != origSpotMap.NominalEnergy) //not original layer
                    {
                        if (origSpotMap.MeterWeights[j] * this.MUMWratio > HUThreshold)
                        {
                            x.Add(origSpotMap.X[j]);
                            y.Add(origSpotMap.Y[j]);
                            mw.Add(origSpotMap.MeterWeights[j] / energies.Count);
                        }
                    }
                    else
                    {
                        if (origSpotMap.MeterWeights[j] * this.MUMWratio > HUThreshold) //original layer
                        {
                            x.Add(origSpotMap.X[j]);
                            y.Add(origSpotMap.Y[j]);
                            mw.Add(origSpotMap.MeterWeights[j] / energies.Count);
                        }
                        else
                        {
                            x.Add(origSpotMap.X[j]);
                            y.Add(origSpotMap.Y[j]);
                            mw.Add(origSpotMap.MeterWeights[j]);
                        }
                    }
                }
                sm.ScanSpotNumber = x.Count;
                sm.X = x.ToArray();
                sm.Y = y.ToArray();
                sm.MeterWeights = mw.ToArray();
                sm.CumMeterWeight = mw.Sum();
                this.spotMaps.Insert(currentLayerIndex + i, sm);
            }

            double cmw = 0;
            for (int i = 0; i < spotMaps.Count; i++)
            {
                cmw += spotMaps[i].MeterWeights.Sum();
                spotMaps[i].CumMeterWeight = cmw;
                spotMaps[i].LayerIndex = i;
            }

            UpdateICS();
            adjustMU();
            loadField();
            planModified = true;
        }

        void UpdateICS()
        {
            foreach (DICOMObject beam in this.sel.IonBeamSequence.DData_)
                if (beam.FindFirst(TagHelper.BeamName).DData.ToString() == this.currentBeam)
                {
                    beam.FindFirst(TagHelper.NumberOfControlPoints).DData = this.spotMaps.Count * 2;
                    double finalCumMW = this.spotMaps[this.spotMaps.Count - 1].CumMeterWeight;
                    beam.FindFirst(TagHelper.FinalCumulativeMetersetWeight).DData = finalCumMW;
                    List<DICOMObject> icps = (List<DICOMObject>)beam.FindFirst(TagHelper.IonControlPointSequence).DData_;
                    var firstcp = Clone(icps[0]);
                    var restcp = Clone(icps[1]);
                    icps.Clear();
                    double cumMW = 0.0;
                    for (int i = 0; i < this.spotMaps.Count; i++)
                    {
                        List<float> positionmap = new List<float>();
                        List<float> mw = new List<float>();
                        List<float> mw0 = new List<float>();
                        List<float> spotsize = new List<float>();
                        for (int j = 0; j < this.spotMaps[i].ScanSpotNumber; j++)
                        {
                            positionmap.Add(this.spotMaps[i].X[j]);
                            positionmap.Add(this.spotMaps[i].Y[j]);
                            mw.Add(this.spotMaps[i].MeterWeights[j]);
                            mw0.Add(0);
                        }
                        spotsize.Add(this.spotMaps[i].SpotSizeX);
                        spotsize.Add(this.spotMaps[i].SpotSizeY);

                        var cp1 = Clone(restcp);
                        var cp2 = Clone(restcp);
                        if (i == 0)
                            cp1 = firstcp;

                        cp1.FindFirst(TagHelper.ControlPointIndex).DData = i * 2;
                        cp1.FindFirst(TagHelper.NominalBeamEnergy).DData = spotMaps[i].NominalEnergy;
                        cp1.FindFirst(TagHelper.CumulativeMetersetWeight).DData = cumMW;
                        cp1.FindFirst(TagHelper.NumberOfScanSpotPositions).DData = spotMaps[i].ScanSpotNumber;
                        cp1.FindFirst(TagHelper.ScanSpotPositionMap).DData_ = positionmap;
                        cp1.FindFirst(TagHelper.ScanSpotMetersetWeights).DData_ = mw;
                        cp1.FindFirst(TagHelper.ScanningSpotSize).DData_ = spotsize;
                        foreach (DICOMObject refdose in cp1.FindFirst(TagHelper.ReferencedDoseReferenceSequence).DData_)
                        {
                            refdose.FindFirst(TagHelper.CumulativeDoseReferenceCoefficient).DData = cumMW / finalCumMW;
                        }

                        cp2.FindFirst(TagHelper.ControlPointIndex).DData = i * 2 + 1;
                        cp2.FindFirst(TagHelper.NominalBeamEnergy).DData = spotMaps[i].NominalEnergy;
                        cumMW += spotMaps[i].MeterWeights.Sum();
                        cp2.FindFirst(TagHelper.CumulativeMetersetWeight).DData = cumMW;
                        cp2.FindFirst(TagHelper.NumberOfScanSpotPositions).DData = spotMaps[i].ScanSpotNumber;
                        cp2.FindFirst(TagHelper.ScanSpotPositionMap).DData_ = positionmap;
                        cp2.FindFirst(TagHelper.ScanSpotMetersetWeights).DData_ = mw0;
                        cp2.FindFirst(TagHelper.ScanningSpotSize).DData_ = spotsize;
                        foreach (DICOMObject refdose in cp2.FindFirst(TagHelper.ReferencedDoseReferenceSequence).DData_)
                        {
                            refdose.FindFirst(TagHelper.CumulativeDoseReferenceCoefficient).DData = cumMW / finalCumMW;
                        }

                        icps.Add(cp1);
                        icps.Add(cp2);
                    }

                }
        }

        void adjustMU() // to adjust MU for whole beam
        {
            foreach (DICOMObject beam in this.sel.IonBeamSequence.DData_)
                if (beam.FindFirst(TagHelper.BeamName).DData.ToString() == this.currentBeam)
                {
                    List<DICOMObject> icps = (List<DICOMObject>)beam.FindFirst(TagHelper.IonControlPointSequence).DData_;
                    //round MU to 4 and check smallMUcap
                    double smallMWcap = this.smallMUcap / this.MUMWratio;
                    bool endicp = false; //even icp is end icp (meterset weight should be 0
                    foreach (DICOMObject icp in icps)
                    {
                        List<float> mws = (List<float>)icp.FindFirst(TagHelper.ScanSpotMetersetWeights).DData_;
                        for (int i = 0; i < mws.Count; i++)
                        {
                            if (endicp)
                            {
                                mws[i] = 0;
                            }
                            else
                            {
                                //mws[i] = (float)Math.Round(mws[i], 4);
                                if (mws[i] < smallMWcap)
                                    mws[i] = (float)smallMWcap;
                            }
                        }
                        icp.FindFirst(TagHelper.ScanSpotMetersetWeights).DData_ = mws;
                        endicp = !endicp;
                    }
                    double cumTotalMW = 0.0;
                    foreach (DICOMObject icp in icps)
                        cumTotalMW += ((List<float>)(icp.FindFirst(TagHelper.ScanSpotMetersetWeights).DData_)).Sum();
                    //cumTotalMW = Math.Round(cumTotalMW, 4);

                    //adjust meterset weight
                    int idx = 0;
                    double cumMW = 0.0;
                    foreach (DICOMObject icp in icps)
                    {
                        icp.FindFirst(TagHelper.ControlPointIndex).DData = idx;
                        icp.FindFirst(TagHelper.CumulativeMetersetWeight).DData = cumMW;
                        foreach (DICOMObject refd in (List<DICOMObject>)icp.FindFirst(TagHelper.ReferencedDoseReferenceSequence).DData_)
                            //refd.FindFirst(TagHelper.CumulativeDoseReferenceCoefficient).DData = Math.Round(cumMW / cumTotalMW, 4);
                            refd.FindFirst(TagHelper.CumulativeDoseReferenceCoefficient).DData = cumMW / cumTotalMW;
                        cumMW += ((List<float>)icp.FindFirst(TagHelper.ScanSpotMetersetWeights).DData_).Sum();
                        idx++;
                        //cumMW = Math.Round(cumMW, 4);
                    }

                    beam.FindFirst(TagHelper.FinalCumulativeMetersetWeight).DData = cumTotalMW;
                    beam.FindFirst(TagHelper.NumberOfControlPoints).DData = icps.Count;
                    foreach (DICOMObject b in (List<DICOMObject>)(this.sel.FractionGroupSequence.Data_[0]).FindFirst(TagHelper.ReferencedBeamSequence).DData_)
                    {
                        if ((int)b.FindFirst(TagHelper.ReferencedBeamNumber).DData == (int)beam.FindFirst(TagHelper.BeamNumber).DData)
                            b.FindFirst(TagHelper.BeamMeterset).DData = cumTotalMW * this.MUMWratio;
                    }
                }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "DICOM File|*.dcm|All File|*.*";
                dialog.Title = "Save DICOM File";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        this.filePlan = dialog.FileName;
                        this.plan.Write(dialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString() + "\nSave DICOM file error.");
                    }
                    this.Text = "Repainting Utility - " + Path.GetFileName(this.filePlan);
                    toolStripStatusLabel1.Text = Path.GetFileName(this.filePlan) + " is Saved.";
                    planSaved = true;
                }
            }
        }

        public DICOMObject Clone(DICOMObject dcm) //copy and alter from EvilDICOM original code, clone a DICOMObject
        {
            List<IDICOMElement> copy = new List<IDICOMElement>();

            foreach (var el in dcm.Elements)
            {
                using (var ms = new MemoryStream())
                {
                    using (var dw = new DICOMBinaryWriter(ms))
                    {

                        DICOMElementWriter.Write(dw, DICOMIOSettings.Default(), el);
                    }
                    using (var dr = new DICOMBinaryReader(ms.ToArray()))
                    {
                        copy.Add(DICOMElementReader.ReadElementImplicitLittleEndian(dr));
                    }
                }
            }

            return new DICOMObject(copy);
        }

        private void preferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReferenceForm referenceForm = new ReferenceForm();
            referenceForm.ShowDialog();
            if (referenceForm.DialogResult == DialogResult.OK)
            {
                ConfigurationManager.AppSettings.Set("smallMUcap", referenceForm.smallMUcap.ToString());
                ConfigurationManager.AppSettings.Set("enIncrement", referenceForm.enIncrement.ToString());
                ConfigurationManager.AppSettings.Set("thresholdMU", referenceForm.thresholdMU.ToString());
                referenceForm.Dispose();
            }
            else
                referenceForm.Dispose();
        }
    }
}
