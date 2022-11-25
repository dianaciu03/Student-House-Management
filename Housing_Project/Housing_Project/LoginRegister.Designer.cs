namespace Housing_Project
{
    partial class LoginRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginbtn = new System.Windows.Forms.Button();
            this.registerbtn = new System.Windows.Forms.Button();
            this.fullnametxt = new System.Windows.Forms.TextBox();
            this.phonenumbertxt = new System.Windows.Forms.TextBox();
            this.emailadresstxt = new System.Windows.Forms.TextBox();
            this.fullnamelbl = new System.Windows.Forms.Label();
            this.phonenumberlbl = new System.Windows.Forms.Label();
            this.emailadresslbl = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.loginpasswordtxt = new System.Windows.Forms.TextBox();
            this.loginemailtxt = new System.Windows.Forms.TextBox();
            this.loginemaillbl = new System.Windows.Forms.Label();
            this.loginpasswordlbl = new System.Windows.Forms.Label();
            this.wrongcredentialslbl = new System.Windows.Forms.Label();
            this.registerbtnshow = new System.Windows.Forms.Button();
            this.loginshowbtn = new System.Windows.Forms.Button();
            this.tabControlLoginRegister = new System.Windows.Forms.TabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageRegister = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControlLoginRegister.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.tabPageRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginbtn.Location = new System.Drawing.Point(91, 649);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(234, 85);
            this.loginbtn.TabIndex = 0;
            this.loginbtn.Text = "Log In";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // registerbtn
            // 
            this.registerbtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerbtn.Location = new System.Drawing.Point(470, 649);
            this.registerbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(242, 85);
            this.registerbtn.TabIndex = 1;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // fullnametxt
            // 
            this.fullnametxt.Location = new System.Drawing.Point(91, 65);
            this.fullnametxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fullnametxt.MinimumSize = new System.Drawing.Size(171, 46);
            this.fullnametxt.Name = "fullnametxt";
            this.fullnametxt.Size = new System.Drawing.Size(620, 46);
            this.fullnametxt.TabIndex = 2;
            // 
            // phonenumbertxt
            // 
            this.phonenumbertxt.Location = new System.Drawing.Point(91, 184);
            this.phonenumbertxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phonenumbertxt.MinimumSize = new System.Drawing.Size(171, 46);
            this.phonenumbertxt.Name = "phonenumbertxt";
            this.phonenumbertxt.Size = new System.Drawing.Size(620, 46);
            this.phonenumbertxt.TabIndex = 3;
            // 
            // emailadresstxt
            // 
            this.emailadresstxt.Location = new System.Drawing.Point(91, 317);
            this.emailadresstxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailadresstxt.MinimumSize = new System.Drawing.Size(171, 46);
            this.emailadresstxt.Name = "emailadresstxt";
            this.emailadresstxt.Size = new System.Drawing.Size(620, 46);
            this.emailadresstxt.TabIndex = 4;
            // 
            // fullnamelbl
            // 
            this.fullnamelbl.AutoSize = true;
            this.fullnamelbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullnamelbl.Location = new System.Drawing.Point(315, 12);
            this.fullnamelbl.Name = "fullnamelbl";
            this.fullnamelbl.Size = new System.Drawing.Size(171, 46);
            this.fullnamelbl.TabIndex = 5;
            this.fullnamelbl.Text = "Full name:";
            // 
            // phonenumberlbl
            // 
            this.phonenumberlbl.AutoSize = true;
            this.phonenumberlbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phonenumberlbl.Location = new System.Drawing.Point(299, 131);
            this.phonenumberlbl.Name = "phonenumberlbl";
            this.phonenumberlbl.Size = new System.Drawing.Size(248, 46);
            this.phonenumberlbl.TabIndex = 6;
            this.phonenumberlbl.Text = "Phone number:";
            // 
            // emailadresslbl
            // 
            this.emailadresslbl.AutoSize = true;
            this.emailadresslbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailadresslbl.Location = new System.Drawing.Point(299, 249);
            this.emailadresslbl.Name = "emailadresslbl";
            this.emailadresslbl.Size = new System.Drawing.Size(215, 46);
            this.emailadresslbl.TabIndex = 7;
            this.emailadresslbl.Text = "Email Adress:";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(91, 436);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordtxt.MinimumSize = new System.Drawing.Size(171, 46);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(620, 46);
            this.passwordtxt.TabIndex = 8;
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordlbl.Location = new System.Drawing.Point(315, 383);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(167, 46);
            this.passwordlbl.TabIndex = 9;
            this.passwordlbl.Text = "Password:";
            // 
            // loginpasswordtxt
            // 
            this.loginpasswordtxt.Location = new System.Drawing.Point(91, 383);
            this.loginpasswordtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginpasswordtxt.MinimumSize = new System.Drawing.Size(171, 46);
            this.loginpasswordtxt.Name = "loginpasswordtxt";
            this.loginpasswordtxt.Size = new System.Drawing.Size(620, 46);
            this.loginpasswordtxt.TabIndex = 10;
            // 
            // loginemailtxt
            // 
            this.loginemailtxt.Location = new System.Drawing.Point(91, 237);
            this.loginemailtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginemailtxt.MinimumSize = new System.Drawing.Size(171, 46);
            this.loginemailtxt.Name = "loginemailtxt";
            this.loginemailtxt.Size = new System.Drawing.Size(620, 46);
            this.loginemailtxt.TabIndex = 11;
            // 
            // loginemaillbl
            // 
            this.loginemaillbl.AutoSize = true;
            this.loginemaillbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginemaillbl.Location = new System.Drawing.Point(299, 180);
            this.loginemaillbl.Name = "loginemaillbl";
            this.loginemaillbl.Size = new System.Drawing.Size(215, 46);
            this.loginemaillbl.TabIndex = 12;
            this.loginemaillbl.Text = "Email Adress:";
            // 
            // loginpasswordlbl
            // 
            this.loginpasswordlbl.AutoSize = true;
            this.loginpasswordlbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginpasswordlbl.Location = new System.Drawing.Point(320, 317);
            this.loginpasswordlbl.Name = "loginpasswordlbl";
            this.loginpasswordlbl.Size = new System.Drawing.Size(167, 46);
            this.loginpasswordlbl.TabIndex = 13;
            this.loginpasswordlbl.Text = "Password:";
            // 
            // wrongcredentialslbl
            // 
            this.wrongcredentialslbl.AutoSize = true;
            this.wrongcredentialslbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wrongcredentialslbl.ForeColor = System.Drawing.Color.Red;
            this.wrongcredentialslbl.Location = new System.Drawing.Point(262, 545);
            this.wrongcredentialslbl.Name = "wrongcredentialslbl";
            this.wrongcredentialslbl.Size = new System.Drawing.Size(304, 46);
            this.wrongcredentialslbl.TabIndex = 14;
            this.wrongcredentialslbl.Text = "Wrong credentials!";
            // 
            // registerbtnshow
            // 
            this.registerbtnshow.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerbtnshow.Location = new System.Drawing.Point(470, 649);
            this.registerbtnshow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registerbtnshow.Name = "registerbtnshow";
            this.registerbtnshow.Size = new System.Drawing.Size(242, 85);
            this.registerbtnshow.TabIndex = 15;
            this.registerbtnshow.Text = "Register";
            this.registerbtnshow.UseVisualStyleBackColor = true;
            this.registerbtnshow.Click += new System.EventHandler(this.registerbtn_Click_1);
            // 
            // loginshowbtn
            // 
            this.loginshowbtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginshowbtn.Location = new System.Drawing.Point(91, 649);
            this.loginshowbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginshowbtn.Name = "loginshowbtn";
            this.loginshowbtn.Size = new System.Drawing.Size(234, 85);
            this.loginshowbtn.TabIndex = 16;
            this.loginshowbtn.Text = "Log In";
            this.loginshowbtn.UseVisualStyleBackColor = true;
            this.loginshowbtn.Click += new System.EventHandler(this.loginshowbtn_Click);
            // 
            // tabControlLoginRegister
            // 
            this.tabControlLoginRegister.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlLoginRegister.Controls.Add(this.tabPageLogin);
            this.tabControlLoginRegister.Controls.Add(this.tabPageRegister);
            this.tabControlLoginRegister.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlLoginRegister.Location = new System.Drawing.Point(776, 65);
            this.tabControlLoginRegister.Name = "tabControlLoginRegister";
            this.tabControlLoginRegister.Padding = new System.Drawing.Point(55, 6);
            this.tabControlLoginRegister.SelectedIndex = 0;
            this.tabControlLoginRegister.Size = new System.Drawing.Size(518, 471);
            this.tabControlLoginRegister.TabIndex = 17;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageLogin.Controls.Add(this.label3);
            this.tabPageLogin.Controls.Add(this.textBox1);
            this.tabPageLogin.Controls.Add(this.label2);
            this.tabPageLogin.Controls.Add(this.label1);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 4);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(510, 417);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Login Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log in";
            // 
            // tabPageRegister
            // 
            this.tabPageRegister.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageRegister.Controls.Add(this.label4);
            this.tabPageRegister.Location = new System.Drawing.Point(4, 4);
            this.tabPageRegister.Name = "tabPageRegister";
            this.tabPageRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegister.Size = new System.Drawing.Size(510, 417);
            this.tabPageRegister.TabIndex = 1;
            this.tabPageRegister.Text = "Create account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Create account:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email adress:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 41);
            this.textBox1.TabIndex = 2;
            // 
            // LoginRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 819);
            this.Controls.Add(this.tabControlLoginRegister);
            this.Controls.Add(this.loginshowbtn);
            this.Controls.Add(this.registerbtnshow);
            this.Controls.Add(this.wrongcredentialslbl);
            this.Controls.Add(this.loginpasswordlbl);
            this.Controls.Add(this.loginemaillbl);
            this.Controls.Add(this.loginemailtxt);
            this.Controls.Add(this.loginpasswordtxt);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.emailadresslbl);
            this.Controls.Add(this.phonenumberlbl);
            this.Controls.Add(this.fullnamelbl);
            this.Controls.Add(this.emailadresstxt);
            this.Controls.Add(this.phonenumbertxt);
            this.Controls.Add(this.fullnametxt);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.loginbtn);
            this.Name = "LoginRegister";
            this.Text = "Login/Register";
            this.tabControlLoginRegister.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.tabPageLogin.PerformLayout();
            this.tabPageRegister.ResumeLayout(false);
            this.tabPageRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loginbtn;
        private Button registerbtn;
        private TextBox fullnametxt;
        private TextBox phonenumbertxt;
        private TextBox emailadresstxt;
        private Label fullnamelbl;
        private Label phonenumberlbl;
        private Label emailadresslbl;
        private TextBox passwordtxt;
        private Label passwordlbl;
        private TextBox loginpasswordtxt;
        private TextBox loginemailtxt;
        private Label loginemaillbl;
        private Label loginpasswordlbl;
        private Label wrongcredentialslbl;
        private Button registerbtnshow;
        private Button loginshowbtn;
        private TabControl tabControlLoginRegister;
        private TabPage tabPageLogin;
        private TabPage tabPageRegister;
        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
    }
}