using System.ComponentModel;

namespace Workers2
{
    partial class Scheduling
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
            this.ScheduleId = new System.Windows.Forms.TextBox();
            this.Service = new System.Windows.Forms.TextBox();
            this.Equipment = new System.Windows.Forms.TextBox();
            this.Employee = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.AllSchedules = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllSchedules)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(298, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "SCHEDULING";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Service Schedule";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Equipment Schedule";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "Employee Schedule";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 41);
            this.label5.TabIndex = 4;
            this.label5.Text = "Scheduling ID";
            // 
            // ScheduleId
            // 
            this.ScheduleId.Location = new System.Drawing.Point(155, 69);
            this.ScheduleId.Name = "ScheduleId";
            this.ScheduleId.Size = new System.Drawing.Size(506, 22);
            this.ScheduleId.TabIndex = 5;
            // 
            // Service
            // 
            this.Service.Location = new System.Drawing.Point(155, 192);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(506, 22);
            this.Service.TabIndex = 6;
            // 
            // Equipment
            // 
            this.Equipment.Location = new System.Drawing.Point(155, 151);
            this.Equipment.Name = "Equipment";
            this.Equipment.Size = new System.Drawing.Size(506, 22);
            this.Equipment.TabIndex = 7;
            // 
            // Employee
            // 
            this.Employee.Location = new System.Drawing.Point(155, 110);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(506, 22);
            this.Employee.TabIndex = 8;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(215, 240);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(106, 39);
            this.Create.TabIndex = 9;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(406, 240);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(106, 39);
            this.Back.TabIndex = 10;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AllSchedules
            // 
            this.AllSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllSchedules.Location = new System.Drawing.Point(6, 322);
            this.AllSchedules.Name = "AllSchedules";
            this.AllSchedules.RowTemplate.Height = 24;
            this.AllSchedules.Size = new System.Drawing.Size(789, 331);
            this.AllSchedules.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(308, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "ALL SCHEDULES";
            // 
            // Scheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 662);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AllSchedules);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.Equipment);
            this.Controls.Add(this.Service);
            this.Controls.Add(this.ScheduleId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Scheduling";
            this.Text = "Scheduling";
            this.Load += new System.EventHandler(this.Scheduling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllSchedules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.DataGridView AllSchedules;

        private System.Windows.Forms.TextBox ScheduleId;
        private System.Windows.Forms.TextBox Service;
        private System.Windows.Forms.TextBox Equipment;
        private System.Windows.Forms.TextBox Employee;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Back;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        #endregion
    }
}