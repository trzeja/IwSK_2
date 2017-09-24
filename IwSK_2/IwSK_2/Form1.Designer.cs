namespace IwSK_2
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbBroadcast = new System.Windows.Forms.RadioButton();
            this.rbAddressed = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAddress = new System.Windows.Forms.ComboBox();
            this.cbCommands = new System.Windows.Forms.ComboBox();
            this.tbArguments = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gbMaster.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbMaster
            // 
            this.rbMaster.AutoSize = true;
            this.rbMaster.Location = new System.Drawing.Point(6, 19);
            this.rbMaster.Name = "rbMaster";
            this.rbMaster.Size = new System.Drawing.Size(57, 17);
            this.rbMaster.TabIndex = 0;
            this.rbMaster.TabStop = true;
            this.rbMaster.Text = "Master";
            this.rbMaster.UseVisualStyleBackColor = true;
            // 
            // rbSlave
            // 
            this.rbSlave.AutoSize = true;
            this.rbSlave.Location = new System.Drawing.Point(6, 42);
            this.rbSlave.Name = "rbSlave";
            this.rbSlave.Size = new System.Drawing.Size(52, 17);
            this.rbSlave.TabIndex = 1;
            this.rbSlave.TabStop = true;
            this.rbSlave.Text = "Slave";
            this.rbSlave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSlave);
            this.groupBox1.Controls.Add(this.rbMaster);
            this.groupBox1.Location = new System.Drawing.Point(337, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // gbMaster
            // 
            this.gbMaster.Controls.Add(this.groupBox5);
            this.gbMaster.Controls.Add(this.groupBox4);
            this.gbMaster.Controls.Add(this.groupBox3);
            this.gbMaster.Location = new System.Drawing.Point(12, 12);
            this.gbMaster.Name = "gbMaster";
            this.gbMaster.Size = new System.Drawing.Size(319, 267);
            this.gbMaster.TabIndex = 3;
            this.gbMaster.TabStop = false;
            this.gbMaster.Text = "Master";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(444, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 267);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Slave";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbBroadcast);
            this.groupBox3.Controls.Add(this.rbAddressed);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(103, 79);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction mode";
            // 
            // rbBroadcast
            // 
            this.rbBroadcast.AutoSize = true;
            this.rbBroadcast.Location = new System.Drawing.Point(6, 55);
            this.rbBroadcast.Name = "rbBroadcast";
            this.rbBroadcast.Size = new System.Drawing.Size(73, 17);
            this.rbBroadcast.TabIndex = 1;
            this.rbBroadcast.TabStop = true;
            this.rbBroadcast.Text = "Broadcast";
            this.rbBroadcast.UseVisualStyleBackColor = true;
            // 
            // rbAddressed
            // 
            this.rbAddressed.AutoSize = true;
            this.rbAddressed.Location = new System.Drawing.Point(6, 32);
            this.rbAddressed.Name = "rbAddressed";
            this.rbAddressed.Size = new System.Drawing.Size(75, 17);
            this.rbAddressed.TabIndex = 0;
            this.rbAddressed.TabStop = true;
            this.rbAddressed.Text = "Addressed";
            this.rbAddressed.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbArguments);
            this.groupBox4.Controls.Add(this.cbCommands);
            this.groupBox4.Controls.Add(this.cbAddress);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(115, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(198, 118);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Frame definition";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Command:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Arguments:";
            // 
            // cbAddress
            // 
            this.cbAddress.FormattingEnabled = true;
            this.cbAddress.Location = new System.Drawing.Point(69, 15);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(102, 21);
            this.cbAddress.TabIndex = 3;
            // 
            // cbCommands
            // 
            this.cbCommands.FormattingEnabled = true;
            this.cbCommands.Location = new System.Drawing.Point(69, 47);
            this.cbCommands.Name = "cbCommands";
            this.cbCommands.Size = new System.Drawing.Size(102, 21);
            this.cbCommands.TabIndex = 4;
            // 
            // tbArguments
            // 
            this.tbArguments.Location = new System.Drawing.Point(69, 82);
            this.tbArguments.Name = "tbArguments";
            this.tbArguments.Size = new System.Drawing.Size(100, 20);
            this.tbArguments.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(6, 104);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(103, 157);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parameters";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 306);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbMaster);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "IwSK2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMaster.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbBroadcast;
        private System.Windows.Forms.RadioButton rbAddressed;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAddress;
        private System.Windows.Forms.TextBox tbArguments;
        private System.Windows.Forms.ComboBox cbCommands;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

