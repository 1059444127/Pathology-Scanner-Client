namespace FirstGuiClient
{
    partial class OpenScan
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxTissueDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTissueType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxScanID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDoctorDegree = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDoctorSurname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDoctorName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPatientSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPatientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPatientIDNP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxClinicalDiagnosis = new System.Windows.Forms.TextBox();
            this.buttonSaveToFolder = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox10);
            this.groupBox5.Location = new System.Drawing.Point(12, 300);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(611, 156);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Clinical Diagnosis";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(9, 19);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox10.Size = new System.Drawing.Size(596, 131);
            this.textBox10.TabIndex = 9;
            this.textBox10.Text = "This is clinical diagnosis.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxTissueDescription);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBoxTissueType);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(12, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(611, 110);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tissue Information";
            // 
            // textBoxTissueDescription
            // 
            this.textBoxTissueDescription.Location = new System.Drawing.Point(301, 22);
            this.textBoxTissueDescription.Multiline = true;
            this.textBoxTissueDescription.Name = "textBoxTissueDescription";
            this.textBoxTissueDescription.ReadOnly = true;
            this.textBoxTissueDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTissueDescription.Size = new System.Drawing.Size(287, 72);
            this.textBoxTissueDescription.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(228, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Description:";
            // 
            // textBoxTissueType
            // 
            this.textBoxTissueType.Location = new System.Drawing.Point(46, 25);
            this.textBoxTissueType.Multiline = true;
            this.textBoxTissueType.Name = "textBoxTissueType";
            this.textBoxTissueType.ReadOnly = true;
            this.textBoxTissueType.Size = new System.Drawing.Size(156, 69);
            this.textBoxTissueType.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSaveToFolder);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBoxScanID);
            this.groupBox3.Location = new System.Drawing.Point(469, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 143);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Scanned Image";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Scan ID:";
            // 
            // textBoxScanID
            // 
            this.textBoxScanID.Location = new System.Drawing.Point(61, 103);
            this.textBoxScanID.Name = "textBoxScanID";
            this.textBoxScanID.ReadOnly = true;
            this.textBoxScanID.Size = new System.Drawing.Size(70, 20);
            this.textBoxScanID.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxDoctorDegree);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxDoctorSurname);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxDoctorName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(236, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 143);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doctor Information";
            // 
            // textBoxDoctorDegree
            // 
            this.textBoxDoctorDegree.Location = new System.Drawing.Point(88, 99);
            this.textBoxDoctorDegree.Name = "textBoxDoctorDegree";
            this.textBoxDoctorDegree.ReadOnly = true;
            this.textBoxDoctorDegree.Size = new System.Drawing.Size(122, 20);
            this.textBoxDoctorDegree.TabIndex = 11;
            this.textBoxDoctorDegree.Text = "doctor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(4, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "PhD degree:";
            // 
            // textBoxDoctorSurname
            // 
            this.textBoxDoctorSurname.Location = new System.Drawing.Point(77, 57);
            this.textBoxDoctorSurname.Name = "textBoxDoctorSurname";
            this.textBoxDoctorSurname.ReadOnly = true;
            this.textBoxDoctorSurname.Size = new System.Drawing.Size(133, 20);
            this.textBoxDoctorSurname.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(4, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Surname:";
            // 
            // textBoxDoctorName
            // 
            this.textBoxDoctorName.Location = new System.Drawing.Point(77, 19);
            this.textBoxDoctorName.Name = "textBoxDoctorName";
            this.textBoxDoctorName.ReadOnly = true;
            this.textBoxDoctorName.Size = new System.Drawing.Size(133, 20);
            this.textBoxDoctorName.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(4, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPatientSurname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxPatientName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxPatientIDNP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 143);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Information";
            // 
            // textBoxPatientSurname
            // 
            this.textBoxPatientSurname.Location = new System.Drawing.Point(70, 61);
            this.textBoxPatientSurname.Name = "textBoxPatientSurname";
            this.textBoxPatientSurname.ReadOnly = true;
            this.textBoxPatientSurname.Size = new System.Drawing.Size(132, 20);
            this.textBoxPatientSurname.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Surname:";
            // 
            // textBoxPatientName
            // 
            this.textBoxPatientName.Location = new System.Drawing.Point(61, 19);
            this.textBoxPatientName.Name = "textBoxPatientName";
            this.textBoxPatientName.ReadOnly = true;
            this.textBoxPatientName.Size = new System.Drawing.Size(141, 20);
            this.textBoxPatientName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name:";
            // 
            // textBoxPatientIDNP
            // 
            this.textBoxPatientIDNP.Location = new System.Drawing.Point(61, 103);
            this.textBoxPatientIDNP.Name = "textBoxPatientIDNP";
            this.textBoxPatientIDNP.ReadOnly = true;
            this.textBoxPatientIDNP.Size = new System.Drawing.Size(141, 20);
            this.textBoxPatientIDNP.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IDNP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Standard Template";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(548, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxClinicalDiagnosis);
            this.groupBox6.Location = new System.Drawing.Point(12, 300);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(611, 156);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Clinical Diagnosis";
            // 
            // textBoxClinicalDiagnosis
            // 
            this.textBoxClinicalDiagnosis.Location = new System.Drawing.Point(9, 19);
            this.textBoxClinicalDiagnosis.Multiline = true;
            this.textBoxClinicalDiagnosis.Name = "textBoxClinicalDiagnosis";
            this.textBoxClinicalDiagnosis.ReadOnly = true;
            this.textBoxClinicalDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxClinicalDiagnosis.Size = new System.Drawing.Size(596, 131);
            this.textBoxClinicalDiagnosis.TabIndex = 9;
            // 
            // buttonSaveToFolder
            // 
            this.buttonSaveToFolder.Location = new System.Drawing.Point(16, 55);
            this.buttonSaveToFolder.Name = "buttonSaveToFolder";
            this.buttonSaveToFolder.Size = new System.Drawing.Size(122, 32);
            this.buttonSaveToFolder.TabIndex = 11;
            this.buttonSaveToFolder.Text = "Save to Folder";
            this.buttonSaveToFolder.UseVisualStyleBackColor = true;
            this.buttonSaveToFolder.Click += new System.EventHandler(this.buttonSaveToFolder_Click);
            // 
            // OpenScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 496);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "OpenScan";
            this.ShowIcon = false;
            this.Text = "Scan Result";
            this.Load += new System.EventHandler(this.OpenScan_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxTissueDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTissueType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxScanID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxDoctorDegree;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDoctorSurname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDoctorName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPatientSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPatientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPatientIDNP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxClinicalDiagnosis;
        private System.Windows.Forms.Button buttonSaveToFolder;
    }
}