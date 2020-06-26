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
                // dt = ds.Tables[0];
                da.Fill(dt);
                // dataGridView1.DataSource = ds.Tables[0];
                Sqlconn.Close();
                if (dt.Rows.Count > 0)
                {
                    sMaterialNo.Text = dt.Rows[0][1].ToString();
                    nLength.Text = dt.Rows[0][2].ToString();
                    sEquipmentNo.Text = dt.Rows[0][3].ToString();
                    nUnitWeight.Text = dt.Rows[0][4].ToString();
                    nWeight.Text = dt.Rows[0][5].ToString();
                }
                //  sMaterialNo.Text=
                //   6200229214   dsgv 
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "保存失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                // dt = ds.Tables[0];
                // da.Fill(dt);
                dataGridView1.DataSource = ds.Tables[0];
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
            com = new SerialPort();
         //   open.PerformClick();


            //com.DataReceived += new SerialDataReceivedEventHandler(Com_DataReceived);           //接受数据线程


        }
 

        /// <summary>
        /// 监听串口数据线程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ////   Thread.Sleep(500);//线程休眠500毫秒，方便接收串口的全部数据
            try
            {
                if (com.IsOpen)
                {
                    byte[] readBuffer = new byte[com.ReadBufferSize + 1];
                    try
                    {
                        int count = com.Read(readBuffer, 0, com.ReadBufferSize);        //读取串口数据(监听)
                        String SerialIn = System.Text.Encoding.ASCII.GetString(readBuffer, 0, count);//将字节数组解码为字符串
                        if (count != 0)
                        {
                            //这里强调一下,线程里不可以直接对UI进行赋值，只能使用委托操作控件
                            this.BeginInvoke(new System.Threading.ThreadStart(delegate ()
                            {
                                nWeight.Text = SerialIn;
                            }));

                        }
                    }
                    catch (TimeoutException) { }
                }
                else
                {
                    TimeSpan waitTime = new TimeSpan(0, 0, 0, 0, 50);
                    Thread.Sleep(waitTime);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CalcLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            com.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string senStr;
            senStr = sentMsg.Text;
            try
            {
                //SendMsg(senStr);
                serialPort1.Write(senStr);

                //  com.Write(senStr);
                //Message_Blue(senStr);
            }
            catch (Exception)
            {
                MessageBox.Show("发送失败");
            }


            //if (listView_Chat.Items.Count > 16)
            //{
            //    listView_Chat.Items.Clear();
            //}
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            byte[] readBuffer = new byte[serialPort1.ReadBufferSize + 1];
            try
            {
                int count = serialPort1.Read(readBuffer, 0, serialPort1.ReadBufferSize);
                //int count = com.Read(readBuffer, 0, com.ReadBufferSize);        //读取串口数据(监听)
                string SerialIn = System.Text.Encoding.ASCII.GetString(readBuffer, 0, count);//将字节数组解码为字符串
                if (count != 0)
                {
                    ///textBox1.Text = SerialIn;
                    //这里强调一下,线程里不可以直接对UI进行赋值，只能使用委托操作控件
                    this.BeginInvoke(new System.Threading.ThreadStart(delegate ()
                    {



                        //foreach(string a in array)

                        textBox1.Text = SerialIn;
                        string aaa = textBox1.Text;
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
                        if(k!=-1)
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

        private void open_Click(object sender, EventArgs e)
        {
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
            cmbPort.SelectedIndex = 0;//默认选择第一个COM1

            if (com.IsOpen)
            {
                com.Close();
            }
                
                com.PortName = cmbPort.SelectedItem.ToString();
            // // com.PortName //= serialName;
            // //  com = new SerialPort("COM1");       //实例化SerialPort并设置COM口

            com.BaudRate = 9600;//波特率
                                //cmbBaudRate.
            com.Parity = Parity.None;//无奇偶校验位
            com.StopBits = StopBits.Two;//两个停止位
            com.Handshake = Handshake.RequestToSend;//控制协议
            com.ReceivedBytesThreshold = 13;//设置 DataReceived 事件发生前内部输入缓冲区中的字节数,我这里是13字节为一组
                                            //// com.Open();                 //打开串口  
            if (!com.IsOpen)
            {
                try
                {
                    com.Open();
                  //  MessageBox.Show(string.Format("打开串口{0}成功！",com.PortName));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}

