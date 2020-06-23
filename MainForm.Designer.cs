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
            this.save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sCardNo = new System.Windows.Forms.TextBox();
            this.sMaterialNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nUnitWeight = new System.Windows.Forms.TextBox();
            this.nLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(187, 278);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 0;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "卡号";
            // 
            // sCardNo
            // 
            this.sCardNo.Location = new System.Drawing.Point(167, 39);
            this.sCardNo.Name = "sCardNo";
            this.sCardNo.Size = new System.Drawing.Size(100, 21);
            this.sCardNo.TabIndex = 2;
            this.sCardNo.TextChanged += new System.EventHandler(this.sCardNo_TextChanged);
            this.sCardNo.MouseLeave += new System.EventHandler(this.sCardNo_MouseLeave);
            // 
            // sMaterialNo
            // 
            this.sMaterialNo.Location = new System.Drawing.Point(449, 39);
            this.sMaterialNo.Name = "sMaterialNo";
            this.sMaterialNo.Size = new System.Drawing.Size(100, 21);
            this.sMaterialNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "款号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "克重";
            // 
            // nUnitWeight
            // 
            this.nUnitWeight.Location = new System.Drawing.Point(167, 86);
            this.nUnitWeight.Name = "nUnitWeight";
            this.nUnitWeight.Size = new System.Drawing.Size(100, 21);
            this.nUnitWeight.TabIndex = 6;
            // 
            // nLength
            // 
            this.nLength.Location = new System.Drawing.Point(449, 86);
            this.nLength.Name = "nLength";
            this.nLength.Size = new System.Drawing.Size(100, 21);
            this.nLength.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "长度";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nWeight
            // 
            this.nWeight.Location = new System.Drawing.Point(167, 135);
            this.nWeight.Name = "nWeight";
            this.nWeight.Size = new System.Drawing.Size(100, 21);
            this.nWeight.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "重量";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(449, 135);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "设备号";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(325, 278);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 337);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(589, 241);
            this.dataGridView1.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.textBox5);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sCardNo;
        private System.Windows.Forms.TextBox sMaterialNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nUnitWeight;
        private System.Windows.Forms.TextBox nLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

