namespace Housing_Project
{
    partial class FormSupervisor
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
            this.tabControlSupervisor = new System.Windows.Forms.TabControl();
            this.tabRules = new System.Windows.Forms.TabPage();
            this.gbEditRules = new System.Windows.Forms.GroupBox();
            this.btnSubmitChanges = new System.Windows.Forms.Button();
            this.btnEditSelectedRule = new System.Windows.Forms.Button();
            this.numRuleNr = new System.Windows.Forms.NumericUpDown();
            this.lblRuleToEdit = new System.Windows.Forms.Label();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.tbRule = new System.Windows.Forms.RichTextBox();
            this.lblHouseRules = new System.Windows.Forms.Label();
            this.lbRules = new System.Windows.Forms.ListBox();
            this.tabContactInfo = new System.Windows.Forms.TabPage();
            this.gbEditSupervisor = new System.Windows.Forms.GroupBox();
            this.btnAddSupervisor = new System.Windows.Forms.Button();
            this.btnSubmitChangesSupervisor = new System.Windows.Forms.Button();
            this.tbSupervisorPhone = new System.Windows.Forms.TextBox();
            this.tbSupervisorEmail = new System.Windows.Forms.TextBox();
            this.lblSupervisorPhone = new System.Windows.Forms.Label();
            this.lblSupervisorEmail = new System.Windows.Forms.Label();
            this.tbSupervisorName = new System.Windows.Forms.TextBox();
            this.lblSupervisorName = new System.Windows.Forms.Label();
            this.numSupervisorID = new System.Windows.Forms.NumericUpDown();
            this.lblSupervisorToEdit = new System.Windows.Forms.Label();
            this.gbEditTenant = new System.Windows.Forms.GroupBox();
            this.btnAddTenant = new System.Windows.Forms.Button();
            this.btnSubmitChangesTenant = new System.Windows.Forms.Button();
            this.tbRoomNumber = new System.Windows.Forms.TextBox();
            this.tbTenantPhone = new System.Windows.Forms.TextBox();
            this.tbTenantEmail = new System.Windows.Forms.TextBox();
            this.lblRoomNr = new System.Windows.Forms.Label();
            this.lblTenantPhone = new System.Windows.Forms.Label();
            this.lblTenantEmail = new System.Windows.Forms.Label();
            this.tbTenantName = new System.Windows.Forms.TextBox();
            this.lblTenantName = new System.Windows.Forms.Label();
            this.numTenantID = new System.Windows.Forms.NumericUpDown();
            this.lblTenantToEdit = new System.Windows.Forms.Label();
            this.lbSupervisorsInfo = new System.Windows.Forms.ListBox();
            this.lblSupervisorContactInfo = new System.Windows.Forms.Label();
            this.lblTenantsContactInfo = new System.Windows.Forms.Label();
            this.lbTenantsInfo = new System.Windows.Forms.ListBox();
            this.tabManageReports = new System.Windows.Forms.TabPage();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.btnSendWarning = new System.Windows.Forms.Button();
            this.cbTenantToSendWarning = new System.Windows.Forms.ComboBox();
            this.lblSelectTenant = new System.Windows.Forms.Label();
            this.tbTenantReportAdressedTo = new System.Windows.Forms.TextBox();
            this.lblPersonAdressedTo = new System.Windows.Forms.Label();
            this.tbReportDescription = new System.Windows.Forms.TextBox();
            this.lblReportDescription = new System.Windows.Forms.Label();
            this.tbSubmittedReports = new System.Windows.Forms.RichTextBox();
            this.lblSubmittedReports = new System.Windows.Forms.Label();
            this.tabAssignTasks = new System.Windows.Forms.TabPage();
            this.lbEvents = new System.Windows.Forms.ListBox();
            this.gbMakeAnnouncement = new System.Windows.Forms.GroupBox();
            this.btnSubmitAnnouncement = new System.Windows.Forms.Button();
            this.tbAnnouncementDescription = new System.Windows.Forms.TextBox();
            this.lblAnnouncementDescription = new System.Windows.Forms.Label();
            this.tbAnnouncementTitle = new System.Windows.Forms.TextBox();
            this.lblAnnouncementTitle = new System.Windows.Forms.Label();
            this.gbAssignTask = new System.Windows.Forms.GroupBox();
            this.btnSubmitTask = new System.Windows.Forms.Button();
            this.cbTakeOutTheTrash = new System.Windows.Forms.CheckBox();
            this.cbCleanTheLivingRoom = new System.Windows.Forms.CheckBox();
            this.cbCleanTheKitchen = new System.Windows.Forms.CheckBox();
            this.cbCleanTheStarirs = new System.Windows.Forms.CheckBox();
            this.cbCleanBathroom2 = new System.Windows.Forms.CheckBox();
            this.cbCleanBathroom1 = new System.Windows.Forms.CheckBox();
            this.lblSelectTask = new System.Windows.Forms.Label();
            this.cbSelectTenantToAssignTask = new System.Windows.Forms.ComboBox();
            this.lblSelectTenantAssignTask = new System.Windows.Forms.Label();
            this.monthCalendarSupervisor = new System.Windows.Forms.MonthCalendar();
            this.lblStudentHouseBV = new System.Windows.Forms.Label();
            this.tabControlSupervisor.SuspendLayout();
            this.tabRules.SuspendLayout();
            this.gbEditRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRuleNr)).BeginInit();
            this.tabContactInfo.SuspendLayout();
            this.gbEditSupervisor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSupervisorID)).BeginInit();
            this.gbEditTenant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTenantID)).BeginInit();
            this.tabManageReports.SuspendLayout();
            this.gbReport.SuspendLayout();
            this.tabAssignTasks.SuspendLayout();
            this.gbMakeAnnouncement.SuspendLayout();
            this.gbAssignTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSupervisor
            // 
            this.tabControlSupervisor.Controls.Add(this.tabRules);
            this.tabControlSupervisor.Controls.Add(this.tabContactInfo);
            this.tabControlSupervisor.Controls.Add(this.tabManageReports);
            this.tabControlSupervisor.Controls.Add(this.tabAssignTasks);
            this.tabControlSupervisor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlSupervisor.Location = new System.Drawing.Point(14, 117);
            this.tabControlSupervisor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlSupervisor.Name = "tabControlSupervisor";
            this.tabControlSupervisor.Padding = new System.Drawing.Point(67, 3);
            this.tabControlSupervisor.SelectedIndex = 0;
            this.tabControlSupervisor.Size = new System.Drawing.Size(1037, 686);
            this.tabControlSupervisor.TabIndex = 3;
            // 
            // tabRules
            // 
            this.tabRules.Controls.Add(this.gbEditRules);
            this.tabRules.Controls.Add(this.lblHouseRules);
            this.tabRules.Controls.Add(this.lbRules);
            this.tabRules.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabRules.Location = new System.Drawing.Point(4, 37);
            this.tabRules.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabRules.Name = "tabRules";
            this.tabRules.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabRules.Size = new System.Drawing.Size(1029, 645);
            this.tabRules.TabIndex = 0;
            this.tabRules.Text = "Rules";
            this.tabRules.UseVisualStyleBackColor = true;
            // 
            // gbEditRules
            // 
            this.gbEditRules.Controls.Add(this.btnSubmitChanges);
            this.gbEditRules.Controls.Add(this.btnEditSelectedRule);
            this.gbEditRules.Controls.Add(this.numRuleNr);
            this.gbEditRules.Controls.Add(this.lblRuleToEdit);
            this.gbEditRules.Controls.Add(this.btnAddRule);
            this.gbEditRules.Controls.Add(this.tbRule);
            this.gbEditRules.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbEditRules.Location = new System.Drawing.Point(582, 59);
            this.gbEditRules.Name = "gbEditRules";
            this.gbEditRules.Size = new System.Drawing.Size(415, 410);
            this.gbEditRules.TabIndex = 6;
            this.gbEditRules.TabStop = false;
            this.gbEditRules.Text = "Edit Rules Set";
            // 
            // btnSubmitChanges
            // 
            this.btnSubmitChanges.Location = new System.Drawing.Point(16, 341);
            this.btnSubmitChanges.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmitChanges.Name = "btnSubmitChanges";
            this.btnSubmitChanges.Size = new System.Drawing.Size(164, 45);
            this.btnSubmitChanges.TabIndex = 6;
            this.btnSubmitChanges.Text = "Submit changes";
            this.btnSubmitChanges.UseVisualStyleBackColor = true;
            this.btnSubmitChanges.Click += new System.EventHandler(this.btnSubmitChanges_Click);
            // 
            // btnEditSelectedRule
            // 
            this.btnEditSelectedRule.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditSelectedRule.Location = new System.Drawing.Point(124, 88);
            this.btnEditSelectedRule.Name = "btnEditSelectedRule";
            this.btnEditSelectedRule.Size = new System.Drawing.Size(171, 33);
            this.btnEditSelectedRule.TabIndex = 5;
            this.btnEditSelectedRule.Text = "Edit selected rule";
            this.btnEditSelectedRule.UseVisualStyleBackColor = true;
            // 
            // numRuleNr
            // 
            this.numRuleNr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numRuleNr.Location = new System.Drawing.Point(124, 50);
            this.numRuleNr.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.numRuleNr.Name = "numRuleNr";
            this.numRuleNr.Size = new System.Drawing.Size(171, 30);
            this.numRuleNr.TabIndex = 4;
            // 
            // lblRuleToEdit
            // 
            this.lblRuleToEdit.AutoSize = true;
            this.lblRuleToEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRuleToEdit.Location = new System.Drawing.Point(16, 52);
            this.lblRuleToEdit.Name = "lblRuleToEdit";
            this.lblRuleToEdit.Size = new System.Drawing.Size(102, 23);
            this.lblRuleToEdit.TabIndex = 3;
            this.lblRuleToEdit.Text = "Rule to edit:";
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(233, 341);
            this.btnAddRule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(164, 45);
            this.btnAddRule.TabIndex = 2;
            this.btnAddRule.Text = "Add Rule";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.addNewRule_Click);
            // 
            // tbRule
            // 
            this.tbRule.Location = new System.Drawing.Point(16, 138);
            this.tbRule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbRule.Name = "tbRule";
            this.tbRule.Size = new System.Drawing.Size(381, 181);
            this.tbRule.TabIndex = 3;
            this.tbRule.Text = "";
            // 
            // lblHouseRules
            // 
            this.lblHouseRules.AutoSize = true;
            this.lblHouseRules.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHouseRules.Location = new System.Drawing.Point(24, 24);
            this.lblHouseRules.Name = "lblHouseRules";
            this.lblHouseRules.Size = new System.Drawing.Size(155, 32);
            this.lblHouseRules.TabIndex = 5;
            this.lblHouseRules.Text = "House Rules";
            // 
            // lbRules
            // 
            this.lbRules.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRules.FormattingEnabled = true;
            this.lbRules.ItemHeight = 23;
            this.lbRules.Location = new System.Drawing.Point(24, 74);
            this.lbRules.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(525, 487);
            this.lbRules.TabIndex = 0;
            // 
            // tabContactInfo
            // 
            this.tabContactInfo.Controls.Add(this.gbEditSupervisor);
            this.tabContactInfo.Controls.Add(this.gbEditTenant);
            this.tabContactInfo.Controls.Add(this.lbSupervisorsInfo);
            this.tabContactInfo.Controls.Add(this.lblSupervisorContactInfo);
            this.tabContactInfo.Controls.Add(this.lblTenantsContactInfo);
            this.tabContactInfo.Controls.Add(this.lbTenantsInfo);
            this.tabContactInfo.Location = new System.Drawing.Point(4, 37);
            this.tabContactInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabContactInfo.Name = "tabContactInfo";
            this.tabContactInfo.Size = new System.Drawing.Size(1029, 645);
            this.tabContactInfo.TabIndex = 3;
            this.tabContactInfo.Text = "Contact Info";
            this.tabContactInfo.UseVisualStyleBackColor = true;
            // 
            // gbEditSupervisor
            // 
            this.gbEditSupervisor.Controls.Add(this.btnAddSupervisor);
            this.gbEditSupervisor.Controls.Add(this.btnSubmitChangesSupervisor);
            this.gbEditSupervisor.Controls.Add(this.tbSupervisorPhone);
            this.gbEditSupervisor.Controls.Add(this.tbSupervisorEmail);
            this.gbEditSupervisor.Controls.Add(this.lblSupervisorPhone);
            this.gbEditSupervisor.Controls.Add(this.lblSupervisorEmail);
            this.gbEditSupervisor.Controls.Add(this.tbSupervisorName);
            this.gbEditSupervisor.Controls.Add(this.lblSupervisorName);
            this.gbEditSupervisor.Controls.Add(this.numSupervisorID);
            this.gbEditSupervisor.Controls.Add(this.lblSupervisorToEdit);
            this.gbEditSupervisor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbEditSupervisor.Location = new System.Drawing.Point(582, 379);
            this.gbEditSupervisor.Name = "gbEditSupervisor";
            this.gbEditSupervisor.Size = new System.Drawing.Size(416, 242);
            this.gbEditSupervisor.TabIndex = 14;
            this.gbEditSupervisor.TabStop = false;
            this.gbEditSupervisor.Text = "Edit supervisor ";
            // 
            // btnAddSupervisor
            // 
            this.btnAddSupervisor.Location = new System.Drawing.Point(231, 195);
            this.btnAddSupervisor.Name = "btnAddSupervisor";
            this.btnAddSupervisor.Size = new System.Drawing.Size(164, 39);
            this.btnAddSupervisor.TabIndex = 16;
            this.btnAddSupervisor.Text = "Add supervisor";
            this.btnAddSupervisor.UseVisualStyleBackColor = true;
            // 
            // btnSubmitChangesSupervisor
            // 
            this.btnSubmitChangesSupervisor.Location = new System.Drawing.Point(20, 195);
            this.btnSubmitChangesSupervisor.Name = "btnSubmitChangesSupervisor";
            this.btnSubmitChangesSupervisor.Size = new System.Drawing.Size(164, 39);
            this.btnSubmitChangesSupervisor.TabIndex = 15;
            this.btnSubmitChangesSupervisor.Text = "Submit changes";
            this.btnSubmitChangesSupervisor.UseVisualStyleBackColor = true;
            // 
            // tbSupervisorPhone
            // 
            this.tbSupervisorPhone.Location = new System.Drawing.Point(165, 148);
            this.tbSupervisorPhone.Name = "tbSupervisorPhone";
            this.tbSupervisorPhone.Size = new System.Drawing.Size(171, 30);
            this.tbSupervisorPhone.TabIndex = 13;
            // 
            // tbSupervisorEmail
            // 
            this.tbSupervisorEmail.Location = new System.Drawing.Point(165, 108);
            this.tbSupervisorEmail.Name = "tbSupervisorEmail";
            this.tbSupervisorEmail.Size = new System.Drawing.Size(171, 30);
            this.tbSupervisorEmail.TabIndex = 12;
            // 
            // lblSupervisorPhone
            // 
            this.lblSupervisorPhone.AutoSize = true;
            this.lblSupervisorPhone.Location = new System.Drawing.Point(96, 151);
            this.lblSupervisorPhone.Name = "lblSupervisorPhone";
            this.lblSupervisorPhone.Size = new System.Drawing.Size(63, 23);
            this.lblSupervisorPhone.TabIndex = 10;
            this.lblSupervisorPhone.Text = "Phone:";
            // 
            // lblSupervisorEmail
            // 
            this.lblSupervisorEmail.AutoSize = true;
            this.lblSupervisorEmail.Location = new System.Drawing.Point(104, 111);
            this.lblSupervisorEmail.Name = "lblSupervisorEmail";
            this.lblSupervisorEmail.Size = new System.Drawing.Size(55, 23);
            this.lblSupervisorEmail.TabIndex = 9;
            this.lblSupervisorEmail.Text = "Email:";
            // 
            // tbSupervisorName
            // 
            this.tbSupervisorName.Location = new System.Drawing.Point(165, 66);
            this.tbSupervisorName.Name = "tbSupervisorName";
            this.tbSupervisorName.Size = new System.Drawing.Size(171, 30);
            this.tbSupervisorName.TabIndex = 8;
            // 
            // lblSupervisorName
            // 
            this.lblSupervisorName.AutoSize = true;
            this.lblSupervisorName.Location = new System.Drawing.Point(99, 69);
            this.lblSupervisorName.Name = "lblSupervisorName";
            this.lblSupervisorName.Size = new System.Drawing.Size(60, 23);
            this.lblSupervisorName.TabIndex = 7;
            this.lblSupervisorName.Text = "Name:";
            // 
            // numSupervisorID
            // 
            this.numSupervisorID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numSupervisorID.Location = new System.Drawing.Point(165, 24);
            this.numSupervisorID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.numSupervisorID.Name = "numSupervisorID";
            this.numSupervisorID.Size = new System.Drawing.Size(171, 30);
            this.numSupervisorID.TabIndex = 6;
            // 
            // lblSupervisorToEdit
            // 
            this.lblSupervisorToEdit.AutoSize = true;
            this.lblSupervisorToEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSupervisorToEdit.Location = new System.Drawing.Point(11, 26);
            this.lblSupervisorToEdit.Name = "lblSupervisorToEdit";
            this.lblSupervisorToEdit.Size = new System.Drawing.Size(148, 23);
            this.lblSupervisorToEdit.TabIndex = 5;
            this.lblSupervisorToEdit.Text = "Supervisor to edit:";
            // 
            // gbEditTenant
            // 
            this.gbEditTenant.Controls.Add(this.btnAddTenant);
            this.gbEditTenant.Controls.Add(this.btnSubmitChangesTenant);
            this.gbEditTenant.Controls.Add(this.tbRoomNumber);
            this.gbEditTenant.Controls.Add(this.tbTenantPhone);
            this.gbEditTenant.Controls.Add(this.tbTenantEmail);
            this.gbEditTenant.Controls.Add(this.lblRoomNr);
            this.gbEditTenant.Controls.Add(this.lblTenantPhone);
            this.gbEditTenant.Controls.Add(this.lblTenantEmail);
            this.gbEditTenant.Controls.Add(this.tbTenantName);
            this.gbEditTenant.Controls.Add(this.lblTenantName);
            this.gbEditTenant.Controls.Add(this.numTenantID);
            this.gbEditTenant.Controls.Add(this.lblTenantToEdit);
            this.gbEditTenant.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbEditTenant.Location = new System.Drawing.Point(582, 38);
            this.gbEditTenant.Name = "gbEditTenant";
            this.gbEditTenant.Size = new System.Drawing.Size(416, 296);
            this.gbEditTenant.TabIndex = 13;
            this.gbEditTenant.TabStop = false;
            this.gbEditTenant.Text = "Edit tenant ";
            // 
            // btnAddTenant
            // 
            this.btnAddTenant.Location = new System.Drawing.Point(231, 241);
            this.btnAddTenant.Name = "btnAddTenant";
            this.btnAddTenant.Size = new System.Drawing.Size(164, 39);
            this.btnAddTenant.TabIndex = 16;
            this.btnAddTenant.Text = "Add tenant";
            this.btnAddTenant.UseVisualStyleBackColor = true;
            this.btnAddTenant.Click += new System.EventHandler(this.btnAddTenant_Click);
            // 
            // btnSubmitChangesTenant
            // 
            this.btnSubmitChangesTenant.Location = new System.Drawing.Point(20, 241);
            this.btnSubmitChangesTenant.Name = "btnSubmitChangesTenant";
            this.btnSubmitChangesTenant.Size = new System.Drawing.Size(164, 39);
            this.btnSubmitChangesTenant.TabIndex = 15;
            this.btnSubmitChangesTenant.Text = "Submit changes";
            this.btnSubmitChangesTenant.UseVisualStyleBackColor = true;
            // 
            // tbRoomNumber
            // 
            this.tbRoomNumber.Location = new System.Drawing.Point(137, 192);
            this.tbRoomNumber.Name = "tbRoomNumber";
            this.tbRoomNumber.Size = new System.Drawing.Size(81, 30);
            this.tbRoomNumber.TabIndex = 14;
            // 
            // tbTenantPhone
            // 
            this.tbTenantPhone.Location = new System.Drawing.Point(137, 155);
            this.tbTenantPhone.Name = "tbTenantPhone";
            this.tbTenantPhone.Size = new System.Drawing.Size(171, 30);
            this.tbTenantPhone.TabIndex = 13;
            // 
            // tbTenantEmail
            // 
            this.tbTenantEmail.Location = new System.Drawing.Point(137, 115);
            this.tbTenantEmail.Name = "tbTenantEmail";
            this.tbTenantEmail.Size = new System.Drawing.Size(171, 30);
            this.tbTenantEmail.TabIndex = 12;
            // 
            // lblRoomNr
            // 
            this.lblRoomNr.AutoSize = true;
            this.lblRoomNr.Location = new System.Drawing.Point(47, 195);
            this.lblRoomNr.Name = "lblRoomNr";
            this.lblRoomNr.Size = new System.Drawing.Size(84, 23);
            this.lblRoomNr.TabIndex = 11;
            this.lblRoomNr.Text = "Room no:";
            // 
            // lblTenantPhone
            // 
            this.lblTenantPhone.AutoSize = true;
            this.lblTenantPhone.Location = new System.Drawing.Point(68, 158);
            this.lblTenantPhone.Name = "lblTenantPhone";
            this.lblTenantPhone.Size = new System.Drawing.Size(63, 23);
            this.lblTenantPhone.TabIndex = 10;
            this.lblTenantPhone.Text = "Phone:";
            // 
            // lblTenantEmail
            // 
            this.lblTenantEmail.AutoSize = true;
            this.lblTenantEmail.Location = new System.Drawing.Point(76, 118);
            this.lblTenantEmail.Name = "lblTenantEmail";
            this.lblTenantEmail.Size = new System.Drawing.Size(55, 23);
            this.lblTenantEmail.TabIndex = 9;
            this.lblTenantEmail.Text = "Email:";
            // 
            // tbTenantName
            // 
            this.tbTenantName.Location = new System.Drawing.Point(137, 73);
            this.tbTenantName.Name = "tbTenantName";
            this.tbTenantName.Size = new System.Drawing.Size(171, 30);
            this.tbTenantName.TabIndex = 8;
            // 
            // lblTenantName
            // 
            this.lblTenantName.AutoSize = true;
            this.lblTenantName.Location = new System.Drawing.Point(71, 76);
            this.lblTenantName.Name = "lblTenantName";
            this.lblTenantName.Size = new System.Drawing.Size(60, 23);
            this.lblTenantName.TabIndex = 7;
            this.lblTenantName.Text = "Name:";
            // 
            // numTenantID
            // 
            this.numTenantID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numTenantID.Location = new System.Drawing.Point(137, 31);
            this.numTenantID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.numTenantID.Name = "numTenantID";
            this.numTenantID.Size = new System.Drawing.Size(171, 30);
            this.numTenantID.TabIndex = 6;
            // 
            // lblTenantToEdit
            // 
            this.lblTenantToEdit.AutoSize = true;
            this.lblTenantToEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTenantToEdit.Location = new System.Drawing.Point(11, 33);
            this.lblTenantToEdit.Name = "lblTenantToEdit";
            this.lblTenantToEdit.Size = new System.Drawing.Size(120, 23);
            this.lblTenantToEdit.TabIndex = 5;
            this.lblTenantToEdit.Text = "Tenant to edit:";
            // 
            // lbSupervisorsInfo
            // 
            this.lbSupervisorsInfo.FormattingEnabled = true;
            this.lbSupervisorsInfo.ItemHeight = 28;
            this.lbSupervisorsInfo.Location = new System.Drawing.Point(14, 393);
            this.lbSupervisorsInfo.Name = "lbSupervisorsInfo";
            this.lbSupervisorsInfo.Size = new System.Drawing.Size(530, 228);
            this.lbSupervisorsInfo.TabIndex = 12;
            // 
            // lblSupervisorContactInfo
            // 
            this.lblSupervisorContactInfo.AutoSize = true;
            this.lblSupervisorContactInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSupervisorContactInfo.Location = new System.Drawing.Point(14, 362);
            this.lblSupervisorContactInfo.Name = "lblSupervisorContactInfo";
            this.lblSupervisorContactInfo.Size = new System.Drawing.Size(257, 28);
            this.lblSupervisorContactInfo.TabIndex = 11;
            this.lblSupervisorContactInfo.Text = "Supervisor(s) contact info";
            // 
            // lblTenantsContactInfo
            // 
            this.lblTenantsContactInfo.AutoSize = true;
            this.lblTenantsContactInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTenantsContactInfo.Location = new System.Drawing.Point(14, 19);
            this.lblTenantsContactInfo.Name = "lblTenantsContactInfo";
            this.lblTenantsContactInfo.Size = new System.Drawing.Size(206, 28);
            this.lblTenantsContactInfo.TabIndex = 10;
            this.lblTenantsContactInfo.Text = "Tenants contact info";
            // 
            // lbTenantsInfo
            // 
            this.lbTenantsInfo.FormattingEnabled = true;
            this.lbTenantsInfo.ItemHeight = 28;
            this.lbTenantsInfo.Location = new System.Drawing.Point(14, 50);
            this.lbTenantsInfo.Name = "lbTenantsInfo";
            this.lbTenantsInfo.Size = new System.Drawing.Size(530, 284);
            this.lbTenantsInfo.TabIndex = 9;
            // 
            // tabManageReports
            // 
            this.tabManageReports.Controls.Add(this.gbReport);
            this.tabManageReports.Controls.Add(this.tbSubmittedReports);
            this.tabManageReports.Controls.Add(this.lblSubmittedReports);
            this.tabManageReports.Location = new System.Drawing.Point(4, 37);
            this.tabManageReports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabManageReports.Name = "tabManageReports";
            this.tabManageReports.Size = new System.Drawing.Size(1029, 645);
            this.tabManageReports.TabIndex = 5;
            this.tabManageReports.Text = "Manage Reports";
            this.tabManageReports.UseVisualStyleBackColor = true;
            // 
            // gbReport
            // 
            this.gbReport.Controls.Add(this.btnSendWarning);
            this.gbReport.Controls.Add(this.cbTenantToSendWarning);
            this.gbReport.Controls.Add(this.lblSelectTenant);
            this.gbReport.Controls.Add(this.tbTenantReportAdressedTo);
            this.gbReport.Controls.Add(this.lblPersonAdressedTo);
            this.gbReport.Controls.Add(this.tbReportDescription);
            this.gbReport.Controls.Add(this.lblReportDescription);
            this.gbReport.Location = new System.Drawing.Point(475, 55);
            this.gbReport.Name = "gbReport";
            this.gbReport.Size = new System.Drawing.Size(507, 439);
            this.gbReport.TabIndex = 6;
            this.gbReport.TabStop = false;
            this.gbReport.Text = "Report";
            // 
            // btnSendWarning
            // 
            this.btnSendWarning.Location = new System.Drawing.Point(180, 367);
            this.btnSendWarning.Name = "btnSendWarning";
            this.btnSendWarning.Size = new System.Drawing.Size(288, 49);
            this.btnSendWarning.TabIndex = 6;
            this.btnSendWarning.Text = "Send warning";
            this.btnSendWarning.UseVisualStyleBackColor = true;
            // 
            // cbTenantToSendWarning
            // 
            this.cbTenantToSendWarning.FormattingEnabled = true;
            this.cbTenantToSendWarning.Location = new System.Drawing.Point(180, 307);
            this.cbTenantToSendWarning.Name = "cbTenantToSendWarning";
            this.cbTenantToSendWarning.Size = new System.Drawing.Size(288, 36);
            this.cbTenantToSendWarning.TabIndex = 5;
            // 
            // lblSelectTenant
            // 
            this.lblSelectTenant.AutoSize = true;
            this.lblSelectTenant.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectTenant.Location = new System.Drawing.Point(56, 315);
            this.lblSelectTenant.Name = "lblSelectTenant";
            this.lblSelectTenant.Size = new System.Drawing.Size(114, 23);
            this.lblSelectTenant.TabIndex = 4;
            this.lblSelectTenant.Text = "Select tenant:";
            // 
            // tbTenantReportAdressedTo
            // 
            this.tbTenantReportAdressedTo.Location = new System.Drawing.Point(180, 231);
            this.tbTenantReportAdressedTo.Name = "tbTenantReportAdressedTo";
            this.tbTenantReportAdressedTo.Size = new System.Drawing.Size(288, 34);
            this.tbTenantReportAdressedTo.TabIndex = 3;
            // 
            // lblPersonAdressedTo
            // 
            this.lblPersonAdressedTo.AutoSize = true;
            this.lblPersonAdressedTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPersonAdressedTo.Location = new System.Drawing.Point(16, 239);
            this.lblPersonAdressedTo.Name = "lblPersonAdressedTo";
            this.lblPersonAdressedTo.Size = new System.Drawing.Size(158, 23);
            this.lblPersonAdressedTo.TabIndex = 2;
            this.lblPersonAdressedTo.Text = "Person adressed to:";
            // 
            // tbReportDescription
            // 
            this.tbReportDescription.Location = new System.Drawing.Point(16, 67);
            this.tbReportDescription.Multiline = true;
            this.tbReportDescription.Name = "tbReportDescription";
            this.tbReportDescription.Size = new System.Drawing.Size(452, 152);
            this.tbReportDescription.TabIndex = 1;
            // 
            // lblReportDescription
            // 
            this.lblReportDescription.AutoSize = true;
            this.lblReportDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReportDescription.Location = new System.Drawing.Point(16, 41);
            this.lblReportDescription.Name = "lblReportDescription";
            this.lblReportDescription.Size = new System.Drawing.Size(154, 23);
            this.lblReportDescription.TabIndex = 0;
            this.lblReportDescription.Text = "Report description:";
            // 
            // tbSubmittedReports
            // 
            this.tbSubmittedReports.Location = new System.Drawing.Point(34, 69);
            this.tbSubmittedReports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSubmittedReports.Name = "tbSubmittedReports";
            this.tbSubmittedReports.Size = new System.Drawing.Size(382, 425);
            this.tbSubmittedReports.TabIndex = 5;
            this.tbSubmittedReports.Text = "";
            // 
            // lblSubmittedReports
            // 
            this.lblSubmittedReports.AutoSize = true;
            this.lblSubmittedReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubmittedReports.Location = new System.Drawing.Point(34, 27);
            this.lblSubmittedReports.Name = "lblSubmittedReports";
            this.lblSubmittedReports.Size = new System.Drawing.Size(185, 28);
            this.lblSubmittedReports.TabIndex = 0;
            this.lblSubmittedReports.Text = "Submitted reports";
            // 
            // tabAssignTasks
            // 
            this.tabAssignTasks.Controls.Add(this.lbEvents);
            this.tabAssignTasks.Controls.Add(this.gbMakeAnnouncement);
            this.tabAssignTasks.Controls.Add(this.gbAssignTask);
            this.tabAssignTasks.Controls.Add(this.monthCalendarSupervisor);
            this.tabAssignTasks.Location = new System.Drawing.Point(4, 37);
            this.tabAssignTasks.Name = "tabAssignTasks";
            this.tabAssignTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabAssignTasks.Size = new System.Drawing.Size(1029, 645);
            this.tabAssignTasks.TabIndex = 6;
            this.tabAssignTasks.Text = "Assign tasks";
            this.tabAssignTasks.UseVisualStyleBackColor = true;
            // 
            // lbEvents
            // 
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.ItemHeight = 28;
            this.lbEvents.Location = new System.Drawing.Point(388, 58);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(612, 200);
            this.lbEvents.TabIndex = 4;
            // 
            // gbMakeAnnouncement
            // 
            this.gbMakeAnnouncement.Controls.Add(this.btnSubmitAnnouncement);
            this.gbMakeAnnouncement.Controls.Add(this.tbAnnouncementDescription);
            this.gbMakeAnnouncement.Controls.Add(this.lblAnnouncementDescription);
            this.gbMakeAnnouncement.Controls.Add(this.tbAnnouncementTitle);
            this.gbMakeAnnouncement.Controls.Add(this.lblAnnouncementTitle);
            this.gbMakeAnnouncement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbMakeAnnouncement.Location = new System.Drawing.Point(564, 310);
            this.gbMakeAnnouncement.Name = "gbMakeAnnouncement";
            this.gbMakeAnnouncement.Size = new System.Drawing.Size(436, 309);
            this.gbMakeAnnouncement.TabIndex = 3;
            this.gbMakeAnnouncement.TabStop = false;
            this.gbMakeAnnouncement.Text = "Make announcement";
            // 
            // btnSubmitAnnouncement
            // 
            this.btnSubmitAnnouncement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitAnnouncement.Location = new System.Drawing.Point(114, 256);
            this.btnSubmitAnnouncement.Name = "btnSubmitAnnouncement";
            this.btnSubmitAnnouncement.Size = new System.Drawing.Size(203, 37);
            this.btnSubmitAnnouncement.TabIndex = 11;
            this.btnSubmitAnnouncement.Text = "Submit announcement";
            this.btnSubmitAnnouncement.UseVisualStyleBackColor = true;
            // 
            // tbAnnouncementDescription
            // 
            this.tbAnnouncementDescription.Location = new System.Drawing.Point(20, 133);
            this.tbAnnouncementDescription.Multiline = true;
            this.tbAnnouncementDescription.Name = "tbAnnouncementDescription";
            this.tbAnnouncementDescription.Size = new System.Drawing.Size(387, 103);
            this.tbAnnouncementDescription.TabIndex = 7;
            // 
            // lblAnnouncementDescription
            // 
            this.lblAnnouncementDescription.AutoSize = true;
            this.lblAnnouncementDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnnouncementDescription.Location = new System.Drawing.Point(20, 93);
            this.lblAnnouncementDescription.Name = "lblAnnouncementDescription";
            this.lblAnnouncementDescription.Size = new System.Drawing.Size(100, 23);
            this.lblAnnouncementDescription.TabIndex = 6;
            this.lblAnnouncementDescription.Text = "Description:";
            // 
            // tbAnnouncementTitle
            // 
            this.tbAnnouncementTitle.Location = new System.Drawing.Point(81, 39);
            this.tbAnnouncementTitle.Name = "tbAnnouncementTitle";
            this.tbAnnouncementTitle.Size = new System.Drawing.Size(217, 34);
            this.tbAnnouncementTitle.TabIndex = 5;
            // 
            // lblAnnouncementTitle
            // 
            this.lblAnnouncementTitle.AutoSize = true;
            this.lblAnnouncementTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnnouncementTitle.Location = new System.Drawing.Point(20, 42);
            this.lblAnnouncementTitle.Name = "lblAnnouncementTitle";
            this.lblAnnouncementTitle.Size = new System.Drawing.Size(46, 23);
            this.lblAnnouncementTitle.TabIndex = 4;
            this.lblAnnouncementTitle.Text = "Title:";
            // 
            // gbAssignTask
            // 
            this.gbAssignTask.Controls.Add(this.btnSubmitTask);
            this.gbAssignTask.Controls.Add(this.cbTakeOutTheTrash);
            this.gbAssignTask.Controls.Add(this.cbCleanTheLivingRoom);
            this.gbAssignTask.Controls.Add(this.cbCleanTheKitchen);
            this.gbAssignTask.Controls.Add(this.cbCleanTheStarirs);
            this.gbAssignTask.Controls.Add(this.cbCleanBathroom2);
            this.gbAssignTask.Controls.Add(this.cbCleanBathroom1);
            this.gbAssignTask.Controls.Add(this.lblSelectTask);
            this.gbAssignTask.Controls.Add(this.cbSelectTenantToAssignTask);
            this.gbAssignTask.Controls.Add(this.lblSelectTenantAssignTask);
            this.gbAssignTask.Location = new System.Drawing.Point(38, 310);
            this.gbAssignTask.Name = "gbAssignTask";
            this.gbAssignTask.Size = new System.Drawing.Size(488, 309);
            this.gbAssignTask.TabIndex = 2;
            this.gbAssignTask.TabStop = false;
            this.gbAssignTask.Text = "Assign task";
            // 
            // btnSubmitTask
            // 
            this.btnSubmitTask.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitTask.Location = new System.Drawing.Point(135, 256);
            this.btnSubmitTask.Name = "btnSubmitTask";
            this.btnSubmitTask.Size = new System.Drawing.Size(174, 37);
            this.btnSubmitTask.TabIndex = 10;
            this.btnSubmitTask.Text = "Submit task";
            this.btnSubmitTask.UseVisualStyleBackColor = true;
            // 
            // cbTakeOutTheTrash
            // 
            this.cbTakeOutTheTrash.AutoSize = true;
            this.cbTakeOutTheTrash.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTakeOutTheTrash.Location = new System.Drawing.Point(277, 199);
            this.cbTakeOutTheTrash.Name = "cbTakeOutTheTrash";
            this.cbTakeOutTheTrash.Size = new System.Drawing.Size(169, 27);
            this.cbTakeOutTheTrash.TabIndex = 9;
            this.cbTakeOutTheTrash.Text = "Take out the trash";
            this.cbTakeOutTheTrash.UseVisualStyleBackColor = true;
            // 
            // cbCleanTheLivingRoom
            // 
            this.cbCleanTheLivingRoom.AutoSize = true;
            this.cbCleanTheLivingRoom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCleanTheLivingRoom.Location = new System.Drawing.Point(277, 133);
            this.cbCleanTheLivingRoom.Name = "cbCleanTheLivingRoom";
            this.cbCleanTheLivingRoom.Size = new System.Drawing.Size(196, 27);
            this.cbCleanTheLivingRoom.TabIndex = 8;
            this.cbCleanTheLivingRoom.Text = "Clean the living room";
            this.cbCleanTheLivingRoom.UseVisualStyleBackColor = true;
            // 
            // cbCleanTheKitchen
            // 
            this.cbCleanTheKitchen.AutoSize = true;
            this.cbCleanTheKitchen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCleanTheKitchen.Location = new System.Drawing.Point(277, 166);
            this.cbCleanTheKitchen.Name = "cbCleanTheKitchen";
            this.cbCleanTheKitchen.Size = new System.Drawing.Size(165, 27);
            this.cbCleanTheKitchen.TabIndex = 7;
            this.cbCleanTheKitchen.Text = "Clean the kitchen";
            this.cbCleanTheKitchen.UseVisualStyleBackColor = true;
            // 
            // cbCleanTheStarirs
            // 
            this.cbCleanTheStarirs.AutoSize = true;
            this.cbCleanTheStarirs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCleanTheStarirs.Location = new System.Drawing.Point(15, 199);
            this.cbCleanTheStarirs.Name = "cbCleanTheStarirs";
            this.cbCleanTheStarirs.Size = new System.Drawing.Size(149, 27);
            this.cbCleanTheStarirs.TabIndex = 6;
            this.cbCleanTheStarirs.Text = "Clean the stairs";
            this.cbCleanTheStarirs.UseVisualStyleBackColor = true;
            // 
            // cbCleanBathroom2
            // 
            this.cbCleanBathroom2.AutoSize = true;
            this.cbCleanBathroom2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCleanBathroom2.Location = new System.Drawing.Point(15, 166);
            this.cbCleanBathroom2.Name = "cbCleanBathroom2";
            this.cbCleanBathroom2.Size = new System.Drawing.Size(170, 27);
            this.cbCleanBathroom2.TabIndex = 5;
            this.cbCleanBathroom2.Text = "Clean bathroom 2";
            this.cbCleanBathroom2.UseVisualStyleBackColor = true;
            // 
            // cbCleanBathroom1
            // 
            this.cbCleanBathroom1.AutoSize = true;
            this.cbCleanBathroom1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCleanBathroom1.Location = new System.Drawing.Point(15, 133);
            this.cbCleanBathroom1.Name = "cbCleanBathroom1";
            this.cbCleanBathroom1.Size = new System.Drawing.Size(170, 27);
            this.cbCleanBathroom1.TabIndex = 4;
            this.cbCleanBathroom1.Text = "Clean bathroom 1";
            this.cbCleanBathroom1.UseVisualStyleBackColor = true;
            // 
            // lblSelectTask
            // 
            this.lblSelectTask.AutoSize = true;
            this.lblSelectTask.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectTask.Location = new System.Drawing.Point(15, 93);
            this.lblSelectTask.Name = "lblSelectTask";
            this.lblSelectTask.Size = new System.Drawing.Size(94, 23);
            this.lblSelectTask.TabIndex = 3;
            this.lblSelectTask.Text = "Select task:";
            // 
            // cbSelectTenantToAssignTask
            // 
            this.cbSelectTenantToAssignTask.FormattingEnabled = true;
            this.cbSelectTenantToAssignTask.Location = new System.Drawing.Point(135, 33);
            this.cbSelectTenantToAssignTask.Name = "cbSelectTenantToAssignTask";
            this.cbSelectTenantToAssignTask.Size = new System.Drawing.Size(269, 36);
            this.cbSelectTenantToAssignTask.TabIndex = 2;
            // 
            // lblSelectTenantAssignTask
            // 
            this.lblSelectTenantAssignTask.AutoSize = true;
            this.lblSelectTenantAssignTask.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectTenantAssignTask.Location = new System.Drawing.Point(15, 41);
            this.lblSelectTenantAssignTask.Name = "lblSelectTenantAssignTask";
            this.lblSelectTenantAssignTask.Size = new System.Drawing.Size(114, 23);
            this.lblSelectTenantAssignTask.TabIndex = 1;
            this.lblSelectTenantAssignTask.Text = "Select tenant:";
            // 
            // monthCalendarSupervisor
            // 
            this.monthCalendarSupervisor.Location = new System.Drawing.Point(38, 51);
            this.monthCalendarSupervisor.Name = "monthCalendarSupervisor";
            this.monthCalendarSupervisor.TabIndex = 0;
            // 
            // lblStudentHouseBV
            // 
            this.lblStudentHouseBV.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblStudentHouseBV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudentHouseBV.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudentHouseBV.Image = global::Housing_Project.Properties.Resources.house;
            this.lblStudentHouseBV.Location = new System.Drawing.Point(14, 20);
            this.lblStudentHouseBV.Name = "lblStudentHouseBV";
            this.lblStudentHouseBV.Size = new System.Drawing.Size(1033, 77);
            this.lblStudentHouseBV.TabIndex = 4;
            this.lblStudentHouseBV.Text = "Student House BV";
            this.lblStudentHouseBV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 810);
            this.Controls.Add(this.lblStudentHouseBV);
            this.Controls.Add(this.tabControlSupervisor);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSupervisor";
            this.Text = "Supervisor";
            this.tabControlSupervisor.ResumeLayout(false);
            this.tabRules.ResumeLayout(false);
            this.tabRules.PerformLayout();
            this.gbEditRules.ResumeLayout(false);
            this.gbEditRules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRuleNr)).EndInit();
            this.tabContactInfo.ResumeLayout(false);
            this.tabContactInfo.PerformLayout();
            this.gbEditSupervisor.ResumeLayout(false);
            this.gbEditSupervisor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSupervisorID)).EndInit();
            this.gbEditTenant.ResumeLayout(false);
            this.gbEditTenant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTenantID)).EndInit();
            this.tabManageReports.ResumeLayout(false);
            this.tabManageReports.PerformLayout();
            this.gbReport.ResumeLayout(false);
            this.gbReport.PerformLayout();
            this.tabAssignTasks.ResumeLayout(false);
            this.gbMakeAnnouncement.ResumeLayout(false);
            this.gbMakeAnnouncement.PerformLayout();
            this.gbAssignTask.ResumeLayout(false);
            this.gbAssignTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl tabControlSupervisor;
        private TabPage tabRules;
        private TabPage tabContactInfo;
        private TabPage tabManageReports;
        private RichTextBox tbSubmittedReports;
        private Label lblSubmittedReports;
        private RichTextBox tbRule;
        private Button btnAddRule;
        private ListBox lbRules;
        private Label lblStudentHouseBV;
        private Label lblHouseRules;
        private GroupBox gbEditRules;
        private Button btnSubmitChanges;
        private Button btnEditSelectedRule;
        private NumericUpDown numRuleNr;
        private Label lblRuleToEdit;
        private ListBox lbTenantsInfo;
        private Label lblTenantsContactInfo;
        private Label lblSupervisorContactInfo;
        private GroupBox gbEditTenant;
        private Label lblTenantName;
        private NumericUpDown numTenantID;
        private Label lblTenantToEdit;
        private ListBox lbSupervisorsInfo;
        private GroupBox gbEditSupervisor;
        private Button btnAddSupervisor;
        private Button btnSubmitChangesSupervisor;
        private TextBox tbSupervisorPhone;
        private TextBox tbSupervisorEmail;
        private Label lblSupervisorPhone;
        private Label lblSupervisorEmail;
        private TextBox tbSupervisorName;
        private Label lblSupervisorName;
        private NumericUpDown numSupervisorID;
        private Label lblSupervisorToEdit;
        private Button btnAddTenant;
        private Button btnSubmitChangesTenant;
        private TextBox tbRoomNumber;
        private TextBox tbTenantPhone;
        private TextBox tbTenantEmail;
        private Label lblRoomNr;
        private Label lblTenantPhone;
        private Label lblTenantEmail;
        private TextBox tbTenantName;
        private GroupBox gbReport;
        private Button btnSendWarning;
        private ComboBox cbTenantToSendWarning;
        private Label lblSelectTenant;
        private TextBox tbTenantReportAdressedTo;
        private Label lblPersonAdressedTo;
        private TextBox tbReportDescription;
        private Label lblReportDescription;
        private TabPage tabAssignTasks;
        private MonthCalendar monthCalendarSupervisor;
        private GroupBox gbAssignTask;
        private CheckBox cbTakeOutTheTrash;
        private CheckBox cbCleanTheLivingRoom;
        private CheckBox cbCleanTheKitchen;
        private CheckBox cbCleanTheStarirs;
        private CheckBox cbCleanBathroom2;
        private CheckBox cbCleanBathroom1;
        private Label lblSelectTask;
        private ComboBox cbSelectTenantToAssignTask;
        private Label lblSelectTenantAssignTask;
        private Button btnSubmitTask;
        private GroupBox gbMakeAnnouncement;
        private Button btnSubmitAnnouncement;
        private TextBox tbAnnouncementDescription;
        private Label lblAnnouncementDescription;
        private TextBox tbAnnouncementTitle;
        private Label lblAnnouncementTitle;
        private ListBox lbEvents;
    }
}