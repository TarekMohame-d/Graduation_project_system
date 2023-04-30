namespace Graduation_project_system
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label_get_started = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_dont_have_account = new System.Windows.Forms.Label();
            this.label_contact_support = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.checkBox_showPW = new System.Windows.Forms.CheckBox();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_get_started
            // 
            this.label_get_started.AutoSize = true;
            this.label_get_started.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_get_started.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label_get_started.Location = new System.Drawing.Point(20, 40);
            this.label_get_started.Name = "label_get_started";
            this.label_get_started.Size = new System.Drawing.Size(191, 33);
            this.label_get_started.TabIndex = 13;
            this.label_get_started.Text = "Get Started";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(24, 100);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(89, 23);
            this.label_username.TabIndex = 14;
            this.label_username.Text = "Username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(24, 175);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(84, 23);
            this.label_password.TabIndex = 16;
            this.label_password.Text = "Password";
            // 
            // label_dont_have_account
            // 
            this.label_dont_have_account.AutoSize = true;
            this.label_dont_have_account.Location = new System.Drawing.Point(85, 390);
            this.label_dont_have_account.Name = "label_dont_have_account";
            this.label_dont_have_account.Size = new System.Drawing.Size(199, 23);
            this.label_dont_have_account.TabIndex = 24;
            this.label_dont_have_account.Text = "Don\'t have an account ?";
            // 
            // label_contact_support
            // 
            this.label_contact_support.AutoSize = true;
            this.label_contact_support.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_contact_support.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label_contact_support.Location = new System.Drawing.Point(110, 415);
            this.label_contact_support.Name = "label_contact_support";
            this.label_contact_support.Size = new System.Drawing.Size(140, 23);
            this.label_contact_support.TabIndex = 25;
            this.label_contact_support.Text = "Contact support";
            // 
            // textBox_username
            // 
            this.textBox_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBox_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_username.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(28, 125);
            this.textBox_username.Multiline = true;
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(216, 28);
            this.textBox_username.TabIndex = 15;
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_password.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(28, 200);
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '•';
            this.textBox_password.Size = new System.Drawing.Size(216, 28);
            this.textBox_password.TabIndex = 17;
            // 
            // checkBox_showPW
            // 
            this.checkBox_showPW.AutoSize = true;
            this.checkBox_showPW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_showPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_showPW.Location = new System.Drawing.Point(250, 200);
            this.checkBox_showPW.Name = "checkBox_showPW";
            this.checkBox_showPW.Size = new System.Drawing.Size(104, 27);
            this.checkBox_showPW.TabIndex = 26;
            this.checkBox_showPW.Text = "Show PW";
            this.checkBox_showPW.UseVisualStyleBackColor = true;
            this.checkBox_showPW.CheckedChanged += new System.EventHandler(this.checkBox_showPW_CheckedChanged);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(28, 299);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(300, 40);
            this.button_login.TabIndex = 23;
            this.button_login.Text = "LOGIN";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 600);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.checkBox_showPW);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_contact_support);
            this.Controls.Add(this.label_dont_have_account);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_get_started);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_get_started;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_dont_have_account;
        private System.Windows.Forms.Label label_contact_support;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.CheckBox checkBox_showPW;
        private System.Windows.Forms.Button button_login;
    }
}