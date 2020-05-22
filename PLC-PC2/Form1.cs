using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using S7.Net.Types;
namespace PLC_PC2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Plc plc = new Plc(CpuType.S71200, txtIp.Text, 0, 0);
            if (plc.Open() == ErrorCode.NoError)
            {

                MessageBox.Show("Connect Successfully!");
                plc.Close();
            }
            else
                MessageBox.Show("Cannot connect to PLC!");
        }

        private void checkQ0_0_CheckedChanged(object sender, EventArgs e)
        {
            Plc plc = new Plc(CpuType.S71200, txtIp.Text, 0, 0);
            if (plc.Open() == ErrorCode.NoError)
            {
                byte[] dataGui = new byte[10];
                if (checkQ0_0.Checked)
                    dataGui[0] |= 0x01;
                else
                    dataGui[0] &= 0xfe;
                if (checkQ0_1.Checked)
                    dataGui[0] |= 0x02;
                else
                    dataGui[0] &= 0xfd;
                if (checkQ0_2.Checked)
                    dataGui[0] |= 0x04;
                else
                    dataGui[0] &= 0xfb;
                if (checkQ0_3.Checked)
                    dataGui[0] |= 0x08;
                else
                    dataGui[0] &= 0xf7;

                plc.WriteBytes(DataType.Output, 0, 0, dataGui);
                plc.Close();

            }
            else
                MessageBox.Show("Cannot connect to PLC!");
            //alo alo
        }
    }
}
