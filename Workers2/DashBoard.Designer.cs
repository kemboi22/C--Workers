using System.ComponentModel;

namespace WorkersAssignment1
{
    partial class DashBoard
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
            this.DashboardLabel = new System.Windows.Forms.Label();
            this.AllCustomersBtn = new System.Windows.Forms.Button();
            this.MarketingBtn = new System.Windows.Forms.Button();
            this.AllTransactionsBtn = new System.Windows.Forms.Button();
            this.StaffBtn = new System.Windows.Forms.Button();
            this.BussinessOperationsBtn = new System.Windows.Forms.Button();
            this.LegalArrangementsBtn = new System.Windows.Forms.Button();
            this.Inventory = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.Scheduling = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DashboardLabel
            // 
            this.DashboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardLabel.Location = new System.Drawing.Point(308, 9);
            this.DashboardLabel.Name = "DashboardLabel";
            this.DashboardLabel.Size = new System.Drawing.Size(167, 36);
            this.DashboardLabel.TabIndex = 0;
            this.DashboardLabel.Text = "DASHBOARD";
            // 
            // AllCustomersBtn
            // 
            this.AllCustomersBtn.Location = new System.Drawing.Point(12, 89);
            this.AllCustomersBtn.Name = "AllCustomersBtn";
            this.AllCustomersBtn.Size = new System.Drawing.Size(155, 30);
            this.AllCustomersBtn.TabIndex = 1;
            this.AllCustomersBtn.Text = "View All Customers";
            this.AllCustomersBtn.UseVisualStyleBackColor = true;
            this.AllCustomersBtn.Click += new System.EventHandler(this.AllCustomersBtn_Click);
            // 
            // MarketingBtn
            // 
            this.MarketingBtn.Location = new System.Drawing.Point(308, 232);
            this.MarketingBtn.Name = "MarketingBtn";
            this.MarketingBtn.Size = new System.Drawing.Size(155, 30);
            this.MarketingBtn.TabIndex = 2;
            this.MarketingBtn.Text = "Marketing";
            this.MarketingBtn.UseVisualStyleBackColor = true;
            this.MarketingBtn.Click += new System.EventHandler(this.MarketingBtn_Click_1);
            // 
            // AllTransactionsBtn
            // 
            this.AllTransactionsBtn.Location = new System.Drawing.Point(12, 232);
            this.AllTransactionsBtn.Name = "AllTransactionsBtn";
            this.AllTransactionsBtn.Size = new System.Drawing.Size(155, 30);
            this.AllTransactionsBtn.TabIndex = 3;
            this.AllTransactionsBtn.Text = "All Transactions";
            this.AllTransactionsBtn.UseVisualStyleBackColor = true;
            this.AllTransactionsBtn.Click += new System.EventHandler(this.AllTransactionsBtn_Click_1);
            // 
            // StaffBtn
            // 
            this.StaffBtn.Location = new System.Drawing.Point(12, 160);
            this.StaffBtn.Name = "StaffBtn";
            this.StaffBtn.Size = new System.Drawing.Size(155, 30);
            this.StaffBtn.TabIndex = 4;
            this.StaffBtn.Text = "View All Staff";
            this.StaffBtn.UseVisualStyleBackColor = true;
            this.StaffBtn.Click += new System.EventHandler(this.StaffBtn_Click);
            // 
            // BussinessOperationsBtn
            // 
            this.BussinessOperationsBtn.Location = new System.Drawing.Point(308, 160);
            this.BussinessOperationsBtn.Name = "BussinessOperationsBtn";
            this.BussinessOperationsBtn.Size = new System.Drawing.Size(155, 30);
            this.BussinessOperationsBtn.TabIndex = 5;
            this.BussinessOperationsBtn.Text = "Bussiness Operations";
            this.BussinessOperationsBtn.UseVisualStyleBackColor = true;
            this.BussinessOperationsBtn.Click += new System.EventHandler(this.BussinessOperationsBtn_Click_1);
            // 
            // LegalArrangementsBtn
            // 
            this.LegalArrangementsBtn.Location = new System.Drawing.Point(308, 89);
            this.LegalArrangementsBtn.Name = "LegalArrangementsBtn";
            this.LegalArrangementsBtn.Size = new System.Drawing.Size(155, 30);
            this.LegalArrangementsBtn.TabIndex = 6;
            this.LegalArrangementsBtn.Text = "Legal Arrangements";
            this.LegalArrangementsBtn.UseVisualStyleBackColor = true;
            this.LegalArrangementsBtn.Click += new System.EventHandler(this.LegalArrangementsBtn_Click_1);
            // 
            // Inventory
            // 
            this.Inventory.Location = new System.Drawing.Point(600, 90);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(136, 28);
            this.Inventory.TabIndex = 7;
            this.Inventory.Text = "Inventory";
            this.Inventory.UseVisualStyleBackColor = true;
            this.Inventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Red;
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Quit.Location = new System.Drawing.Point(326, 329);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(158, 61);
            this.Quit.TabIndex = 8;
            this.Quit.Text = "Quit  Application";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Scheduling
            // 
            this.Scheduling.Location = new System.Drawing.Point(600, 165);
            this.Scheduling.Name = "Scheduling";
            this.Scheduling.Size = new System.Drawing.Size(136, 25);
            this.Scheduling.TabIndex = 9;
            this.Scheduling.Text = "Scheduling";
            this.Scheduling.UseVisualStyleBackColor = true;
            this.Scheduling.Click += new System.EventHandler(this.Scheduling_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Equipments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Scheduling);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.LegalArrangementsBtn);
            this.Controls.Add(this.BussinessOperationsBtn);
            this.Controls.Add(this.StaffBtn);
            this.Controls.Add(this.AllTransactionsBtn);
            this.Controls.Add(this.MarketingBtn);
            this.Controls.Add(this.AllCustomersBtn);
            this.Controls.Add(this.DashboardLabel);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button Scheduling;

        private System.Windows.Forms.Button Quit;

        private System.Windows.Forms.Button Inventory;

        private System.Windows.Forms.DataGridView result;

        private System.Windows.Forms.Button BussinessOperationsBtn;
        private System.Windows.Forms.Button LegalArrangementsBtn;

        private System.Windows.Forms.Button AllCustomersBtn;
        private System.Windows.Forms.Button MarketingBtn;
        private System.Windows.Forms.Button AllTransactionsBtn;
        private System.Windows.Forms.Button StaffBtn;

        private System.Windows.Forms.Label DashboardLabel;

        #endregion
    }
}