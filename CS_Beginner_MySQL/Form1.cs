using MySql.Data.MySqlClient;
using System.Data;

namespace CS_Beginner_MySQL
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlconn = new MySqlConnection();
        MySqlCommand sqlcmd = new MySqlCommand();
        DataTable dt = new DataTable();
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

        }
    }
}