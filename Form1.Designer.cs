namespace WeightRecord
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sentMsg = new System.Windows.Forms.TextBox();
            this.IschBoxAuto = new System.Windows.Forms.CheckBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sent = new System.Windows.Forms.Button();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbStopBit = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(275, 390);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(21, 18);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 57;
            this.pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sentMsg
            // 
            this.sentMsg.Location = new System.Drawing.Point(299, 70);
            this.sentMsg.Name = "sentMsg";
            this.sentMsg.Size = new System.Drawing.Size(100, 21);
            this.sentMsg.TabIndex = 60;
            this.sentMsg.Text = "R";
            // 
            // IschBoxAuto
            // 
            this.IschBoxAuto.AutoSize = true;
            this.IschBoxAuto.Location = new System.Drawing.Point(257, 433);
            this.IschBoxAuto.Name = "IschBoxAuto";
            this.IschBoxAuto.Size = new System.Drawing.Size(96, 16);
            this.IschBoxAuto.TabIndex = 56;
            this.IschBoxAuto.Text = "是否自动发送";
            this.IschBoxAuto.UseVisualStyleBackColor = true;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(356, 1);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(67, 20);
            this.cmbBaudRate.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(297, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 48;
            this.label10.Text = "波 特 率";
            // 
            // sent
            // 
            this.sent.Location = new System.Drawing.Point(301, 102);
            this.sent.Name = "sent";
            this.sent.Size = new System.Drawing.Size(75, 23);
            this.sent.TabIndex = 59;
            this.sent.Text = "发送";
            this.sent.UseVisualStyleBackColor = true;
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Location = new System.Drawing.Point(305, 287);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(51, 20);
            this.cmbDataBits.TabIndex = 54;
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(312, 388);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(70, 23);
            this.btnOpenPort.TabIndex = 55;
            this.btnOpenPort.Text = "打开串口";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(305, 356);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(80, 20);
            this.cmbParity.TabIndex = 53;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(469, 80);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 58;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(258, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 49;
            this.label11.Text = "校验位";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(258, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 47;
            this.label12.Text = "数据位";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(258, 324);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 50;
            this.label13.Text = "停止位";
            // 
            // cmbStopBit
            // 
            this.cmbStopBit.FormattingEnabled = true;
            this.cmbStopBit.Location = new System.Drawing.Point(305, 321);
            this.cmbStopBit.Name = "cmbStopBit";
            this.cmbStopBit.Size = new System.Drawing.Size(51, 20);
            this.cmbStopBit.TabIndex = 52;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sentMsg);
            this.Controls.Add(this.IschBoxAuto);
            this.Controls.Add(this.cmbBaudRate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sent);
            this.Controls.Add(this.cmbDataBits);
            this.Controls.Add(this.btnOpenPort);
            this.Controls.Add(this.cmbParity);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbStopBit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sentMsg;
        private System.Windows.Forms.CheckBox IschBoxAuto;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button sent;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbStopBit;
    }
}