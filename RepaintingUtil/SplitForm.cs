using System;
using System.Text;
using System.Windows.Forms;


namespace RepaintingUtil
{
    public partial class SplitForm : Form
    {
        public SplitForm(double energy, double enIncrement, double thresholdMU)
        {
            InitializeComponent();
            this.energy = energy;
            numEnPlus.Value = Convert.ToDecimal(enIncrement);
            numEnMinus.Value = Convert.ToDecimal(enIncrement);
            numMU.Value = Convert.ToDecimal(thresholdMU);
            updateNote();

        }

        double energy;
        public double energyUp { get; set; }
        public double energyDown { get; set; }
        public double thresholdMU { get; set; }
        public bool energyUpflag { get; set; }
        public bool energyDownflag { get; set; }
        public bool HUthresholdflag { get; set; }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numEnPlus.Enabled = checkBox1.Checked;
            updateNote();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            numEnMinus.Enabled = checkBox2.Checked;
            updateNote();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            numMU.Enabled = radioButton2.Checked;
            updateNote();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            numMU.Enabled = radioButton2.Checked;
            updateNote();
        }

        private void updateNote()
        {
            this.thresholdMU = Convert.ToDouble(numMU.Value);
            this.energyUp = Convert.ToDouble(numEnPlus.Value);
            this.energyUpflag = checkBox1.Checked;
            this.energyDown = Convert.ToDouble(numEnMinus.Value);
            this.energyDownflag = checkBox2.Checked;
            this.HUthresholdflag = radioButton2.Checked;

            //StringBuilder sb = new StringBuilder();
            //sb.Append(String.Format("Split function is to split the current energy ({0}MeV) to {0}MeV, ", this.energy));
            //if (checkBox1.Checked)
            //{
            //    energyUp = (double)numEnPlus.Value;
            //    sb.Append(String.Format("{0}MeV, ", energy + energyUp));
            //}
            //if (checkBox2.Checked)
            //{
            //    energyDown = (double)numEnMinus.Value;
            //    sb.Append(String.Format("{0}MeV, ", energy + energyDown));
            //}
            //if (radioButton1.Checked)
            //{
            //    sb.Append("all spots will be split.");
            //}
            //if (radioButton2.Checked)
            //{
            //    MUthreshold = Convert.ToDouble(numMU.Text);
            //    sb.Append(String.Format("only spots with MU big than {0} will be split.", MUthreshold));
            //}
            //txtNote.Text = sb.ToString();
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
            this.thresholdMU = Convert.ToDouble(numMU.Value);
            this.energyUp = Convert.ToDouble(numEnPlus.Value);
            this.energyUpflag = checkBox1.Checked;
            this.energyDown = Convert.ToDouble(numEnMinus.Value);
            this.energyDownflag = checkBox2.Checked;
            this.HUthresholdflag = radioButton2.Checked;
        }
    }
}
