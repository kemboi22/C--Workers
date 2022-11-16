using System.ComponentModel;

namespace WorkersAssignment1
{
    partial class Login
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
            this.LoginLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.Location = new System.Drawing.Point(351, 30);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(79, 28);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "LOGIN";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Location = new System.Drawing.Point(84, 75);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(105, 33);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "Email Address";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Location = new System.Drawing.Point(116, 124);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(72, 54);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(212, 70);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(309, 23);
            this.Email.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(212, 121);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '.';
            this.Password.Size = new System.Drawing.Size(309, 23);
            this.Password.TabIndex = 4;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(306, 183);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(123, 40);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LoginLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login";
            this.Text = "Login";
            
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button LoginBtn;

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;

        #endregion
    }
}