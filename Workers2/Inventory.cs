using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WorkersAssignment1
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"C:\\Users\\KEMBOI ELVIS\\Downloads\\lawn_care.mdb\"");
        OleDbCommand cmd = new OleDbCommand(); 
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string productCreate = $"INSERT INTO Inventory('Inventory Id', 'Products', 'Stock levels', 'Suppliers') VALUES ('"+inventoryId.Text+"', '"+ProductName.Text+"', '"+StockLevels.Text+"', '"+Suppliers.Text+"')";
            cmd = new OleDbCommand(productCreate, con);
            cmd.ExecuteNonQuery();
            con.Close();
            inventoryId.Text = "";
            ProductName.Text = "";
            StockLevels.Text = "";
            Suppliers.Text = "";
            MessageBox.Show("Inventory Created SuccessFully", "Inventory Created SuccessFully", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new DashBoard().Show();
            this.Hide();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Inventory";
            var adapter = new OleDbDataAdapter(query, con);
            OleDbCommandBuilder sql_command = new OleDbCommandBuilder();
            var ds = new DataSet();
            adapter.Fill(ds);
            InventoryList.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
