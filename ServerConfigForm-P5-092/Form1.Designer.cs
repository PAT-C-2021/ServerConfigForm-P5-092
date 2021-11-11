namespace ServerConfigForm_P5_092
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonON = new System.Windows.Forms.Button();
            this.buttonOFF = new System.Windows.Forms.Button();
            this.labelKet = new System.Windows.Forms.Label();
            this.labelOnOrOff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // buttonON
            // 
            this.buttonON.Location = new System.Drawing.Point(176, 172);
            this.buttonON.Name = "buttonON";
            this.buttonON.Size = new System.Drawing.Size(75, 23);
            this.buttonON.TabIndex = 1;
            this.buttonON.Text = "ON";
            this.buttonON.UseVisualStyleBackColor = true;
            this.buttonON.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOFF
            // 
            this.buttonOFF.Location = new System.Drawing.Point(328, 172);
            this.buttonOFF.Name = "buttonOFF";
            this.buttonOFF.Size = new System.Drawing.Size(75, 23);
            this.buttonOFF.TabIndex = 2;
            this.buttonOFF.Text = "OFF";
            this.buttonOFF.UseVisualStyleBackColor = true;
            this.buttonOFF.Click += new System.EventHandler(this.buttonOFF_Click);
            // 
            // labelKet
            // 
            this.labelKet.AutoSize = true;
            this.labelKet.Location = new System.Drawing.Point(264, 128);
            this.labelKet.Name = "labelKet";
            this.labelKet.Size = new System.Drawing.Size(0, 13);
            this.labelKet.TabIndex = 3;
            // 
            // labelOnOrOff
            // 
            this.labelOnOrOff.AutoSize = true;
            this.labelOnOrOff.Location = new System.Drawing.Point(264, 102);
            this.labelOnOrOff.Name = "labelOnOrOff";
            this.labelOnOrOff.Size = new System.Drawing.Size(0, 13);
            this.labelOnOrOff.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOnOrOff);
            this.Controls.Add(this.labelKet);
            this.Controls.Add(this.buttonOFF);
            this.Controls.Add(this.buttonON);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonON;
        private System.Windows.Forms.Button buttonOFF;
        private System.Windows.Forms.Label labelKet;
        private System.Windows.Forms.Label labelOnOrOff;
    }
}

