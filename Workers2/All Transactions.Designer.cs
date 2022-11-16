using System.ComponentModel;

namespace Workers2
{
    partial class All_Transactions
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TransactionId = new System.Windows.Forms.TextBox();
            this.CustomerDetail = new System.Windows.Forms.TextBox();
            this.PaymentDetail = new System.Windows.Forms.TextBox();
            this.ServiceProvider = new System.Windows.Forms.TextBox();
            this.record = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.AllTransactions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AllTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANSACTIONS";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Details";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payment Detail";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Service Provider";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Record";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Transaction ID";
            // 
            // TransactionId
            // 
            this.TransactionId.Location = new System.Drawing.Point(138, 61);
            this.TransactionId.Name = "TransactionId";
            this.TransactionId.Size = new System.Drawing.Size(446, 22);
            this.TransactionId.TabIndex = 6;
            // 
            // CustomerDetail
            // 
            this.CustomerDetail.Location = new System.Drawing.Point(138, 193);
            this.CustomerDetail.Name = "CustomerDetail";
            this.CustomerDetail.Size = new System.Drawing.Size(446, 22);
            this.CustomerDetail.TabIndex = 7;
            // 
            // PaymentDetail
            // 
            this.PaymentDetail.Location = new System.Drawing.Point(138, 160);
            this.PaymentDetail.Name = "PaymentDetail";
            this.PaymentDetail.Size = new System.Drawing.Size(446, 22);
            this.PaymentDetail.TabIndex = 8;
            // 
            // ServiceProvider
            // 
            this.ServiceProvider.Location = new System.Drawing.Point(138, 127);
            this.ServiceProvider.Name = "ServiceProvider";
            this.ServiceProvider.Size = new System.Drawing.Size(446, 22);
            this.ServiceProvider.TabIndex = 9;
            // 
            // record
            // 
            this.record.Location = new System.Drawing.Point(138, 94);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(446, 22);
            this.record.TabIndex = 10;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(362, 233);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(134, 46);
            this.Back.TabIndex = 11;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(177, 233);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(134, 46);
            this.Create.TabIndex = 12;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(316, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 33);
            this.label7.TabIndex = 13;
            this.label7.Text = "ALL TRANSACTIONS";
            // 
            // AllTransactions
            // 
            this.AllTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllTransactions.Location = new System.Drawing.Point(4, 332);
            this.AllTransactions.Name = "AllTransactions";
            this.AllTransactions.RowTemplate.Height = 24;
            this.AllTransactions.Size = new System.Drawing.Size(791, 283);
            this.AllTransactions.TabIndex = 14;
            // 
            // All_Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.AllTransactions);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.record);
            this.Controls.Add(this.ServiceProvider);
            this.Controls.Add(this.PaymentDetail);
            this.Controls.Add(this.CustomerDetail);
            this.Controls.Add(this.TransactionId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "All_Transactions";
            this.Text = "All_Transactions";
            this.Load += new System.EventHandler(this.All_Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TransactionId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CustomerDetail;
        private System.Windows.Forms.TextBox PaymentDetail;
        private System.Windows.Forms.TextBox ServiceProvider;
        private System.Windows.Forms.TextBox record;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.DataGridView AllTransactions;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}