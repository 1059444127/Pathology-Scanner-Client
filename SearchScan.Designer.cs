namespace FirstGuiClient
{
    partial class SearchScan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.textBoxPatientSurname = new System.Windows.Forms.TextBox();
            this.checkBoxPatientSurname = new System.Windows.Forms.CheckBox();
            this.textBoxDoctorSurname = new System.Windows.Forms.TextBox();
            this.checkBoxDoctorSurname = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxPatientName = new System.Windows.Forms.TextBox();
            this.checkBoxPatientName = new System.Windows.Forms.CheckBox();
            this.textBoxDoctorName = new System.Windows.Forms.TextBox();
            this.checkBoxDoctorName = new System.Windows.Forms.CheckBox();
            this.textBoxPatientIDNP = new System.Windows.Forms.TextBox();
            this.checkBoxPatientIDNP = new System.Windows.Forms.CheckBox();
            this.textBoxScanID = new System.Windows.Forms.TextBox();
            this.checkBoxScanID = new System.Windows.Forms.CheckBox();
            this.groupBoxSearchResults = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chScanID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatientIDNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDoctor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chResultNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBoxSearchResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonShowAll);
            this.groupBox1.Controls.Add(this.textBoxPatientSurname);
            this.groupBox1.Controls.Add(this.checkBoxPatientSurname);
            this.groupBox1.Controls.Add(this.textBoxDoctorSurname);
            this.groupBox1.Controls.Add(this.checkBoxDoctorSurname);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.textBoxPatientName);
            this.groupBox1.Controls.Add(this.checkBoxPatientName);
            this.groupBox1.Controls.Add(this.textBoxDoctorName);
            this.groupBox1.Controls.Add(this.checkBoxDoctorName);
            this.groupBox1.Controls.Add(this.textBoxPatientIDNP);
            this.groupBox1.Controls.Add(this.checkBoxPatientIDNP);
            this.groupBox1.Controls.Add(this.textBoxScanID);
            this.groupBox1.Controls.Add(this.checkBoxScanID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 418);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search criteria";
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(151, 305);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(92, 84);
            this.buttonShowAll.TabIndex = 13;
            this.buttonShowAll.Text = "Show All";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // textBoxPatientSurname
            // 
            this.textBoxPatientSurname.Location = new System.Drawing.Point(108, 258);
            this.textBoxPatientSurname.Name = "textBoxPatientSurname";
            this.textBoxPatientSurname.Size = new System.Drawing.Size(135, 20);
            this.textBoxPatientSurname.TabIndex = 12;
            // 
            // checkBoxPatientSurname
            // 
            this.checkBoxPatientSurname.AutoSize = true;
            this.checkBoxPatientSurname.Location = new System.Drawing.Point(6, 258);
            this.checkBoxPatientSurname.Name = "checkBoxPatientSurname";
            this.checkBoxPatientSurname.Size = new System.Drawing.Size(105, 17);
            this.checkBoxPatientSurname.TabIndex = 11;
            this.checkBoxPatientSurname.Text = "Patient surname:";
            this.checkBoxPatientSurname.UseVisualStyleBackColor = true;
            // 
            // textBoxDoctorSurname
            // 
            this.textBoxDoctorSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDoctorSurname.Location = new System.Drawing.Point(108, 159);
            this.textBoxDoctorSurname.Name = "textBoxDoctorSurname";
            this.textBoxDoctorSurname.Size = new System.Drawing.Size(135, 20);
            this.textBoxDoctorSurname.TabIndex = 10;
            // 
            // checkBoxDoctorSurname
            // 
            this.checkBoxDoctorSurname.AutoSize = true;
            this.checkBoxDoctorSurname.Location = new System.Drawing.Point(6, 159);
            this.checkBoxDoctorSurname.Name = "checkBoxDoctorSurname";
            this.checkBoxDoctorSurname.Size = new System.Drawing.Size(104, 17);
            this.checkBoxDoctorSurname.TabIndex = 9;
            this.checkBoxDoctorSurname.Text = "Doctor surname:";
            this.checkBoxDoctorSurname.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(18, 305);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(92, 84);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPatientName
            // 
            this.textBoxPatientName.Location = new System.Drawing.Point(108, 211);
            this.textBoxPatientName.Name = "textBoxPatientName";
            this.textBoxPatientName.Size = new System.Drawing.Size(135, 20);
            this.textBoxPatientName.TabIndex = 7;
            // 
            // checkBoxPatientName
            // 
            this.checkBoxPatientName.AutoSize = true;
            this.checkBoxPatientName.Location = new System.Drawing.Point(6, 211);
            this.checkBoxPatientName.Name = "checkBoxPatientName";
            this.checkBoxPatientName.Size = new System.Drawing.Size(91, 17);
            this.checkBoxPatientName.TabIndex = 6;
            this.checkBoxPatientName.Text = "Patient name:";
            this.checkBoxPatientName.UseVisualStyleBackColor = true;
            // 
            // textBoxDoctorName
            // 
            this.textBoxDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDoctorName.Location = new System.Drawing.Point(91, 107);
            this.textBoxDoctorName.Name = "textBoxDoctorName";
            this.textBoxDoctorName.Size = new System.Drawing.Size(152, 20);
            this.textBoxDoctorName.TabIndex = 5;
            // 
            // checkBoxDoctorName
            // 
            this.checkBoxDoctorName.AutoSize = true;
            this.checkBoxDoctorName.Location = new System.Drawing.Point(6, 107);
            this.checkBoxDoctorName.Name = "checkBoxDoctorName";
            this.checkBoxDoctorName.Size = new System.Drawing.Size(90, 17);
            this.checkBoxDoctorName.TabIndex = 4;
            this.checkBoxDoctorName.Text = "Doctor name:";
            this.checkBoxDoctorName.UseVisualStyleBackColor = true;
            // 
            // textBoxPatientIDNP
            // 
            this.textBoxPatientIDNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPatientIDNP.Location = new System.Drawing.Point(91, 64);
            this.textBoxPatientIDNP.Name = "textBoxPatientIDNP";
            this.textBoxPatientIDNP.Size = new System.Drawing.Size(152, 20);
            this.textBoxPatientIDNP.TabIndex = 3;
            // 
            // checkBoxPatientIDNP
            // 
            this.checkBoxPatientIDNP.AutoSize = true;
            this.checkBoxPatientIDNP.Location = new System.Drawing.Point(5, 66);
            this.checkBoxPatientIDNP.Name = "checkBoxPatientIDNP";
            this.checkBoxPatientIDNP.Size = new System.Drawing.Size(91, 17);
            this.checkBoxPatientIDNP.TabIndex = 2;
            this.checkBoxPatientIDNP.Text = "Patient IDNP:";
            this.checkBoxPatientIDNP.UseVisualStyleBackColor = true;
            // 
            // textBoxScanID
            // 
            this.textBoxScanID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxScanID.Location = new System.Drawing.Point(91, 28);
            this.textBoxScanID.Name = "textBoxScanID";
            this.textBoxScanID.Size = new System.Drawing.Size(152, 20);
            this.textBoxScanID.TabIndex = 1;
            // 
            // checkBoxScanID
            // 
            this.checkBoxScanID.AutoSize = true;
            this.checkBoxScanID.Location = new System.Drawing.Point(6, 30);
            this.checkBoxScanID.Name = "checkBoxScanID";
            this.checkBoxScanID.Size = new System.Drawing.Size(68, 17);
            this.checkBoxScanID.TabIndex = 0;
            this.checkBoxScanID.Text = "Scan ID:";
            this.checkBoxScanID.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearchResults
            // 
            this.groupBoxSearchResults.Controls.Add(this.listView1);
            this.groupBoxSearchResults.Location = new System.Drawing.Point(279, 12);
            this.groupBoxSearchResults.Name = "groupBoxSearchResults";
            this.groupBoxSearchResults.Size = new System.Drawing.Size(539, 424);
            this.groupBoxSearchResults.TabIndex = 1;
            this.groupBoxSearchResults.TabStop = false;
            this.groupBoxSearchResults.Text = "Search Results";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chResultNr,
            this.chScanID,
            this.chPatientIDNP,
            this.chPatient,
            this.chDoctor});
            this.listView1.Location = new System.Drawing.Point(6, 15);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(527, 403);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.ItemDoubleClick);
            // 
            // chScanID
            // 
            this.chScanID.Text = "Scan Id";
            this.chScanID.Width = 100;
            // 
            // chPatientIDNP
            // 
            this.chPatientIDNP.Text = "PatientIDNP";
            this.chPatientIDNP.Width = 122;
            // 
            // chPatient
            // 
            this.chPatient.Text = "Patient";
            this.chPatient.Width = 146;
            // 
            // chDoctor
            // 
            this.chDoctor.Text = "Doctor";
            this.chDoctor.Width = 135;
            // 
            // chResultNr
            // 
            this.chResultNr.Text = "Result ";
            this.chResultNr.Width = 20;
            // 
            // SearchScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 448);
            this.Controls.Add(this.groupBoxSearchResults);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "SearchScan";
            this.ShowIcon = false;
            this.Text = "Search Scan";
            this.Load += new System.EventHandler(this.SearchScan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSearchResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxPatientName;
        private System.Windows.Forms.CheckBox checkBoxPatientName;
        private System.Windows.Forms.TextBox textBoxDoctorName;
        private System.Windows.Forms.CheckBox checkBoxDoctorName;
        private System.Windows.Forms.TextBox textBoxPatientIDNP;
        private System.Windows.Forms.CheckBox checkBoxPatientIDNP;
        private System.Windows.Forms.TextBox textBoxScanID;
        private System.Windows.Forms.CheckBox checkBoxScanID;
        private System.Windows.Forms.GroupBox groupBoxSearchResults;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chScanID;
        private System.Windows.Forms.ColumnHeader chPatientIDNP;
        private System.Windows.Forms.ColumnHeader chPatient;
        private System.Windows.Forms.ColumnHeader chDoctor;
        private System.Windows.Forms.TextBox textBoxPatientSurname;
        private System.Windows.Forms.CheckBox checkBoxPatientSurname;
        private System.Windows.Forms.TextBox textBoxDoctorSurname;
        private System.Windows.Forms.CheckBox checkBoxDoctorSurname;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.ColumnHeader chResultNr;
    }
}