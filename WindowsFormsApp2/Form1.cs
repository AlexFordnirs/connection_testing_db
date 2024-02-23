using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        private static string Conn = "";
        private static SqlConnection sqlConnection = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
        }
        private void ConnectBtn_click(object sender, EventArgs e)
        {
            if (ServerNameTb.TextLength == 0)
            {
                MessageBox.Show("Connection string can not de empty!");
                return;
            }
            try
            {
                Conn = "Data Source=" + ServerNameTb.Text + ";User ID=Student;Password=;Integrated Security=False;";
                if (sqlConnection.DataSource != ServerNameTb.Text)
                {
                    sqlConnection.ConnectionString = Conn;
                    sqlConnection.Open();
                }
                StatusLabel.Text = "Status: \nConnected";
                DbCb.Enabled = true;
                GetDBs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message.ToString());
                return;
            }
        }

        public void GetDBs()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", sqlConnection))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            DbCb.Items.Add(dr[0].ToString());
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                return;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DbCb.Enabled = false;
            TableCb.Enabled = false;
            ComandTb.Enabled = false;
            ConnectBtn.Enabled = false;
            TestBtn.Enabled = false;
            StatusLabel.Text = "Status: No \nconnection";
        }

        private void DbCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableCb.Enabled = true;
            using (SqlCommand cmd = new SqlCommand("USE " + DbCb.SelectedItem.ToString() + "; SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", sqlConnection))
            {
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        TableCb.Items.Add(dr[0].ToString());
                    }
                }
            }
        }
        private void TableCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComandTb.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (ComandTb.TextLength < 1)
            {
                TestBtn.Enabled = false;
                DoBtn.Enabled = false;
            }
            else
            {
                TestBtn.Enabled = true;
                DoBtn.Enabled = true;
            }
        }

        private void DoBtn_Click(object sender, EventArgs e)
        {
            if (sqlConnection.State.ToString() == "Closed")
            {
                sqlConnection.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("USE " + DbCb.SelectedItem.ToString() + "; " + ComandTb.Text + " [" + TableCb.Text + "];", sqlConnection);
                cmd.ExecuteNonQuery();
                StatusLabel.Text = "Status: \nLast OK";
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                StatusLabel.Text = "Status: \nLast NO";
            }
        }
    }
}
