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
            this.tbRecievedDataMaster = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSendMaster = new System.Windows.Forms.Button();
            this.tbTransmittedDataMaster = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.cbCommandMaster = new System.Windows.Forms.ComboBox();
            this.cbAddress = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSlave = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfigureSlave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nudAdddress = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nudTimeConstraintSlave = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbCommandSlave = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSendSlave = new System.Windows.Forms.Button();
            this.tbTransmittedDataSlave = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbRecievedDataSlave = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbHexTransmittedMaster = new System.Windows.Forms.CheckBox();
            this.cbHexRecievedMaster = new System.Windows.Forms.CheckBox();
            this.cbHexTransmittedSlave = new System.Windows.Forms.CheckBox();
            this.cbHexRecievedSlave = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.gbMaster.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeConstraintMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetransmissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeout)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbSlave.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeConstraintSlave)).BeginInit();
            this.groupBox7.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(346, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tryb";
            // 
            // gbMaster
            // 
            this.gbMaster.Controls.Add(this.cbHexRecievedMaster);
            this.gbMaster.Controls.Add(this.cbHexTransmittedMaster);
            this.gbMaster.Controls.Add(this.tbRecievedDataMaster);
            this.gbMaster.Controls.Add(this.label3);
            this.gbMaster.Controls.Add(this.btnSendMaster);
            this.gbMaster.Controls.Add(this.tbTransmittedDataMaster);
            this.gbMaster.Controls.Add(this.label9);
            this.gbMaster.Controls.Add(this.panel1);
            this.gbMaster.Location = new System.Drawing.Point(12, 12);
            this.gbMaster.Name = "gbMaster";
            this.gbMaster.Size = new System.Drawing.Size(328, 419);
            this.gbMaster.TabIndex = 3;
            this.gbMaster.TabStop = false;
            this.gbMaster.Text = "Master";
            // 
            // tbRecievedDataMaster
            // 
            this.tbRecievedDataMaster.Location = new System.Drawing.Point(134, 288);
            this.tbRecievedDataMaster.Margin = new System.Windows.Forms.Padding(2);
            this.tbRecievedDataMaster.Multiline = true;
            this.tbRecievedDataMaster.Name = "tbRecievedDataMaster";
            this.tbRecievedDataMaster.Size = new System.Drawing.Size(113, 86);
            this.tbRecievedDataMaster.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Odbieranie";
            // 
            // btnSendMaster
            // 
            this.btnSendMaster.Location = new System.Drawing.Point(6, 379);
            this.btnSendMaster.Name = "btnSendMaster";
            this.btnSendMaster.Size = new System.Drawing.Size(75, 23);
            this.btnSendMaster.TabIndex = 14;
            this.btnSendMaster.Text = "Wyślij";
            this.btnSendMaster.UseVisualStyleBackColor = true;
            this.btnSendMaster.Click += new System.EventHandler(this.btnSendMaster_Click);
            // 
            // tbTransmittedDataMaster
            // 
            this.tbTransmittedDataMaster.Location = new System.Drawing.Point(6, 288);
            this.tbTransmittedDataMaster.Margin = new System.Windows.Forms.Padding(2);
            this.tbTransmittedDataMaster.Multiline = true;
            this.tbTransmittedDataMaster.Name = "tbTransmittedDataMaster";
            this.tbTransmittedDataMaster.Size = new System.Drawing.Size(113, 86);
            this.tbTransmittedDataMaster.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 270);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nadawanie: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnConfigureMaster);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 243);
            this.panel1.TabIndex = 0;
            // 
            // btnConfigureMaster
            // 
            this.btnConfigureMaster.Location = new System.Drawing.Point(115, 205);
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
            this.groupBox5.Location = new System.Drawing.Point(7, 84);
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
            this.label8.Location = new System.Drawing.Point(6, 86);
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
            this.label6.Location = new System.Drawing.Point(6, 58);
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
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Timeout:";
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
            this.groupBox3.Location = new System.Drawing.Point(7, 3);
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
            this.groupBox4.Controls.Add(this.cbCommandMaster);
            this.groupBox4.Controls.Add(this.cbAddress);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(124, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 75);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Definicja ramki";
            // 
            // cbCommandMaster
            // 
            this.cbCommandMaster.FormattingEnabled = true;
            this.cbCommandMaster.Location = new System.Drawing.Point(69, 47);
            this.cbCommandMaster.Name = "cbCommandMaster";
            this.cbCommandMaster.Size = new System.Drawing.Size(102, 21);
            this.cbCommandMaster.TabIndex = 4;
            // 
            // cbAddress
            // 
            this.cbAddress.FormattingEnabled = true;
            this.cbAddress.Location = new System.Drawing.Point(69, 15);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(102, 21);
            this.cbAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rozkaz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adres:";
            // 
            // gbSlave
            // 
            this.gbSlave.Controls.Add(this.cbHexRecievedSlave);
            this.gbSlave.Controls.Add(this.cbHexTransmittedSlave);
            this.gbSlave.Controls.Add(this.panel2);
            this.gbSlave.Controls.Add(this.btnSendSlave);
            this.gbSlave.Controls.Add(this.tbTransmittedDataSlave);
            this.gbSlave.Controls.Add(this.label11);
            this.gbSlave.Controls.Add(this.tbRecievedDataSlave);
            this.gbSlave.Controls.Add(this.label10);
            this.gbSlave.Enabled = false;
            this.gbSlave.Location = new System.Drawing.Point(453, 12);
            this.gbSlave.Name = "gbSlave";
            this.gbSlave.Size = new System.Drawing.Size(450, 419);
            this.gbSlave.TabIndex = 4;
            this.gbSlave.TabStop = false;
            this.gbSlave.Text = "Slave";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnConfigureSlave);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox7);
            this.panel2.Location = new System.Drawing.Point(24, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 209);
            this.panel2.TabIndex = 22;
            // 
            // btnConfigureSlave
            // 
            this.btnConfigureSlave.Location = new System.Drawing.Point(117, 173);
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
            this.groupBox2.Controls.Add(this.nudAdddress);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.nudTimeConstraintSlave);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(7, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 83);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametry";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(200, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "ms";
            // 
            // nudAdddress
            // 
            this.nudAdddress.Location = new System.Drawing.Point(74, 19);
            this.nudAdddress.Maximum = new decimal(new int[] {
            247,
            0,
            0,
            0});
            this.nudAdddress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdddress.Name = "nudAdddress";
            this.nudAdddress.Size = new System.Drawing.Size(101, 20);
            this.nudAdddress.TabIndex = 5;
            this.nudAdddress.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 51);
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
            this.nudTimeConstraintSlave.Location = new System.Drawing.Point(74, 45);
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
            this.label18.Location = new System.Drawing.Point(10, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Adres:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbCommandSlave);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Location = new System.Drawing.Point(124, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(180, 63);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Definicja ramki";
            // 
            // cbCommandSlave
            // 
            this.cbCommandSlave.FormattingEnabled = true;
            this.cbCommandSlave.Location = new System.Drawing.Point(72, 24);
            this.cbCommandSlave.Name = "cbCommandSlave";
            this.cbCommandSlave.Size = new System.Drawing.Size(102, 21);
            this.cbCommandSlave.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Rozkaz";
            // 
            // btnSendSlave
            // 
            this.btnSendSlave.Location = new System.Drawing.Point(24, 388);
            this.btnSendSlave.Name = "btnSendSlave";
            this.btnSendSlave.Size = new System.Drawing.Size(75, 23);
            this.btnSendSlave.TabIndex = 21;
            this.btnSendSlave.Text = "Wyślij";
            this.btnSendSlave.UseVisualStyleBackColor = true;
            this.btnSendSlave.Click += new System.EventHandler(this.btnSendSlave_Click);
            // 
            // tbTransmittedDataSlave
            // 
            this.tbTransmittedDataSlave.Location = new System.Drawing.Point(24, 297);
            this.tbTransmittedDataSlave.Margin = new System.Windows.Forms.Padding(2);
            this.tbTransmittedDataSlave.Multiline = true;
            this.tbTransmittedDataSlave.Name = "tbTransmittedDataSlave";
            this.tbTransmittedDataSlave.Size = new System.Drawing.Size(113, 86);
            this.tbTransmittedDataSlave.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 279);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Nadawanie: ";
            // 
            // tbRecievedDataSlave
            // 
            this.tbRecievedDataSlave.Location = new System.Drawing.Point(163, 297);
            this.tbRecievedDataSlave.Margin = new System.Windows.Forms.Padding(2);
            this.tbRecievedDataSlave.Multiline = true;
            this.tbRecievedDataSlave.Name = "tbRecievedDataSlave";
            this.tbRecievedDataSlave.Size = new System.Drawing.Size(113, 86);
            this.tbRecievedDataSlave.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 279);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Odbieranie";
            // 
            // cbHexTransmittedMaster
            // 
            this.cbHexTransmittedMaster.AutoSize = true;
            this.cbHexTransmittedMaster.Location = new System.Drawing.Point(76, 266);
            this.cbHexTransmittedMaster.Name = "cbHexTransmittedMaster";
            this.cbHexTransmittedMaster.Size = new System.Drawing.Size(43, 17);
            this.cbHexTransmittedMaster.TabIndex = 5;
            this.cbHexTransmittedMaster.Text = "hex";
            this.cbHexTransmittedMaster.UseVisualStyleBackColor = true;
            // 
            // cbHexRecievedMaster
            // 
            this.cbHexRecievedMaster.AutoSize = true;
            this.cbHexRecievedMaster.Location = new System.Drawing.Point(204, 266);
            this.cbHexRecievedMaster.Name = "cbHexRecievedMaster";
            this.cbHexRecievedMaster.Size = new System.Drawing.Size(43, 17);
            this.cbHexRecievedMaster.TabIndex = 17;
            this.cbHexRecievedMaster.Text = "hex";
            this.cbHexRecievedMaster.UseVisualStyleBackColor = true;
            // 
            // cbHexTransmittedSlave
            // 
            this.cbHexTransmittedSlave.AutoSize = true;
            this.cbHexTransmittedSlave.Location = new System.Drawing.Point(94, 275);
            this.cbHexTransmittedSlave.Name = "cbHexTransmittedSlave";
            this.cbHexTransmittedSlave.Size = new System.Drawing.Size(43, 17);
            this.cbHexTransmittedSlave.TabIndex = 18;
            this.cbHexTransmittedSlave.Text = "hex";
            this.cbHexTransmittedSlave.UseVisualStyleBackColor = true;
            // 
            // cbHexRecievedSlave
            // 
            this.cbHexRecievedSlave.AutoSize = true;
            this.cbHexRecievedSlave.Location = new System.Drawing.Point(233, 275);
            this.cbHexRecievedSlave.Name = "cbHexRecievedSlave";
            this.cbHexRecievedSlave.Size = new System.Drawing.Size(43, 17);
            this.cbHexRecievedSlave.TabIndex = 23;
            this.cbHexRecievedSlave.Text = "hex";
            this.cbHexRecievedSlave.UseVisualStyleBackColor = true;
            // 
            // IwSK2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 443);
            this.Controls.Add(this.gbSlave);
            this.Controls.Add(this.gbMaster);
            this.Controls.Add(this.groupBox1);
            this.Name = "IwSK2";
            this.Text = "IwSK2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMaster.ResumeLayout(false);
            this.gbMaster.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeConstraintMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetransmissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeout)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbSlave.ResumeLayout(false);
            this.gbSlave.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeConstraintSlave)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
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
        private System.Windows.Forms.ComboBox cbAddress;
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
        private System.Windows.Forms.TextBox tbRecievedDataMaster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConfigureSlave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudTimeConstraintSlave;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown nudAdddress;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSendSlave;
        private System.Windows.Forms.TextBox tbTransmittedDataSlave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbRecievedDataSlave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCommandSlave;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox cbHexTransmittedMaster;
        private System.Windows.Forms.CheckBox cbHexRecievedMaster;
        private System.Windows.Forms.CheckBox cbHexRecievedSlave;
        private System.Windows.Forms.CheckBox cbHexTransmittedSlave;
    }
}

