using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using Workers2;

namespace WorkersAssignment1
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        OleDbConnection con =
            new OleDbConnection(Connection.ConnectionString);
              


        private void AllCustomersBtn_Click(object sender, EventArgs e)
        {
            new ViewAllCustomers().Show();
            this.Hide();
        }                 


        private void Inventory_Click(object sender, EventArgs e)
        {
            new Inventory().Show();
            this.Hide();
        }

        private void StaffBtn_Click(object sender, EventArgs e)
        {
            new Create().Show();
            this.Hide();
        }

        private void LegalArrangementsBtn_Click_1(object sender, EventArgs e)
        {
            new LegalArrangements().Show();
            this.Hide();
        }

        private void BussinessOperationsBtn_Click_1(object sender, EventArgs e)
        {
            new BusinessOperation().Show();
            this.Hide();
        }

        private void MarketingBtn_Click_1(object sender, EventArgs e)
        {
            new Marketing().Show();
            this.Hide();
        }

        private void AllTransactionsBtn_Click_1(object sender, EventArgs e)
        {
            new All_Transactions().Show();
            this.Hide();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Equipments().Show();
            this.Hide();
        }

        private void Scheduling_Click(object sender, EventArgs e)
        {
            new Scheduling().Show();
            this.Hide();
        }
    }
}