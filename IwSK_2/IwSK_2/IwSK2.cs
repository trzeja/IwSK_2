using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;

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
        private int retransmissionAmount = 1;
        private long interval = 0;
        private long startTime, endTime = 0;
        private Stopwatch timer;
        private bool frameFinished = false;

        public IwSK2()
        {
            InitializeComponent();
            stationType = StationType.Master;
            transactionType = TransactionType.Broadcast;
            cbCommandMaster.DataSource = commands.Take(1).ToList(); // rozkaz 2 dostepny tylko w adresowanej 
            cbCommandMaster.SelectedIndex = 0;
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
            try
            {
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
            catch (Exception)
            {
                MessageBox.Show("Nie wybrano poprawnego portu");
                return;            
            }
            gbCommunicationMaster.Enabled = true;
        }

        private void ConfigureMasterPort()
        {
            interval = (long)nudTimeConstraintMaster.Value;
            retransmissionAmount = 1 + Convert.ToInt32(nudRetransmissions.Text);
            timer = new Stopwatch();
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
            if (function == 1)
            {
                for (int i = 0; i < ConvertStringToHex(tbTransmittedDataMaster.Text).Length; i++)
                {
                    if (ConvertStringToHex(tbTransmittedDataMaster.Text).ElementAt(i) != ' ')
                    {
                        dataChar.Add(ConvertStringToHex(tbTransmittedDataMaster.Text).ElementAt(i));
                    }
                }
            }

            //liczenie lrc
            sum += dec;
            sum += function;
            if (function == 1)
            {
                for (int i = 0; i < tbTransmittedDataMaster.Text.Length; i++)
                {
                    string hex = ConvertStringToHex(tbTransmittedDataMaster.Text.ElementAt(i).ToString());
                    sum += Convert.ToInt32(hex, 16);
                }
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
            tbHexSendFrame.Text += convertASCIIToHex(dataChar);
            int retransmissionCount = 0;
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
            try
            {
                //konfiguracja reszty parametrow tu musi byc
                if (port == null)
                {
                    timer = new Stopwatch();
                    interval = (long)nudTimeConstraintSlave.Value;
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
                        timer = new Stopwatch();
                        interval = (long)nudTimeConstraintSlave.Value;
                        port = new SerialPort(cbPortsSlave.SelectedValue.ToString());
                        port.DataReceived += new SerialDataReceivedEventHandler(dataReceivedHandler);
                        port.Open();
                    }
                }
            }           
            catch (Exception)
            {
                MessageBox.Show("Nie wybrano poprawnego portu");
                return;
            }
            gbCommunicationSlave.Enabled = true;
        }  

        private void setTbTransmittedDataSlaveHex(string data)
        {
            tbTransmittedDataSlaveHex.Text += (data + "\r\n");
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
                    
                }
            }
        }

        private void commandTwo(List<char> received, int i, int lrcSum)
        {
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
                    //TODO - odeslac ramke z danymi od siebie
                    sendFrameWithData(received);
                }
            }
        }

        private void sendFrameWithData(List<char> received)
        {
            List<char> toSend = new List<char>();
            toSend.Add(':');
            int sum = 0;
            //adres
            int dec = Int32.Parse(nudAdddressSlave.Text);
            string address = dec.ToString("X");
            if (address.Length == 1)
            {
                toSend.Add('0');
                toSend.Add(address.ElementAt(0));
            }
            else
            {
                for (int i = 0; i < address.Length; i++)
                {
                    toSend.Add(address.ElementAt(i));
                }
            }

            //funkcja
            int function = 2;
            string funHex = function.ToString("X");
            toSend.Add('0'); //by bylo 01 lub 02, musi byc zero wczesniej
            toSend.Add(funHex.ElementAt(0));

            //dane hex
            string data = ConvertStringToHex(tbTransmittedDataSlave.Text);
            for (int i = 0; i< data.Length;i++)
            {
                if (data.ElementAt(i)!= ' ')
                {
                    toSend.Add(data.ElementAt(i));
                   // sum += Convert.ToInt32(data.ElementAt(i).ToString(),16);
                }
            }
            for (int i = 0; i < tbTransmittedDataSlave.Text.Length; i++)
            {
                string hex = ConvertStringToHex(tbTransmittedDataSlave.Text.ElementAt(i).ToString());
                sum += Convert.ToInt32(hex, 16);
            }
            sum += dec;
            sum += function;
            byte[] sumByte = BitConverter.GetBytes(sum);
            int sB = Convert.ToInt32(sumByte[0]);
            sB = (255 - sB) + 1;
            string lrc = sB.ToString("X");
            //dodanie lrc
            if (lrc.Length == 1)
            {
                toSend.Add('0');
                toSend.Add(lrc.ElementAt(0));
            }
            else
            {
                for (int i = 0; i < lrc.Length; i++)
                {
                    toSend.Add(lrc.ElementAt(i));
                }
            }
            toSend.Add('\r');
            toSend.Add('\n');
            //tbTransmittedDataSlaveHex.Text = convertASCIIToHex(toSend);
            if (tbTransmittedDataSlaveHex.InvokeRequired)
            {
                tbRecievedDataSlaveCallback call = new tbRecievedDataSlaveCallback(setTbTransmittedDataSlaveHex);
                this.Invoke(call, convertASCIIToHex(toSend));
            }
            else
            {
                tbTransmittedDataSlaveHex.Text += (convertASCIIToHex(toSend) + "\r\n");
            }
            port.Write(toSend.ToArray<char>(), 0, toSend.Count);
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
                            commandTwo(received,i,lrcSum);
                            break;
                        default:
                            //jakis error gdy zla komenda, moze jakies przeklamania
                            break;
                    }
                }
            }
        }

        private void dataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            timer = Stopwatch.StartNew();
            if (stationType == StationType.Slave) {
                SerialPort senderPort = (SerialPort)sender;
                int bytesToRead = senderPort.BytesToRead;
                for (int i = 0; i < bytesToRead; i++)
                {
                    //TODO -> tu będzie 
                    endTime = startTime;
                    int intChar = senderPort.ReadChar();
                    endTime = timer.ElapsedMilliseconds;
                    if(endTime - startTime > interval)
                    {
                        receivedChars.Clear();
                        frameFinished = false;
                    }
                    char rChar = Convert.ToChar(intChar);
                    receivedChars.Add(rChar);
                    //sprawdzac i \r i \n czy to starczy?
                    if (rChar == '\n' && frameFinished)
                    {
                        List<char> frame = new List<char>(receivedChars);
                        receivedDataTransformation(frame);
                        receivedChars.Clear();
                        //TODO -> tu pewnie bedzie odsylanie wiadomosci
                    }
                }
            }
            else //gdy jest masterem
            {
                SerialPort senderPort = (SerialPort)sender;
                int bytesToRead = senderPort.BytesToRead;
                for (int i=0; i< bytesToRead; i++)
                {
                    int intChar = senderPort.ReadChar();
                    char rChar = Convert.ToChar(intChar);
                    receivedChars.Add(rChar);
                    //sprawdzac i \r i \n czy to starczy?
                    if (rChar == '\n')
                    {
                        List<char> frame = new List<char>(receivedChars);
                        receivedDataMaster(frame);
                        receivedChars.Clear();
                        //TODO -> tu pewnie bedzie odsylanie wiadomosci
                    }
                } 
            }
        }

        private void receivedDataMaster(List<char> received)
        {
            int i = 0;
            if (received.ElementAt(i++)!=':')
            {
                //TODO - to nie ramka
                MessageBox.Show("Odebrano dane bez znaku ':'");
            }
            else
            {
                
                int lrcSum = 0;
                string hexAddress = "";
                hexAddress += received.ElementAt(i++);
                hexAddress += received.ElementAt(i++);
                int decAddress = Convert.ToInt32(hexAddress,16);
                lrcSum += decAddress;
                if ((decAddress != Int32.Parse(nudAddressMaster.Text)))
                {
                    //TODO - to nie do mnie
                    MessageBox.Show("Odpowiedż od złego adresu");
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
                            commandOneAnswer(received,i,lrcSum);
                            break;
                        case 2:
                            commandTwoAnswer(received,i,lrcSum);
                            break;
                        case 129: //potwierdzenie z bledem od slave dla komendy 1
                            break;
                        case 130: //potwierdzenie z bledem od slave dla komedy 2
                            break;
                        default:
                            //jakis error gdy zla komenda, moze jakies przeklamania
                            break;
                    }
                }
            }
        }

        private void commandOneAnswer(List<char> received, int i, int lrcSum)
        {

        }

        private void setTbRecievedDataMasterHex(string data)
        {
            tbRecievedDataMasterHex.Text += (data + "\r\n");
        }

        private void setTbRecievedDataMaster(string data)
        {
            tbRecievedDataMaster.Text += (data + "\r\n");
        }

        private void commandTwoAnswer(List<char> received, int i, int lrcSum)
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
                MessageBox.Show("Błąd odebranej ramki - złe LRC");
            }
            else
            {
                string del = "";
                del += received.ElementAt(i++);
                del += received.ElementAt(i++);
                if (!del.Equals("\r\n"))
                {
                    MessageBox.Show("Błąd odebranej ramki - nie zgadza sie delimiter");
                }
                else
                {
                    if (tbRecievedDataMaster.InvokeRequired)
                    {
                        tbRecievedDataSlaveCallback call = new tbRecievedDataSlaveCallback(setTbRecievedDataMaster);
                        this.Invoke(call, dataToShow);
                    }
                    else
                    {
                        tbRecievedDataMaster.Text += (dataToShow + "\r\n");
                    }
                    string hex = convertASCIIToHex(received);
                    if (tbRecievedDataMasterHex.InvokeRequired)
                    {
                        tbRecievedDataSlaveCallback call = new tbRecievedDataSlaveCallback(setTbRecievedDataMasterHex);
                        this.Invoke(call, hex);
                    }
                    else
                    {
                        tbRecievedDataMasterHex.Text += (hex + "\r\n");
                    }

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
