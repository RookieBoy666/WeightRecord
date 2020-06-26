namespace WeightRecord
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cancel = new System.Windows.Forms.Button();
            this.sEquipmentNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nUnitWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sMaterialNo = new System.Windows.Forms.TextBox();
            this.sCardNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.sFabricNo = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.open = new System.Windows.Forms.Button();
            this.CalcLength = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.intervalValue = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.IschBoxAuto = new System.Windows.Forms.CheckBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbStopBit = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.sent = new System.Windows.Forms.Button();
            this.sentMsg = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalValue)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(434, 403);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 31;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // sEquipmentNo
            // 
            this.sEquipmentNo.Enabled = false;
            this.sEquipmentNo.Location = new System.Drawing.Point(367, 144);
            this.sEquipmentNo.Multiline = true;
            this.sEquipmentNo.Name = "sEquipmentNo";
            this.sEquipmentNo.ReadOnly = true;
            this.sEquipmentNo.Size = new System.Drawing.Size(136, 37);
            this.sEquipmentNo.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 29;
            this.label7.Text = "设备号";
            // 
            // nWeight
            // 
            this.nWeight.Location = new System.Drawing.Point(80, 31);
            this.nWeight.Multiline = true;
            this.nWeight.Name = "nWeight";
            this.nWeight.Size = new System.Drawing.Size(136, 37);
            this.nWeight.TabIndex = 28;
            this.nWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nWeight_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 27;
            this.label5.Text = "重量";
            // 
            // nLength
            // 
            this.nLength.Enabled = false;
            this.nLength.Location = new System.Drawing.Point(367, 48);
            this.nLength.Multiline = true;
            this.nLength.Name = "nLength";
            this.nLength.ReadOnly = true;
            this.nLength.Size = new System.Drawing.Size(136, 37);
            this.nLength.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "长度";
            // 
            // nUnitWeight
            // 
            this.nUnitWeight.Enabled = false;
            this.nUnitWeight.Location = new System.Drawing.Point(367, 100);
            this.nUnitWeight.Multiline = true;
            this.nUnitWeight.Name = "nUnitWeight";
            this.nUnitWeight.ReadOnly = true;
            this.nUnitWeight.Size = new System.Drawing.Size(136, 37);
            this.nUnitWeight.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "克重";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "款号";
            // 
            // sMaterialNo
            // 
            this.sMaterialNo.Enabled = false;
            this.sMaterialNo.Location = new System.Drawing.Point(78, 143);
            this.sMaterialNo.Multiline = true;
            this.sMaterialNo.Name = "sMaterialNo";
            this.sMaterialNo.ReadOnly = true;
            this.sMaterialNo.Size = new System.Drawing.Size(136, 37);
            this.sMaterialNo.TabIndex = 21;
            // 
            // sCardNo
            // 
            this.sCardNo.Enabled = false;
            this.sCardNo.Location = new System.Drawing.Point(78, 100);
            this.sCardNo.Multiline = true;
            this.sCardNo.Name = "sCardNo";
            this.sCardNo.ReadOnly = true;
            this.sCardNo.Size = new System.Drawing.Size(136, 37);
            this.sCardNo.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "卡号";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(186, 403);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 18;
            this.save.Text = "确认";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click_1);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(820, 403);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 36;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click_1);
            // 
            // sFabricNo
            // 
            this.sFabricNo.Location = new System.Drawing.Point(80, 48);
            this.sFabricNo.Multiline = true;
            this.sFabricNo.Name = "sFabricNo";
            this.sFabricNo.Size = new System.Drawing.Size(136, 37);
            this.sFabricNo.TabIndex = 38;
            this.sFabricNo.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(9, 62);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(41, 12);
            this.lable1.TabIndex = 37;
            this.lable1.Text = "布卷号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 39;
            this.label6.Text = "折算长度";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sMaterialNo);
            this.panel1.Controls.Add(this.nLength);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sCardNo);
            this.panel1.Controls.Add(this.sFabricNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lable1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nUnitWeight);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.sEquipmentNo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(55, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 217);
            this.panel1.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.open);
            this.panel2.Controls.Add(this.CalcLength);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.nWeight);
            this.panel2.Location = new System.Drawing.Point(55, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 108);
            this.panel2.TabIndex = 41;
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(565, 35);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 41;
            this.open.Text = "打开串口";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // CalcLength
            // 
            this.CalcLength.Location = new System.Drawing.Point(367, 31);
            this.CalcLength.Multiline = true;
            this.CalcLength.Name = "CalcLength";
            this.CalcLength.Size = new System.Drawing.Size(136, 37);
            this.CalcLength.TabIndex = 40;
            this.CalcLength.TextChanged += new System.EventHandler(this.CalcLength_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 450);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(852, 187);
            this.dataGridView1.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.intervalValue);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.IschBoxAuto);
            this.groupBox1.Controls.Add(this.cmbDataBits);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnOpenPort);
            this.groupBox1.Controls.Add(this.cmbPort);
            this.groupBox1.Controls.Add(this.cmbParity);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbBaudRate);
            this.groupBox1.Controls.Add(this.cmbStopBit);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(981, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 324);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置信息";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(28, 211);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(21, 18);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 19;
            this.pictureBox.TabStop = false;
            // 
            // intervalValue
            // 
            this.intervalValue.Location = new System.Drawing.Point(65, 281);
            this.intervalValue.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.intervalValue.Name = "intervalValue";
            this.intervalValue.Size = new System.Drawing.Size(67, 21);
            this.intervalValue.TabIndex = 18;
            this.intervalValue.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "间隔时间";
            // 
            // IschBoxAuto
            // 
            this.IschBoxAuto.AutoSize = true;
            this.IschBoxAuto.Location = new System.Drawing.Point(10, 254);
            this.IschBoxAuto.Name = "IschBoxAuto";
            this.IschBoxAuto.Size = new System.Drawing.Size(96, 16);
            this.IschBoxAuto.TabIndex = 15;
            this.IschBoxAuto.Text = "是否自动发送";
            this.IschBoxAuto.UseVisualStyleBackColor = true;
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Location = new System.Drawing.Point(55, 96);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(51, 20);
            this.cmbDataBits.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "串口号";
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(65, 209);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(70, 23);
            this.btnOpenPort.TabIndex = 14;
            this.btnOpenPort.Text = "打开串口";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(55, 23);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(80, 20);
            this.cmbPort.TabIndex = 8;
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(55, 165);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(80, 20);
            this.cmbParity.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "波特率";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "校验位";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(55, 62);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(80, 20);
            this.cmbBaudRate.TabIndex = 9;
            // 
            // cmbStopBit
            // 
            this.cmbStopBit.FormattingEnabled = true;
            this.cmbStopBit.Location = new System.Drawing.Point(55, 130);
            this.cmbStopBit.Name = "cmbStopBit";
            this.cmbStopBit.Size = new System.Drawing.Size(51, 20);
            this.cmbStopBit.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "数据位";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 7;
            this.label13.Text = "停止位";
            // 
            // sent
            // 
            this.sent.Location = new System.Drawing.Point(991, 450);
            this.sent.Name = "sent";
            this.sent.Size = new System.Drawing.Size(75, 23);
            this.sent.TabIndex = 44;
            this.sent.Text = "发送";
            this.sent.UseVisualStyleBackColor = true;
            this.sent.Click += new System.EventHandler(this.button1_Click);
            // 
            // sentMsg
            // 
            this.sentMsg.Location = new System.Drawing.Point(989, 418);
            this.sentMsg.Name = "sentMsg";
            this.sentMsg.Size = new System.Drawing.Size(100, 21);
            this.sentMsg.TabIndex = 45;
            this.sentMsg.Text = "R";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(991, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(981, 568);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 21);
            this.textBox1.TabIndex = 47;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 664);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sentMsg);
            this.Controls.Add(this.sent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "称重记录";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox sEquipmentNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nUnitWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sMaterialNo;
        private System.Windows.Forms.TextBox sCardNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox sFabricNo;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox CalcLength;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.NumericUpDown intervalValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox IschBoxAuto;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbStopBit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button sent;
        private System.Windows.Forms.TextBox sentMsg;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button open;
    }
}

