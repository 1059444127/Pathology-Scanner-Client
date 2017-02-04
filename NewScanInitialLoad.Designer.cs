namespace FirstGuiClient
{
    partial class NewScanInitialLoad
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
            this.labelInitialLoad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInitialLoad
            // 
            this.labelInitialLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelInitialLoad.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInitialLoad.Location = new System.Drawing.Point(36, 65);
            this.labelInitialLoad.Name = "labelInitialLoad";
            this.labelInitialLoad.Size = new System.Drawing.Size(359, 19);
            this.labelInitialLoad.TabIndex = 1;
            this.labelInitialLoad.Text = "Loading...";
            this.labelInitialLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInitialLoad.TextChanged += new System.EventHandler(this.labelInitialLoad_TextChanged);
            this.labelInitialLoad.Click += new System.EventHandler(this.labelInitialLoad_Click);
            // 
            // NewScanInitialLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 148);
            this.Controls.Add(this.labelInitialLoad);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewScanInitialLoad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scanning Image...";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NewScanInitialLoad_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelInitialLoad;

    }
}