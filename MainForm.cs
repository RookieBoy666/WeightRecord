using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WeightRecord
{
    public partial class MainForm : Form
    {
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
            string connStr = "Data Source=192.168.88.6;Initial Catalog = HSTextileERP;Persist Security Info = True;User ID = zjp;Password =123456 ";
            if (!string.IsNullOrEmpty(sCardNo.Text))
            {
                string @sCardNo = this.sCardNo.Text;
                string sql = "SELECT top 1  a.sCardNo,a.sMaterialNo,a. nLength,a.nUnitWeight FROM qmRawInspectHdr A WHERE DATEDIFF(MONTH, tCreateTime, GETDATE()) <= 3 and a.sCardNo='"+sCardNo+"'";
                try
                {
                    SqlConnection Sqlconn = new SqlConnection(connStr);
                    SqlCommand cmd = new SqlCommand(sql, Sqlconn);
                    Sqlconn.Open();
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(sql, Sqlconn);
                    da.Fill(ds);
                   dataGridView1.DataSource = ds.Tables[0];
                    Sqlconn.Close();
                    if (dataGridView1.Rows.Count != 0)
                    {
                        sMaterialNo.Text = dataGridView1[1, 0].Value.ToString();
                        nLength.Text= dataGridView1[2, 0].Value.ToString();
                        sEquipmentNo.Text= dataGridView1[3, 0].Value.ToString();
                    }
                        //  sMaterialNo.Text=
                       
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "查找失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
