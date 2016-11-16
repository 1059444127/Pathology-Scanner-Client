namespace FirstGuiClient
{
    partial class NewScanWizzardMode
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.radioButtonSingleImage = new System.Windows.Forms.RadioButton();
            this.radioButtonPanoramaImage = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select the Scan Type:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(455, 407);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(368, 407);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 7;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // radioButtonSingleImage
            // 
            this.radioButtonSingleImage.AutoSize = true;
            this.radioButtonSingleImage.Checked = true;
            this.radioButtonSingleImage.Location = new System.Drawing.Point(26, 31);
            this.radioButtonSingleImage.Name = "radioButtonSingleImage";
            this.radioButtonSingleImage.Size = new System.Drawing.Size(86, 17);
            this.radioButtonSingleImage.TabIndex = 9;
            this.radioButtonSingleImage.TabStop = true;
            this.radioButtonSingleImage.Text = "Single Image";
            this.radioButtonSingleImage.UseVisualStyleBackColor = true;
            // 
            // radioButtonPanoramaImage
            // 
            this.radioButtonPanoramaImage.AutoSize = true;
            this.radioButtonPanoramaImage.Enabled = false;
            this.radioButtonPanoramaImage.Location = new System.Drawing.Point(26, 68);
            this.radioButtonPanoramaImage.Name = "radioButtonPanoramaImage";
            this.radioButtonPanoramaImage.Size = new System.Drawing.Size(174, 17);
            this.radioButtonPanoramaImage.TabIndex = 10;
            this.radioButtonPanoramaImage.Text = "Panorama Image (not available)";
            this.radioButtonPanoramaImage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSingleImage);
            this.groupBox1.Controls.Add(this.radioButtonPanoramaImage);
            this.groupBox1.Location = new System.Drawing.Point(12, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 122);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scan Type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "- a single image scan will be perfomed.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Single Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(31, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Panorama Image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "- a panorama image will be performed.";
            // 
            // NewScanWizzardMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 442);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "NewScanWizzardMode";
            this.ShowIcon = false;
            this.Text = "New Scan";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NewScanWizzardMode_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.RadioButton radioButtonSingleImage;
        private System.Windows.Forms.RadioButton radioButtonPanoramaImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}