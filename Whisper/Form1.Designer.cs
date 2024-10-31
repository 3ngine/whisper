namespace Whisper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            txtTarget = new TextBox();
            label1 = new Label();
            txtStartPort = new TextBox();
            txtEndPort = new TextBox();
            label2 = new Label();
            label5 = new Label();
            txtTimeout = new TextBox();
            cmbScanSpeed = new ComboBox();
            label3 = new Label();
            btnStop = new Button();
            btnScan = new Button();
            lstResults = new ListBox();
            progressBarScan = new ProgressBar();
            label4 = new Label();
            chkUdpScan = new CheckBox();
            lstOpenPorts = new ListBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(489, 426);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtTarget
            // 
            txtTarget.Location = new Point(31, 67);
            txtTarget.Name = "txtTarget";
            txtTarget.Size = new Size(148, 23);
            txtTarget.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(31, 49);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Target";
            // 
            // txtStartPort
            // 
            txtStartPort.Location = new Point(31, 116);
            txtStartPort.Name = "txtStartPort";
            txtStartPort.Size = new Size(72, 23);
            txtStartPort.TabIndex = 3;
            // 
            // txtEndPort
            // 
            txtEndPort.Location = new Point(109, 116);
            txtEndPort.Name = "txtEndPort";
            txtEndPort.Size = new Size(70, 23);
            txtEndPort.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(31, 98);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 5;
            label2.Text = "Scan range (Ports)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(31, 147);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 8;
            label5.Text = "Timeout";
            // 
            // txtTimeout
            // 
            txtTimeout.Location = new Point(31, 165);
            txtTimeout.Name = "txtTimeout";
            txtTimeout.Size = new Size(72, 23);
            txtTimeout.TabIndex = 9;
            // 
            // cmbScanSpeed
            // 
            cmbScanSpeed.FormattingEnabled = true;
            cmbScanSpeed.Items.AddRange(new object[] { "Fast", "Normal", "Slow" });
            cmbScanSpeed.Location = new Point(109, 165);
            cmbScanSpeed.Name = "cmbScanSpeed";
            cmbScanSpeed.Size = new Size(70, 23);
            cmbScanSpeed.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(109, 147);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 11;
            label3.Text = "Speed";
            // 
            // btnStop
            // 
            btnStop.Location = new Point(109, 222);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(70, 32);
            btnStop.TabIndex = 12;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnScan
            // 
            btnScan.Location = new Point(31, 222);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(72, 32);
            btnScan.TabIndex = 13;
            btnScan.Text = "Scan";
            btnScan.UseVisualStyleBackColor = true;
            btnScan.Click += btnScan_Click;
            // 
            // lstResults
            // 
            lstResults.FormattingEnabled = true;
            lstResults.ItemHeight = 15;
            lstResults.Location = new Point(248, 67);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(240, 124);
            lstResults.TabIndex = 14;
            // 
            // progressBarScan
            // 
            progressBarScan.Location = new Point(26, 408);
            progressBarScan.Name = "progressBarScan";
            progressBarScan.Size = new Size(462, 23);
            progressBarScan.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(248, 49);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 16;
            label4.Text = "Scan Result";
            // 
            // chkUdpScan
            // 
            chkUdpScan.AutoSize = true;
            chkUdpScan.BackColor = Color.FromArgb(224, 224, 224);
            chkUdpScan.Location = new Point(31, 196);
            chkUdpScan.Name = "chkUdpScan";
            chkUdpScan.Size = new Size(77, 19);
            chkUdpScan.TabIndex = 17;
            chkUdpScan.Text = "UDP Scan";
            chkUdpScan.UseVisualStyleBackColor = false;
            // 
            // lstOpenPorts
            // 
            lstOpenPorts.FormattingEnabled = true;
            lstOpenPorts.ItemHeight = 15;
            lstOpenPorts.Location = new Point(248, 218);
            lstOpenPorts.Name = "lstOpenPorts";
            lstOpenPorts.Size = new Size(240, 184);
            lstOpenPorts.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(248, 200);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 19;
            label6.Text = "Open Ports";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 450);
            Controls.Add(label6);
            Controls.Add(lstOpenPorts);
            Controls.Add(chkUdpScan);
            Controls.Add(label4);
            Controls.Add(progressBarScan);
            Controls.Add(lstResults);
            Controls.Add(btnScan);
            Controls.Add(btnStop);
            Controls.Add(label3);
            Controls.Add(cmbScanSpeed);
            Controls.Add(txtTimeout);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txtEndPort);
            Controls.Add(txtStartPort);
            Controls.Add(label1);
            Controls.Add(txtTarget);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Whisper";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtTarget;
        private Label label1;
        private TextBox txtStartPort;
        private TextBox txtEndPort;
        private Label label2;
        private Label label5;
        private TextBox txtTimeout;
        private ComboBox cmbScanSpeed;
        private Label label3;
        private Button btnStop;
        private Button btnScan;
        private ListBox lstResults;
        private ProgressBar progressBarScan;
        private Label label4;
        private CheckBox chkUdpScan;
        private ListBox lstOpenPorts;
        private Label label6;
    }
}
