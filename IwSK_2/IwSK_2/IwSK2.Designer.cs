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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudTimeConstraint = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudRetransmissions = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTimeout = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbBroadcast = new System.Windows.Forms.RadioButton();
            this.rbAddressed = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbCommands = new System.Windows.Forms.ComboBox();
            this.cbAddress = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSlave = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTransmitedData = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbRecievedData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbMaster.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeConstraint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetransmissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeout)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.gbMaster.Controls.Add(this.tbRecievedData);
            this.gbMaster.Controls.Add(this.label3);
            this.gbMaster.Controls.Add(this.btnSend);
            this.gbMaster.Controls.Add(this.tbTransmitedData);
            this.gbMaster.Controls.Add(this.label9);
            this.gbMaster.Controls.Add(this.panel1);
            this.gbMaster.Location = new System.Drawing.Point(12, 12);
            this.gbMaster.Name = "gbMaster";
            this.gbMaster.Size = new System.Drawing.Size(328, 419);
            this.gbMaster.TabIndex = 3;
            this.gbMaster.TabStop = false;
            this.gbMaster.Text = "Master";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnConfigure);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 243);
            this.panel1.TabIndex = 0;
            // 
            // btnConfigure
            // 
            this.btnConfigure.Location = new System.Drawing.Point(115, 205);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(75, 23);
            this.btnConfigure.TabIndex = 13;
            this.btnConfigure.Text = "Konfiguruj";
            this.btnConfigure.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.nudTimeConstraint);
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
            // nudTimeConstraint
            // 
            this.nudTimeConstraint.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTimeConstraint.Location = new System.Drawing.Point(98, 84);
            this.nudTimeConstraint.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTimeConstraint.Name = "nudTimeConstraint";
            this.nudTimeConstraint.Size = new System.Drawing.Size(120, 20);
            this.nudTimeConstraint.TabIndex = 10;
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
            this.rbAddressed.TabStop = true;
            this.rbAddressed.Text = "Adresowana";
            this.rbAddressed.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbCommands);
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
            // cbCommands
            // 
            this.cbCommands.FormattingEnabled = true;
            this.cbCommands.Location = new System.Drawing.Point(69, 47);
            this.cbCommands.Name = "cbCommands";
            this.cbCommands.Size = new System.Drawing.Size(102, 21);
            this.cbCommands.TabIndex = 4;
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
            this.gbSlave.Enabled = false;
            this.gbSlave.Location = new System.Drawing.Point(453, 12);
            this.gbSlave.Name = "gbSlave";
            this.gbSlave.Size = new System.Drawing.Size(450, 419);
            this.gbSlave.TabIndex = 4;
            this.gbSlave.TabStop = false;
            this.gbSlave.Text = "Slave";
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
            // tbTransmitedData
            // 
            this.tbTransmitedData.Location = new System.Drawing.Point(6, 288);
            this.tbTransmitedData.Margin = new System.Windows.Forms.Padding(2);
            this.tbTransmitedData.Multiline = true;
            this.tbTransmitedData.Name = "tbTransmitedData";
            this.tbTransmitedData.Size = new System.Drawing.Size(113, 86);
            this.tbTransmitedData.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(6, 379);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Wyślij";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // tbRecievedData
            // 
            this.tbRecievedData.Location = new System.Drawing.Point(134, 288);
            this.tbRecievedData.Margin = new System.Windows.Forms.Padding(2);
            this.tbRecievedData.Multiline = true;
            this.tbRecievedData.Name = "tbRecievedData";
            this.tbRecievedData.Size = new System.Drawing.Size(113, 86);
            this.tbRecievedData.TabIndex = 15;
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
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeConstraint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetransmissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeout)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.ComboBox cbCommands;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown nudTimeout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudRetransmissions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudTimeConstraint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfigure;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbTransmitedData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbRecievedData;
        private System.Windows.Forms.Label label3;
    }
}

