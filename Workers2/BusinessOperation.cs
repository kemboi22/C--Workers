using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using WorkersAssignment1;

namespace Workers2
{
    public partial class BusinessOperation : Form
    {
        OleDbConnection con = new OleDbConnection(Connection.ConnectionString);
        OleDbCommand cmd = new OleDbCommand(); 
        OleDbDataAdapter da = new OleDbDataAdapter();
        public BusinessOperation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new DashBoard().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO `Business operations`('operation ID', 'Quoting', 'Scheduling', 'Service delivery', 'Follow up') VALUES ('{OperationID.Text}', '{Quoting.Text}', '{Scheduling.Text}', '{ServiceDelivery.Text}', '{FollowUp.Text}')";
            OleDbCommand cmd = new OleDbCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Business Operation Registered ", "Business Operation registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BusinessOperation_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM `Business operations`";
            var adapter = new OleDbDataAdapter(query, con);
            var ds = new DataSet();
            adapter.Fill(ds);
            BusinessOperationList.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}