using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WeightRecord
{
    public partial class MainForm : Form
    {
        private SerialPort com;
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
                    nUnitWeight.Text = dt.Rows[0][4].ToString();
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
            string sql = "SELECT  top 100 a.sFabricNo, a.sCardNo,a.sMaterialNo,a. nLength,sEquipmentNo,a.nUnitWeight,a.nWeight,tcreatetime FROM qmRawInspectHdr A  where nWeight is not null   order by tcreatetime desc ";

            try
            {
                string @sFabricNo = (this.sFabricNo.Text).Trim();
                if (!string.IsNullOrEmpty(@sFabricNo))
                {
                    sql = "SELECT    a.sFabricNo, a.sCardNo,a.sMaterialNo,a. nLength,sEquipmentNo,a.nUnitWeight,a.nWeight,tcreatetime FROM qmRawInspectHdr A   where a.sFabricNo='" + @sFabricNo + "'";
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
                return;
            }
            else
            {
                string sql = "SELECT    a.sCardNo,a.sMaterialNo,a. nLength,sEquipmentNo,a.nUnitWeight,a.nWeight,a.sFabricNo,b.nGMWT FROM qmRawInspectHdr A JOIN dbo.mmMaterial b ON a.sMaterialNo=b.sMaterialNo AND b.bUsable=1 WHERE   " + "  a.sFabricNo='" + @sFabricNo + "'";
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
                        nUnitWeight.Text = string.IsNullOrEmpty(dt.Rows[0][7].ToString()) ? "0.00" : dt.Rows[0][7].ToString();
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
            decimal Weight;
            string @nWeight = this.nWeight.Text;
            if (@nWeight == "")
                @nWeight = "0";
            Weight = Convert.ToDecimal(@nWeight);

            //string @sLength = this.nLength.Text;
            //if (@sLength == "" || sLength=="0.00")
            //{
            //    MessageBox.Show("长度不能为空，除0操作！");
            //    return;
            //}
            // nUnitWeight.Text = (Weight * 1000 / Convert.ToDecimal(@sLength)).ToString();

            string sql = "UPDATE qmRawInspectHdr SET" + " nWeight=" + Math.Round(Weight, 2) + " WHERE  sFabricNo='" + this.sFabricNo.Text.Trim() + "'";
            try
            {
                SqlConnection Sqlconn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(sql, Sqlconn);
                Sqlconn.Open();
                cmd.ExecuteNonQuery();
                Sqlconn.Close();
                MessageBox.Show("保存成功！");
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
        //private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{
        //    ////   Thread.Sleep(500);//线程休眠500毫秒，方便接收串口的全部数据
        //    try
        //    {
        //        if (com.IsOpen)
        //        {
        //            byte[] readBuffer = new byte[com.ReadBufferSize + 1];
        //            try
        //            {
        //                int count = com.Read(readBuffer, 0, com.ReadBufferSize);        //读取串口数据(监听)
        //                String SerialIn = System.Text.Encoding.ASCII.GetString(readBuffer, 0, count);//将字节数组解码为字符串
        //                if (count != 0)
        //                {
        //                    //这里强调一下,线程里不可以直接对UI进行赋值，只能使用委托操作控件
        //                    this.BeginInvoke(new System.Threading.ThreadStart(delegate ()
        //                    {
        //                        nWeight.Text = SerialIn;
        //                    }));

        //                }
        //            }
        //            catch (TimeoutException) { }
        //        }
        //        else
        //        {
        //            TimeSpan waitTime = new TimeSpan(0, 0, 0, 0, 50);
        //            Thread.Sleep(waitTime);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}


        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            com.Open();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string senStr;
        //    senStr = sentMsg.Text;
        //    try
        //    {
        //        serialPort1.Write(senStr);
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("发送失败");
        //    }
        //}

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] readBuffer = new byte[serialPort1.ReadBufferSize + 1];
            try
            {
                int count = serialPort1.Read(readBuffer, 0, serialPort1.ReadBufferSize);
                //int count = com.Read(readBuffer, 0, com.ReadBufferSize);        //读取串口数据(监听)
                string SerialIn = serialPort1.ReadLine();// System.Text.Encoding.ASCII.GetString(readBuffer, 0, count);//将字节数组解码为字符串
                Console.WriteLine(SerialIn);
                // return;
                if (count != 0)
                {
                    ///textBox1.Text = SerialIn;
                    //这里强调一下,线程里不可以直接对UI进行赋值，只能使用委托操作控件
                    this.BeginInvoke(new System.Threading.ThreadStart(delegate ()
                    {

                        string initData = SerialIn;

                        string aaa = initData;
                        //ST,GS,+   0.00kg
                        string[] array = aaa.Split(',');
                        int k = -1;

                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i].Contains("kg"))
                            {
                                k = i;
                            }
                        }
                        if (k != -1)
                        {
                            nWeight.Text = (array[k].Trim().Replace('+', ' ').Replace('-', ' ').Replace("kg", " ")).Trim();
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

        //private void open_Click(object sender, EventArgs e)
        //{
        //    string[] str = SerialPort.GetPortNames();
        //    if (str.Length == 0)
        //    {
        //        MessageBox.Show("本机没有串口,磅秤重量读取将会失败！", "警告");
        //        return;
        //    }

        //    //添加串口项目
        //    foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
        //    {//获取有多少个COM口

        //        cmbPort.Items.Add(s);
        //    }
        //    cmbPort.SelectedIndex = 0;//默认选择第一个COM1

        //    if (com.IsOpen)
        //    {
        //        com.Close();
        //    }

        //    com.PortName = cmbPort.SelectedItem.ToString();
        //    // // com.PortName //= serialName;
        //    // //  com = new SerialPort("COM1");       //实例化SerialPort并设置COM口

        //    com.BaudRate = 9600;//波特率
        //    com.Parity = Parity.None;//无奇偶校验位
        //    com.StopBits = StopBits.Two;//两个停止位
        //    com.Handshake = Handshake.RequestToSend;//控制协议
        //    com.ReceivedBytesThreshold = 13;//设置 DataReceived 事件发生前内部输入缓冲区中的字节数,我这里是13字节为一组
        //                                    //// com.Open();                 //打开串口  
        //    if (!com.IsOpen)
        //    {
        //        try
        //        {
        //            com.Open();
        //            //  MessageBox.Show(string.Format("打开串口{0}成功！",com.PortName));
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.ToString());
        //        }
        //    }
        //}

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
            string senStr="R";
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
    }
}

