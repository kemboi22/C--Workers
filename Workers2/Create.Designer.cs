using System.ComponentModel;

namespace WorkersAssignment1
{
    partial class Create
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
            this.CreateStaffLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QualificationsLabel = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.CreateStaffBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.AllStaffList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AllStaffList)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateStaffLbl
            // 
            this.CreateStaffLbl.Location = new System.Drawing.Point(353, 12);
            this.CreateStaffLbl.Name = "CreateStaffLbl";
            this.CreateStaffLbl.Size = new System.Drawing.Size(133, 37);
            this.CreateStaffLbl.TabIndex = 0;
            this.CreateStaffLbl.Text = "CREATE STAFF";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = " Date Of Employment";
            // 
            // QualificationsLabel
            // 
            this.QualificationsLabel.Location = new System.Drawing.Point(12, 170);
            this.QualificationsLabel.Name = "QualificationsLabel";
            this.QualificationsLabel.Size = new System.Drawing.Size(133, 37);
            this.QualificationsLabel.TabIndex = 2;
            this.QualificationsLabel.Text = "Qualifications";
            // 
            // ContactLabel
            // 
            this.ContactLabel.Location = new System.Drawing.Point(12, 124);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(133, 37);
            this.ContactLabel.TabIndex = 3;
            this.ContactLabel.Text = "Contact";
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(12, 77);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(133, 37);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(436, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 218);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(436, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(168, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(436, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(168, 124);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(436, 22);
            this.textBox4.TabIndex = 8;
            // 
            // CreateStaffBtn
            // 
            this.CreateStaffBtn.Location = new System.Drawing.Point(198, 263);
            this.CreateStaffBtn.Name = "CreateStaffBtn";
            this.CreateStaffBtn.Size = new System.Drawing.Size(176, 33);
            this.CreateStaffBtn.TabIndex = 9;
            this.CreateStaffBtn.Text = "CREATE";
            this.CreateStaffBtn.UseVisualStyleBackColor = true;
            this.CreateStaffBtn.Click += new System.EventHandler(this.CreateStaffBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(432, 263);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(157, 32);
            this.BackBtn.TabIndex = 10;
            this.BackBtn.Text = "BACK";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click_1);
            // 
            // AllStaffList
            // 
            this.AllStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllStaffList.Location = new System.Drawing.Point(11, 332);
            this.AllStaffList.Name = "AllStaffList";
            this.AllStaffList.RowTemplate.Height = 24;
            this.AllStaffList.Size = new System.Drawing.Size(780, 270);
            this.AllStaffList.TabIndex = 11;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.AllStaffList);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.CreateStaffBtn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.QualificationsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreateStaffLbl);
            this.Name = "Create";
            this.Text = "Create";
            this.Load += new System.EventHandler(this.Create_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllStaffList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView AllStaffList;

        private System.Windows.Forms.Button BackBtn;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button CreateStaffBtn;

        private System.Windows.Forms.Label CreateStaffLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label QualificationsLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label NameLabel;

        #endregion
    }
}