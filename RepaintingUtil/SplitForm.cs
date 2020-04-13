using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot.Axes;

namespace RepaintingUtil
{
    public partial class SplitForm : Form
    {
        public SplitForm(double enIncrement, double thresholdMU, List<SpotMap> spotMaps, double MUMWratio, double smallMUcap)
        {
            InitializeComponent();
            this.spotMaps = spotMaps;
            this.MUMWratio = MUMWratio;
            this.smallMUcap = smallMUcap;
            numEnPlus.Value = Convert.ToDecimal(enIncrement);
            numEnMinus.Value = Convert.ToDecimal(enIncrement);
            numMU.Value = Convert.ToDecimal(thresholdMU);
            initText = initNote();
            txtStatistic.Text = initText;
        }

        private string initNote()
        {
            int totalSpots = spotMaps.Sum(s => s.ScanSpotNumber);
            double maxMU = spotMaps.Max(s => s.MeterWeights.Max()) * this.MUMWratio;
            double maxEn = spotMaps.Max(s => s.NominalEnergy);
            double minEn = spotMaps.Min(s => s.NominalEnergy);
            return string.Format("Total {0} layers from {1:0.000} MeV to {2:0.000} MeV. Total {3} spots. Max MU is {4:0.000}.", spotMaps.Count, minEn, maxEn, totalSpots, maxMU);
        }


        public double energyUp { get; set; }
        public double energyDown { get; set; }
        public double thresholdMU { get; set; }
        public double layerThreshold { get; set; }
        public double layerPercent { get; set; }
        public bool energyUpflag { get; set; }
        public bool energyDownflag { get; set; }
        public bool HUthresholdflag { get; set; }
        public bool layerThresholdflag { get; set; }
        public bool layerPercentflag { get; set; }
        public List<SpotMap> spotMaps { get; set; }
        public double MUMWratio { get; set; }
        public double smallMUcap { get; set; }
        public string initText { get; set; }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numEnPlus.Enabled = cbEnUp.Checked;
            updateNote();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            numEnMinus.Enabled = cbEnDown.Checked;
            updateNote();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            numMU.Enabled = rbSpotsThreshold.Checked;
            updateNote();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            numMU.Enabled = rbSpotsThreshold.Checked;
            updateNote();
        }

        private void updateNote()
        {
            this.thresholdMU = Convert.ToDouble(numMU.Value);
            this.HUthresholdflag = rbSpotsThreshold.Checked;
            this.energyUp = Convert.ToDouble(numEnPlus.Value);
            this.energyUpflag = cbEnUp.Checked;
            this.energyDown = Convert.ToDouble(numEnMinus.Value);
            this.energyDownflag = cbEnDown.Checked;
            this.layerPercent = Convert.ToDouble(numLayerPercent.Value);
            this.layerPercentflag = rbLayersPercent.Checked;
            this.layerThreshold = Convert.ToDouble(numLayerThreshold.Value);
            this.layerThresholdflag = rbLayersThreshold.Checked;
            if (!this.HUthresholdflag)
                this.thresholdMU = -1.0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void numEnPlus_ValueChanged(object sender, EventArgs e)
        {
            updateNote();
        }

        private void numMU_ValueChanged(object sender, EventArgs e)
        {
            updateNote();
        }

        private void numEnMinus_ValueChanged(object sender, EventArgs e)
        {
            updateNote();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            updateNote();
        }

        private void rbLayersAll_CheckedChanged(object sender, EventArgs e)
        {
            numLayerPercent.Enabled = rbLayersPercent.Checked;
            numLayerThreshold.Enabled = rbLayersThreshold.Checked;
            updateNote();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            updateNote();
            //get layers
            List<double> layers = new List<double>();
            if (layerPercentflag)
            {
                int num = (int)(layerPercent * spotMaps.Count / 100);
                layers = spotMaps.OrderByDescending(s => s.NominalEnergy).Select(s => s.NominalEnergy).Take(num).ToList();
            }
            else if (layerThresholdflag)
                layers = spotMaps.Where(s => s.NominalEnergy > layerThreshold).Select(s => s.NominalEnergy).ToList();
            else
                layers = spotMaps.Select(s => s.NominalEnergy).ToList();

            List<SpotMap> ssm = Utility.splitSpotMaps(spotMaps, thresholdMU, MUMWratio, layers, energyUp, smallMUcap, energyUpflag, energyDownflag);
            int totalSpots = ssm.Sum(s => s.ScanSpotNumber);
            double maxMU = ssm.Max(s => s.MeterWeights.Max()) * this.MUMWratio;

            txtStatistic.Text = initText + string.Format(" After split total {0} layers, Total {1} spot and Max MU is {2:0.000}.", ssm.Count, totalSpots, maxMU);
            txtStatistic.Text += ("\nUse PgUP PgDn to ZOOM, use right mouse click and drag to PAN.");

            panel3.Controls.Clear();
            int ht = 0;
            foreach (SpotMap sm in ssm)
            {
                var pm = new PlotModel { Title = string.Format("{0:0.000}MeV", sm.NominalEnergy), TitleFontSize = 10 };
                var coloraxis = new LinearColorAxis
                {
                    Key = "ColorAxis",
                    Position = AxisPosition.None,
                    Minimum = ssm.Min(ss => ss.MeterWeights.Min()),
                    Maximum = ssm.Max(ss => ss.MeterWeights.Max())
                };
                pm.Axes.Add(coloraxis);
                var s = new ScatterSeries { MarkerType = MarkerType.Circle, MarkerSize = 2, MarkerStrokeThickness = 0, ColorAxisKey = "ColorAxis", TrackerFormatString = "\nX: {2:0.###}\nY: {4:0.###}\nMU: {Tag}" };
                for (int i = 0; i < sm.ScanSpotNumber; i++)
                    s.Points.Add(new ScatterPoint(sm.X[i], sm.Y[i], double.NaN, sm.MeterWeights[i] * this.MUMWratio, (sm.MeterWeights[i] * this.MUMWratio).ToString("0.###")));
                pm.Series.Add(s);
                var pv = new PlotView();
                pv.Model = pm;
                pm.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = -200, Maximum = 200 });
                pm.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Minimum = -200, Maximum = 200 });
                pv.Location = new System.Drawing.Point(0, ht);
                pv.Size = new System.Drawing.Size(360, 400);
                ht += pv.Size.Height;
                panel3.Controls.Add(pv);
            }
        }
    }
}
