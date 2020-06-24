using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace WeightRecord
{
    public partial class MainForm : Form
    {
        public static string connStr = "Data Source=192.168.88.4;Initial Catalog = HSTextileERP;Persist Security Info = True;User ID = zjp;Password =123456 ";
        public MainForm()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sCardNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void sCardNo_MouseLeave(object sender, EventArgs e)
        {


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
                //if (dt.Rows.Count > 0)
                //{
                //    sMaterialNo.Text = dt.Rows[0][1].ToString();
                //    nLength.Text = dt.Rows[0][2].ToString();
                //    sEquipmentNo.Text = dt.Rows[0][3].ToString();
                //    nUnitWeight.Text = dt.Rows[0][4].ToString();
                //    nWeight.Text = dt.Rows[0][5].ToString();
                //}
                //   6200229214   dsgv 
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "查找失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void search_Click_1(object sender, EventArgs e)
        {

            string str = this.sFabricNo.Text.Trim();

            Thread th = new Thread(delegate () { new SearchForm(str).ShowDialog(); });
            th.Start();


        }

        private void sCardNo_TextChanged_1(object sender, EventArgs e)
        {

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
                        nUnitWeight.Text = dt.Rows[0][6].ToString();
                        nWeight.Text = dt.Rows[0][5].ToString();
                    }
                    //  sMaterialNo.Text=
                    //   6200229214   dsgv 
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "查找失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void sFabricNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lable1_Click(object sender, EventArgs e)
        {

        }

        private void save_Click_1(object sender, EventArgs e)
        {
            decimal Weight;
            string @nWeight= this.nWeight.Text;
            if (@nWeight == "")
                @nWeight = "0";
            Weight= Convert.ToDecimal(@nWeight);

            
            string @sLength = this.nLength.Text;
            if (@sLength == "")
            {
                MessageBox.Show("长度不能为空，除0操作！");
                return;
            }
            nUnitWeight.Text = (Weight * 1000 / Convert.ToDecimal(@sLength)).ToString();

            string sql = "UPDATE qmRawInspectHdr SET nUnitWeight=" + Math.Round(Convert.ToDecimal(nUnitWeight.Text),2)+",nWeight=" + Math.Round(Weight, 2)  + " WHERE  sFabricNo='"+ this.sFabricNo.Text.Trim() + "'";
            try
            {
                SqlConnection Sqlconn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(sql, Sqlconn);
                Sqlconn.Open();
                cmd.ExecuteNonQuery();
                Sqlconn.Close();
                MessageBox.Show("保存成功！");
    
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "保存失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void nWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >57) && (e.KeyChar != 8) && (e.KeyChar != 46))
                e.Handled = true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
