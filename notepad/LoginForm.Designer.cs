namespace notepad
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
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.radio_male = new System.Windows.Forms.RadioButton();
            this.radio_female = new System.Windows.Forms.RadioButton();
            this.reset = new System.Windows.Forms.Button();
            this.gender_radio = new System.Windows.Forms.GroupBox();
            this.gender_radio.SuspendLayout();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(41, 45);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(53, 12);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "用户名：";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(41, 78);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(41, 12);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "密码：";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(88, 42);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(184, 21);
            this.username.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(88, 75);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(184, 21);
            this.password.TabIndex = 3;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(43, 159);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 4;
            this.login.Text = "登录";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.Login);
            // 
            // radio_male
            // 
            this.radio_male.AutoSize = true;
            this.radio_male.Checked = true;
            this.radio_male.Location = new System.Drawing.Point(6, 20);
            this.radio_male.Name = "radio_male";
            this.radio_male.Size = new System.Drawing.Size(35, 16);
            this.radio_male.TabIndex = 5;
            this.radio_male.TabStop = true;
            this.radio_male.Text = "男";
            this.radio_male.UseVisualStyleBackColor = true;
            // 
            // radio_female
            // 
            this.radio_female.AutoSize = true;
            this.radio_female.Location = new System.Drawing.Point(56, 19);
            this.radio_female.Name = "radio_female";
            this.radio_female.Size = new System.Drawing.Size(35, 16);
            this.radio_female.TabIndex = 6;
            this.radio_female.TabStop = true;
            this.radio_female.Text = "女";
            this.radio_female.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(197, 159);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 7;
            this.reset.Text = "重置";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // gender_radio
            // 
            this.gender_radio.BackColor = System.Drawing.SystemColors.Control;
            this.gender_radio.Controls.Add(this.radio_male);
            this.gender_radio.Controls.Add(this.radio_female);
            this.gender_radio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gender_radio.Location = new System.Drawing.Point(97, 102);
            this.gender_radio.Name = "gender_radio";
            this.gender_radio.Size = new System.Drawing.Size(100, 51);
            this.gender_radio.TabIndex = 8;
            this.gender_radio.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 236);
            this.Controls.Add(this.gender_radio);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Name = "LoginForm";
            this.Text = "登录窗体";
            this.gender_radio.ResumeLayout(false);
            this.gender_radio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.RadioButton radio_male;
        private System.Windows.Forms.RadioButton radio_female;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.GroupBox gender_radio;
    }
}