using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using WorkersAssignment1;

namespace Workers2
{
    public partial class Equipments : Form
    {
        OleDbConnection con = new OleDbConnection(Connection.ConnectionString);

        public Equipments()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new DashBoard().Show();
            this.Hide();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO `Equipment`('Equipment ID', 'Type', 'Model', 'Serial number', 'Maintanance records') VALUES ('{EquipmentID.Text}', '{type.Text}', '{Model.Text}', '{SerialNumber.Text}', '{Maitanance.Text}')";
            OleDbCommand cmd = new OleDbCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Business Operation Registered ", "Business Operation registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Equipments_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM `Equipment`";
            var adapter = new OleDbDataAdapter(query, con);
            var ds = new DataSet();
            adapter.Fill(ds);
            AllEquipments.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}