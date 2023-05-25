namespace Batutest
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
            this.COMGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StopbitComboBox = new System.Windows.Forms.ComboBox();
            this.ParityComboBox = new System.Windows.Forms.ComboBox();
            this.BaudrateComboBox = new System.Windows.Forms.ComboBox();
            this.PortsComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Grup = new System.Windows.Forms.GroupBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LedON = new System.Windows.Forms.Button();
            this.LedOFF = new System.Windows.Forms.Button();
            this.UDPGroupBox = new System.Windows.Forms.GroupBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.udpbaglan = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StatusProgressBar = new System.Windows.Forms.ProgressBar();
            this.COMGroupBox.SuspendLayout();
            this.Grup.SuspendLayout();
            this.UDPGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // COMGroupBox
            // 
            this.COMGroupBox.Controls.Add(this.label4);
            this.COMGroupBox.Controls.Add(this.ConnectButton);
            this.COMGroupBox.Controls.Add(this.label3);
            this.COMGroupBox.Controls.Add(this.label2);
            this.COMGroupBox.Controls.Add(this.label1);
            this.COMGroupBox.Controls.Add(this.StopbitComboBox);
            this.COMGroupBox.Controls.Add(this.ParityComboBox);
            this.COMGroupBox.Controls.Add(this.BaudrateComboBox);
            this.COMGroupBox.Controls.Add(this.PortsComboBox);
            this.COMGroupBox.Location = new System.Drawing.Point(32, 32);
            this.COMGroupBox.Name = "COMGroupBox";
            this.COMGroupBox.Size = new System.Drawing.Size(1115, 193);
            this.COMGroupBox.TabIndex = 0;
            this.COMGroupBox.TabStop = false;
            this.COMGroupBox.Text = "Bağlantı Ayar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(817, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "StopBits";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(963, 73);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(135, 66);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "BAGLAN";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Parity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baudrate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ports";
            // 
            // StopbitComboBox
            // 
            this.StopbitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopbitComboBox.FormattingEnabled = true;
            this.StopbitComboBox.Location = new System.Drawing.Point(752, 95);
            this.StopbitComboBox.Name = "StopbitComboBox";
            this.StopbitComboBox.Size = new System.Drawing.Size(186, 24);
            this.StopbitComboBox.TabIndex = 0;
            // 
            // ParityComboBox
            // 
            this.ParityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParityComboBox.FormattingEnabled = true;
            this.ParityComboBox.Location = new System.Drawing.Point(517, 95);
            this.ParityComboBox.Name = "ParityComboBox";
            this.ParityComboBox.Size = new System.Drawing.Size(186, 24);
            this.ParityComboBox.TabIndex = 0;
            // 
            // BaudrateComboBox
            // 
            this.BaudrateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudrateComboBox.FormattingEnabled = true;
            this.BaudrateComboBox.Location = new System.Drawing.Point(282, 95);
            this.BaudrateComboBox.Name = "BaudrateComboBox";
            this.BaudrateComboBox.Size = new System.Drawing.Size(186, 24);
            this.BaudrateComboBox.TabIndex = 0;
            // 
            // PortsComboBox
            // 
            this.PortsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortsComboBox.FormattingEnabled = true;
            this.PortsComboBox.Location = new System.Drawing.Point(47, 95);
            this.PortsComboBox.Name = "PortsComboBox";
            this.PortsComboBox.Size = new System.Drawing.Size(186, 24);
            this.PortsComboBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Grup
            // 
            this.Grup.Controls.Add(this.StatusProgressBar);
            this.Grup.Controls.Add(this.StatusLabel);
            this.Grup.Controls.Add(this.label5);
            this.Grup.Location = new System.Drawing.Point(32, 245);
            this.Grup.Name = "Grup";
            this.Grup.Size = new System.Drawing.Size(249, 125);
            this.Grup.TabIndex = 1;
            this.Grup.TabStop = false;
            this.Grup.Text = "Status";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(108, 38);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(27, 16);
            this.StatusLabel.TabIndex = 1;
            this.StatusLabel.Text = "-----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status:";
            // 
            // LedON
            // 
            this.LedON.Location = new System.Drawing.Point(346, 283);
            this.LedON.Name = "LedON";
            this.LedON.Size = new System.Drawing.Size(135, 66);
            this.LedON.TabIndex = 2;
            this.LedON.Text = "Led Yak";
            this.LedON.UseVisualStyleBackColor = true;
            this.LedON.Click += new System.EventHandler(this.LedON_Click);
            // 
            // LedOFF
            // 
            this.LedOFF.Location = new System.Drawing.Point(549, 283);
            this.LedOFF.Name = "LedOFF";
            this.LedOFF.Size = new System.Drawing.Size(135, 66);
            this.LedOFF.TabIndex = 2;
            this.LedOFF.Text = "Led Sondür";
            this.LedOFF.UseVisualStyleBackColor = true;
            this.LedOFF.Click += new System.EventHandler(this.LedOFF_Click);
            // 
            // UDPGroupBox
            // 
            this.UDPGroupBox.Controls.Add(this.PortTextBox);
            this.UDPGroupBox.Controls.Add(this.udpbaglan);
            this.UDPGroupBox.Controls.Add(this.label7);
            this.UDPGroupBox.Location = new System.Drawing.Point(85, 415);
            this.UDPGroupBox.Name = "UDPGroupBox";
            this.UDPGroupBox.Size = new System.Drawing.Size(454, 140);
            this.UDPGroupBox.TabIndex = 3;
            this.UDPGroupBox.TabStop = false;
            this.UDPGroupBox.Text = "UDP ";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(106, 47);
            this.PortTextBox.Multiline = true;
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(139, 46);
            this.PortTextBox.TabIndex = 1;
            // 
            // udpbaglan
            // 
            this.udpbaglan.Location = new System.Drawing.Point(293, 37);
            this.udpbaglan.Name = "udpbaglan";
            this.udpbaglan.Size = new System.Drawing.Size(135, 66);
            this.udpbaglan.TabIndex = 2;
            this.udpbaglan.Text = "Udp Baglan";
            this.udpbaglan.UseVisualStyleBackColor = true;
            this.udpbaglan.Click += new System.EventHandler(this.udpbaglan_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Status:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(85, 574);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(454, 140);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox3";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 37);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 34);
            this.textBox2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Status:";
            // 
            // StatusProgressBar
            // 
            this.StatusProgressBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StatusProgressBar.ForeColor = System.Drawing.SystemColors.Control;
            this.StatusProgressBar.Location = new System.Drawing.Point(29, 72);
            this.StatusProgressBar.Name = "StatusProgressBar";
            this.StatusProgressBar.Size = new System.Drawing.Size(176, 32);
            this.StatusProgressBar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 726);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.UDPGroupBox);
            this.Controls.Add(this.LedOFF);
            this.Controls.Add(this.LedON);
            this.Controls.Add(this.Grup);
            this.Controls.Add(this.COMGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.COMGroupBox.ResumeLayout(false);
            this.COMGroupBox.PerformLayout();
            this.Grup.ResumeLayout(false);
            this.Grup.PerformLayout();
            this.UDPGroupBox.ResumeLayout(false);
            this.UDPGroupBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox COMGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StopbitComboBox;
        private System.Windows.Forms.ComboBox ParityComboBox;
        private System.Windows.Forms.ComboBox BaudrateComboBox;
        private System.Windows.Forms.ComboBox PortsComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Grup;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button LedON;
        private System.Windows.Forms.Button LedOFF;
        private System.Windows.Forms.GroupBox UDPGroupBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button udpbaglan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar StatusProgressBar;
    }
}

