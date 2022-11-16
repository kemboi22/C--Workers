using System.ComponentModel;
using System.Windows.Forms;

namespace WorkersAssignment1
{
    partial class Inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuppliersLabel = new System.Windows.Forms.Label();
            this.StockLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.InventoryIDLabel = new System.Windows.Forms.Label();
            this.inventoryId = new System.Windows.Forms.TextBox();
            this.Suppliers = new System.Windows.Forms.TextBox();
            this.StockLevels = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.InventoryList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(301, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREATE A NEW INVENTORY";
            // 
            // SuppliersLabel
            // 
            this.SuppliersLabel.Location = new System.Drawing.Point(12, 183);
            this.SuppliersLabel.Name = "SuppliersLabel";
            this.SuppliersLabel.Size = new System.Drawing.Size(151, 39);
            this.SuppliersLabel.TabIndex = 2;
            this.SuppliersLabel.Text = "Suppliers";
            // 
            // StockLabel
            // 
            this.StockLabel.Location = new System.Drawing.Point(12, 144);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(151, 39);
            this.StockLabel.TabIndex = 3;
            this.StockLabel.Text = "Stock Levels";
            // 
            // ProductLabel
            // 
            this.ProductLabel.Location = new System.Drawing.Point(12, 105);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(151, 39);
            this.ProductLabel.TabIndex = 4;
            this.ProductLabel.Text = "Product";
            // 
            // InventoryIDLabel
            // 
            this.InventoryIDLabel.Location = new System.Drawing.Point(12, 66);
            this.InventoryIDLabel.Name = "InventoryIDLabel";
            this.InventoryIDLabel.Size = new System.Drawing.Size(151, 39);
            this.InventoryIDLabel.TabIndex = 5;
            this.InventoryIDLabel.Text = "Inventory ID";
            // 
            // inventoryId
            // 
            this.inventoryId.Location = new System.Drawing.Point(149, 66);
            this.inventoryId.Name = "inventoryId";
            this.inventoryId.Size = new System.Drawing.Size(466, 22);
            this.inventoryId.TabIndex = 6;
            // 
            // Suppliers
            // 
            this.Suppliers.Location = new System.Drawing.Point(149, 186);
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.Size = new System.Drawing.Size(466, 22);
            this.Suppliers.TabIndex = 7;
            // 
            // StockLevels
            // 
            this.StockLevels.Location = new System.Drawing.Point(149, 147);
            this.StockLevels.Name = "StockLevels";
            this.StockLevels.Size = new System.Drawing.Size(466, 22);
            this.StockLevels.TabIndex = 8;
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(149, 108);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(466, 22);
            this.ProductName.TabIndex = 9;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(422, 229);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(114, 39);
            this.BackBtn.TabIndex = 10;
            this.BackBtn.Text = "BACK";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(192, 229);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(114, 39);
            this.CreateBtn.TabIndex = 11;
            this.CreateBtn.Text = "CREATE";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // InventoryList
            // 
            this.InventoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryList.Location = new System.Drawing.Point(13, 310);
            this.InventoryList.Name = "InventoryList";
            this.InventoryList.RowTemplate.Height = 24;
            this.InventoryList.Size = new System.Drawing.Size(776, 251);
            this.InventoryList.TabIndex = 12;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.InventoryList);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.StockLevels);
            this.Controls.Add(this.Suppliers);
            this.Controls.Add(this.inventoryId);
            this.Controls.Add(this.InventoryIDLabel);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.StockLabel);
            this.Controls.Add(this.SuppliersLabel);
            this.Controls.Add(this.label1);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView InventoryList;

        private System.Windows.Forms.TextBox inventoryId;
        private System.Windows.Forms.TextBox Suppliers;
        private System.Windows.Forms.TextBox StockLevels;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button CreateBtn;

        private System.Windows.Forms.Label SuppliersLabel;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label InventoryIDLabel;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}