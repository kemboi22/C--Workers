using System.ComponentModel;

namespace Workers2
{
    partial class BusinessOperation
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
            this.OperationID = new System.Windows.Forms.TextBox();
            this.FollowUp = new System.Windows.Forms.TextBox();
            this.ServiceDelivery = new System.Windows.Forms.TextBox();
            this.Scheduling = new System.Windows.Forms.TextBox();
            this.Quoting = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BusinessOperationList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BusinessOperationList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(306, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSINESS OPERATIONS";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Follow Up";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Service Delivery";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Scheduling";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quoting";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "Operation ID";
            // 
            // OperationID
            // 
            this.OperationID.Location = new System.Drawing.Point(146, 54);
            this.OperationID.Name = "OperationID";
            this.OperationID.Size = new System.Drawing.Size(457, 22);
            this.OperationID.TabIndex = 6;
            // 
            // FollowUp
            // 
            this.FollowUp.Location = new System.Drawing.Point(146, 191);
            this.FollowUp.Name = "FollowUp";
            this.FollowUp.Size = new System.Drawing.Size(457, 22);
            this.FollowUp.TabIndex = 8;
            // 
            // ServiceDelivery
            // 
            this.ServiceDelivery.Location = new System.Drawing.Point(146, 156);
            this.ServiceDelivery.Name = "ServiceDelivery";
            this.ServiceDelivery.Size = new System.Drawing.Size(457, 22);
            this.ServiceDelivery.TabIndex = 9;
            // 
            // Scheduling
            // 
            this.Scheduling.Location = new System.Drawing.Point(146, 121);
            this.Scheduling.Name = "Scheduling";
            this.Scheduling.Size = new System.Drawing.Size(457, 22);
            this.Scheduling.TabIndex = 10;
            // 
            // Quoting
            // 
            this.Quoting.Location = new System.Drawing.Point(146, 86);
            this.Quoting.Name = "Quoting";
            this.Quoting.Size = new System.Drawing.Size(457, 22);
            this.Quoting.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 40);
            this.button2.TabIndex = 13;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(256, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 35);
            this.label7.TabIndex = 14;
            this.label7.Text = "BUSINESS OPERATIONS LIST";
            // 
            // BusinessOperationList
            // 
            this.BusinessOperationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BusinessOperationList.Location = new System.Drawing.Point(8, 316);
            this.BusinessOperationList.Name = "BusinessOperationList";
            this.BusinessOperationList.RowTemplate.Height = 24;
            this.BusinessOperationList.Size = new System.Drawing.Size(785, 332);
            this.BusinessOperationList.TabIndex = 15;
            // 
            // BusinessOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 658);
            this.Controls.Add(this.BusinessOperationList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Quoting);
            this.Controls.Add(this.Scheduling);
            this.Controls.Add(this.ServiceDelivery);
            this.Controls.Add(this.FollowUp);
            this.Controls.Add(this.OperationID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BusinessOperation";
            this.Text = "BusinessOperation";
            this.Load += new System.EventHandler(this.BusinessOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BusinessOperationList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView BusinessOperationList;

        private System.Windows.Forms.TextBox OperationID;
        private System.Windows.Forms.TextBox FollowUp;
        private System.Windows.Forms.TextBox Scheduling;
        private System.Windows.Forms.TextBox ServiceDelivery;
        private System.Windows.Forms.TextBox Quoting;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        #endregion
    }
}