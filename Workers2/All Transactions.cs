using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using WorkersAssignment1;

namespace Workers2
{
    public partial class All_Transactions : Form
    {
        OleDbConnection con = new OleDbConnection(Connection.ConnectionString);
        public All_Transactions()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new DashBoard().Show();
            this.Hide();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO `transactions`('Transaction ID', 'Record', 'Service provided', 'Payment details', 'Customer details') VALUES ('{TransactionId.Text}', '{record.Text}', '{ServiceProvider.Text}', '{PaymentDetail.Text}', '{CustomerDetail.Text}')";
            OleDbCommand cmd = new OleDbCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Transaction Registered ", "Transaction register", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void All_Transactions_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM `transactions`";
            var adapter = new OleDbDataAdapter(query, con);
            var ds = new DataSet();
            adapter.Fill(ds);
            AllTransactions.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}