namespace Housing_Project
{
    partial class FormStudent
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
            this.tabControlStudent = new System.Windows.Forms.TabControl();
            this.tabHouseRules = new System.Windows.Forms.TabPage();
            this.tabContactInfo = new System.Windows.Forms.TabPage();
            this.tabCleaningSchedule = new System.Windows.Forms.TabPage();
            this.tabSupplies = new System.Windows.Forms.TabPage();
            this.tabAgreements = new System.Windows.Forms.TabPage();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.lblStudentHouseBV = new System.Windows.Forms.Label();
            this.lblTenantsContactInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabControlStudent.SuspendLayout();
            this.tabContactInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlStudent
            // 
            this.tabControlStudent.Controls.Add(this.tabHouseRules);
            this.tabControlStudent.Controls.Add(this.tabContactInfo);
            this.tabControlStudent.Controls.Add(this.tabCleaningSchedule);
            this.tabControlStudent.Controls.Add(this.tabSupplies);
            this.tabControlStudent.Controls.Add(this.tabAgreements);
            this.tabControlStudent.Controls.Add(this.tabReport);
            this.tabControlStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlStudent.Location = new System.Drawing.Point(12, 84);
            this.tabControlStudent.Multiline = true;
            this.tabControlStudent.Name = "tabControlStudent";
            this.tabControlStudent.Padding = new System.Drawing.Point(27, 5);
            this.tabControlStudent.SelectedIndex = 0;
            this.tabControlStudent.Size = new System.Drawing.Size(1036, 521);
            this.tabControlStudent.TabIndex = 0;
            // 
            // tabHouseRules
            // 
            this.tabHouseRules.Location = new System.Drawing.Point(4, 41);
            this.tabHouseRules.Name = "tabHouseRules";
            this.tabHouseRules.Padding = new System.Windows.Forms.Padding(3);
            this.tabHouseRules.Size = new System.Drawing.Size(1042, 476);
            this.tabHouseRules.TabIndex = 0;
            this.tabHouseRules.Text = "House Rules";
            this.tabHouseRules.UseVisualStyleBackColor = true;
            // 
            // tabContactInfo
            // 
            this.tabContactInfo.Controls.Add(this.listBox2);
            this.tabContactInfo.Controls.Add(this.listBox1);
            this.tabContactInfo.Controls.Add(this.label1);
            this.tabContactInfo.Controls.Add(this.lblTenantsContactInfo);
            this.tabContactInfo.Location = new System.Drawing.Point(4, 41);
            this.tabContactInfo.Name = "tabContactInfo";
            this.tabContactInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabContactInfo.Size = new System.Drawing.Size(1028, 476);
            this.tabContactInfo.TabIndex = 1;
            this.tabContactInfo.Text = "Contact Info";
            this.tabContactInfo.UseVisualStyleBackColor = true;
            // 
            // tabCleaningSchedule
            // 
            this.tabCleaningSchedule.Location = new System.Drawing.Point(4, 41);
            this.tabCleaningSchedule.Name = "tabCleaningSchedule";
            this.tabCleaningSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabCleaningSchedule.Size = new System.Drawing.Size(1028, 476);
            this.tabCleaningSchedule.TabIndex = 2;
            this.tabCleaningSchedule.Text = "Cleaning Schedule";
            this.tabCleaningSchedule.UseVisualStyleBackColor = true;
            // 
            // tabSupplies
            // 
            this.tabSupplies.Location = new System.Drawing.Point(4, 41);
            this.tabSupplies.Name = "tabSupplies";
            this.tabSupplies.Padding = new System.Windows.Forms.Padding(3);
            this.tabSupplies.Size = new System.Drawing.Size(1028, 476);
            this.tabSupplies.TabIndex = 3;
            this.tabSupplies.Text = "Supplies";
            this.tabSupplies.UseVisualStyleBackColor = true;
            // 
            // tabAgreements
            // 
            this.tabAgreements.Location = new System.Drawing.Point(4, 41);
            this.tabAgreements.Name = "tabAgreements";
            this.tabAgreements.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgreements.Size = new System.Drawing.Size(1028, 476);
            this.tabAgreements.TabIndex = 4;
            this.tabAgreements.Text = "Agreements";
            this.tabAgreements.UseVisualStyleBackColor = true;
            // 
            // tabReport
            // 
            this.tabReport.Location = new System.Drawing.Point(4, 41);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(1028, 476);
            this.tabReport.TabIndex = 5;
            this.tabReport.Text = "Report a problem";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // lblStudentHouseBV
            // 
            this.lblStudentHouseBV.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblStudentHouseBV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudentHouseBV.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudentHouseBV.Image = global::Housing_Project.Properties.Resources.house;
            this.lblStudentHouseBV.Location = new System.Drawing.Point(12, 9);
            this.lblStudentHouseBV.Name = "lblStudentHouseBV";
            this.lblStudentHouseBV.Size = new System.Drawing.Size(1036, 61);
            this.lblStudentHouseBV.TabIndex = 1;
            this.lblStudentHouseBV.Text = "Student House BV";
            // 
            // lblTenantsContactInfo
            // 
            this.lblTenantsContactInfo.AutoSize = true;
            this.lblTenantsContactInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTenantsContactInfo.Location = new System.Drawing.Point(139, 45);
            this.lblTenantsContactInfo.Name = "lblTenantsContactInfo";
            this.lblTenantsContactInfo.Size = new System.Drawing.Size(206, 28);
            this.lblTenantsContactInfo.TabIndex = 0;
            this.lblTenantsContactInfo.Text = "Tenants contact info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(637, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Supervisor(s) contact info";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Location = new System.Drawing.Point(57, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(393, 312);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 28;
            this.listBox2.Location = new System.Drawing.Point(561, 93);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(393, 312);
            this.listBox2.TabIndex = 3;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 650);
            this.Controls.Add(this.lblStudentHouseBV);
            this.Controls.Add(this.tabControlStudent);
            this.Name = "FormStudent";
            this.Text = "Student";
            this.tabControlStudent.ResumeLayout(false);
            this.tabContactInfo.ResumeLayout(false);
            this.tabContactInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TabPage tabHouseRules;
        private TabPage tabContactInfo;
        private Label lblStudentHouseBV;
        private TabPage tabCleaningSchedule;
        private TabPage tabSupplies;
        private TabPage tabAgreements;
        private TabPage tabReport;
        private Label lblTenantsContactInfo;
        private Label label1;
        private ListBox listBox2;
        private ListBox listBox1;
        protected TabControl tabControlStudent;
    }
}