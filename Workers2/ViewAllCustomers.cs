using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using WorkersAssignment1;

namespace Workers2
{
    public partial class ViewAllCustomers : Form
    {
        OleDbConnection con = new OleDbConnection(Connection.ConnectionString);
        OleDbCommand cmd = new OleDbCommand(); 
        OleDbDataAdapter da = new OleDbDataAdapter();
        public ViewAllCustomers()
        {
            InitializeComponent();
        }

        private void ViewAllCustomers_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM customers";
            var adapter = new OleDbDataAdapter(query, con);
            OleDbCommandBuilder sql_command = new OleDbCommandBuilder();
            var ds = new DataSet();
            adapter.Fill(ds);
            ViewAllCustomersList.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new DashBoard().Show();
            this.Hide();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO `Customers`('customer ID', 'Name', 'Contact details', 'Service agreement','Payment details') VALUES ('{textBox1.Text}', '{textBox5.Text}', '{textBox4.Text}', '{textBox3.Text}', '{textBox2.Text}')";
            OleDbCommand cmd = new OleDbCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Customer Registered ", "Customer registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}