namespace Housing_Project
{
    partial class Supervisor
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
            this.lblStudentHouseBV = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbrule = new System.Windows.Forms.RichTextBox();
            this.addNewRule = new System.Windows.Forms.Button();
            this.editRul = new System.Windows.Forms.Button();
            this.Rules = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.report_problem = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbnumberofrule = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbnrofapartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbresult2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.add_user = new System.Windows.Forms.Button();
            this.add_tenant = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentHouseBV
            // 
            this.lblStudentHouseBV.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblStudentHouseBV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudentHouseBV.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudentHouseBV.Image = global::Housing_Project.Properties.Resources.house;
            this.lblStudentHouseBV.Location = new System.Drawing.Point(12, 21);
            this.lblStudentHouseBV.Name = "lblStudentHouseBV";
            this.lblStudentHouseBV.Size = new System.Drawing.Size(907, 46);
            this.lblStudentHouseBV.TabIndex = 2;
            this.lblStudentHouseBV.Text = "Student House BV";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(907, 364);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbnumberofrule);
            this.tabPage1.Controls.Add(this.tbrule);
            this.tabPage1.Controls.Add(this.addNewRule);
            this.tabPage1.Controls.Add(this.editRul);
            this.tabPage1.Controls.Add(this.Rules);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(899, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rules";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbrule
            // 
            this.tbrule.Location = new System.Drawing.Point(304, 107);
            this.tbrule.Name = "tbrule";
            this.tbrule.Size = new System.Drawing.Size(335, 110);
            this.tbrule.TabIndex = 3;
            this.tbrule.Text = "";
            // 
            // addNewRule
            // 
            this.addNewRule.Location = new System.Drawing.Point(304, 257);
            this.addNewRule.Name = "addNewRule";
            this.addNewRule.Size = new System.Drawing.Size(335, 65);
            this.addNewRule.TabIndex = 2;
            this.addNewRule.Text = "Add Rule";
            this.addNewRule.UseVisualStyleBackColor = true;
            this.addNewRule.Click += new System.EventHandler(this.addNewRule_Click);
            // 
            // editRul
            // 
            this.editRul.Location = new System.Drawing.Point(304, 18);
            this.editRul.Name = "editRul";
            this.editRul.Size = new System.Drawing.Size(335, 67);
            this.editRul.TabIndex = 1;
            this.editRul.Text = "Edit Rule Nr";
            this.editRul.UseVisualStyleBackColor = true;
            this.editRul.Click += new System.EventHandler(this.editRul_Click);
            // 
            // Rules
            // 
            this.Rules.FormattingEnabled = true;
            this.Rules.ItemHeight = 25;
            this.Rules.Location = new System.Drawing.Point(6, 18);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(292, 304);
            this.Rules.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.monthCalendar1);
            this.tabPage2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(899, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cleaning Schedule";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(28, 26);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(145, 40);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.add_user);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.lbresult2);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.tbnrofapartment);
            this.tabPage4.Controls.Add(this.tbemail);
            this.tabPage4.Controls.Add(this.tbname);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(899, 336);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Contact Info";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.report_problem);
            this.tabPage6.Controls.Add(this.richTextBox1);
            this.tabPage6.Controls.Add(this.textBox2);
            this.tabPage6.Controls.Add(this.textBox1);
            this.tabPage6.Controls.Add(this.label3);
            this.tabPage6.Controls.Add(this.label2);
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(899, 336);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Report a problem";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // report_problem
            // 
            this.report_problem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.report_problem.Location = new System.Drawing.Point(287, 237);
            this.report_problem.Name = "report_problem";
            this.report_problem.Size = new System.Drawing.Size(323, 68);
            this.report_problem.TabIndex = 6;
            this.report_problem.Text = "Report a problem";
            this.report_problem.UseVisualStyleBackColor = true;
            this.report_problem.Click += new System.EventHandler(this.report_problem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 112);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(881, 96);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(538, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 35);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(196, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 35);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(364, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nr of apartment:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(127, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description of the problem:";
            // 
            // tbnumberofrule
            // 
            this.tbnumberofrule.Location = new System.Drawing.Point(529, 36);
            this.tbnumberofrule.Name = "tbnumberofrule";
            this.tbnumberofrule.Size = new System.Drawing.Size(33, 33);
            this.tbnumberofrule.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_tenant);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(259, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 276);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tenants";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 90);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(145, 40);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 136);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(145, 40);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 182);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(145, 40);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // tbname
            // 
            this.tbname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbname.Location = new System.Drawing.Point(417, 48);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(161, 33);
            this.tbname.TabIndex = 1;
            // 
            // tbemail
            // 
            this.tbemail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbemail.Location = new System.Drawing.Point(417, 109);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(161, 33);
            this.tbemail.TabIndex = 2;
            // 
            // tbnrofapartment
            // 
            this.tbnrofapartment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbnrofapartment.Location = new System.Drawing.Point(417, 167);
            this.tbnrofapartment.Name = "tbnrofapartment";
            this.tbnrofapartment.Size = new System.Drawing.Size(161, 33);
            this.tbnrofapartment.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(154, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(154, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "E-mail";
            // 
            // lbresult2
            // 
            this.lbresult2.AutoSize = true;
            this.lbresult2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbresult2.Location = new System.Drawing.Point(667, 117);
            this.lbresult2.Name = "lbresult2";
            this.lbresult2.Size = new System.Drawing.Size(160, 25);
            this.lbresult2.TabIndex = 6;
            this.lbresult2.Text = "The user is added";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(154, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nr of apartment";
            // 
            // add_user
            // 
            this.add_user.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_user.Location = new System.Drawing.Point(294, 239);
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(159, 60);
            this.add_user.TabIndex = 8;
            this.add_user.Text = "Add user";
            this.add_user.UseVisualStyleBackColor = true;
            this.add_user.Click += new System.EventHandler(this.add_user_Click_1);
            // 
            // add_tenant
            // 
            this.add_tenant.Location = new System.Drawing.Point(6, 228);
            this.add_tenant.Name = "add_tenant";
            this.add_tenant.Size = new System.Drawing.Size(212, 42);
            this.add_tenant.TabIndex = 4;
            this.add_tenant.Text = "Add tenant";
            this.add_tenant.UseVisualStyleBackColor = true;
            this.add_tenant.Click += new System.EventHandler(this.add_tenant_Click);
            // 
            // Supervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 486);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblStudentHouseBV);
            this.Name = "Supervisor";
            this.Text = "Supervisor";
            this.Load += new System.EventHandler(this.Supervisor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblStudentHouseBV;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private TabPage tabPage6;
        private Button report_problem;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox checkBox1;
        private MonthCalendar monthCalendar1;
        private RichTextBox tbrule;
        private Button addNewRule;
        private Button editRul;
        private ListBox Rules;
        private TextBox tbnumberofrule;
        private GroupBox groupBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private Label label7;
        private Label lbresult2;
        private Label label5;
        private Label label4;
        private TextBox tbnrofapartment;
        private TextBox tbemail;
        private TextBox tbname;
        private Button add_user;
        private Button add_tenant;
    }
}