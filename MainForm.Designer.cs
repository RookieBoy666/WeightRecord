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
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(320, 278);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 31;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // sEquipmentNo
            // 
            this.sEquipmentNo.Enabled = false;
            this.sEquipmentNo.Location = new System.Drawing.Point(468, 174);
            this.sEquipmentNo.Name = "sEquipmentNo";
            this.sEquipmentNo.ReadOnly = true;
            this.sEquipmentNo.Size = new System.Drawing.Size(100, 21);
            this.sEquipmentNo.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 29;
            this.label7.Text = "设备号";
            // 
            // nWeight
            // 
            this.nWeight.Enabled = false;
            this.nWeight.Location = new System.Drawing.Point(186, 174);
            this.nWeight.Name = "nWeight";
            this.nWeight.ReadOnly = true;
            this.nWeight.Size = new System.Drawing.Size(100, 21);
            this.nWeight.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 27;
            this.label5.Text = "重量";
            // 
            // nLength
            // 
            this.nLength.Enabled = false;
            this.nLength.Location = new System.Drawing.Point(468, 147);
            this.nLength.Name = "nLength";
            this.nLength.ReadOnly = true;
            this.nLength.Size = new System.Drawing.Size(100, 21);
            this.nLength.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "长度";
            // 
            // nUnitWeight
            // 
            this.nUnitWeight.Enabled = false;
            this.nUnitWeight.Location = new System.Drawing.Point(186, 147);
            this.nUnitWeight.Name = "nUnitWeight";
            this.nUnitWeight.ReadOnly = true;
            this.nUnitWeight.Size = new System.Drawing.Size(100, 21);
            this.nUnitWeight.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "克重";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "款号";
            // 
            // sMaterialNo
            // 
            this.sMaterialNo.Enabled = false;
            this.sMaterialNo.Location = new System.Drawing.Point(468, 120);
            this.sMaterialNo.Name = "sMaterialNo";
            this.sMaterialNo.ReadOnly = true;
            this.sMaterialNo.Size = new System.Drawing.Size(100, 21);
            this.sMaterialNo.TabIndex = 21;
            // 
            // sCardNo
            // 
            this.sCardNo.Enabled = false;
            this.sCardNo.Location = new System.Drawing.Point(186, 120);
            this.sCardNo.Name = "sCardNo";
            this.sCardNo.ReadOnly = true;
            this.sCardNo.Size = new System.Drawing.Size(100, 21);
            this.sCardNo.TabIndex = 20;
            this.sCardNo.TextChanged += new System.EventHandler(this.sCardNo_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "卡号";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(182, 278);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 18;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(399, 79);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 36;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click_1);
            // 
            // sFabricNo
            // 
            this.sFabricNo.Location = new System.Drawing.Point(186, 73);
            this.sFabricNo.Multiline = true;
            this.sFabricNo.Name = "sFabricNo";
            this.sFabricNo.Size = new System.Drawing.Size(100, 41);
            this.sFabricNo.TabIndex = 38;
            this.sFabricNo.TextChanged += new System.EventHandler(this.sFabricNo_TextChanged);
            this.sFabricNo.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(115, 90);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(41, 12);
            this.lable1.TabIndex = 37;
            this.lable1.Text = "布卷号";
            this.lable1.Click += new System.EventHandler(this.lable1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 442);
            this.Controls.Add(this.sFabricNo);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.sEquipmentNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nWeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nUnitWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sMaterialNo);
            this.Controls.Add(this.sCardNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "称重记录";
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
    }
}

