namespace FirstGuiClient
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbMain = new System.Windows.Forms.TextBox();
            this.btnStartClient = new System.Windows.Forms.Button();
            this.btnTakePhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbMain
            // 
            this.tbMain.Location = new System.Drawing.Point(12, 368);
            this.tbMain.MaxLength = 327677676;
            this.tbMain.Multiline = true;
            this.tbMain.Name = "tbMain";
            this.tbMain.ReadOnly = true;
            this.tbMain.Size = new System.Drawing.Size(300, 95);
            this.tbMain.TabIndex = 1;
            this.tbMain.TextChanged += new System.EventHandler(this.tbMain_TextChanged);
            // 
            // btnStartClient
            // 
            this.btnStartClient.Location = new System.Drawing.Point(12, 318);
            this.btnStartClient.Name = "btnStartClient";
            this.btnStartClient.Size = new System.Drawing.Size(75, 44);
            this.btnStartClient.TabIndex = 2;
            this.btnStartClient.Text = "Start Client";
            this.btnStartClient.UseVisualStyleBackColor = true;
            this.btnStartClient.Click += new System.EventHandler(this.btnStartClient_Click);
            // 
            // btnTakePhoto
            // 
            this.btnTakePhoto.Location = new System.Drawing.Point(237, 318);
            this.btnTakePhoto.Name = "btnTakePhoto";
            this.btnTakePhoto.Size = new System.Drawing.Size(75, 44);
            this.btnTakePhoto.TabIndex = 3;
            this.btnTakePhoto.Text = "Take Photo";
            this.btnTakePhoto.UseVisualStyleBackColor = true;
            this.btnTakePhoto.Click += new System.EventHandler(this.btnTakePhoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 475);
            this.Controls.Add(this.btnTakePhoto);
            this.Controls.Add(this.btnStartClient);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbMain;
        private System.Windows.Forms.Button btnStartClient;
        private System.Windows.Forms.Button btnTakePhoto;
    }
}

