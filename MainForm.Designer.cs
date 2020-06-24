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
            this.CalcLength = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(498, 403);
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
            this.sEquipmentNo.Location = new System.Drawing.Point(78, 143);
            this.sEquipmentNo.Multiline = true;
            this.sEquipmentNo.Name = "sEquipmentNo";
            this.sEquipmentNo.ReadOnly = true;
            this.sEquipmentNo.Size = new System.Drawing.Size(136, 37);
            this.sEquipmentNo.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 157);
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
            this.label2.Location = new System.Drawing.Point(9, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "款号";
            // 
            // sMaterialNo
            // 
            this.sMaterialNo.Enabled = false;
            this.sMaterialNo.Location = new System.Drawing.Point(78, 102);
            this.sMaterialNo.Multiline = true;
            this.sMaterialNo.Name = "sMaterialNo";
            this.sMaterialNo.ReadOnly = true;
            this.sMaterialNo.Size = new System.Drawing.Size(136, 37);
            this.sMaterialNo.TabIndex = 21;
            // 
            // sCardNo
            // 
            this.sCardNo.Enabled = false;
            this.sCardNo.Location = new System.Drawing.Point(78, 59);
            this.sCardNo.Multiline = true;
            this.sCardNo.Name = "sCardNo";
            this.sCardNo.ReadOnly = true;
            this.sCardNo.Size = new System.Drawing.Size(136, 37);
            this.sCardNo.TabIndex = 20;
            this.sCardNo.TextChanged += new System.EventHandler(this.sCardNo_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 82);
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
            this.search.Location = new System.Drawing.Point(959, 297);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 36;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click_1);
            // 
            // sFabricNo
            // 
            this.sFabricNo.Location = new System.Drawing.Point(78, 16);
            this.sFabricNo.Multiline = true;
            this.sFabricNo.Name = "sFabricNo";
            this.sFabricNo.Size = new System.Drawing.Size(136, 37);
            this.sFabricNo.TabIndex = 38;
            this.sFabricNo.TextChanged += new System.EventHandler(this.sFabricNo_TextChanged);
            this.sFabricNo.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(5, 32);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(41, 12);
            this.lable1.TabIndex = 37;
            this.lable1.Text = "布卷号";
            this.lable1.Click += new System.EventHandler(this.lable1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 46);
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
            this.panel2.Controls.Add(this.CalcLength);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.nWeight);
            this.panel2.Location = new System.Drawing.Point(55, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 108);
            this.panel2.TabIndex = 41;
            // 
            // CalcLength
            // 
            this.CalcLength.Location = new System.Drawing.Point(382, 31);
            this.CalcLength.Multiline = true;
            this.CalcLength.Name = "CalcLength";
            this.CalcLength.Size = new System.Drawing.Size(136, 37);
            this.CalcLength.TabIndex = 40;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 734);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "称重记录";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

