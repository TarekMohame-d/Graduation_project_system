namespace Graduation_project_system
{
    partial class AdminDashboardForm
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
            this.sideMenu_panel = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.viewAllUsers_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_profile = new System.Windows.Forms.PictureBox();
            this.design_panel2 = new System.Windows.Forms.Panel();
            this.label_page_title = new System.Windows.Forms.Label();
            this.design_panel1 = new System.Windows.Forms.Panel();
            this.design_panel3 = new System.Windows.Forms.Panel();
            this.add_Insert_delete_User_panel = new System.Windows.Forms.Panel();
            this.textBox_old_id = new System.Windows.Forms.TextBox();
            this.Label_old_id = new System.Windows.Forms.Label();
            this.action_button = new System.Windows.Forms.Button();
            this.radio_group_panel = new System.Windows.Forms.Panel();
            this.radioBtn_admin = new System.Windows.Forms.RadioButton();
            this.radioBtn_professor = new System.Windows.Forms.RadioButton();
            this.radioBtn_student = new System.Windows.Forms.RadioButton();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_user_name = new System.Windows.Forms.Label();
            this.profile_panel = new System.Windows.Forms.Panel();
            this.button_profile_save = new System.Windows.Forms.Button();
            this.label_profile_id = new System.Windows.Forms.Label();
            this.label_profile_email = new System.Windows.Forms.Label();
            this.label_profile_username = new System.Windows.Forms.Label();
            this.textBox_profile_email = new System.Windows.Forms.TextBox();
            this.textBox_profile_id = new System.Windows.Forms.TextBox();
            this.textBox_profile_username = new System.Windows.Forms.TextBox();
            this.panel_view_allUsers = new System.Windows.Forms.Panel();
            this.sideMenu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).BeginInit();
            this.design_panel2.SuspendLayout();
            this.add_Insert_delete_User_panel.SuspendLayout();
            this.radio_group_panel.SuspendLayout();
            this.profile_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenu_panel
            // 
            this.sideMenu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.sideMenu_panel.Controls.Add(this.logout_btn);
            this.sideMenu_panel.Controls.Add(this.viewAllUsers_btn);
            this.sideMenu_panel.Controls.Add(this.edit_btn);
            this.sideMenu_panel.Controls.Add(this.delete_btn);
            this.sideMenu_panel.Controls.Add(this.add_btn);
            this.sideMenu_panel.Controls.Add(this.label1);
            this.sideMenu_panel.Controls.Add(this.pictureBox_profile);
            this.sideMenu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu_panel.Location = new System.Drawing.Point(0, 0);
            this.sideMenu_panel.Name = "sideMenu_panel";
            this.sideMenu_panel.Size = new System.Drawing.Size(300, 900);
            this.sideMenu_panel.TabIndex = 0;
            // 
            // logout_btn
            // 
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = global::Graduation_project_system.Properties.Resources.logout;
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(3, 570);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(294, 49);
            this.logout_btn.TabIndex = 1;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // viewAllUsers_btn
            // 
            this.viewAllUsers_btn.FlatAppearance.BorderSize = 0;
            this.viewAllUsers_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.viewAllUsers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllUsers_btn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllUsers_btn.ForeColor = System.Drawing.Color.White;
            this.viewAllUsers_btn.Image = global::Graduation_project_system.Properties.Resources.view;
            this.viewAllUsers_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewAllUsers_btn.Location = new System.Drawing.Point(3, 490);
            this.viewAllUsers_btn.Name = "viewAllUsers_btn";
            this.viewAllUsers_btn.Size = new System.Drawing.Size(294, 49);
            this.viewAllUsers_btn.TabIndex = 2;
            this.viewAllUsers_btn.Text = "View all Users";
            this.viewAllUsers_btn.UseVisualStyleBackColor = true;
            this.viewAllUsers_btn.Click += new System.EventHandler(this.viewAllUsers_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.ForeColor = System.Drawing.Color.White;
            this.edit_btn.Image = global::Graduation_project_system.Properties.Resources.user_edit;
            this.edit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_btn.Location = new System.Drawing.Point(3, 330);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(294, 49);
            this.edit_btn.TabIndex = 3;
            this.edit_btn.Text = "Edit User";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Image = global::Graduation_project_system.Properties.Resources.delete_user;
            this.delete_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_btn.Location = new System.Drawing.Point(3, 410);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(294, 49);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.Text = "Delete User";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Image = global::Graduation_project_system.Properties.Resources.add_user;
            this.add_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_btn.Location = new System.Drawing.Point(3, 250);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(294, 49);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "Add User";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Admin 1";
            // 
            // pictureBox_profile
            // 
            this.pictureBox_profile.Image = global::Graduation_project_system.Properties.Resources.account;
            this.pictureBox_profile.Location = new System.Drawing.Point(79, 15);
            this.pictureBox_profile.Name = "pictureBox_profile";
            this.pictureBox_profile.Size = new System.Drawing.Size(143, 131);
            this.pictureBox_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_profile.TabIndex = 7;
            this.pictureBox_profile.TabStop = false;
            this.pictureBox_profile.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // design_panel2
            // 
            this.design_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.design_panel2.Controls.Add(this.label_page_title);
            this.design_panel2.Location = new System.Drawing.Point(474, 0);
            this.design_panel2.Name = "design_panel2";
            this.design_panel2.Size = new System.Drawing.Size(285, 35);
            this.design_panel2.TabIndex = 8;
            // 
            // label_page_title
            // 
            this.label_page_title.BackColor = System.Drawing.Color.Transparent;
            this.label_page_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_page_title.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_page_title.ForeColor = System.Drawing.Color.White;
            this.label_page_title.Location = new System.Drawing.Point(45, 2);
            this.label_page_title.Name = "label_page_title";
            this.label_page_title.Size = new System.Drawing.Size(195, 33);
            this.label_page_title.TabIndex = 30;
            this.label_page_title.Text = "Admin Page";
            // 
            // design_panel1
            // 
            this.design_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.design_panel1.Location = new System.Drawing.Point(300, 0);
            this.design_panel1.Name = "design_panel1";
            this.design_panel1.Size = new System.Drawing.Size(175, 35);
            this.design_panel1.TabIndex = 9;
            // 
            // design_panel3
            // 
            this.design_panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.design_panel3.Location = new System.Drawing.Point(758, 0);
            this.design_panel3.Name = "design_panel3";
            this.design_panel3.Size = new System.Drawing.Size(840, 35);
            this.design_panel3.TabIndex = 10;
            // 
            // add_Insert_delete_User_panel
            // 
            this.add_Insert_delete_User_panel.BackColor = System.Drawing.Color.LightGray;
            this.add_Insert_delete_User_panel.Controls.Add(this.textBox_old_id);
            this.add_Insert_delete_User_panel.Controls.Add(this.Label_old_id);
            this.add_Insert_delete_User_panel.Controls.Add(this.action_button);
            this.add_Insert_delete_User_panel.Controls.Add(this.radio_group_panel);
            this.add_Insert_delete_User_panel.Controls.Add(this.textBox_id);
            this.add_Insert_delete_User_panel.Controls.Add(this.textBox_email);
            this.add_Insert_delete_User_panel.Controls.Add(this.label_id);
            this.add_Insert_delete_User_panel.Controls.Add(this.label_email);
            this.add_Insert_delete_User_panel.Controls.Add(this.textBox_password);
            this.add_Insert_delete_User_panel.Controls.Add(this.textBox_username);
            this.add_Insert_delete_User_panel.Controls.Add(this.label_password);
            this.add_Insert_delete_User_panel.Controls.Add(this.label_user_name);
            this.add_Insert_delete_User_panel.Location = new System.Drawing.Point(300, 35);
            this.add_Insert_delete_User_panel.Name = "add_Insert_delete_User_panel";
            this.add_Insert_delete_User_panel.Size = new System.Drawing.Size(1300, 884);
            this.add_Insert_delete_User_panel.TabIndex = 11;
            // 
            // textBox_old_id
            // 
            this.textBox_old_id.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_old_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_old_id.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_old_id.Location = new System.Drawing.Point(50, 86);
            this.textBox_old_id.Multiline = true;
            this.textBox_old_id.Name = "textBox_old_id";
            this.textBox_old_id.Size = new System.Drawing.Size(350, 35);
            this.textBox_old_id.TabIndex = 29;
            this.textBox_old_id.Visible = false;
            // 
            // Label_old_id
            // 
            this.Label_old_id.AutoSize = true;
            this.Label_old_id.BackColor = System.Drawing.Color.Transparent;
            this.Label_old_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_old_id.Location = new System.Drawing.Point(46, 58);
            this.Label_old_id.Name = "Label_old_id";
            this.Label_old_id.Size = new System.Drawing.Size(69, 23);
            this.Label_old_id.TabIndex = 28;
            this.Label_old_id.Text = "Old id";
            this.Label_old_id.Visible = false;
            // 
            // action_button
            // 
            this.action_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.action_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.action_button.FlatAppearance.BorderSize = 0;
            this.action_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action_button.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action_button.ForeColor = System.Drawing.Color.White;
            this.action_button.Location = new System.Drawing.Point(295, 425);
            this.action_button.Name = "action_button";
            this.action_button.Size = new System.Drawing.Size(374, 40);
            this.action_button.TabIndex = 27;
            this.action_button.Text = "Add User";
            this.action_button.UseVisualStyleBackColor = false;
            // 
            // radio_group_panel
            // 
            this.radio_group_panel.Controls.Add(this.radioBtn_admin);
            this.radio_group_panel.Controls.Add(this.radioBtn_professor);
            this.radio_group_panel.Controls.Add(this.radioBtn_student);
            this.radio_group_panel.Location = new System.Drawing.Point(23, 317);
            this.radio_group_panel.Name = "radio_group_panel";
            this.radio_group_panel.Size = new System.Drawing.Size(586, 46);
            this.radio_group_panel.TabIndex = 26;
            // 
            // radioBtn_admin
            // 
            this.radioBtn_admin.AutoSize = true;
            this.radioBtn_admin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_admin.Location = new System.Drawing.Point(411, 11);
            this.radioBtn_admin.Name = "radioBtn_admin";
            this.radioBtn_admin.Size = new System.Drawing.Size(84, 25);
            this.radioBtn_admin.TabIndex = 2;
            this.radioBtn_admin.TabStop = true;
            this.radioBtn_admin.Text = "Admin";
            this.radioBtn_admin.UseVisualStyleBackColor = true;
            // 
            // radioBtn_professor
            // 
            this.radioBtn_professor.AutoSize = true;
            this.radioBtn_professor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_professor.Location = new System.Drawing.Point(212, 11);
            this.radioBtn_professor.Name = "radioBtn_professor";
            this.radioBtn_professor.Size = new System.Drawing.Size(103, 25);
            this.radioBtn_professor.TabIndex = 1;
            this.radioBtn_professor.TabStop = true;
            this.radioBtn_professor.Text = "Professor";
            this.radioBtn_professor.UseVisualStyleBackColor = true;
            // 
            // radioBtn_student
            // 
            this.radioBtn_student.AutoSize = true;
            this.radioBtn_student.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_student.Location = new System.Drawing.Point(27, 11);
            this.radioBtn_student.Name = "radioBtn_student";
            this.radioBtn_student.Size = new System.Drawing.Size(96, 25);
            this.radioBtn_student.TabIndex = 0;
            this.radioBtn_student.TabStop = true;
            this.radioBtn_student.Text = "Student";
            this.radioBtn_student.UseVisualStyleBackColor = true;
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_id.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(504, 262);
            this.textBox_id.Multiline = true;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(350, 35);
            this.textBox_id.TabIndex = 25;
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_email.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(504, 171);
            this.textBox_email.Multiline = true;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(350, 35);
            this.textBox_email.TabIndex = 23;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.Color.Transparent;
            this.label_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(500, 234);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(30, 23);
            this.label_id.TabIndex = 24;
            this.label_id.Text = "ID";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.BackColor = System.Drawing.Color.Transparent;
            this.label_email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(500, 141);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(70, 23);
            this.label_email.TabIndex = 22;
            this.label_email.Text = "E-mail";
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_password.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(50, 262);
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(350, 35);
            this.textBox_password.TabIndex = 21;
            // 
            // textBox_username
            // 
            this.textBox_username.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_username.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(50, 171);
            this.textBox_username.Multiline = true;
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(350, 35);
            this.textBox_username.TabIndex = 19;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(46, 234);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(100, 23);
            this.label_password.TabIndex = 20;
            this.label_password.Text = "Password";
            // 
            // label_user_name
            // 
            this.label_user_name.AutoSize = true;
            this.label_user_name.BackColor = System.Drawing.Color.Transparent;
            this.label_user_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user_name.Location = new System.Drawing.Point(46, 141);
            this.label_user_name.Name = "label_user_name";
            this.label_user_name.Size = new System.Drawing.Size(108, 23);
            this.label_user_name.TabIndex = 18;
            this.label_user_name.Text = "Username";
            // 
            // profile_panel
            // 
            this.profile_panel.BackColor = System.Drawing.Color.LightGray;
            this.profile_panel.Controls.Add(this.button_profile_save);
            this.profile_panel.Controls.Add(this.label_profile_id);
            this.profile_panel.Controls.Add(this.label_profile_email);
            this.profile_panel.Controls.Add(this.label_profile_username);
            this.profile_panel.Controls.Add(this.textBox_profile_email);
            this.profile_panel.Controls.Add(this.textBox_profile_id);
            this.profile_panel.Controls.Add(this.textBox_profile_username);
            this.profile_panel.Location = new System.Drawing.Point(300, 35);
            this.profile_panel.Name = "profile_panel";
            this.profile_panel.Size = new System.Drawing.Size(1300, 884);
            this.profile_panel.TabIndex = 12;
            this.profile_panel.Visible = false;
            // 
            // button_profile_save
            // 
            this.button_profile_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button_profile_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_profile_save.FlatAppearance.BorderSize = 0;
            this.button_profile_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_profile_save.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_profile_save.ForeColor = System.Drawing.Color.White;
            this.button_profile_save.Location = new System.Drawing.Point(295, 425);
            this.button_profile_save.Name = "button_profile_save";
            this.button_profile_save.Size = new System.Drawing.Size(374, 40);
            this.button_profile_save.TabIndex = 27;
            this.button_profile_save.Text = "SAVE";
            this.button_profile_save.UseVisualStyleBackColor = false;
            // 
            // label_profile_id
            // 
            this.label_profile_id.AutoSize = true;
            this.label_profile_id.BackColor = System.Drawing.Color.Transparent;
            this.label_profile_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_profile_id.Location = new System.Drawing.Point(46, 323);
            this.label_profile_id.Name = "label_profile_id";
            this.label_profile_id.Size = new System.Drawing.Size(30, 23);
            this.label_profile_id.TabIndex = 35;
            this.label_profile_id.Text = "ID";
            // 
            // label_profile_email
            // 
            this.label_profile_email.AutoSize = true;
            this.label_profile_email.BackColor = System.Drawing.Color.Transparent;
            this.label_profile_email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_profile_email.Location = new System.Drawing.Point(46, 234);
            this.label_profile_email.Name = "label_profile_email";
            this.label_profile_email.Size = new System.Drawing.Size(65, 23);
            this.label_profile_email.TabIndex = 34;
            this.label_profile_email.Text = "email";
            // 
            // label_profile_username
            // 
            this.label_profile_username.AutoSize = true;
            this.label_profile_username.BackColor = System.Drawing.Color.Transparent;
            this.label_profile_username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_profile_username.Location = new System.Drawing.Point(46, 141);
            this.label_profile_username.Name = "label_profile_username";
            this.label_profile_username.Size = new System.Drawing.Size(108, 23);
            this.label_profile_username.TabIndex = 18;
            this.label_profile_username.Text = "Username";
            // 
            // textBox_profile_email
            // 
            this.textBox_profile_email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_profile_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_profile_email.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_profile_email.Location = new System.Drawing.Point(50, 260);
            this.textBox_profile_email.Multiline = true;
            this.textBox_profile_email.Name = "textBox_profile_email";
            this.textBox_profile_email.Size = new System.Drawing.Size(350, 35);
            this.textBox_profile_email.TabIndex = 33;
            // 
            // textBox_profile_id
            // 
            this.textBox_profile_id.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_profile_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_profile_id.Enabled = false;
            this.textBox_profile_id.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_profile_id.Location = new System.Drawing.Point(50, 349);
            this.textBox_profile_id.Multiline = true;
            this.textBox_profile_id.Name = "textBox_profile_id";
            this.textBox_profile_id.Size = new System.Drawing.Size(350, 35);
            this.textBox_profile_id.TabIndex = 32;
            // 
            // textBox_profile_username
            // 
            this.textBox_profile_username.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_profile_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_profile_username.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_profile_username.Location = new System.Drawing.Point(50, 171);
            this.textBox_profile_username.Multiline = true;
            this.textBox_profile_username.Name = "textBox_profile_username";
            this.textBox_profile_username.Size = new System.Drawing.Size(350, 35);
            this.textBox_profile_username.TabIndex = 31;
            // 
            // panel_view_allUsers
            // 
            this.panel_view_allUsers.BackColor = System.Drawing.Color.LightGray;
            this.panel_view_allUsers.Location = new System.Drawing.Point(300, 35);
            this.panel_view_allUsers.Name = "panel_view_allUsers";
            this.panel_view_allUsers.Size = new System.Drawing.Size(1300, 884);
            this.panel_view_allUsers.TabIndex = 33;
            this.panel_view_allUsers.Visible = false;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panel_view_allUsers);
            this.Controls.Add(this.profile_panel);
            this.Controls.Add(this.add_Insert_delete_User_panel);
            this.Controls.Add(this.design_panel3);
            this.Controls.Add(this.design_panel1);
            this.Controls.Add(this.design_panel2);
            this.Controls.Add(this.sideMenu_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboardForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashboardForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.sideMenu_panel.ResumeLayout(false);
            this.sideMenu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).EndInit();
            this.design_panel2.ResumeLayout(false);
            this.add_Insert_delete_User_panel.ResumeLayout(false);
            this.add_Insert_delete_User_panel.PerformLayout();
            this.radio_group_panel.ResumeLayout(false);
            this.radio_group_panel.PerformLayout();
            this.profile_panel.ResumeLayout(false);
            this.profile_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideMenu_panel;
        private System.Windows.Forms.PictureBox pictureBox_profile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button viewAllUsers_btn;
        private System.Windows.Forms.Panel design_panel2;
        private System.Windows.Forms.Panel design_panel1;
        private System.Windows.Forms.Panel design_panel3;
        private System.Windows.Forms.Panel add_Insert_delete_User_panel;
        private System.Windows.Forms.Panel radio_group_panel;
        private System.Windows.Forms.RadioButton radioBtn_admin;
        private System.Windows.Forms.RadioButton radioBtn_professor;
        private System.Windows.Forms.RadioButton radioBtn_student;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_user_name;
        private System.Windows.Forms.Button action_button;
        private System.Windows.Forms.TextBox textBox_old_id;
        private System.Windows.Forms.Label Label_old_id;
        private System.Windows.Forms.Label label_page_title;
        private System.Windows.Forms.Panel profile_panel;
        private System.Windows.Forms.TextBox textBox_profile_username;
        private System.Windows.Forms.TextBox textBox_profile_email;
        private System.Windows.Forms.TextBox textBox_profile_id;
        private System.Windows.Forms.Label label_profile_username;
        private System.Windows.Forms.Label label_profile_id;
        private System.Windows.Forms.Label label_profile_email;
        private System.Windows.Forms.Button button_profile_save;
        private System.Windows.Forms.Panel panel_view_allUsers;
    }
}