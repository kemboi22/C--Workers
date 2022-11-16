using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using WorkersAssignment1;

namespace Workers2
{
    public partial class Scheduling : Form
    {
        OleDbConnection con = new OleDbConnection(Connection.ConnectionString);
        public Scheduling()
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
            string query = $"INSERT INTO `Scheduling`('Scheduling ID', 'Employee schedule', 'Equipment schedule', 'Service scedule') VALUES ('{ScheduleId.Text}', '{Employee.Text}', '{Equipment.Text}', '{Service.Text}')";
            OleDbCommand cmd = new OleDbCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Scheduling Registered ", "Scheduling registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void Scheduling_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM `Scheduling`";
            var adapter = new OleDbDataAdapter(query, con);
            var ds = new DataSet();
            adapter.Fill(ds);
            AllSchedules.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}