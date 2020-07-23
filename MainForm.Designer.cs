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
            this.clear = new System.Windows.Forms.PictureBox();
            this.Tube2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.netWeight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Tube3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Tube1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nWeight = new System.Windows.Forms.TextBox();
            this.CalcLength = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Mainpanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sEquipmentNo
            // 
            this.sEquipmentNo.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sEquipmentNo.Location = new System.Drawing.Point(538, 103);
            this.sEquipmentNo.Name = "sEquipmentNo";
            this.sEquipmentNo.ReadOnly = true;
            this.sEquipmentNo.Size = new System.Drawing.Size(133, 27);
            this.sEquipmentNo.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(471, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "设备号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(69, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 30);
            this.label5.TabIndex = 27;
            this.label5.Text = "毛重";
            // 
            // nLength
            // 
            this.nLength.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nLength.Location = new System.Drawing.Point(538, 70);
            this.nLength.Name = "nLength";
            this.nLength.ReadOnly = true;
            this.nLength.Size = new System.Drawing.Size(133, 27);
            this.nLength.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(476, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "长  度";
            // 
            // sRawGMWT
            // 
            this.sRawGMWT.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sRawGMWT.Location = new System.Drawing.Point(538, 137);
            this.sRawGMWT.Name = "sRawGMWT";
            this.sRawGMWT.ReadOnly = true;
            this.sRawGMWT.Size = new System.Drawing.Size(133, 27);
            this.sRawGMWT.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(476, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "克  重";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(74, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "款  号";
            // 
            // sMaterialNo
            // 
            this.sMaterialNo.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sMaterialNo.Location = new System.Drawing.Point(140, 108);
            this.sMaterialNo.Name = "sMaterialNo";
            this.sMaterialNo.ReadOnly = true;
            this.sMaterialNo.Size = new System.Drawing.Size(207, 27);
            this.sMaterialNo.TabIndex = 21;
            // 
            // sCardNo
            // 
            this.sCardNo.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sCardNo.Location = new System.Drawing.Point(140, 71);
            this.sCardNo.Name = "sCardNo";
            this.sCardNo.ReadOnly = true;
            this.sCardNo.Size = new System.Drawing.Size(207, 27);
            this.sCardNo.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(74, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "卡  号";
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save.Location = new System.Drawing.Point(461, 272);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(120, 51);
            this.save.TabIndex = 18;
            this.save.Text = "确认";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click_1);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search.Location = new System.Drawing.Point(230, 272);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(120, 51);
            this.search.TabIndex = 36;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click_1);
            // 
            // sFabricNo
            // 
            this.sFabricNo.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sFabricNo.Location = new System.Drawing.Point(305, 12);
            this.sFabricNo.Name = "sFabricNo";
            this.sFabricNo.Size = new System.Drawing.Size(223, 46);
            this.sFabricNo.TabIndex = 38;
            this.sFabricNo.TextChanged += new System.EventHandler(this.sFabricNo_TextChanged);
            this.sFabricNo.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable1.Location = new System.Drawing.Point(220, 21);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(79, 30);
            this.lable1.TabIndex = 37;
            this.lable1.Text = "布卷号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(529, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 60);
            this.label6.TabIndex = 39;
            this.label6.Text = "折算\r\n长度";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.Tube2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.netWeight);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.Tube3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Tube1);
            this.panel1.Controls.Add(this.label11);
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
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 263);
            this.panel1.TabIndex = 40;
            // 
            // clear
            // 
            this.clear.Image = global::WeightRecord.Properties.Resources.clear;
            this.clear.Location = new System.Drawing.Point(524, -3);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(68, 64);
            this.clear.TabIndex = 53;
            this.clear.TabStop = false;
            this.clear.Click += new System.EventHandler(this.clear_Click_1);
            // 
            // Tube2
            // 
            this.Tube2.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tube2.Location = new System.Drawing.Point(284, 144);
            this.Tube2.Name = "Tube2";
            this.Tube2.Size = new System.Drawing.Size(63, 27);
            this.Tube2.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(487, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 30);
            this.label13.TabIndex = 51;
            this.label13.Text = "kg";
            // 
            // netWeight
            // 
            this.netWeight.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.netWeight.ForeColor = System.Drawing.Color.Red;
            this.netWeight.Location = new System.Drawing.Point(353, 184);
            this.netWeight.Name = "netWeight";
            this.netWeight.Size = new System.Drawing.Size(134, 60);
            this.netWeight.TabIndex = 50;
            this.netWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(290, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 30);
            this.label12.TabIndex = 49;
            this.label12.Text = "净重";
            // 
            // Tube3
            // 
            this.Tube3.AutoSize = true;
            this.Tube3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tube3.Location = new System.Drawing.Point(348, 138);
            this.Tube3.Name = "Tube3";
            this.Tube3.Size = new System.Drawing.Size(36, 27);
            this.Tube3.TabIndex = 48;
            this.Tube3.Text = "kg";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(241, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 22);
            this.label10.TabIndex = 46;
            this.label10.Text = "管重";
            // 
            // Tube1
            // 
            this.Tube1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tube1.FormattingEnabled = true;
            this.Tube1.Location = new System.Drawing.Point(140, 144);
            this.Tube1.Name = "Tube1";
            this.Tube1.Size = new System.Drawing.Size(98, 24);
            this.Tube1.TabIndex = 45;
            this.Tube1.SelectedIndexChanged += new System.EventHandler(this.Tube1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(74, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 22);
            this.label11.TabIndex = 44;
            this.label11.Text = "管   型";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(729, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 53);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // nWeight
            // 
            this.nWeight.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nWeight.ForeColor = System.Drawing.Color.Red;
            this.nWeight.Location = new System.Drawing.Point(140, 183);
            this.nWeight.Name = "nWeight";
            this.nWeight.Size = new System.Drawing.Size(136, 60);
            this.nWeight.TabIndex = 28;
            this.nWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nWeight_KeyPress);
            // 
            // CalcLength
            // 
            this.CalcLength.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CalcLength.ForeColor = System.Drawing.Color.Blue;
            this.CalcLength.Location = new System.Drawing.Point(592, 184);
            this.CalcLength.Name = "CalcLength";
            this.CalcLength.Size = new System.Drawing.Size(131, 53);
            this.CalcLength.TabIndex = 40;
            this.CalcLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(888, 280);
            this.dataGridView1.TabIndex = 42;
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
            this.Mainpanel.Controls.Add(this.label9);
            this.Mainpanel.Controls.Add(this.label8);
            this.Mainpanel.Controls.Add(this.panel1);
            this.Mainpanel.Controls.Add(this.dataGridView1);
            this.Mainpanel.Controls.Add(this.search);
            this.Mainpanel.Controls.Add(this.save);
            this.Mainpanel.Controls.Add(this.menuStrip1);
            this.Mainpanel.Location = new System.Drawing.Point(12, 12);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Size = new System.Drawing.Size(894, 638);
            this.Mainpanel.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(602, 619);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 44;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 619);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 43;
            this.label8.Text = "label8";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 646);
            this.Controls.Add(this.Mainpanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "坯布称重";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Mainpanel.ResumeLayout(false);
            this.Mainpanel.PerformLayout();
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
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox nWeight;
        private System.Windows.Forms.Panel Mainpanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Tube1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Tube3;
        private System.Windows.Forms.TextBox netWeight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Tube2;
        private System.Windows.Forms.PictureBox clear;
    }
}

