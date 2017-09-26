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
        private List<string> commands = new List<string>(new string[] { "1", "2" });

        private StationType stationType;
        private TransactionType transactionType;

        public IwSK2()
        {
            InitializeComponent();
            stationType = StationType.Master;
            transactionType = TransactionType.Broadcast;

            cbCommandMaster.DataSource = commands;
            cbCommandMaster.SelectedIndex = -1;
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

        private enum TransactionType
        {
            Addressed,
            Broadcast
        }

        private void btnConfigureMaster_Click(object sender, EventArgs e)
        {

        }

        private void btnSendMaster_Click(object sender, EventArgs e)
        {
            List<char> dataChar = new List<char>();
            dataChar.Add(':');
            int sum = 0;
            int dec = Int32.Parse(tbAddress.Text);
            
            //adres
            string address = dec.ToString("X");
            if (address.Length == 1)
            {
                dataChar.Add('0');
                dataChar.Add(address.ElementAt(0));
            }
            else
            {
                for (int i = 0; i < address.Length; i++)
                {
                    dataChar.Add(address.ElementAt(i));
                }
            }
            //funkcja 1 lub 2
            int function = Int32.Parse(cbCommandMaster.SelectedValue.ToString());
            string funHex = function.ToString("X");
            dataChar.Add('0'); //by bylo 01 lub 02, musi byc zero wczesniej
            dataChar.Add(funHex.ElementAt(0));

            //dane hex
            for (int i = 0; i < tbTransmittedDataMasterHex.Text.Length; i++)
            {
                if (tbTransmittedDataMasterHex.Text.ElementAt(i) != ' ') {
                    dataChar.Add(tbTransmittedDataMasterHex.Text.ElementAt(i));
                }
            }

            //liczenie lrc
            sum += dec;
            sum += function;
            for (int i = 0;i<tbTransmittedDataMaster.Text.Length;i++)
            {
                string hex = ConvertStringToHex(tbTransmittedDataMaster.Text.ElementAt(i).ToString());
                sum += Convert.ToInt32(hex,16);
            }
            byte[] sumByte = BitConverter.GetBytes(sum);
            int sB = Convert.ToInt32(sumByte[0]);
            sB = (255-sB)+1;
            string lrc = sB.ToString("X");
            //dodanie lrc
            if (lrc.Length == 1)
            {
                dataChar.Add('0');
                dataChar.Add(lrc.ElementAt(0));
            }
            else
            {
                for (int i = 0; i < lrc.Length; i++)
                {
                    dataChar.Add(lrc.ElementAt(i));
                }
            }
            dataChar.Add('\r');
            dataChar.Add('\n');
            convertASCIIToHex(dataChar);
        }

        private void convertASCIIToHex(List<char> data)
        {
            List<char> chars = new List<char>();
            for (int i = 0;i< data.Count; i++)
            {
                string ascii = Convert.ToInt32(data.ElementAt(i)).ToString("X");
                if (ascii.Length == 1)
                {
                    chars.Add('0');
                    chars.Add(ascii.ElementAt(0));
                }
                else
                {
                    chars.Add(ascii.ElementAt(0));
                    chars.Add(ascii.ElementAt(1));
                }
            }
        }

        private void btnConfigureSlave_Click(object sender, EventArgs e)
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

        private void rbBroadcast_CheckedChanged(object sender, EventArgs e)
        {
            //gbMaster.Enabled = !gbMaster.Enabled;
            //gbSlave.Enabled = !gbSlave.Enabled;

            if (transactionType == TransactionType.Broadcast)
            {
                transactionType = TransactionType.Addressed;
                tbAddress.Enabled = true;
            }
            else
            {
                transactionType = TransactionType.Broadcast;
                tbAddress.Enabled = false;
            }

        }
    }
}
