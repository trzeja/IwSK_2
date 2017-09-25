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

        }

        private void btnConfigureSlave_Click(object sender, EventArgs e)
        {

        }

        private void btnSendSlave_Click(object sender, EventArgs e)
        {

        }

        private void cbHexTransmittedMaster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHexTransmittedMaster.Checked)
            {
                byte[] ba = Encoding.Default.GetBytes(tbTransmittedDataMaster.Text);

            }
        }

        
    }
}
