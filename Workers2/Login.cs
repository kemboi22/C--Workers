using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WorkersAssignment1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"C:\\Users\\KEMBOI ELVIS\\Downloads\\lawn_care.mdb\"");
        OleDbCommand cmd = new OleDbCommand(); 
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (Email.Text == "" && Password.Text == "")
            {
                MessageBox.Show("Email And Password fields are required", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string login = "SELECT * FROM login WHERE email= '"+Email.Text+"' AND password='"+Password.Text+"'";
                cmd = new OleDbCommand(login, con);
                cmd.ExecuteNonQuery();
                con.Close();
                Email.Text = "";
                Password.Text = "";
                MessageBox.Show("Login Succesfull", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new DashBoard().Show();
                this.Hide();

            }
        }

       
    }
}