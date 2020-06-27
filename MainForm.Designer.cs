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
            this.sEquipmentNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sRawGMWT = new System.Windows.Forms.TextBox();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nWeight = new System.Windows.Forms.TextBox();
            this.CalcLength = new System.Windows.Forms.TextBox();
            this.intervalValue = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Mainpanel = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sEquipmentNo
            // 
            this.sEquipmentNo.Enabled = false;
            this.sEquipmentNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sEquipmentNo.Location = new System.Drawing.Point(502, 118);
            this.sEquipmentNo.Name = "sEquipmentNo";
            this.sEquipmentNo.ReadOnly = true;
            this.sEquipmentNo.Size = new System.Drawing.Size(136, 26);
            this.sEquipmentNo.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(432, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "设备号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(146, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 30);
            this.label5.TabIndex = 27;
            this.label5.Text = "重  量";
            // 
            // nLength
            // 
            this.nLength.Enabled = false;
            this.nLength.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nLength.Location = new System.Drawing.Point(502, 40);
            this.nLength.Name = "nLength";
            this.nLength.ReadOnly = true;
            this.nLength.Size = new System.Drawing.Size(136, 26);
            this.nLength.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(432, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "长  度";
            // 
            // sRawGMWT
            // 
            this.sRawGMWT.Enabled = false;
            this.sRawGMWT.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sRawGMWT.Location = new System.Drawing.Point(502, 81);
            this.sRawGMWT.Name = "sRawGMWT";
            this.sRawGMWT.ReadOnly = true;
            this.sRawGMWT.Size = new System.Drawing.Size(136, 26);
            this.sRawGMWT.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(431, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "克  重";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(147, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "款  号";
            // 
            // sMaterialNo
            // 
            this.sMaterialNo.Enabled = false;
            this.sMaterialNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sMaterialNo.Location = new System.Drawing.Point(213, 118);
            this.sMaterialNo.Name = "sMaterialNo";
            this.sMaterialNo.ReadOnly = true;
            this.sMaterialNo.Size = new System.Drawing.Size(136, 26);
            this.sMaterialNo.TabIndex = 21;
            // 
            // sCardNo
            // 
            this.sCardNo.Enabled = false;
            this.sCardNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sCardNo.Location = new System.Drawing.Point(213, 81);
            this.sCardNo.Name = "sCardNo";
            this.sCardNo.ReadOnly = true;
            this.sCardNo.Size = new System.Drawing.Size(136, 26);
            this.sCardNo.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(147, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "卡  号";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(266, 267);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(88, 26);
            this.save.TabIndex = 18;
            this.save.Text = "确认";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click_1);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(438, 267);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(88, 26);
            this.search.TabIndex = 36;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click_1);
            // 
            // sFabricNo
            // 
            this.sFabricNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sFabricNo.Location = new System.Drawing.Point(213, 40);
            this.sFabricNo.Name = "sFabricNo";
            this.sFabricNo.Size = new System.Drawing.Size(136, 26);
            this.sFabricNo.TabIndex = 38;
            this.sFabricNo.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable1.Location = new System.Drawing.Point(149, 40);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(58, 22);
            this.lable1.TabIndex = 37;
            this.lable1.Text = "布卷号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(431, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 30);
            this.label6.TabIndex = 39;
            this.label6.Text = "折算长度";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.nWeight);
            this.panel1.Controls.Add(this.sMaterialNo);
            this.panel1.Controls.Add(this.CalcLength);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nLength);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sCardNo);
            this.panel1.Controls.Add(this.sFabricNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lable1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.sRawGMWT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.sEquipmentNo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 232);
            this.panel1.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(345, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 36);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // nWeight
            // 
            this.nWeight.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nWeight.ForeColor = System.Drawing.Color.Red;
            this.nWeight.Location = new System.Drawing.Point(213, 180);
            this.nWeight.Name = "nWeight";
            this.nWeight.Size = new System.Drawing.Size(126, 36);
            this.nWeight.TabIndex = 28;
            this.nWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nWeight_KeyPress);
            // 
            // CalcLength
            // 
            this.CalcLength.Enabled = false;
            this.CalcLength.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CalcLength.Location = new System.Drawing.Point(526, 180);
            this.CalcLength.Name = "CalcLength";
            this.CalcLength.Size = new System.Drawing.Size(112, 32);
            this.CalcLength.TabIndex = 40;
            // 
            // intervalValue
            // 
            this.intervalValue.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.intervalValue.Location = new System.Drawing.Point(65, 27);
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
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "间隔时间";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "串 口 号";
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(65, 54);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(67, 20);
            this.cmbPort.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(840, 297);
            this.dataGridView1.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.intervalValue);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbPort);
            this.groupBox1.Location = new System.Drawing.Point(859, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 232);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置信息";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Mainpanel
            // 
            this.Mainpanel.Controls.Add(this.panel1);
            this.Mainpanel.Controls.Add(this.groupBox1);
            this.Mainpanel.Controls.Add(this.dataGridView1);
            this.Mainpanel.Controls.Add(this.search);
            this.Mainpanel.Controls.Add(this.save);
            this.Mainpanel.Location = new System.Drawing.Point(12, 12);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Size = new System.Drawing.Size(1016, 629);
            this.Mainpanel.TabIndex = 44;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 644);
            this.Controls.Add(this.Mainpanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "称重记录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Mainpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox sEquipmentNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sRawGMWT;
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
        private System.Windows.Forms.TextBox CalcLength;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown intervalValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox nWeight;
        private System.Windows.Forms.Panel Mainpanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

