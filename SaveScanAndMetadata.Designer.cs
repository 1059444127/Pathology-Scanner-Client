namespace FirstGuiClient
{
    partial class SaveScanAndMetadata
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
            this.groupBoxSaveLocation = new System.Windows.Forms.GroupBox();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.checkBoxDatabase = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.groupBoxSaveLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSaveLocation
            // 
            this.groupBoxSaveLocation.Controls.Add(this.textBoxDatabase);
            this.groupBoxSaveLocation.Controls.Add(this.checkBoxDatabase);
            this.groupBoxSaveLocation.Controls.Add(this.button1);
            this.groupBoxSaveLocation.Controls.Add(this.textBox1);
            this.groupBoxSaveLocation.Controls.Add(this.checkBox1);
            this.groupBoxSaveLocation.Location = new System.Drawing.Point(3, 12);
            this.groupBoxSaveLocation.Name = "groupBoxSaveLocation";
            this.groupBoxSaveLocation.Size = new System.Drawing.Size(609, 109);
            this.groupBoxSaveLocation.TabIndex = 0;
            this.groupBoxSaveLocation.TabStop = false;
            this.groupBoxSaveLocation.Text = "Save Location";
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(83, 65);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.ReadOnly = true;
            this.textBoxDatabase.Size = new System.Drawing.Size(172, 20);
            this.textBoxDatabase.TabIndex = 4;
            this.textBoxDatabase.Text = "Local Database";
            // 
            // checkBoxDatabase
            // 
            this.checkBoxDatabase.AutoSize = true;
            this.checkBoxDatabase.Checked = true;
            this.checkBoxDatabase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDatabase.Location = new System.Drawing.Point(9, 68);
            this.checkBoxDatabase.Name = "checkBoxDatabase";
            this.checkBoxDatabase.Size = new System.Drawing.Size(72, 17);
            this.checkBoxDatabase.TabIndex = 3;
            this.checkBoxDatabase.Text = "Database";
            this.checkBoxDatabase.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(281, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(83, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "R:\\Test";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(9, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Archieve";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(537, 407);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(402, 407);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(129, 23);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Save And Close";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // SaveScanAndMetadata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxSaveLocation);
            this.MaximizeBox = false;
            this.Name = "SaveScanAndMetadata";
            this.ShowIcon = false;
            this.Text = "Save Scan";
            this.Load += new System.EventHandler(this.SaveScanAndMetadata_Load);
            this.groupBoxSaveLocation.ResumeLayout(false);
            this.groupBoxSaveLocation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSaveLocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.CheckBox checkBoxDatabase;
    }
}