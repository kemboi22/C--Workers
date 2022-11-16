using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using WorkersAssignment1;

namespace Workers2
{
    public partial class LegalArrangements : Form
    {
        OleDbConnection con = new OleDbConnection(Connection.ConnectionString);
        OleDbCommand cmd = new OleDbCommand(); 
        OleDbDataAdapter da = new OleDbDataAdapter();
        public LegalArrangements()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new DashBoard().Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string Insert = $"INSERT INTO `Legal arrangements`(`ID`,`arrangements ID`,`Terms and conditions`,`Liability insurance`) VALUES (`12`,`{textBox1.Text}`, `{textBox3.Text}`, `{textBox2.Text}`)";
            var cmd = new OleDbCommand(Insert, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Legal Aggrement Successfully Added", "Legal Aggrement Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       

        private void LegalArrangements_Load_1(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM `Legal arrangements`";
            var adapter = new OleDbDataAdapter(query, con);
            var dataset = new DataSet();
            adapter.Fill(dataset);
            AllLegalArrangements.DataSource = dataset.Tables[0];
            con.Close();
        }
    }
}