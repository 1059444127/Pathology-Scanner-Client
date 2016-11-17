using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirstGuiClient
{
    public partial class Settings : Form
    {
        private Configuration Config;

        public Settings()
        {
            InitializeComponent();
            Config = new Configuration();
            textBoxIp.Text = Config.Ip;
            textBoxPort.Text = Config.Port;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            Config.ResetToDefault();

            textBoxIp.Text = Config.Ip;
            textBoxPort.Text = Config.Port;
        }

        private void groupBoxLanguage_Enter(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonEnglish_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIp_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Config.Ip = textBoxIp.Text;
            Config.Port = textBoxPort.Text;

            this.Close();
        }
    }
}
