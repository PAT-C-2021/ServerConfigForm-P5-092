using ServiceMtk_P1_20170140092;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerConfigForm_P5_092
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));

            labelOnOrOff.Text = "Server ON";
            labelKet.Text = "Klik OFF untuk Mematikan Server";
            Host.Open();
            buttonON.Enabled = false;
            buttonOFF.Enabled = true;
        }

        private void buttonOFF_Click(object sender, EventArgs e)
        {
            buttonON.Enabled = true;
            buttonOFF.Enabled = false;
            Host.Close();
            labelKet.Text = "Klik ON untuk menjalankan server";
            labelOnOrOff.Text = "Server OFF";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
