using System.ComponentModel;

namespace WorkersAssignment1
{
    partial class Register
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
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.ConfrimLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.Location = new System.Drawing.Point(337, 7);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(174, 38);
            this.RegisterLabel.TabIndex = 0;
            this.RegisterLabel.Text = "REGISTER";
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(11, 77);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(136, 30);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Location = new System.Drawing.Point(9, 129);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(137, 30);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email Address";
            // 
            // ConfrimLabel
            // 
            this.ConfrimLabel.Location = new System.Drawing.Point(9, 218);
            this.ConfrimLabel.Name = "ConfrimLabel";
            this.ConfrimLabel.Size = new System.Drawing.Size(137, 30);
            this.ConfrimLabel.TabIndex = 5;
            this.ConfrimLabel.Text = "Confirm Password";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(9, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(333, 257);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(139, 32);
            this.RegisterBtn.TabIndex = 7;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(170, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(371, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(170, 173);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(371, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(170, 129);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(371, 22);
            this.textBox4.TabIndex = 11;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ConfrimLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.RegisterLabel);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;

        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label ConfrimLabel;
        private System.Windows.Forms.Label label7;

        #endregion
    }
}