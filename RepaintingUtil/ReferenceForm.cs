using System;
using System.Windows.Forms;
using System.Configuration;

namespace RepaintingUtil
{
    public partial class ReferenceForm : Form
    {
        public double smallMUcap { get; set; }
        public double enIncrement { get; set; }
        public double thresholdMU { get; set; }
        public ReferenceForm()
        {
            InitializeComponent();
            smallMUcap = Convert.ToDouble(ConfigurationManager.AppSettings.Get("smallMUcap"));
            enIncrement = Convert.ToDouble(ConfigurationManager.AppSettings.Get("enIncrement"));
            thresholdMU = Convert.ToDouble(ConfigurationManager.AppSettings.Get("thresholdMU"));
            txtSmallMUcap.Text = smallMUcap.ToString();
            txtEnIncrement.Text = enIncrement.ToString();
            txtThresholdMU.Text = thresholdMU.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            smallMUcap = Convert.ToDouble(txtSmallMUcap.Text);
            enIncrement = Convert.ToDouble(txtEnIncrement.Text);
            thresholdMU = Convert.ToDouble(txtThresholdMU.Text);
        }
    }
}
