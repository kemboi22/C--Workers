using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using WorkersAssignment1;

namespace Workers2
{
    public partial class Marketing : Form
    {
        OleDbConnection con = new OleDbConnection(Connection.ConnectionString);
        
        public Marketing()
        {
            InitializeComponent();
        }


        private void BackBtn_Click(object sender, EventArgs e)
        {
            new DashBoard().Show();
            this.Hide();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO `marketing`('Marketing ID', 'Compaigns', 'Leads', 'Customers', 'Inquiries') VALUES ('{textBox1.Text}', '{textBox7.Text}', '{textBox6.Text}', '{textBox5.Text}', '{textBox4.Text}')";
            OleDbCommand cmd = new OleDbCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Business Operation Registered ", "Business Operation registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void Marketing_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM `marketing`";
            var adapter = new OleDbDataAdapter(query, con);
            var ds = new DataSet();
            adapter.Fill(ds);
            MarketingList.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}