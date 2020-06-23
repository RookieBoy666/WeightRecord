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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
           
        }
        public SearchForm(string str)
        {
            InitializeComponent();
                this.sFabricNo.Text = str;
            if (string.IsNullOrEmpty(str))
            {
            }
            else
            {
                search.PerformClick();
            }
     
        }

      

    private void search_Click(object sender, EventArgs e)
        {
            string sql = "SELECT  top 100  a.sCardNo,a.sFabricNo,a.sMaterialNo,a. nLength,sEquipmentNo,a.nUnitWeight,a.nWeight FROM qmRawInspectHdr A  order by tcreatetime desc ";

            try
            { 
                string @sFabricNo = (this.sFabricNo.Text).Trim();
                if (!string.IsNullOrEmpty(@sFabricNo))
                {
                      sql = "SELECT     a.sCardNo,a.sFabricNo,a.sMaterialNo,a. nLength,sEquipmentNo,a.nUnitWeight,a.nWeight FROM qmRawInspectHdr A   where a.sFabricNo='" + @sFabricNo + "'";
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

        private void clear_Click(object sender, EventArgs e)
        {
            sFabricNo.Text = "";
        }
    }
}
 
