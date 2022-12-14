using MySql.Data.MySqlClient;
using System.Data;

namespace CS_Beginner_MySQL
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlconn = new MySqlConnection();
        MySqlCommand sqlcmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        String sqlQuery;
        MySqlDataAdapter Dta = new MySqlDataAdapter();
        MySqlDataReader sqlRd;
        
        DataSet DS = new DataSet();

        string server = "localhost";
        string username = "root";
        string password = "DREADhead2638!";
        string database = "membership";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uploadData();
        }

        private void uploadData()
        {
            sqlconn.ConnectionString = "server=" + server + ";"
                + "username = " + username + ";"
                + "password = " + password + ";"
                + "database = " + database;

            sqlconn.Open();
            sqlcmd.Connection = sqlconn;
            sqlcmd.CommandText = "select * from membership";
            sqlRd = sqlcmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlconn.Close();
            dataGridView1.DataSource = sqlDt;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;

                iExit = MessageBox.Show("Do you want to exit?", "MySql Connector", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in panel2.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();
                    }
                }
                searchTb.Clear();
                genderCb.Text = "";
                memberTypeCb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlconn.ConnectionString = "server=" + server + ";"
                + "username = " + username + ";"
                + "password = " + password + ";"
                + "database = " + database;

                sqlconn.Open();

                sqlQuery = "insert into membership(memid,firstname,lastname,address,postcode,gender,moblie,email,mtype)" +
                    "values('" + memberIdTb.Text + "', '" + firstNameTb.Text + "', '" + lastNameTb.Text + "', '" + addressTb.Text + "', '" 
                   + genderCb.Text + "', '" + moblieTb.Text + "', '" + postCodeTb.Text + "', '" + emailTb.Text + "', '" + memberTypeCb.Text + "')";

                sqlcmd = new MySqlCommand(sqlQuery, sqlconn);
                sqlRd = sqlcmd.ExecuteReader();
                sqlconn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlconn.Close();
            }
            uploadData();
        }
    }
}