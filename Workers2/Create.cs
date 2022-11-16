using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WorkersAssignment1
{
    public partial class Create : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"C:\\Users\\KEMBOI ELVIS\\Downloads\\lawn_care.mdb\"");
        OleDbCommand cmd = new OleDbCommand(); 
        OleDbDataAdapter da = new OleDbDataAdapter();
        public Create()
        {
            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM staff";
            var adapter = new OleDbDataAdapter(query, con);
            OleDbCommandBuilder sql_command = new OleDbCommandBuilder();
            var ds = new DataSet();
            adapter.Fill(ds);
            AllStaffList.DataSource = ds.Tables[0];
            con.Close();
        }        

        private void BackBtn_Click_1(object sender, EventArgs e)
        {
            new DashBoard().Show();
            this.Hide();
        }

        private void CreateStaffBtn_Click(object sender, EventArgs e)
        {
            string col = "('Staff ID', 'Staff name', 'Contact', 'Qualification', 'Employment')";
            string val = " values(300, '" + textBox1.Text  + "', '" + textBox4.Text + "', '" + textBox3.Text + "', '";
            val +=  textBox2.Text + "' )";
            OleDbCommand cmd = new OleDbCommand("Insert into staff" + col + val, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Staff Registered ", "Staff register", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}