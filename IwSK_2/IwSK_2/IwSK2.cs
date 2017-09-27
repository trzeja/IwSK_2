using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace IwSK_2
{
    public partial class IwSK2 : Form
    {
        delegate void tbRecievedDataSlaveCallback(string data);
        private List<string> commands = new List<string>(new string[] { "1", "2" });

        private StationType stationType;
        private TransactionType transactionType;
        private SerialPort port;
        private List<char> receivedChars = new List<char>();
        private int retransmissionAmount = 0;

        public IwSK2()
        {
            InitializeComponent();
            stationType = StationType.Master;
            transactionType = TransactionType.Broadcast;
            cbCommandMaster.DataSource = commands.Take(1).ToList(); // rozkaz 2 dostepny tylko w adresowanej 
            cbCommandMaster.SelectedIndex = -1;
            cbPortsMaster.DataSource = SerialPort.GetPortNames();
            cbPortsMaster.SelectedIndex = -1;
            cbPortsSlave.DataSource = SerialPort.GetPortNames();
            cbPortsSlave.SelectedIndex = -1;
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
            gbCommunicationMaster.Enabled = true;
            if (port == null)
            {
                ConfigureMasterPort();
            }
            else
            {
                if (port.PortName != cbPortsMaster.SelectedValue.ToString())
                {
                    if (port.IsOpen)
                    {
                        port.Close();
                    }
                    ConfigureMasterPort();
                }
            }
        }

        private void ConfigureMasterPort()
        {
            retransmissionAmount = Convert.ToInt32(nudRetransmissions.Text);
            port = new SerialPort(cbPortsMaster.SelectedValue.ToString());
            port.DataReceived += new SerialDataReceivedEventHandler(dataReceivedHandler);
            port.ReadTimeout = GetTimeoutValue(nudTimeout.Value);
            port.WriteTimeout = GetTimeoutValue(nudTimeout.Value);
            port.Open();
        }

        private void btnSendMaster_Click(object sender, EventArgs e)
        {
            List<char> dataChar = new List<char>();
            dataChar.Add(':');
            int sum = 0;
            int dec = Int32.Parse(nudAddressMaster.Text);
            
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
            for (int i = 0; i < ConvertStringToHex(tbTransmittedDataMaster.Text).Length; i++)
            {
                if (ConvertStringToHex(tbTransmittedDataMaster.Text).ElementAt(i) != ' ') {
                    dataChar.Add(ConvertStringToHex(tbTransmittedDataMaster.Text).ElementAt(i));
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
            //tu mamy w charach ładnie wszystko, tylko na hex trzeba zmienić już do wyświetlania
            tbHexSendFrame.Text = convertASCIIToHex(dataChar);
            int retransmissionCount = 0;
            port.Write(dataChar.ToArray<char>(), 0, dataChar.Count);
            //TODO - Piotr, numer retransmisji moze być zerowy nie? ale musimy pierwszy raz wyslac ;)
            while (retransmissionCount < retransmissionAmount)
            {
                try
                {
                    port.Write(dataChar.ToArray<char>(), 0, dataChar.Count);
                }
                catch (TimeoutException)
                {
                    retransmissionCount++;
                    continue;
                }
                break;
            }
        }

        private string convertASCIIToHex(List<char> data)
        {
            //List<char> chars = new List<char>();
            string hexFrame = "";
            for (int i = 0;i< data.Count; i++)
            {
                string ascii = Convert.ToInt32(data.ElementAt(i)).ToString("X");
                if (ascii.Length == 1)
                {
                    hexFrame += "0";
                }
                hexFrame += ascii;
                hexFrame += " ";
                //if (ascii.Length == 1)
                //{
                //    chars.Add('0');
                //    chars.Add(ascii.ElementAt(0));
                //}
                //else
                //{
                //    chars.Add(ascii.ElementAt(0));
                //    chars.Add(ascii.ElementAt(1));
                //}
            }
            //tbHexSendFrame.Text = hexFrame;
            return hexFrame;
        }

        private void btnConfigureSlave_Click(object sender, EventArgs e)
        {
            //konfiguracja reszty parametrow tu musi byc
            gbCommunicationSlave.Enabled = true;
            if (port == null)
            {
                port = new SerialPort(cbPortsSlave.SelectedValue.ToString());
                port.DataReceived += new SerialDataReceivedEventHandler(dataReceivedHandler);

                port.Open();
            }
            else
            {
                if (port.PortName != cbPortsSlave.SelectedValue.ToString())
                {
                    if (port.IsOpen)
                    {
                        port.Close();
                    }
                    port = new SerialPort(cbPortsSlave.SelectedValue.ToString());
                    port.DataReceived += new SerialDataReceivedEventHandler(dataReceivedHandler);
                    port.Open();
                }
            }
        }  

        private void setTbRecievedDataSlave(string data)
        {
            tbRecievedDataSlave.Text += (data + "\r\n");
        }

        private void setTbRecievedDataSlaveHex(string data)
        {
            tbReceivedDataSlaveHex.Text += (data + "\r\n");
        }

        private void commandOne(List<char> received, int i, int lrcSum)
        {
            string dataToShow = "";
            string hexData = "";
            while (i < (received.Count - 5)) //przed suma kontrolna i delimiterami
            {
                hexData += received.ElementAt(i++);
                hexData += received.ElementAt(i++);
                int decData = Convert.ToInt32(hexData, 16);
                lrcSum += decData;
                char ascii = Convert.ToChar(decData);
                dataToShow += ascii;
                hexData = "";
            }
            string hexLrc = "";
            hexLrc += received.ElementAt(i++);
            hexLrc += received.ElementAt(i++);
            //
            byte[] sumByte = BitConverter.GetBytes(lrcSum);
            int sB = Convert.ToInt32(sumByte[0]);
            sB = (255 - sB) + 1;
            string lrc = sB.ToString("X");
            if (lrc.Length == 1)
            {
                lrc = '0' + lrc;
            }

            if (!hexLrc.Equals(lrc))
            {
                MessageBox.Show("Złe LRC");
                //TODO - lrc się nie zgadza, odpowiedz z bledem?
            }
            else
            {
                string del = "";
                del += received.ElementAt(i++);
                del += received.ElementAt(i++);
                if (!del.Equals("\r\n"))
                {
                    MessageBox.Show("Nie zgadza sie delimiter");
                    //TODO - nie zgadza sie delimiter
                }
                else
                {
                    if (tbRecievedDataSlave.InvokeRequired)
                    {
                        tbRecievedDataSlaveCallback call = new tbRecievedDataSlaveCallback(setTbRecievedDataSlave);
                        this.Invoke(call, dataToShow);
                    }
                    else
                    {
                        tbRecievedDataSlave.Text += (dataToShow + "\r\n");
                    }
                    string hex = convertASCIIToHex(received);
                    if (tbReceivedDataSlaveHex.InvokeRequired)
                    {
                        tbRecievedDataSlaveCallback call = new tbRecievedDataSlaveCallback(setTbRecievedDataSlaveHex);
                        this.Invoke(call, hex);
                    }
                    else
                    {
                        tbReceivedDataSlaveHex.Text += (hex + "\r\n");
                    }
                    // TODO - wyswietlic w hexie jeszcze
                }
            }
        }

        private void receivedDataTransformation(List<char> received)
        {
            int i = 0;
            //tbRecievedDataSlave.Text = received.ToString();
            if (received.ElementAt(i++) != ':')
            {
                //TODO - to nie ramka
                MessageBox.Show("To nie ramka");
            }
            else
            {
                int lrcSum = 0;
                string hexAddress = "";
                hexAddress += received.ElementAt(i++);
                hexAddress += received.ElementAt(i++);
                int decAddress = Convert.ToInt32(hexAddress,16);
                lrcSum += decAddress;
                if ((decAddress != Int32.Parse(nudAdddressSlave.Text)) && (decAddress != 0))
                {
                    //TODO - to nie do mnie
                    MessageBox.Show("To nie do mnie");
                }
                else
                {
                    string hexCommand = "";
                    hexCommand += received.ElementAt(i++);
                    hexCommand += received.ElementAt(i++);
                    int decCommand = Convert.ToInt32(hexCommand,16);
                    lrcSum += decCommand;
                    switch (decCommand)
                    {
                        case 1:
                            commandOne(received,i,lrcSum);
                            break;
                        case 2:
                            //TODO - komenda druga
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void dataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            if (stationType == StationType.Slave) {
                SerialPort senderPort = (SerialPort)sender;

                for (int i = 0; i < senderPort.BytesToRead; i++)
                {
                    //TODO -> tu będzie 
                    int intChar = senderPort.ReadChar();
                    char rChar = Convert.ToChar(intChar);
                    receivedChars.Add(rChar);
                    //sprawdzac i \r i \n czy to starczy?
                    if (rChar == '\n')
                    {
                        List<char> frame = new List<char>(receivedChars);
                        receivedDataTransformation(frame);
                        receivedChars.Clear();
                        //TODO -> tu pewnie bedzie odsylanie wiadomosci
                    }
                    //if (tbRecievedDataSlave.InvokeRequired)
                    //{
                    //    tbRecievedDataSlaveCallback call = new tbRecievedDataSlaveCallback(setTbRecievedDataSlave);
                    //    this.Invoke(call, Convert.ToChar(senderPort.ReadChar()));
                    //}
                    //else
                    //{
                    //    tbRecievedDataSlave.Text += Convert.ToChar(senderPort.ReadChar());
                    //}
                }
            }
        }

        private string ConvertStringToHex(string text)
        {
            byte[] ba = Encoding.Default.GetBytes(text);
            return BitConverter.ToString(ba).Replace("-", " ");
        }

        private void rbBroadcast_CheckedChanged(object sender, EventArgs e)
        {
            if (transactionType == TransactionType.Broadcast)
            {
                transactionType = TransactionType.Addressed;
                nudAddressMaster.Enabled = true;
                cbCommandMaster.DataSource = commands; // w adresowanej dostepny 1 i 2 rozkaz
                nudAddressMaster.Minimum = 1;
            }
            else
            {
                transactionType = TransactionType.Broadcast;
                nudAddressMaster.Enabled = false;
                cbCommandMaster.DataSource = commands.Take(1).ToList(); // rozkaz 2 dostepny tylko w adresowanej 
                nudAddressMaster.Minimum = 0;
                nudAddressMaster.Value = 0;
            }

        }

        private int GetTimeoutValue(decimal fieldValue)
        {
            int value = Convert.ToInt32(fieldValue);
            if (value == 0)
                value = -1;
            return value;
        }
    }
}
