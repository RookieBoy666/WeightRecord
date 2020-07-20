using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace WeightRecord
{
    public partial class setting : Form
    {

        public setting()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 获取DataTable某一列的所有值
        /// </summary>
        /// <typeparam name="T">列数据类型</typeparam>
        /// <param name="dtSource">数据表</param>
        /// <param name="filedName">列名</param>
        /// <returns></returns>
        public static List<T> GetColumnValues<T>(DataTable dtSource, string filedName)
        {
            return (from r in dtSource.AsEnumerable() select r.Field<T>(filedName)).ToList<T>();
        }
        private void setting_Load(object sender, EventArgs e)
        {
            string tubeweight = ConfigurationSettings.AppSettings["TubeWeight"];
            if (string.IsNullOrEmpty(tubeweight))
            {
                TubeWeight.Text = "0";
            }
            else
            {
                TubeWeight.Text = tubeweight;
            }

            string sql = "select sValueName,sTypeCode, sValueCode  , sRemark from dbo.pbDataDictionary where sTypeCode = 'TubeWeight'";

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

                List<string> ids = GetColumnValues<string>(dataTable, "sValueName");

                foreach (var a in ids)
                {
                    TubeWeight.Items.Add(a);
                }

                //ArrayList al = new ArrayList();
                //foreach (var col in dataTable.Rows[0].ToString())
                //{
                //    al.Add(col.ToString());
                //}
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
        }

        private void TubeWeight_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConfigHelper.SetValue("TubeWeight", TubeWeight.Text.ToString());
                MessageBox.Show(string.Format("保存成功！管型为{0},重启程序后生效！", TubeWeight.Text.ToString()));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
