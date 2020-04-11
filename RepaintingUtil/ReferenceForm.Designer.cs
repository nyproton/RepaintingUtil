namespace RepaintingUtil
{
    partial class ReferenceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReferenceForm));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSmallMUcap = new System.Windows.Forms.TextBox();
            this.txtEnIncrement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThresholdMU = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(40, 107);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(141, 107);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minimal MU";
            // 
            // txtSmallMUcap
            // 
            this.txtSmallMUcap.Location = new System.Drawing.Point(130, 6);
            this.txtSmallMUcap.Name = "txtSmallMUcap";
            this.txtSmallMUcap.Size = new System.Drawing.Size(65, 22);
            this.txtSmallMUcap.TabIndex = 3;
            this.txtSmallMUcap.Text = "2.0";
            this.txtSmallMUcap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEnIncrement
            // 
            this.txtEnIncrement.Location = new System.Drawing.Point(130, 34);
            this.txtEnIncrement.Name = "txtEnIncrement";
            this.txtEnIncrement.Size = new System.Drawing.Size(65, 22);
            this.txtEnIncrement.TabIndex = 5;
            this.txtEnIncrement.Text = "0.2";
            this.txtEnIncrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Energy Increment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "MU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "MeV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "MU";
            // 
            // txtThresholdMU
            // 
            this.txtThresholdMU.Location = new System.Drawing.Point(130, 62);
            this.txtThresholdMU.Name = "txtThresholdMU";
            this.txtThresholdMU.Size = new System.Drawing.Size(65, 22);
            this.txtThresholdMU.TabIndex = 9;
            this.txtThresholdMU.Text = "10";
            this.txtThresholdMU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Threshold MU";
            // 
            // ReferenceForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(254, 154);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtThresholdMU);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnIncrement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSmallMUcap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReferenceForm";
            this.Text = "Reference";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSmallMUcap;
        private System.Windows.Forms.TextBox txtEnIncrement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThresholdMU;
        private System.Windows.Forms.Label label6;
    }
}