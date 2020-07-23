using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace WeightRecord
{
    public partial class MainForm : Form
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        private SerialPort com;
        private int isStable = 0;
        public static string connStr = ConfigHelper.GetConnectSql("SQL.xml");

        // public static string connStr = "Data Source=192.168.88.4;Initial Catalog = HSTextileERP;Persist Security Info = True;User ID = zjp;Password =123456 ;Connect Timeout=8;";
        string setInterval = ConfigurationSettings.AppSettings["setInterval"];
        string setCOM = ConfigurationSettings.AppSettings["chooseCOM"];
        string sentStr = ConfigurationSettings.AppSettings["senStr"];
        string info = ConfigurationSettings.AppSettings["info"];
        // string tubeweight = ConfigurationSettings.AppSettings["TubeWeight"];
        decimal tubeWeight = 0;
        string tubeType = "";

        string tubetype = ConfigurationSettings.AppSettings["TubeType"];
        string tubeweight = ConfigurationSettings.AppSettings["TubeWeight"];
        List<string> ids = new List<string>();//管重列表
        List<string> idCode = new List<string>();//管型列表
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            #region
            Tube1.Text = tubetype;
            Tube2.Text = tubeweight;
            if (tubeweight == "")
            {
                Tube2.Text = "0";
            }



            string sql = "select sValueName,sTypeCode, sValueCode  , sRemark from dbo.pbDataDictionary where sTypeCode = 'TubeWeight'  and bUsable = 1 order by iOrderNo";

            SqlConnection Sqlconn = new SqlConnection(MainForm.connStr);
            SqlCommand cmd = new SqlCommand(sql, Sqlconn);
            try
            {
                Sqlconn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, Sqlconn);
                // da.Fill(ds);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                idCode = GetColumnValues<string>(dataTable, "sValueCode");

                ids = GetColumnValues<string>(dataTable, "sValueName");
                //   List<string> idRemark = GetColumnValues<string>(dataTable, "sRemark");
                for (int i = 0; i < idCode.Count; i++)
                {
                    Tube1.Items.Add(idCode[i]);// +" "+ids[i]);
                                               // Tube2.Items.Add(ids[i]);
                                               //Tube3.Text=
                }
                Sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Sqlconn.Close();
                Sqlconn.Dispose();
            }

            if (!string.IsNullOrEmpty(tubeweight))
            {
                tubeType = Tube1.Text.ToString();
                tubeWeight = Convert.ToDecimal(Tube2.Text.ToString());
            }
            #endregion



            label9.Text = info;
            asc.controllInitializeSize(this);
            label8.Hide();
            com = new SerialPort();
            string[] str = SerialPort.GetPortNames();
            if (str.Length == 0)
            {
                MessageBox.Show("本机没有串口或者串口连接失败,磅秤重量读取将会失败！", "警告");
                return;
            }
            string[] portNmaes;
            ArrayList arrayList = new ArrayList();
            // List<string> portNmaes = new List<string>();
            //添加串口项目
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {//获取有多少个COM口
                arrayList.Add(s);
            }
            for (int i = 0; i < arrayList.Count; i++)
            {
                ConfigHelper.SetValue("getAllCOM", "本机的所有可用端口为：" + arrayList[i].ToString() + " ");
            }
            ConfigHelper.SetValue("AllCOMCount", "此设备共有" + arrayList.Count.ToString() + "个COM端口");

            if (arrayList.Count == 1)
            {
                setCOM = arrayList[0].ToString();  //有1个串口 默认取这个
            }
            else
            {
                //大于1个串口 ，就取配置文件中串口
            }
            // cmbPort.SelectedIndex = 0;//默认选择第一个COM 
            try
            {
                serialPort1.PortName = setCOM;//str[0];}
            }
            catch (Exception ex)
            {
                label8.Show();
                label8.Text = "串口配置失败！";
            }
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
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "保存失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void search_Click_1(object sender, EventArgs e)
        {
            //string str = this.sFabricNo.Text.Trim();
            //Thread th = new Thread(delegate () { new SearchForm(str).ShowDialog(); });
            //th.Start();
            if (string.IsNullOrEmpty(this.sFabricNo.Text.Trim()))
            {
                CalcLength.Text = "";
                nLength.Text = "";
                sCardNo.Text = "";
                sRawGMWT.Text = "";
                sMaterialNo.Text = "";
                sEquipmentNo.Text = "";
            }
            string sql = "SELECT  top 100 a.sFabricNo, a.sCardNo,a.sMaterialNo,a. nLength,b.sModel,sEquipmentNo,b.sRawGMWT,a.nWeight,A.Tupdatetime FROM qmRawInspectHdr A join mmMaterial b on a.sMaterialNo=b.sMaterialNo and b.bUsable=1   where nWeight is not null   order by a.tupdateTime desc ";
            try
            {
                string @sFabricNo = (this.sFabricNo.Text).Trim();
                if (!string.IsNullOrEmpty(@sFabricNo))
                {
                    sql = "SELECT    a.sFabricNo, a.sCardNo,a.sMaterialNo,a.nLength,b.sModel,sEquipmentNo,b.sRawGMWT,a.nWeight,A.Tupdatetime FROM qmRawInspectHdr A join mmMaterial b on a.sMaterialNo=b.sMaterialNo and b.bUsable=1   where a.sFabricNo='" + @sFabricNo + "'";
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
                dataGridView1.Columns[3].HeaderText = "折算长度";
                dataGridView1.Columns[4].HeaderText = "长度";
                dataGridView1.Columns[5].HeaderText = "设备号";
                dataGridView1.Columns[6].HeaderText = "克重";
                dataGridView1.Columns[7].HeaderText = "重量";
                dataGridView1.Columns[8].HeaderText = "更新时间";
                //   dataGridView1.Columns[9].HeaderText = "更新时间";
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
                string sql = "SELECT    a.sFabricNo,a.sCardNo,a.sMaterialNo,a.nLength,b.sModel,sEquipmentNo,b.sRawGMWT,a.nWeight,A.TUPDATETIME FROM qmRawInspectHdr A JOIN dbo.mmMaterial b ON a.sMaterialNo=b.sMaterialNo AND b.bUsable=1 WHERE   " + "  a.sFabricNo='" + @sFabricNo + "'";
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
                    dataGridView1.DataSource = ds.Tables[0];

                    dataGridView1.Columns[0].HeaderText = "布卷号";
                    dataGridView1.Columns[1].HeaderText = "卡号";
                    dataGridView1.Columns[2].HeaderText = "款号";
                    dataGridView1.Columns[3].HeaderText = "折算长度";
                    dataGridView1.Columns[4].HeaderText = "原长度";
                    dataGridView1.Columns[5].HeaderText = "设备号";
                    dataGridView1.Columns[6].HeaderText = "克重";
                    dataGridView1.Columns[7].HeaderText = "重量";
                    dataGridView1.Columns[8].HeaderText = "更新时间";
                    Sqlconn.Close();
                    if (dt.Rows.Count > 0)
                    {
                        sCardNo.Text = dt.Rows[0][1].ToString();
                        sMaterialNo.Text = dt.Rows[0][2].ToString();
                        nLength.Text = dt.Rows[0][3].ToString();
                        sEquipmentNo.Text = dt.Rows[0][5].ToString();
                        sRawGMWT.Text = string.IsNullOrEmpty(dt.Rows[0][6].ToString()) ? "0.00" : dt.Rows[0][6].ToString();
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
            if (Convert.ToDecimal(this.CalcLength.Text.Replace("m", "")) < 0)
            {
                MessageBox.Show("折算长度小于0！请检查管重是否正确！", "保存失败");
                return;
            }
            if (Convert.ToDecimal(this.CalcLength.Text.Replace("m", "")) == 0)
            {
                MessageBox.Show("折算长度等于0！", "保存失败");
                return;
            }
            if (isStable != 1)
            {
                MessageBox.Show("当前称重量不稳定，保存失败！", "警告");
                return;
            }
            decimal Weight;
            string @nWeight = this.netWeight.Text.Replace("kg", "");
            if (@nWeight == "")
                @nWeight = "0";
            Weight = Convert.ToDecimal(@nWeight);
            string sql = "UPDATE qmRawInspectHdr SET" + " nWeight=" + Math.Round(Weight, 2) + " WHERE  sFabricNo='" + this.sFabricNo.Text.Trim() + "'";


            //吧qmRawInspectHdr表中长度更新为折算长度
            string sqlLength = "update qmRawInspectHdr SET nLength=" + CalcLength.Text.Replace("m", "") + ",tupdatetime='" + System.DateTime.Now.ToString() + "'" + " where sFabricNo='" + this.sFabricNo.Text.Trim() + "'";

            //搜寻mmMaterial表中 sModel字段  ，此字段保存最初qmRawInspectHdr的长度（第一次）
            string getsModel = "select sModel from mmMaterial a where sMaterialNo='" + sMaterialNo.Text.ToString() + "'";
            string sqlsModel = "update mmMaterial set sModel='" + nLength.Text.ToString() + "' where sMaterialNo='" + sMaterialNo.Text.ToString() + "'";
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
                string sModel = ds.Tables[0].Rows[0][0].ToString();
                if (string.IsNullOrEmpty(sModel))
                {
                    SqlCommand cmdsModel = new SqlCommand(sqlsModel, Sqlconn);
                    cmdsModel.ExecuteNonQuery();//如果sModel为空，更新mmMaterial表中的sModel为qmRawInspectHdr表最初的长度（第一次）
                }

                SqlCommand cmdsqlLength = new SqlCommand(sqlLength, Sqlconn);
                cmdsqlLength.ExecuteNonQuery();//qmRawInspectHdr表中长度更新为折算长度
                Sqlconn.Close();
                MessageBox.Show("保存成功！");
                Log.RegisterLog(string.Format("布卷号{0}的重量是{1},折算长度是{2}", this.sFabricNo.Text.Trim(), Math.Round(Weight, 2), CalcLength.Text.Replace("m", "")), DateTime.Now.ToString());
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
                            if (Tube2.Text == "")
                            {
                                Tube2.Text = "0";
                            }
                            netWeight.Text = (Convert.ToDecimal(nWeight.Text) - Convert.ToDecimal(Tube2.Text)).ToString();

                            if (sRawGMWT.Text != "" && Convert.ToDecimal(sRawGMWT.Text) > 0)
                            {
                                Decimal @nWeight = Convert.ToDecimal(this.nWeight.Text.Replace("kg", ""));

                                Decimal @sRawGMWT = Convert.ToDecimal(this.sRawGMWT.Text);
                                Decimal @sFinalWeight = Convert.ToDecimal(netWeight.Text);//净重
                                CalcLength.Text = Math.Round(((@sFinalWeight) * 1000 / @sRawGMWT), 2).ToString() + " m";//此处要减去管(塑料或者纸管)重
                            }
                        }
                        if (m != -1)
                        {
                            //pictureBox1.Show();
                            isStable = 1;
                            string picPath = Application.StartupPath.Replace("bin\\Debug", "pic") + "\\1.ico";

                            //使用ResourceManager类（资源管理器），aa为Resources中的名称
                            //ResourceManager resman = new ResourceManager("WeightRecord.Properties.Resources",);
                            //this.BackgroundImage = (Bitmap)resman.GetObject("aa");
                            ////或者直接这样写，name为资源中已有的名称
                            //this.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("1.ico");


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
            timer1.Interval = int.Parse(setInterval);//int.Parse(intervalValue.Value.ToString());
            if (!(serialPort1.IsOpen))
            {
                try
                {
                    serialPort1.Open();
                }
                catch (Exception ex)
                {
                    label8.Show();
                    label8.Text = "打开串口失败，请配置config文件中的串口！";
                    label8.ForeColor = Color.Red;
                    // MessageBox.Show("打开串口失败，请检查config文件！"); }
                }
            }
            try
            {
                serialPort1.Write(sentStr);
            }
            catch (Exception ex)
            {
                label8.Show();
                label8.Text = "发送失败，请检查config文件！";
                //MessageBox.Show("发送失败");
            }
        }
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }


        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setting setting = new setting();
            setting.Show();
            //Thread th = new Thread(delegate () { new setting().ShowDialog(); });
            //th.Start();
            //this.Dispose();

        }


        public static List<T> GetColumnValues<T>(DataTable dtSource, string filedName)
        {
            return (from r in dtSource.AsEnumerable() select r.Field<T>(filedName)).ToList<T>();
        }

        private void Tube1_SelectedIndexChanged(object sender, EventArgs e)
        {

            tubeType = Tube1.SelectedItem.ToString();//tubeWeight=ConfigHelper.GetNumber(TubeWeight1.SelectedItem.ToString());
            Tube2.Text = ids[Tube1.SelectedIndex];
            try
            {
                //将选择的管型重量保存到配置文件里面
                ConfigHelper.SetValue("TubeType", Tube1.Text.ToString());
                ConfigHelper.SetValue("TubeWeight", Tube2.Text.ToString());
                //  MessageBox.Show("保存成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "保存管型失败");
            }
        }

        private void sFabricNo_TextChanged(object sender, EventArgs e)
        {
            if (this.sFabricNo.Text.Length >=10)
            {
                this.sFabricNo.TextChanged += new System.EventHandler(textBox1_MouseLeave);
            }
            else
            {
                return;
            }
        }

        private void clear_Click_1(object sender, EventArgs e)
        {
            CalcLength.Text = "";
            nLength.Text = "";
            sCardNo.Text = "";
            sRawGMWT.Text = "";
            sMaterialNo.Text = "";
            sEquipmentNo.Text = "";
            this.sFabricNo.Text = "";
        }
    }
}

