using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IwSK_2
{
    public partial class IwSK2 : Form
    {

        private StationType stationType;
        public IwSK2()
        {
            InitializeComponent();
            stationType = StationType.Master;
        }

        private void rbMaster_CheckedChanged(object sender, EventArgs e)
        {
            gbMaster.Enabled = !gbMaster.Enabled;
            gbSlave.Enabled = !gbSlave.Enabled;
            if (stationType == StationType.Slave)
            {
                stationType = StationType.Master;
            }
            else
            {
                stationType = StationType.Slave;
            }          
            
        }

        private enum StationType
        {
            Master,
            Slave
        }

        private void btnConfigureMaster_Click(object sender, EventArgs e)
        {

        }

        private void btnSendMaster_Click(object sender, EventArgs e)
        {
            List<char> dataChar = new List<char>();
            dataChar.Add(';');
            int sum = 0;
            int dec = Int32.Parse(tbAddress.Text);
            
            string address = dec.ToString("X");
            for (int i = 0;i<address.Length;i++)
            {
                dataChar.Add(address.ElementAt(i));
            }
            for (int i = 0; i < tbTransmittedDataMasterHex.Text.Length; i++)
            {
                if (tbTransmittedDataMasterHex.Text.ElementAt(i) != ' ') {
                    dataChar.Add(tbTransmittedDataMasterHex.Text.ElementAt(i));
                }
            }
            sum += dec;
            for (int i = 0;i<tbTransmittedDataMaster.Text.Length;i++)
            {
                string hex = ConvertStringToHex(tbTransmittedDataMaster.Text.ElementAt(i).ToString());
                sum += Convert.ToInt32(hex,16);
            }
            byte[] sumByte = BitConverter.GetBytes(sum);
            int sB = Convert.ToInt32(sumByte[0]);
            sB = (255-sB)+1;
            string lrc = sB.ToString("X");
            for (int i = 0; i < lrc.Length; i++)
            {
                dataChar.Add(lrc.ElementAt(i));
            }
            dataChar.Add('\r');
            dataChar.Add('\n');
        }

        private void btnConfigureSlave_Click(object sender, EventArgs e)
        {

        }

        private void btnSendSlave_Click(object sender, EventArgs e)
        {
            

        }

        private void tbTransmittedDataMaster_TextChanged(object sender, EventArgs e)
        {
            tbTransmittedDataMasterHex.Text = ConvertStringToHex(tbTransmittedDataMaster.Text);
        }
        
        private void tbRecievedDataMaster_TextChanged(object sender, EventArgs e)
        {
            tbRecievedDataMasterHex.Text = ConvertStringToHex(tbRecievedDataMaster.Text);
        }

        private void tbTransmittedDataSlave_TextChanged(object sender, EventArgs e)
        {
            tbTransmittedDataSlaveHex.Text = ConvertStringToHex(tbTransmittedDataSlave.Text);
        }

        private void tbRecievedDataSlave_TextChanged(object sender, EventArgs e)
        {
            tbRecievedDataSlaveHex.Text = ConvertStringToHex(tbRecievedDataSlave.Text);
        }

        private string ConvertStringToHex(string text)
        {
            byte[] ba = Encoding.Default.GetBytes(text);
            return BitConverter.ToString(ba).Replace("-", " ");
        }
    }
}
