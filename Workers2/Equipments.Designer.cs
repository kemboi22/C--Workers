using System.ComponentModel;

namespace Workers2
{
    partial class Equipments
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
            this.EquipmentID = new System.Windows.Forms.TextBox();
            this.Maitanance = new System.Windows.Forms.TextBox();
            this.SerialNumber = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.AllEquipments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AllEquipments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "EQUIPMENTS";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serial number";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Equipment ID";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 36);
            this.label6.TabIndex = 5;
            this.label6.Text = "Maintanance records";
            // 
            // EquipmentID
            // 
            this.EquipmentID.Location = new System.Drawing.Point(182, 53);
            this.EquipmentID.Name = "EquipmentID";
            this.EquipmentID.Size = new System.Drawing.Size(541, 22);
            this.EquipmentID.TabIndex = 6;
            // 
            // Maitanance
            // 
            this.Maitanance.Location = new System.Drawing.Point(182, 197);
            this.Maitanance.Name = "Maitanance";
            this.Maitanance.Size = new System.Drawing.Size(541, 22);
            this.Maitanance.TabIndex = 7;
            // 
            // SerialNumber
            // 
            this.SerialNumber.Location = new System.Drawing.Point(182, 161);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(541, 22);
            this.SerialNumber.TabIndex = 8;
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(182, 125);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(541, 22);
            this.Model.TabIndex = 9;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(182, 89);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(541, 22);
            this.type.TabIndex = 10;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(259, 245);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(126, 40);
            this.CreateBtn.TabIndex = 11;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(491, 245);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(126, 40);
            this.Back.TabIndex = 12;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(318, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 36);
            this.label7.TabIndex = 13;
            this.label7.Text = "ALL EQUIPMENTS";
            // 
            // AllEquipments
            // 
            this.AllEquipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllEquipments.Location = new System.Drawing.Point(10, 341);
            this.AllEquipments.Name = "AllEquipments";
            this.AllEquipments.RowTemplate.Height = 24;
            this.AllEquipments.Size = new System.Drawing.Size(785, 301);
            this.AllEquipments.TabIndex = 14;
            // 
            // Equipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.AllEquipments);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.type);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.SerialNumber);
            this.Controls.Add(this.Maitanance);
            this.Controls.Add(this.EquipmentID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Equipments";
            this.Text = "Equipments";
            this.Load += new System.EventHandler(this.Equipments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllEquipments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox EquipmentID;
        private System.Windows.Forms.TextBox Maitanance;
        private System.Windows.Forms.TextBox SerialNumber;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView AllEquipments;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        #endregion
    }
}