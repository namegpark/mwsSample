using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mwsSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            mwsLib.mwsLib mws_api = new mwsLib.mwsLib()
            {
                mws_apikey = "Input your malwares.com APIKey"
            };

            string result = await mws_api.getFileStaticReport("AD5700D0E230C2A85259AF625DEDF2C5300F33B5B5FD1C03F8CD879A0AF57C1B");
            MessageBox.Show(result);
        }
    }
}
