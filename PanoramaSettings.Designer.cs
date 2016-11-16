namespace FirstGuiClient
{
    partial class PanoramaSettings
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
            this.groupBoxPanoramaSettings = new System.Windows.Forms.GroupBox();
            this.textBoxTW = new System.Windows.Forms.TextBox();
            this.textBoxTL = new System.Windows.Forms.TextBox();
            this.labelTW = new System.Windows.Forms.Label();
            this.labelTL = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonScanPanorama = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelAT = new System.Windows.Forms.Label();
            this.labelAdvice1 = new System.Windows.Forms.Label();
            this.labelAdvice2 = new System.Windows.Forms.Label();
            this.labelAdvice3 = new System.Windows.Forms.Label();
            this.labelAdvice4 = new System.Windows.Forms.Label();
            this.groupBoxPanoramaSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPanoramaSettings
            // 
            this.groupBoxPanoramaSettings.Controls.Add(this.labelAdvice4);
            this.groupBoxPanoramaSettings.Controls.Add(this.labelAdvice3);
            this.groupBoxPanoramaSettings.Controls.Add(this.labelAdvice2);
            this.groupBoxPanoramaSettings.Controls.Add(this.labelAdvice1);
            this.groupBoxPanoramaSettings.Controls.Add(this.labelAT);
            this.groupBoxPanoramaSettings.Controls.Add(this.textBoxTW);
            this.groupBoxPanoramaSettings.Controls.Add(this.textBoxTL);
            this.groupBoxPanoramaSettings.Controls.Add(this.labelTW);
            this.groupBoxPanoramaSettings.Controls.Add(this.labelTL);
            this.groupBoxPanoramaSettings.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPanoramaSettings.Name = "groupBoxPanoramaSettings";
            this.groupBoxPanoramaSettings.Size = new System.Drawing.Size(440, 229);
            this.groupBoxPanoramaSettings.TabIndex = 8;
            this.groupBoxPanoramaSettings.TabStop = false;
            this.groupBoxPanoramaSettings.Text = "Panorama Settings";
            // 
            // textBoxTW
            // 
            this.textBoxTW.Location = new System.Drawing.Point(327, 38);
            this.textBoxTW.Name = "textBoxTW";
            this.textBoxTW.Size = new System.Drawing.Size(100, 20);
            this.textBoxTW.TabIndex = 3;
            // 
            // textBoxTL
            // 
            this.textBoxTL.Location = new System.Drawing.Point(111, 38);
            this.textBoxTL.Name = "textBoxTL";
            this.textBoxTL.Size = new System.Drawing.Size(100, 20);
            this.textBoxTL.TabIndex = 2;
            // 
            // labelTW
            // 
            this.labelTW.AutoSize = true;
            this.labelTW.Location = new System.Drawing.Point(229, 41);
            this.labelTW.Name = "labelTW";
            this.labelTW.Size = new System.Drawing.Size(94, 13);
            this.labelTW.TabIndex = 1;
            this.labelTW.Text = "Tissue width  (mm)";
            // 
            // labelTL
            // 
            this.labelTL.AutoSize = true;
            this.labelTL.Location = new System.Drawing.Point(13, 41);
            this.labelTL.Name = "labelTL";
            this.labelTL.Size = new System.Drawing.Size(95, 13);
            this.labelTL.TabIndex = 0;
            this.labelTL.Text = "Tissue length (mm)";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(377, 247);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonScanPanorama
            // 
            this.buttonScanPanorama.Location = new System.Drawing.Point(276, 247);
            this.buttonScanPanorama.Name = "buttonScanPanorama";
            this.buttonScanPanorama.Size = new System.Drawing.Size(95, 23);
            this.buttonScanPanorama.TabIndex = 10;
            this.buttonScanPanorama.Text = "Scan Panorama";
            this.buttonScanPanorama.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(195, 247);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // labelAT
            // 
            this.labelAT.AutoSize = true;
            this.labelAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAT.Location = new System.Drawing.Point(184, 73);
            this.labelAT.Name = "labelAT";
            this.labelAT.Size = new System.Drawing.Size(72, 16);
            this.labelAT.TabIndex = 4;
            this.labelAT.Text = "Attention!";
            // 
            // labelAdvice1
            // 
            this.labelAdvice1.AutoSize = true;
            this.labelAdvice1.Location = new System.Drawing.Point(40, 103);
            this.labelAdvice1.Name = "labelAdvice1";
            this.labelAdvice1.Size = new System.Drawing.Size(319, 13);
            this.labelAdvice1.TabIndex = 5;
            this.labelAdvice1.Text = "- adjust Miscroscope table to upper left corner of the tissue section";
            // 
            // labelAdvice2
            // 
            this.labelAdvice2.AutoSize = true;
            this.labelAdvice2.Location = new System.Drawing.Point(40, 131);
            this.labelAdvice2.Name = "labelAdvice2";
            this.labelAdvice2.Size = new System.Drawing.Size(121, 13);
            this.labelAdvice2.TabIndex = 6;
            this.labelAdvice2.Text = "- adjust the lenses focus";
            // 
            // labelAdvice3
            // 
            this.labelAdvice3.AutoSize = true;
            this.labelAdvice3.Location = new System.Drawing.Point(40, 160);
            this.labelAdvice3.Name = "labelAdvice3";
            this.labelAdvice3.Size = new System.Drawing.Size(181, 13);
            this.labelAdvice3.TabIndex = 7;
            this.labelAdvice3.Text = "- make sure all cables are connected";
            // 
            // labelAdvice4
            // 
            this.labelAdvice4.AutoSize = true;
            this.labelAdvice4.Location = new System.Drawing.Point(40, 189);
            this.labelAdvice4.Name = "labelAdvice4";
            this.labelAdvice4.Size = new System.Drawing.Size(148, 13);
            this.labelAdvice4.TabIndex = 8;
            this.labelAdvice4.Text = "- be patient untill scan finishes";
            // 
            // PanoramaSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 282);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonScanPanorama);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxPanoramaSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PanoramaSettings";
            this.ShowIcon = false;
            this.Text = "Panorama Settings";
            this.groupBoxPanoramaSettings.ResumeLayout(false);
            this.groupBoxPanoramaSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPanoramaSettings;
        private System.Windows.Forms.Label labelAdvice4;
        private System.Windows.Forms.Label labelAdvice3;
        private System.Windows.Forms.Label labelAdvice2;
        private System.Windows.Forms.Label labelAdvice1;
        private System.Windows.Forms.Label labelAT;
        private System.Windows.Forms.TextBox textBoxTW;
        private System.Windows.Forms.TextBox textBoxTL;
        private System.Windows.Forms.Label labelTW;
        private System.Windows.Forms.Label labelTL;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonScanPanorama;
        private System.Windows.Forms.Button buttonBack;
    }
}