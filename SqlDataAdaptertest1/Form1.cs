using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlDataAdaptertest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string cnstr = "server  = .;database = FYJ;uid = sa;pwd = 8sfxa2eengp-pc";
            string sql = "select * from drug";
            using (SqlDataAdapter sqlData = new SqlDataAdapter(sql,cnstr))
            {
                sqlData.Fill(dt);
            }
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            DataTable dt = new DataTable();
            string cnstr = "server  = .;database = FYJ;uid = sa;pwd = 8sfxa2eengp-pc";
            //string sql = "select * from drug where drugabbre like '%"+textBox1.Text+"%'";
            string sql = "select * from drug where drugabbre like '%"+textBox1.Text+"'";
            //SqlParameter[] parameter = new SqlParameter[] {
            //    new SqlParameter("@abbre",SqlDbType.NVarChar,20){ Value = textBox1.Text}
            //};
            using (SqlDataAdapter sqlData = new SqlDataAdapter(sql, cnstr))
            {
                //sqlData.SelectCommand.Parameters.AddWithValue("@abbre",textBox1.Text);
                sqlData.Fill(dt);
            }
            dataGridView1.DataSource = dt;
        }
    }
}
