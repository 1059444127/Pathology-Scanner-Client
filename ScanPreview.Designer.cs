namespace FirstGuiClient
{
    partial class ScanPreview
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
            this.groupBoxPoorImage = new System.Windows.Forms.GroupBox();
            this.buttonPreviewAgain = new System.Windows.Forms.Button();
            this.buttonFullScreen = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.panelImage = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCreatePanorama = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelZoom = new System.Windows.Forms.Label();
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            this.groupBoxPoorImage.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPoorImage
            // 
            this.groupBoxPoorImage.Controls.Add(this.buttonPreviewAgain);
            this.groupBoxPoorImage.Location = new System.Drawing.Point(653, 12);
            this.groupBoxPoorImage.Name = "groupBoxPoorImage";
            this.groupBoxPoorImage.Size = new System.Drawing.Size(125, 123);
            this.groupBoxPoorImage.TabIndex = 0;
            this.groupBoxPoorImage.TabStop = false;
            this.groupBoxPoorImage.Text = "Poor Image ?";
            // 
            // buttonPreviewAgain
            // 
            this.buttonPreviewAgain.Location = new System.Drawing.Point(25, 32);
            this.buttonPreviewAgain.Name = "buttonPreviewAgain";
            this.buttonPreviewAgain.Size = new System.Drawing.Size(75, 58);
            this.buttonPreviewAgain.TabIndex = 0;
            this.buttonPreviewAgain.Text = "Scan Again";
            this.buttonPreviewAgain.UseVisualStyleBackColor = true;
            this.buttonPreviewAgain.Click += new System.EventHandler(this.buttonPreviewAgain_Click);
            // 
            // buttonFullScreen
            // 
            this.buttonFullScreen.Location = new System.Drawing.Point(25, 34);
            this.buttonFullScreen.Name = "buttonFullScreen";
            this.buttonFullScreen.Size = new System.Drawing.Size(75, 58);
            this.buttonFullScreen.TabIndex = 1;
            this.buttonFullScreen.Text = "Full Screen";
            this.buttonFullScreen.UseVisualStyleBackColor = true;
            this.buttonFullScreen.Click += new System.EventHandler(this.buttonFullScreen_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(703, 533);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(622, 533);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // panelImage
            // 
            this.panelImage.AutoScroll = true;
            this.panelImage.Controls.Add(this.pictureBox1);
            this.panelImage.Location = new System.Drawing.Point(12, 12);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(635, 515);
            this.panelImage.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 509);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCreatePanorama);
            this.groupBox1.Location = new System.Drawing.Point(653, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panorama";
            // 
            // buttonCreatePanorama
            // 
            this.buttonCreatePanorama.Enabled = false;
            this.buttonCreatePanorama.Location = new System.Drawing.Point(25, 28);
            this.buttonCreatePanorama.Name = "buttonCreatePanorama";
            this.buttonCreatePanorama.Size = new System.Drawing.Size(75, 58);
            this.buttonCreatePanorama.TabIndex = 0;
            this.buttonCreatePanorama.Text = "Create Panorama";
            this.buttonCreatePanorama.UseVisualStyleBackColor = true;
            this.buttonCreatePanorama.Click += new System.EventHandler(this.buttonCreatePanorama_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelZoom);
            this.groupBox2.Controls.Add(this.trackBarZoom);
            this.groupBox2.Controls.Add(this.buttonFullScreen);
            this.groupBox2.Location = new System.Drawing.Point(653, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 263);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // labelZoom
            // 
            this.labelZoom.AutoSize = true;
            this.labelZoom.Location = new System.Drawing.Point(45, 151);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(34, 13);
            this.labelZoom.TabIndex = 3;
            this.labelZoom.Text = "Zoom";
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.LargeChange = 2;
            this.trackBarZoom.Location = new System.Drawing.Point(10, 167);
            this.trackBarZoom.Minimum = 1;
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Size = new System.Drawing.Size(104, 45);
            this.trackBarZoom.TabIndex = 2;
            this.trackBarZoom.Value = 1;
            this.trackBarZoom.Scroll += new System.EventHandler(this.trackBarZoom_Scroll);
            // 
            // ScanPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 576);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxPoorImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ScanPreview";
            this.ShowIcon = false;
            this.Text = "Scan Preview";
            this.Load += new System.EventHandler(this.ScanPreview_Load);
            this.groupBoxPoorImage.ResumeLayout(false);
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPoorImage;
        private System.Windows.Forms.Button buttonFullScreen;
        private System.Windows.Forms.Button buttonPreviewAgain;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCreatePanorama;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelZoom;
        private System.Windows.Forms.TrackBar trackBarZoom;
    }
}