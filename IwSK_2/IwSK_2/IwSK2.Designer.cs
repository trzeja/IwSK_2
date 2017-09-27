namespace IwSK_2
{
    partial class IwSK2
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
            this.rbMaster = new System.Windows.Forms.RadioButton();
            this.rbSlave = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbMaster = new System.Windows.Forms.GroupBox();
            this.gbCommunicationMaster = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbTransmittedDataMaster = new System.Windows.Forms.TextBox();
            this.tbHexSendFrame = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSendMaster = new System.Windows.Forms.Button();
            this.tbRecievedDataMaster = new System.Windows.Forms.TextBox();
            this.tbRecievedDataMasterHex = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbPortsMaster = new System.Windows.Forms.ComboBox();
            this.btnConfigureMaster = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudTimeConstraintMaster = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudRetransmissions = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTimeout = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbBroadcast = new System.Windows.Forms.RadioButton();
            this.rbAddressed = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nudAddressMaster = new System.Windows.Forms.NumericUpDown();
            this.cbCommandMaster = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSlave = new System.Windows.Forms.GroupBox();
            this.gbCommunicationSlave = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbReceivedDataSlaveHex = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbRecievedDataSlave = new System.Windows.Forms.TextBox();
            this.tbTransmittedDataSlave = new System.Windows.Forms.TextBox();
            this.tbTransmittedDataSlaveHex = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbPortsSlave = new System.Windows.Forms.ComboBox();
            this.btnConfigureSlave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nudAdddressSlave = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nudTimeConstraintSlave = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbMaster.SuspendLayout();
            this.gbCommunicationMaster.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeConstraintMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetransmissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeout)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddressMaster)).BeginInit();
            this.gbSlave.SuspendLayout();
            this.gbCommunicationSlave.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdddressSlave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeConstraintSlave)).BeginInit();
            this.SuspendLayout();
            // 
            // rbMaster
            // 
            this.rbMaster.AutoSize = true;
            this.rbMaster.Checked = true;
            this.rbMaster.Location = new System.Drawing.Point(6, 19);
            this.rbMaster.Name = "rbMaster";
            this.rbMaster.Size = new System.Drawing.Size(57, 17);
            this.rbMaster.TabIndex = 0;
            this.rbMaster.TabStop = true;
            this.rbMaster.Text = "Master";
            this.rbMaster.UseVisualStyleBackColor = true;
            this.rbMaster.CheckedChanged += new System.EventHandler(this.rbMaster_CheckedChanged);
            // 
            // rbSlave
            // 
            this.rbSlave.AutoSize = true;
            this.rbSlave.Location = new System.Drawing.Point(6, 42);
            this.rbSlave.Name = "rbSlave";
            this.rbSlave.Size = new System.Drawing.Size(52, 17);
            this.rbSlave.TabIndex = 1;
            this.rbSlave.Text = "Slave";
            this.rbSlave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSlave);
            this.groupBox1.Controls.Add(this.rbMaster);
            this.groupBox1.Location = new System.Drawing.Point(379, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(68, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tryb";
            // 
            // gbMaster
            // 
            this.gbMaster.Controls.Add(this.gbCommunicationMaster);
            this.gbMaster.Controls.Add(this.panel1);
            this.gbMaster.Location = new System.Drawing.Point(10, 12);
            this.gbMaster.Name = "gbMaster";
            this.gbMaster.Size = new System.Drawing.Size(347, 596);
            this.gbMaster.TabIndex = 3;
            this.gbMaster.TabStop = false;
            this.gbMaster.Text = "Master";
            // 
            // gbCommunicationMaster
            // 
            this.gbCommunicationMaster.Controls.Add(this.label14);
            this.gbCommunicationMaster.Controls.Add(this.label9);
            this.gbCommunicationMaster.Controls.Add(this.label17);
            this.gbCommunicationMaster.Controls.Add(this.tbTransmittedDataMaster);
            this.gbCommunicationMaster.Controls.Add(this.tbHexSendFrame);
            this.gbCommunicationMaster.Controls.Add(this.label3);
            this.gbCommunicationMaster.Controls.Add(this.btnSendMaster);
            this.gbCommunicationMaster.Controls.Add(this.tbRecievedDataMaster);
            this.gbCommunicationMaster.Controls.Add(this.tbRecievedDataMasterHex);
            this.gbCommunicationMaster.Enabled = false;
            this.gbCommunicationMaster.Location = new System.Drawing.Point(6, 322);
            this.gbCommunicationMaster.Name = "gbCommunicationMaster";
            this.gbCommunicationMaster.Size = new System.Drawing.Size(333, 268);
            this.gbCommunicationMaster.TabIndex = 25;
            this.gbCommunicationMaster.TabStop = false;
            this.gbCommunicationMaster.Text = "Komunikacja";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 204);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Odebrana ramka hex:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nadawanie: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 79);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Wysłana ramka hex:";
            // 
            // tbTransmittedDataMaster
            // 
            this.tbTransmittedDataMaster.Location = new System.Drawing.Point(11, 38);
            this.tbTransmittedDataMaster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTransmittedDataMaster.Multiline = true;
            this.tbTransmittedDataMaster.Name = "tbTransmittedDataMaster";
            this.tbTransmittedDataMaster.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTransmittedDataMaster.Size = new System.Drawing.Size(316, 39);
            this.tbTransmittedDataMaster.TabIndex = 4;
            // 
            // tbHexSendFrame
            // 
            this.tbHexSendFrame.Location = new System.Drawing.Point(10, 95);
            this.tbHexSendFrame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbHexSendFrame.Multiline = true;
            this.tbHexSendFrame.Name = "tbHexSendFrame";
            this.tbHexSendFrame.ReadOnly = true;
            this.tbHexSendFrame.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbHexSendFrame.Size = new System.Drawing.Size(317, 39);
            this.tbHexSendFrame.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Odbieranie";
            // 
            // btnSendMaster
            // 
            this.btnSendMaster.Location = new System.Drawing.Point(252, 10);
            this.btnSendMaster.Name = "btnSendMaster";
            this.btnSendMaster.Size = new System.Drawing.Size(75, 23);
            this.btnSendMaster.TabIndex = 14;
            this.btnSendMaster.Text = "Wyślij";
            this.btnSendMaster.UseVisualStyleBackColor = true;
            this.btnSendMaster.Click += new System.EventHandler(this.btnSendMaster_Click);
            // 
            // tbRecievedDataMaster
            // 
            this.tbRecievedDataMaster.Location = new System.Drawing.Point(10, 158);
            this.tbRecievedDataMaster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRecievedDataMaster.Multiline = true;
            this.tbRecievedDataMaster.Name = "tbRecievedDataMaster";
            this.tbRecievedDataMaster.ReadOnly = true;
            this.tbRecievedDataMaster.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRecievedDataMaster.Size = new System.Drawing.Size(314, 39);
            this.tbRecievedDataMaster.TabIndex = 19;
            // 
            // tbRecievedDataMasterHex
            // 
            this.tbRecievedDataMasterHex.Location = new System.Drawing.Point(10, 219);
            this.tbRecievedDataMasterHex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRecievedDataMasterHex.Multiline = true;
            this.tbRecievedDataMasterHex.Name = "tbRecievedDataMasterHex";
            this.tbRecievedDataMasterHex.ReadOnly = true;
            this.tbRecievedDataMasterHex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRecievedDataMasterHex.Size = new System.Drawing.Size(317, 39);
            this.tbRecievedDataMasterHex.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.btnConfigureMaster);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 287);
            this.panel1.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbPortsMaster);
            this.groupBox6.Location = new System.Drawing.Point(8, 4);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Size = new System.Drawing.Size(297, 36);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Port COM:";
            // 
            // cbPortsMaster
            // 
            this.cbPortsMaster.FormattingEnabled = true;
            this.cbPortsMaster.Location = new System.Drawing.Point(88, 11);
            this.cbPortsMaster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPortsMaster.Name = "cbPortsMaster";
            this.cbPortsMaster.Size = new System.Drawing.Size(112, 21);
            this.cbPortsMaster.TabIndex = 0;
            // 
            // btnConfigureMaster
            // 
            this.btnConfigureMaster.Location = new System.Drawing.Point(116, 251);
            this.btnConfigureMaster.Name = "btnConfigureMaster";
            this.btnConfigureMaster.Size = new System.Drawing.Size(75, 23);
            this.btnConfigureMaster.TabIndex = 13;
            this.btnConfigureMaster.Text = "Konfiguruj";
            this.btnConfigureMaster.UseVisualStyleBackColor = true;
            this.btnConfigureMaster.Click += new System.EventHandler(this.btnConfigureMaster_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.nudTimeConstraintMaster);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.nudRetransmissions);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.nudTimeout);
            this.groupBox5.Location = new System.Drawing.Point(8, 126);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(297, 115);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parametry";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "ms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Odstęp";
            // 
            // nudTimeConstraintMaster
            // 
            this.nudTimeConstraintMaster.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTimeConstraintMaster.Location = new System.Drawing.Point(98, 84);
            this.nudTimeConstraintMaster.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTimeConstraintMaster.Name = "nudTimeConstraintMaster";
            this.nudTimeConstraintMaster.Size = new System.Drawing.Size(120, 20);
            this.nudTimeConstraintMaster.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Retransmisje";
            // 
            // nudRetransmissions
            // 
            this.nudRetransmissions.Location = new System.Drawing.Point(98, 56);
            this.nudRetransmissions.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRetransmissions.Name = "nudRetransmissions";
            this.nudRetransmissions.Size = new System.Drawing.Size(120, 20);
            this.nudRetransmissions.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Timeout";
            // 
            // nudTimeout
            // 
            this.nudTimeout.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTimeout.Location = new System.Drawing.Point(98, 29);
            this.nudTimeout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTimeout.Name = "nudTimeout";
            this.nudTimeout.Size = new System.Drawing.Size(120, 20);
            this.nudTimeout.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbBroadcast);
            this.groupBox3.Controls.Add(this.rbAddressed);
            this.groupBox3.Location = new System.Drawing.Point(8, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(111, 75);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Typ Transakcji";
            // 
            // rbBroadcast
            // 
            this.rbBroadcast.AutoSize = true;
            this.rbBroadcast.Checked = true;
            this.rbBroadcast.Location = new System.Drawing.Point(6, 48);
            this.rbBroadcast.Name = "rbBroadcast";
            this.rbBroadcast.Size = new System.Drawing.Size(104, 17);
            this.rbBroadcast.TabIndex = 1;
            this.rbBroadcast.TabStop = true;
            this.rbBroadcast.Text = "Rozgłoszeniowa";
            this.rbBroadcast.UseVisualStyleBackColor = true;
            this.rbBroadcast.CheckedChanged += new System.EventHandler(this.rbBroadcast_CheckedChanged);
            // 
            // rbAddressed
            // 
            this.rbAddressed.AutoSize = true;
            this.rbAddressed.Location = new System.Drawing.Point(6, 21);
            this.rbAddressed.Name = "rbAddressed";
            this.rbAddressed.Size = new System.Drawing.Size(84, 17);
            this.rbAddressed.TabIndex = 0;
            this.rbAddressed.Text = "Adresowana";
            this.rbAddressed.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nudAddressMaster);
            this.groupBox4.Controls.Add(this.cbCommandMaster);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(125, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 75);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Definicja ramki";
            // 
            // nudAddressMaster
            // 
            this.nudAddressMaster.Enabled = false;
            this.nudAddressMaster.Location = new System.Drawing.Point(62, 18);
            this.nudAddressMaster.Maximum = new decimal(new int[] {
            247,
            0,
            0,
            0});
            this.nudAddressMaster.Name = "nudAddressMaster";
            this.nudAddressMaster.Size = new System.Drawing.Size(102, 20);
            this.nudAddressMaster.TabIndex = 13;
            // 
            // cbCommandMaster
            // 
            this.cbCommandMaster.FormattingEnabled = true;
            this.cbCommandMaster.Location = new System.Drawing.Point(62, 49);
            this.cbCommandMaster.Name = "cbCommandMaster";
            this.cbCommandMaster.Size = new System.Drawing.Size(102, 21);
            this.cbCommandMaster.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rozkaz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adres";
            // 
            // gbSlave
            // 
            this.gbSlave.Controls.Add(this.gbCommunicationSlave);
            this.gbSlave.Controls.Add(this.panel2);
            this.gbSlave.Enabled = false;
            this.gbSlave.Location = new System.Drawing.Point(453, 12);
            this.gbSlave.Name = "gbSlave";
            this.gbSlave.Size = new System.Drawing.Size(353, 596);
            this.gbSlave.TabIndex = 4;
            this.gbSlave.TabStop = false;
            this.gbSlave.Text = "Slave";
            // 
            // gbCommunicationSlave
            // 
            this.gbCommunicationSlave.Controls.Add(this.label11);
            this.gbCommunicationSlave.Controls.Add(this.label19);
            this.gbCommunicationSlave.Controls.Add(this.tbReceivedDataSlaveHex);
            this.gbCommunicationSlave.Controls.Add(this.label16);
            this.gbCommunicationSlave.Controls.Add(this.label10);
            this.gbCommunicationSlave.Controls.Add(this.tbRecievedDataSlave);
            this.gbCommunicationSlave.Controls.Add(this.tbTransmittedDataSlave);
            this.gbCommunicationSlave.Controls.Add(this.tbTransmittedDataSlaveHex);
            this.gbCommunicationSlave.Enabled = false;
            this.gbCommunicationSlave.Location = new System.Drawing.Point(6, 322);
            this.gbCommunicationSlave.Name = "gbCommunicationSlave";
            this.gbCommunicationSlave.Size = new System.Drawing.Size(333, 268);
            this.gbCommunicationSlave.TabIndex = 26;
            this.gbCommunicationSlave.TabStop = false;
            this.gbCommunicationSlave.Text = "Komunikacja";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Nadawanie: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 207);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 13);
            this.label19.TabIndex = 25;
            this.label19.Text = "Odebrana ramka hex:";
            // 
            // tbReceivedDataSlaveHex
            // 
            this.tbReceivedDataSlaveHex.Location = new System.Drawing.Point(8, 222);
            this.tbReceivedDataSlaveHex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbReceivedDataSlaveHex.Multiline = true;
            this.tbReceivedDataSlaveHex.Name = "tbReceivedDataSlaveHex";
            this.tbReceivedDataSlaveHex.ReadOnly = true;
            this.tbReceivedDataSlaveHex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbReceivedDataSlaveHex.Size = new System.Drawing.Size(320, 39);
            this.tbReceivedDataSlaveHex.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 84);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Wysłana ramka hex:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 144);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Odbieranie";
            // 
            // tbRecievedDataSlave
            // 
            this.tbRecievedDataSlave.Location = new System.Drawing.Point(8, 159);
            this.tbRecievedDataSlave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRecievedDataSlave.Multiline = true;
            this.tbRecievedDataSlave.Name = "tbRecievedDataSlave";
            this.tbRecievedDataSlave.ReadOnly = true;
            this.tbRecievedDataSlave.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRecievedDataSlave.Size = new System.Drawing.Size(320, 39);
            this.tbRecievedDataSlave.TabIndex = 23;
            // 
            // tbTransmittedDataSlave
            // 
            this.tbTransmittedDataSlave.Location = new System.Drawing.Point(7, 43);
            this.tbTransmittedDataSlave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTransmittedDataSlave.Multiline = true;
            this.tbTransmittedDataSlave.Name = "tbTransmittedDataSlave";
            this.tbTransmittedDataSlave.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTransmittedDataSlave.Size = new System.Drawing.Size(321, 39);
            this.tbTransmittedDataSlave.TabIndex = 19;
            // 
            // tbTransmittedDataSlaveHex
            // 
            this.tbTransmittedDataSlaveHex.Location = new System.Drawing.Point(7, 99);
            this.tbTransmittedDataSlaveHex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTransmittedDataSlaveHex.Multiline = true;
            this.tbTransmittedDataSlaveHex.Name = "tbTransmittedDataSlaveHex";
            this.tbTransmittedDataSlaveHex.ReadOnly = true;
            this.tbTransmittedDataSlaveHex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTransmittedDataSlaveHex.Size = new System.Drawing.Size(321, 39);
            this.tbTransmittedDataSlaveHex.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox7);
            this.panel2.Controls.Add(this.btnConfigureSlave);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(6, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 177);
            this.panel2.TabIndex = 22;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbPortsSlave);
            this.groupBox7.Location = new System.Drawing.Point(10, 5);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Size = new System.Drawing.Size(297, 36);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Port COM:";
            // 
            // cbPortsSlave
            // 
            this.cbPortsSlave.FormattingEnabled = true;
            this.cbPortsSlave.Location = new System.Drawing.Point(88, 11);
            this.cbPortsSlave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPortsSlave.Name = "cbPortsSlave";
            this.cbPortsSlave.Size = new System.Drawing.Size(112, 21);
            this.cbPortsSlave.TabIndex = 0;
            // 
            // btnConfigureSlave
            // 
            this.btnConfigureSlave.Location = new System.Drawing.Point(127, 138);
            this.btnConfigureSlave.Name = "btnConfigureSlave";
            this.btnConfigureSlave.Size = new System.Drawing.Size(75, 23);
            this.btnConfigureSlave.TabIndex = 13;
            this.btnConfigureSlave.Text = "Konfiguruj";
            this.btnConfigureSlave.UseVisualStyleBackColor = true;
            this.btnConfigureSlave.Click += new System.EventHandler(this.btnConfigureSlave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.nudAdddressSlave);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.nudTimeConstraintSlave);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(10, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 83);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametry";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(217, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "ms";
            // 
            // nudAdddressSlave
            // 
            this.nudAdddressSlave.Location = new System.Drawing.Point(91, 25);
            this.nudAdddressSlave.Maximum = new decimal(new int[] {
            247,
            0,
            0,
            0});
            this.nudAdddressSlave.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdddressSlave.Name = "nudAdddressSlave";
            this.nudAdddressSlave.Size = new System.Drawing.Size(120, 20);
            this.nudAdddressSlave.TabIndex = 5;
            this.nudAdddressSlave.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Odstęp";
            // 
            // nudTimeConstraintSlave
            // 
            this.nudTimeConstraintSlave.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTimeConstraintSlave.Location = new System.Drawing.Point(91, 51);
            this.nudTimeConstraintSlave.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTimeConstraintSlave.Name = "nudTimeConstraintSlave";
            this.nudTimeConstraintSlave.Size = new System.Drawing.Size(120, 20);
            this.nudTimeConstraintSlave.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(43, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Adres";
            // 
            // IwSK2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 602);
            this.Controls.Add(this.gbSlave);
            this.Controls.Add(this.gbMaster);
            this.Controls.Add(this.groupBox1);
            this.Name = "IwSK2";
            this.Text = "IwSK2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMaster.ResumeLayout(false);
            this.gbCommunicationMaster.ResumeLayout(false);
            this.gbCommunicationMaster.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeConstraintMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetransmissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeout)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddressMaster)).EndInit();
            this.gbSlave.ResumeLayout(false);
            this.gbCommunicationSlave.ResumeLayout(false);
            this.gbCommunicationSlave.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdddressSlave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeConstraintSlave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMaster;
        private System.Windows.Forms.RadioButton rbSlave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbMaster;
        private System.Windows.Forms.GroupBox gbSlave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbBroadcast;
        private System.Windows.Forms.RadioButton rbAddressed;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCommandMaster;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown nudTimeout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudRetransmissions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudTimeConstraintMaster;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfigureMaster;
        private System.Windows.Forms.Button btnSendMaster;
        private System.Windows.Forms.TextBox tbTransmittedDataMaster;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConfigureSlave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudTimeConstraintSlave;
        private System.Windows.Forms.NumericUpDown nudAdddressSlave;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbRecievedDataMasterHex;
        private System.Windows.Forms.TextBox tbRecievedDataMaster;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbReceivedDataSlaveHex;
        private System.Windows.Forms.TextBox tbRecievedDataSlave;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbTransmittedDataSlaveHex;
        private System.Windows.Forms.TextBox tbTransmittedDataSlave;
        private System.Windows.Forms.NumericUpDown nudAddressMaster;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbHexSendFrame;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbPortsMaster;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbCommunicationMaster;
        private System.Windows.Forms.GroupBox gbCommunicationSlave;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cbPortsSlave;
    }
}

