﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WeightRecord
{
    public partial class MainForm : Form
    {
        private SerialPort com;
        private int isStable = 0;
        public static string connStr = "Data Source=192.168.88.4;Initial Catalog = HSTextileERP;Persist Security Info = True;User ID = zjp;Password =123456 ";
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int x = (int)(0.5 * (this.Width - Mainpanel.Width));
            int y = Mainpanel.Location.Y;
            Mainpanel.Location = new System.Drawing.Point(x, y);

        }




        private void save_Click(object sender, EventArgs e)
        {
            string sql = "";
            try
            {
                SqlConnection Sqlconn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(sql, Sqlconn);
                Sqlconn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, Sqlconn);
                da.Fill(ds);
                DataTable dt = new DataTable();
                Sqlconn.Close();
                if (dt.Rows.Count > 0)
                {
                    sMaterialNo.Text = dt.Rows[0][1].ToString();
                    nLength.Text = dt.Rows[0][2].ToString();
                    sEquipmentNo.Text = dt.Rows[0][3].ToString();
                    sRawGMWT.Text = dt.Rows[0][4].ToString();
                    nWeight.Text = dt.Rows[0][5].ToString();
                }

                //   6200229214   dsgv 
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "保存失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void search_Click(object sender, EventArgs e)
        {
            string sql = "SELECT  top 100  a.sCardNo,a.sFabricNo,a.sMaterialNo,a. nLength,sEquipmentNo,a.nUnitWeight,a.nWeight FROM qmRawInspectHdr A  order by tcreatetime desc ";
            try
            {
                SqlConnection Sqlconn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(sql, Sqlconn);
                Sqlconn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, Sqlconn);
                da.Fill(ds);
                DataTable dt = new DataTable();
                // dt = ds.Tables[0];
                da.Fill(dt);
                //dataGridView1.DataSource = ds.Tables[0];
                Sqlconn.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "查找失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void search_Click_1(object sender, EventArgs e)
        {
            //string str = this.sFabricNo.Text.Trim();
            //Thread th = new Thread(delegate () { new SearchForm(str).ShowDialog(); });
            //th.Start();
            if (string.IsNullOrEmpty(this.sFabricNo.Text.Trim()))
            { 

            }
            string sql = "SELECT  top 100 a.sFabricNo, a.sCardNo,a.sMaterialNo,a. nLength,sEquipmentNo,a.nUnitWeight,a.nWeight,A.tcreatetime FROM qmRawInspectHdr A  where nWeight is not null   order by tcreatetime desc ";

            try
            {
                string @sFabricNo = (this.sFabricNo.Text).Trim();
                if (!string.IsNullOrEmpty(@sFabricNo))
                {
                    sql = "SELECT    a.sFabricNo, a.sCardNo,a.sMaterialNo,a. nLength,sEquipmentNo,b.sRawGMWT,a.nWeight,A.tcreatetime FROM qmRawInspectHdr A join mmMaterial b on a.sMaterialNo=b.sMaterialNo and b.bUsable=1   where a.sFabricNo='" + @sFabricNo + "'";
                }
                SqlConnection Sqlconn = new SqlConnection(MainForm.connStr);
                SqlCommand cmd = new SqlCommand(sql, Sqlconn);
                Sqlconn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, Sqlconn);
                da.Fill(ds);
                DataTable dt = new DataTable();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "布卷号";
                dataGridView1.Columns[1].HeaderText = "卡号";
                dataGridView1.Columns[2].HeaderText = "款号";
                dataGridView1.Columns[3].HeaderText = "长度";
                dataGridView1.Columns[4].HeaderText = "设备号";
                dataGridView1.Columns[5].HeaderText = "克重";
                dataGridView1.Columns[6].HeaderText = "重量";
                dataGridView1.Columns[7].HeaderText = "创建时间";
                Sqlconn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "查找失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }



        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            string @sFabricNo = this.sFabricNo.Text.Trim();
            if (string.IsNullOrEmpty(@sFabricNo))
            {
                sCardNo.Text = "";
                sMaterialNo.Text = "";
                nLength.Text = "";
                sRawGMWT.Text = "";
                sEquipmentNo.Text = "";
                return;
            }
            else
            {
                string sql = "SELECT    a.sCardNo,a.sMaterialNo,a. nLength,sEquipmentNo,a.nUnitWeight,a.nWeight,a.sFabricNo,b.sRawGMWT FROM qmRawInspectHdr A JOIN dbo.mmMaterial b ON a.sMaterialNo=b.sMaterialNo AND b.bUsable=1 WHERE   " + "  a.sFabricNo='" + @sFabricNo + "'";
                try
                {
                    SqlConnection Sqlconn = new SqlConnection(connStr);
                    SqlCommand cmd = new SqlCommand(sql, Sqlconn);
                    Sqlconn.Open();
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(sql, Sqlconn);
                    da.Fill(ds);
                    DataTable dt = new DataTable();
                    // dt = ds.Tables[0];
                    da.Fill(dt);
                    // dataGridView1.DataSource = ds.Tables[0];
                    Sqlconn.Close();
                    if (dt.Rows.Count > 0)
                    {
                        sCardNo.Text = dt.Rows[0][0].ToString();
                        sMaterialNo.Text = dt.Rows[0][1].ToString();
                        nLength.Text = dt.Rows[0][2].ToString();
                        sEquipmentNo.Text = dt.Rows[0][3].ToString();
                        sRawGMWT.Text = string.IsNullOrEmpty(dt.Rows[0][7].ToString()) ? "0.00" : dt.Rows[0][7].ToString();
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "查找失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


        private void save_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sFabricNo.Text))
            {
                MessageBox.Show("布卷号为空，确认失败！", "警告");
                return;
            }
            if (isStable != 1)
            {
                MessageBox.Show("当前称重量不稳定，保存失败！", "警告");
                return;
            }
            decimal Weight;
            string @nWeight = this.nWeight.Text;
            if (@nWeight == "")
                @nWeight = "0";
            Weight = Convert.ToDecimal(@nWeight);
            string sql = "UPDATE qmRawInspectHdr SET" + " nWeight=" + Math.Round(Weight, 2) + " WHERE  sFabricNo='" + this.sFabricNo.Text.Trim() + "'";


            //吧qmRawInspectHdr表中长度更新为折算长度
            string sqlLength = "update qmRawInspectHdr SET nLength="+ CalcLength.Text+ " where sFabricNo='" + this.sFabricNo.Text.Trim() + "'";

            //搜寻mmMaterial表中 sModel字段  ，此字段保存最初qmRawInspectHdr的长度（第一次）
            string getsModel = "select sModel from mmMaterial a where sMaterialNo='"+sMaterialNo.Text.ToString()+"'";
            string sqlsModel = "update mmMaterial set sModel='"+nLength.Text.ToString()+ "' where sMaterialNo='" + sMaterialNo.Text.ToString() + "'" ;

          //  string sqlnewLength = "update qmRawInspectHdr SET nLength=" + CalcLength.Text + " where sFabricNo='" + this.sFabricNo.Text.Trim() + "'";

            try
            {
                SqlConnection Sqlconn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(sql, Sqlconn);
               // SqlCommand getsModelcmd=new SqlCommand(getsModel, Sqlconn);
                Sqlconn.Open();

                cmd.ExecuteNonQuery();//更新qmRawInspectHdr的重量

                SqlDataAdapter da = new SqlDataAdapter(getsModel, Sqlconn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataSet ds = new DataSet();
                da.Fill(ds);
                string sModel =ds.Tables[0].Rows[0][0].ToString();
              

                if(string.IsNullOrEmpty(sModel))
                {
                    SqlCommand cmdsModel = new SqlCommand(sqlsModel, Sqlconn);
                    cmdsModel.ExecuteNonQuery();//如果sModel为空，更新mmMaterial表中的sModel为qmRawInspectHdr表最初的长度（第一次）
                }

                SqlCommand cmdsqlLength = new SqlCommand(sqlLength, Sqlconn);
                cmdsqlLength.ExecuteNonQuery();//qmRawInspectHdr表中长度更新为折算长度



                Sqlconn.Close();
                MessageBox.Show("保存成功！");
                Log log = new Log();
                log.RegisterLog(string.Format("布卷号{0}的重量是{1}", this.sFabricNo.Text.Trim(), Math.Round(Weight, 2)), DateTime.Now.ToString());
                // PJ190327002
                search.PerformClick();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "保存失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void nWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && (e.KeyChar != 46))
                e.Handled = true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            search.PerformClick();
            com = new SerialPort();
            string[] str = SerialPort.GetPortNames();
            if (str.Length == 0)
            {
                MessageBox.Show("本机没有串口,磅秤重量读取将会失败！", "警告");
                return;
            }

            //添加串口项目
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {//获取有多少个COM口

                cmbPort.Items.Add(s);
            }
            cmbPort.SelectedIndex = 0;//默认选择第一个COM 
            serialPort1.PortName = str[0];
        }


        /// <summary>
        /// 监听串口数据线程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         


  
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] readBuffer = new byte[serialPort1.ReadBufferSize + 1];
            try
            {
                // int count = serialPort1.Read(readBuffer, 0, serialPort1.ReadBufferSize);
                //int count = com.Read(readBuffer, 0, com.ReadBufferSize);        //读取串口数据(监听)
                string SerialIn = serialPort1.ReadLine();// System.Text.Encoding.ASCII.GetString(readBuffer, 0, count);//将字节数组解码为字符串
                Console.WriteLine(SerialIn);
                // return;
                if (SerialIn != string.Empty)
                {
                    ///textBox1.Text = SerialIn;
                    //这里强调一下,线程里不可以直接对UI进行赋值，只能使用委托操作控件
                    this.BeginInvoke(new System.Threading.ThreadStart(delegate ()
                    {
                        string initData = SerialIn;
                        string aaa = initData;
                        //ST,GS,+   0.00kg
                        string[] array = aaa.Split(',');
                        int k = -1, m = -1;

                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i].Contains("kg"))
                            {
                                k = i;
                            }
                            if (array[i].Contains("ST"))
                            {
                                m = i;
                            }
                        }
                        if (k != -1)
                        {
                            nWeight.Text = (array[k].Trim().Replace('+', ' ').Replace('-', ' ').Replace("kg", " ")).Trim();
                             if(sRawGMWT.Text!="" && Convert.ToDecimal(sRawGMWT.Text)>0)
                            {
                                Decimal @nWeight= Convert.ToDecimal(this.nWeight.Text);
                                Decimal @sRawGMWT = Convert.ToDecimal(this.sRawGMWT.Text);
                                CalcLength.Text = Math.Round((@nWeight * 1000 / @sRawGMWT*100),2).ToString();
                            }
                        }
                        if (m != -1)
                        {
                            //pictureBox1.Show();
                            isStable = 1;
                            string picPath = Application.StartupPath.Replace("bin\\Debug", "pic") + "\\1.ico";
                            pictureBox1.Image = Image.FromFile(picPath);
                        }
                        else
                        {
                            isStable = 0;
                            string picPath = Application.StartupPath.Replace("bin\\Debug", "pic") + "\\2.ico";
                            pictureBox1.Image = Image.FromFile(picPath);
                        }
                    }));
                }
            }
            catch (TimeoutException) { }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            serialPort1.Open();
        }

       
        //发送R
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(serialPort1.PortName))
            {
                MessageBox.Show("串口读取失败！");
                return;
            }
            timer1.Interval = int.Parse(intervalValue.Value.ToString());
            if (!(serialPort1.IsOpen))
            {
                serialPort1.Open();
            }
            string senStr = "R";
            //senStr = sentMsg.Text;
            try
            {
                serialPort1.Write(senStr);
            }
            catch (Exception)
            {
                //MessageBox.Show("发送失败");

            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;

        }
    }
}

