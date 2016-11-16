namespace FirstGuiClient
{
    partial class AddMetadata
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
            this.panelAddMetadata = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxClinicalDiagnosis = new System.Windows.Forms.TextBox();
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
            this.buttonSaveAndClose = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAddMetadata.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddMetadata
            // 
            this.panelAddMetadata.AutoScroll = true;
            this.panelAddMetadata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAddMetadata.Controls.Add(this.label11);
            this.panelAddMetadata.Controls.Add(this.groupBox5);
            this.panelAddMetadata.Controls.Add(this.groupBox4);
            this.panelAddMetadata.Controls.Add(this.groupBox3);
            this.panelAddMetadata.Controls.Add(this.groupBox2);
            this.panelAddMetadata.Controls.Add(this.groupBox1);
            this.panelAddMetadata.Controls.Add(this.buttonSaveAndClose);
            this.panelAddMetadata.Controls.Add(this.buttonCancel);
            this.panelAddMetadata.Controls.Add(this.label1);
            this.panelAddMetadata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddMetadata.Location = new System.Drawing.Point(0, 0);
            this.panelAddMetadata.Name = "panelAddMetadata";
            this.panelAddMetadata.Size = new System.Drawing.Size(660, 512);
            this.panelAddMetadata.TabIndex = 0;
            this.panelAddMetadata.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAddMetadata_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(25, 482);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "* - this fields are mandatory";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxClinicalDiagnosis);
            this.groupBox5.Location = new System.Drawing.Point(24, 310);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(611, 156);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Clinical Diagnosis";
            // 
            // textBoxClinicalDiagnosis
            // 
            this.textBoxClinicalDiagnosis.Location = new System.Drawing.Point(9, 19);
            this.textBoxClinicalDiagnosis.Multiline = true;
            this.textBoxClinicalDiagnosis.Name = "textBoxClinicalDiagnosis";
            this.textBoxClinicalDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxClinicalDiagnosis.Size = new System.Drawing.Size(596, 131);
            this.textBoxClinicalDiagnosis.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxTissueDescription);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBoxTissueType);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(24, 194);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(611, 110);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tissue Information";
            // 
            // textBoxTissueDescription
            // 
            this.textBoxTissueDescription.Location = new System.Drawing.Point(301, 22);
            this.textBoxTissueDescription.Multiline = true;
            this.textBoxTissueDescription.Name = "textBoxTissueDescription";
            this.textBoxTissueDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTissueDescription.Size = new System.Drawing.Size(287, 72);
            this.textBoxTissueDescription.TabIndex = 11;
            this.textBoxTissueDescription.TextChanged += new System.EventHandler(this.textBoxTissueDescription_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Description:";
            // 
            // textBoxTissueType
            // 
            this.textBoxTissueType.Location = new System.Drawing.Point(46, 25);
            this.textBoxTissueType.Multiline = true;
            this.textBoxTissueType.Name = "textBoxTissueType";
            this.textBoxTissueType.Size = new System.Drawing.Size(156, 69);
            this.textBoxTissueType.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBoxScanID);
            this.groupBox3.Location = new System.Drawing.Point(481, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 143);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Scanned Image";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(16, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Full Screen";
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
            this.textBoxScanID.Location = new System.Drawing.Point(54, 103);
            this.textBoxScanID.Name = "textBoxScanID";
            this.textBoxScanID.ReadOnly = true;
            this.textBoxScanID.Size = new System.Drawing.Size(84, 20);
            this.textBoxScanID.TabIndex = 9;
            this.textBoxScanID.Text = "12345";
            this.textBoxScanID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxDoctorDegree);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxDoctorSurname);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxDoctorName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(248, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 143);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doctor Information";
            // 
            // textBoxDoctorDegree
            // 
            this.textBoxDoctorDegree.Location = new System.Drawing.Point(77, 99);
            this.textBoxDoctorDegree.Name = "textBoxDoctorDegree";
            this.textBoxDoctorDegree.Size = new System.Drawing.Size(133, 20);
            this.textBoxDoctorDegree.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "PhD degree:";
            // 
            // textBoxDoctorSurname
            // 
            this.textBoxDoctorSurname.Location = new System.Drawing.Point(77, 57);
            this.textBoxDoctorSurname.Name = "textBoxDoctorSurname";
            this.textBoxDoctorSurname.Size = new System.Drawing.Size(133, 20);
            this.textBoxDoctorSurname.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Surname*:";
            // 
            // textBoxDoctorName
            // 
            this.textBoxDoctorName.Location = new System.Drawing.Point(77, 19);
            this.textBoxDoctorName.Name = "textBoxDoctorName";
            this.textBoxDoctorName.Size = new System.Drawing.Size(133, 20);
            this.textBoxDoctorName.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Name*:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPatientSurname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxPatientName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxPatientIDNP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 143);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Information";
            // 
            // textBoxPatientSurname
            // 
            this.textBoxPatientSurname.Location = new System.Drawing.Point(61, 61);
            this.textBoxPatientSurname.Name = "textBoxPatientSurname";
            this.textBoxPatientSurname.Size = new System.Drawing.Size(141, 20);
            this.textBoxPatientSurname.TabIndex = 11;
            this.textBoxPatientSurname.TextChanged += new System.EventHandler(this.textBoxPatientSurname_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Surname:";
            // 
            // textBoxPatientName
            // 
            this.textBoxPatientName.Location = new System.Drawing.Point(61, 19);
            this.textBoxPatientName.Name = "textBoxPatientName";
            this.textBoxPatientName.Size = new System.Drawing.Size(141, 20);
            this.textBoxPatientName.TabIndex = 7;
            this.textBoxPatientName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name:";
            // 
            // textBoxPatientIDNP
            // 
            this.textBoxPatientIDNP.Location = new System.Drawing.Point(61, 103);
            this.textBoxPatientIDNP.Name = "textBoxPatientIDNP";
            this.textBoxPatientIDNP.Size = new System.Drawing.Size(141, 20);
            this.textBoxPatientIDNP.TabIndex = 5;
            this.textBoxPatientIDNP.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IDNP*:";
            // 
            // buttonSaveAndClose
            // 
            this.buttonSaveAndClose.Location = new System.Drawing.Point(455, 477);
            this.buttonSaveAndClose.Name = "buttonSaveAndClose";
            this.buttonSaveAndClose.Size = new System.Drawing.Size(99, 23);
            this.buttonSaveAndClose.TabIndex = 10;
            this.buttonSaveAndClose.Text = "Next";
            this.buttonSaveAndClose.UseVisualStyleBackColor = true;
            this.buttonSaveAndClose.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(560, 477);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Standard Template";
            // 
            // AddMetadata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(660, 512);
            this.Controls.Add(this.panelAddMetadata);
            this.MaximizeBox = false;
            this.Name = "AddMetadata";
            this.ShowIcon = false;
            this.Text = "Add Metadata";
            this.Load += new System.EventHandler(this.AddMetadata_Load);
            this.panelAddMetadata.ResumeLayout(false);
            this.panelAddMetadata.PerformLayout();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddMetadata;
        private System.Windows.Forms.TextBox textBoxPatientIDNP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveAndClose;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxDoctorSurname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDoctorName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxScanID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPatientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxDoctorDegree;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxTissueType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPatientSurname;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxClinicalDiagnosis;
        private System.Windows.Forms.TextBox textBoxTissueDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
    }
}