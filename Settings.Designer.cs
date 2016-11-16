namespace FirstGuiClient
{
    partial class Settings
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
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.labelIp = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.groupBoxLanguage = new System.Windows.Forms.GroupBox();
            this.radioButtonRussian = new System.Windows.Forms.RadioButton();
            this.radioButtonEnglish = new System.Windows.Forms.RadioButton();
            this.radioButtonRomanian = new System.Windows.Forms.RadioButton();
            this.groupBoxUserInfo = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxLanguage.SuspendLayout();
            this.groupBoxUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPort);
            this.groupBox1.Controls.Add(this.labelPort);
            this.groupBox1.Controls.Add(this.textBoxIp);
            this.groupBox1.Controls.Add(this.labelIp);
            this.groupBox1.Location = new System.Drawing.Point(236, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scanner Connection";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(42, 76);
            this.textBoxPort.MaxLength = 100;
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(124, 20);
            this.textBoxPort.TabIndex = 3;
            this.textBoxPort.TextChanged += new System.EventHandler(this.textBoxPort_TextChanged);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(10, 79);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(29, 13);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "Port:";
            // 
            // textBoxIp
            // 
            this.textBoxIp.Location = new System.Drawing.Point(42, 32);
            this.textBoxIp.MaxLength = 100;
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(124, 20);
            this.textBoxIp.TabIndex = 1;
            this.textBoxIp.TextChanged += new System.EventHandler(this.textBoxIp_TextChanged);
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.Location = new System.Drawing.Point(10, 35);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(20, 13);
            this.labelIp.TabIndex = 0;
            this.labelIp.Text = "IP:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(351, 314);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(267, 314);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonDefault
            // 
            this.buttonDefault.Location = new System.Drawing.Point(186, 314);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(75, 23);
            this.buttonDefault.TabIndex = 3;
            this.buttonDefault.Text = "Default";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxPassword);
            this.groupBox2.Controls.Add(this.labelPassword);
            this.groupBox2.Controls.Add(this.textBoxUser);
            this.groupBox2.Controls.Add(this.labelUser);
            this.groupBox2.Location = new System.Drawing.Point(236, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 128);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database Connection";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Enabled = false;
            this.textBoxPassword.Location = new System.Drawing.Point(42, 84);
            this.textBoxPassword.MaxLength = 100;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(124, 20);
            this.textBoxPassword.TabIndex = 5;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(10, 87);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(33, 13);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Pass:";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Enabled = false;
            this.textBoxUser.Location = new System.Drawing.Point(42, 39);
            this.textBoxUser.MaxLength = 100;
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(124, 20);
            this.textBoxUser.TabIndex = 3;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(10, 42);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(32, 13);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "User:";
            // 
            // groupBoxLanguage
            // 
            this.groupBoxLanguage.Controls.Add(this.radioButtonRussian);
            this.groupBoxLanguage.Controls.Add(this.radioButtonEnglish);
            this.groupBoxLanguage.Controls.Add(this.radioButtonRomanian);
            this.groupBoxLanguage.Location = new System.Drawing.Point(12, 170);
            this.groupBoxLanguage.Name = "groupBoxLanguage";
            this.groupBoxLanguage.Size = new System.Drawing.Size(200, 128);
            this.groupBoxLanguage.TabIndex = 5;
            this.groupBoxLanguage.TabStop = false;
            this.groupBoxLanguage.Text = "Language Settings";
            this.groupBoxLanguage.Enter += new System.EventHandler(this.groupBoxLanguage_Enter);
            // 
            // radioButtonRussian
            // 
            this.radioButtonRussian.AutoSize = true;
            this.radioButtonRussian.Enabled = false;
            this.radioButtonRussian.Location = new System.Drawing.Point(6, 79);
            this.radioButtonRussian.Name = "radioButtonRussian";
            this.radioButtonRussian.Size = new System.Drawing.Size(63, 17);
            this.radioButtonRussian.TabIndex = 3;
            this.radioButtonRussian.TabStop = true;
            this.radioButtonRussian.Text = "Russian";
            this.radioButtonRussian.UseVisualStyleBackColor = true;
            // 
            // radioButtonEnglish
            // 
            this.radioButtonEnglish.AutoSize = true;
            this.radioButtonEnglish.Checked = true;
            this.radioButtonEnglish.Location = new System.Drawing.Point(6, 54);
            this.radioButtonEnglish.Name = "radioButtonEnglish";
            this.radioButtonEnglish.Size = new System.Drawing.Size(59, 17);
            this.radioButtonEnglish.TabIndex = 2;
            this.radioButtonEnglish.TabStop = true;
            this.radioButtonEnglish.Text = "English";
            this.radioButtonEnglish.UseVisualStyleBackColor = true;
            this.radioButtonEnglish.CheckedChanged += new System.EventHandler(this.radioButtonEnglish_CheckedChanged);
            // 
            // radioButtonRomanian
            // 
            this.radioButtonRomanian.AutoSize = true;
            this.radioButtonRomanian.Enabled = false;
            this.radioButtonRomanian.Location = new System.Drawing.Point(6, 31);
            this.radioButtonRomanian.Name = "radioButtonRomanian";
            this.radioButtonRomanian.Size = new System.Drawing.Size(65, 17);
            this.radioButtonRomanian.TabIndex = 1;
            this.radioButtonRomanian.TabStop = true;
            this.radioButtonRomanian.Text = "Română";
            this.radioButtonRomanian.UseVisualStyleBackColor = true;
            // 
            // groupBoxUserInfo
            // 
            this.groupBoxUserInfo.Controls.Add(this.textBox1);
            this.groupBoxUserInfo.Controls.Add(this.labelEmail);
            this.groupBoxUserInfo.Controls.Add(this.textBox2);
            this.groupBoxUserInfo.Controls.Add(this.labelUserName);
            this.groupBoxUserInfo.Location = new System.Drawing.Point(12, 24);
            this.groupBoxUserInfo.Name = "groupBoxUserInfo";
            this.groupBoxUserInfo.Size = new System.Drawing.Size(200, 128);
            this.groupBoxUserInfo.TabIndex = 6;
            this.groupBoxUserInfo.TabStop = false;
            this.groupBoxUserInfo.Text = "User Information";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(54, 76);
            this.textBox1.MaxLength = 100;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 3;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(10, 79);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(54, 32);
            this.textBox2.MaxLength = 100;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 1;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(10, 35);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(38, 13);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Name:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 358);
            this.Controls.Add(this.groupBoxUserInfo);
            this.Controls.Add(this.groupBoxLanguage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonDefault);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxLanguage.ResumeLayout(false);
            this.groupBoxLanguage.PerformLayout();
            this.groupBoxUserInfo.ResumeLayout(false);
            this.groupBoxUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.Button buttonDefault;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.GroupBox groupBoxLanguage;
        private System.Windows.Forms.RadioButton radioButtonRomanian;
        private System.Windows.Forms.RadioButton radioButtonRussian;
        private System.Windows.Forms.RadioButton radioButtonEnglish;
        private System.Windows.Forms.GroupBox groupBoxUserInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelUserName;
    }
}