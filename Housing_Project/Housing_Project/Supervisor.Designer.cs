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
            this.lblPersonAdressedTo = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbtitle = new System.Windows.Forms.TextBox();
            this.tbadressedPerson = new System.Windows.Forms.TextBox();
            this.tbdescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roomNr = new System.Windows.Forms.TextBox();
            this.tabControlSupervisor.SuspendLayout();
            this.tabRules.SuspendLayout();
            this.gbEditRules.SuspendLayout();
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
            this.tabControlSupervisor.Location = new System.Drawing.Point(12, 88);
            this.tabControlSupervisor.Name = "tabControlSupervisor";
            this.tabControlSupervisor.Padding = new System.Drawing.Point(67, 3);
            this.tabControlSupervisor.SelectedIndex = 0;
            this.tabControlSupervisor.Size = new System.Drawing.Size(907, 514);
            this.tabControlSupervisor.TabIndex = 3;
            // 
            // tabRules
            // 
            this.tabRules.Controls.Add(this.gbEditRules);
            this.tabRules.Controls.Add(this.lblHouseRules);
            this.tabRules.Controls.Add(this.lbRules);
            this.tabRules.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabRules.Location = new System.Drawing.Point(4, 30);
            this.tabRules.Name = "tabRules";
            this.tabRules.Padding = new System.Windows.Forms.Padding(3);
            this.tabRules.Size = new System.Drawing.Size(899, 480);
            this.tabRules.TabIndex = 0;
            this.tabRules.Text = "Rules";
            this.tabRules.UseVisualStyleBackColor = true;
            // 
            // gbEditRules
            // 
            this.gbEditRules.Controls.Add(this.btnSubmitChanges);
            this.gbEditRules.Controls.Add(this.btnAddRule);
            this.gbEditRules.Controls.Add(this.tbRule);
            this.gbEditRules.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbEditRules.Location = new System.Drawing.Point(509, 44);
            this.gbEditRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEditRules.Name = "gbEditRules";
            this.gbEditRules.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEditRules.Size = new System.Drawing.Size(363, 308);
            this.gbEditRules.TabIndex = 6;
            this.gbEditRules.TabStop = false;
            this.gbEditRules.Text = "Edit Rules Set";
            // 
            // btnSubmitChanges
            // 
            this.btnSubmitChanges.Location = new System.Drawing.Point(14, 256);
            this.btnSubmitChanges.Name = "btnSubmitChanges";
            this.btnSubmitChanges.Size = new System.Drawing.Size(144, 34);
            this.btnSubmitChanges.TabIndex = 6;
            this.btnSubmitChanges.Text = "Submit changes";
            this.btnSubmitChanges.UseVisualStyleBackColor = true;
            this.btnSubmitChanges.Click += new System.EventHandler(this.btnSubmitChanges_Click);
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(204, 256);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(144, 34);
            this.btnAddRule.TabIndex = 2;
            this.btnAddRule.Text = "Add Rule";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.addNewRule_Click);
            // 
            // tbRule
            // 
            this.tbRule.Location = new System.Drawing.Point(14, 27);
            this.tbRule.Name = "tbRule";
            this.tbRule.Size = new System.Drawing.Size(334, 214);
            this.tbRule.TabIndex = 3;
            this.tbRule.Text = "";
            // 
            // lblHouseRules
            // 
            this.lblHouseRules.AutoSize = true;
            this.lblHouseRules.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHouseRules.Location = new System.Drawing.Point(21, 18);
            this.lblHouseRules.Name = "lblHouseRules";
            this.lblHouseRules.Size = new System.Drawing.Size(121, 25);
            this.lblHouseRules.TabIndex = 5;
            this.lblHouseRules.Text = "House Rules";
            // 
            // lbRules
            // 
            this.lbRules.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRules.FormattingEnabled = true;
            this.lbRules.ItemHeight = 17;
            this.lbRules.Location = new System.Drawing.Point(21, 56);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(460, 361);
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
            this.tabContactInfo.Location = new System.Drawing.Point(4, 30);
            this.tabContactInfo.Name = "tabContactInfo";
            this.tabContactInfo.Size = new System.Drawing.Size(899, 480);
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
            this.gbEditSupervisor.Location = new System.Drawing.Point(509, 284);
            this.gbEditSupervisor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEditSupervisor.Name = "gbEditSupervisor";
            this.gbEditSupervisor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEditSupervisor.Size = new System.Drawing.Size(364, 182);
            this.gbEditSupervisor.TabIndex = 14;
            this.gbEditSupervisor.TabStop = false;
            this.gbEditSupervisor.Text = "Edit supervisor ";
            // 
            // btnAddSupervisor
            // 
            this.btnAddSupervisor.Location = new System.Drawing.Point(202, 146);
            this.btnAddSupervisor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSupervisor.Name = "btnAddSupervisor";
            this.btnAddSupervisor.Size = new System.Drawing.Size(144, 29);
            this.btnAddSupervisor.TabIndex = 16;
            this.btnAddSupervisor.Text = "Add supervisor";
            this.btnAddSupervisor.UseVisualStyleBackColor = true;
            // 
            // btnSubmitChangesSupervisor
            // 
            this.btnSubmitChangesSupervisor.Location = new System.Drawing.Point(18, 146);
            this.btnSubmitChangesSupervisor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitChangesSupervisor.Name = "btnSubmitChangesSupervisor";
            this.btnSubmitChangesSupervisor.Size = new System.Drawing.Size(144, 29);
            this.btnSubmitChangesSupervisor.TabIndex = 15;
            this.btnSubmitChangesSupervisor.Text = "Submit changes";
            this.btnSubmitChangesSupervisor.UseVisualStyleBackColor = true;
            // 
            // tbSupervisorPhone
            // 
            this.tbSupervisorPhone.Location = new System.Drawing.Point(144, 111);
            this.tbSupervisorPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSupervisorPhone.Name = "tbSupervisorPhone";
            this.tbSupervisorPhone.Size = new System.Drawing.Size(150, 25);
            this.tbSupervisorPhone.TabIndex = 13;
            // 
            // tbSupervisorEmail
            // 
            this.tbSupervisorEmail.Location = new System.Drawing.Point(144, 81);
            this.tbSupervisorEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSupervisorEmail.Name = "tbSupervisorEmail";
            this.tbSupervisorEmail.Size = new System.Drawing.Size(150, 25);
            this.tbSupervisorEmail.TabIndex = 12;
            // 
            // lblSupervisorPhone
            // 
            this.lblSupervisorPhone.AutoSize = true;
            this.lblSupervisorPhone.Location = new System.Drawing.Point(84, 113);
            this.lblSupervisorPhone.Name = "lblSupervisorPhone";
            this.lblSupervisorPhone.Size = new System.Drawing.Size(51, 19);
            this.lblSupervisorPhone.TabIndex = 10;
            this.lblSupervisorPhone.Text = "Phone:";
            // 
            // lblSupervisorEmail
            // 
            this.lblSupervisorEmail.AutoSize = true;
            this.lblSupervisorEmail.Location = new System.Drawing.Point(91, 83);
            this.lblSupervisorEmail.Name = "lblSupervisorEmail";
            this.lblSupervisorEmail.Size = new System.Drawing.Size(44, 19);
            this.lblSupervisorEmail.TabIndex = 9;
            this.lblSupervisorEmail.Text = "Email:";
            // 
            // tbSupervisorName
            // 
            this.tbSupervisorName.Location = new System.Drawing.Point(144, 50);
            this.tbSupervisorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSupervisorName.Name = "tbSupervisorName";
            this.tbSupervisorName.Size = new System.Drawing.Size(150, 25);
            this.tbSupervisorName.TabIndex = 8;
            // 
            // lblSupervisorName
            // 
            this.lblSupervisorName.AutoSize = true;
            this.lblSupervisorName.Location = new System.Drawing.Point(87, 52);
            this.lblSupervisorName.Name = "lblSupervisorName";
            this.lblSupervisorName.Size = new System.Drawing.Size(48, 19);
            this.lblSupervisorName.TabIndex = 7;
            this.lblSupervisorName.Text = "Name:";
            // 
            // numSupervisorID
            // 
            this.numSupervisorID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numSupervisorID.Location = new System.Drawing.Point(144, 18);
            this.numSupervisorID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numSupervisorID.Name = "numSupervisorID";
            this.numSupervisorID.Size = new System.Drawing.Size(150, 25);
            this.numSupervisorID.TabIndex = 6;
            // 
            // lblSupervisorToEdit
            // 
            this.lblSupervisorToEdit.AutoSize = true;
            this.lblSupervisorToEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSupervisorToEdit.Location = new System.Drawing.Point(10, 20);
            this.lblSupervisorToEdit.Name = "lblSupervisorToEdit";
            this.lblSupervisorToEdit.Size = new System.Drawing.Size(120, 19);
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
            this.gbEditTenant.Location = new System.Drawing.Point(509, 28);
            this.gbEditTenant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEditTenant.Name = "gbEditTenant";
            this.gbEditTenant.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEditTenant.Size = new System.Drawing.Size(364, 222);
            this.gbEditTenant.TabIndex = 13;
            this.gbEditTenant.TabStop = false;
            this.gbEditTenant.Text = "Edit tenant ";
            // 
            // btnAddTenant
            // 
            this.btnAddTenant.Location = new System.Drawing.Point(202, 181);
            this.btnAddTenant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTenant.Name = "btnAddTenant";
            this.btnAddTenant.Size = new System.Drawing.Size(144, 29);
            this.btnAddTenant.TabIndex = 16;
            this.btnAddTenant.Text = "Add tenant";
            this.btnAddTenant.UseVisualStyleBackColor = true;
            this.btnAddTenant.Click += new System.EventHandler(this.btnAddTenant_Click);
            // 
            // btnSubmitChangesTenant
            // 
            this.btnSubmitChangesTenant.Location = new System.Drawing.Point(18, 181);
            this.btnSubmitChangesTenant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitChangesTenant.Name = "btnSubmitChangesTenant";
            this.btnSubmitChangesTenant.Size = new System.Drawing.Size(144, 29);
            this.btnSubmitChangesTenant.TabIndex = 15;
            this.btnSubmitChangesTenant.Text = "Submit changes";
            this.btnSubmitChangesTenant.UseVisualStyleBackColor = true;
            // 
            // tbRoomNumber
            // 
            this.tbRoomNumber.Location = new System.Drawing.Point(120, 144);
            this.tbRoomNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRoomNumber.Name = "tbRoomNumber";
            this.tbRoomNumber.Size = new System.Drawing.Size(71, 25);
            this.tbRoomNumber.TabIndex = 14;
            // 
            // tbTenantPhone
            // 
            this.tbTenantPhone.Location = new System.Drawing.Point(120, 116);
            this.tbTenantPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTenantPhone.Name = "tbTenantPhone";
            this.tbTenantPhone.Size = new System.Drawing.Size(150, 25);
            this.tbTenantPhone.TabIndex = 13;
            // 
            // tbTenantEmail
            // 
            this.tbTenantEmail.Location = new System.Drawing.Point(120, 86);
            this.tbTenantEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTenantEmail.Name = "tbTenantEmail";
            this.tbTenantEmail.Size = new System.Drawing.Size(150, 25);
            this.tbTenantEmail.TabIndex = 12;
            // 
            // lblRoomNr
            // 
            this.lblRoomNr.AutoSize = true;
            this.lblRoomNr.Location = new System.Drawing.Point(41, 146);
            this.lblRoomNr.Name = "lblRoomNr";
            this.lblRoomNr.Size = new System.Drawing.Size(68, 19);
            this.lblRoomNr.TabIndex = 11;
            this.lblRoomNr.Text = "Room no:";
            // 
            // lblTenantPhone
            // 
            this.lblTenantPhone.AutoSize = true;
            this.lblTenantPhone.Location = new System.Drawing.Point(60, 118);
            this.lblTenantPhone.Name = "lblTenantPhone";
            this.lblTenantPhone.Size = new System.Drawing.Size(51, 19);
            this.lblTenantPhone.TabIndex = 10;
            this.lblTenantPhone.Text = "Phone:";
            // 
            // lblTenantEmail
            // 
            this.lblTenantEmail.AutoSize = true;
            this.lblTenantEmail.Location = new System.Drawing.Point(66, 88);
            this.lblTenantEmail.Name = "lblTenantEmail";
            this.lblTenantEmail.Size = new System.Drawing.Size(44, 19);
            this.lblTenantEmail.TabIndex = 9;
            this.lblTenantEmail.Text = "Email:";
            // 
            // tbTenantName
            // 
            this.tbTenantName.Location = new System.Drawing.Point(120, 55);
            this.tbTenantName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTenantName.Name = "tbTenantName";
            this.tbTenantName.Size = new System.Drawing.Size(150, 25);
            this.tbTenantName.TabIndex = 8;
            // 
            // lblTenantName
            // 
            this.lblTenantName.AutoSize = true;
            this.lblTenantName.Location = new System.Drawing.Point(62, 57);
            this.lblTenantName.Name = "lblTenantName";
            this.lblTenantName.Size = new System.Drawing.Size(48, 19);
            this.lblTenantName.TabIndex = 7;
            this.lblTenantName.Text = "Name:";
            // 
            // numTenantID
            // 
            this.numTenantID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numTenantID.Location = new System.Drawing.Point(120, 23);
            this.numTenantID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numTenantID.Name = "numTenantID";
            this.numTenantID.Size = new System.Drawing.Size(150, 25);
            this.numTenantID.TabIndex = 6;
            // 
            // lblTenantToEdit
            // 
            this.lblTenantToEdit.AutoSize = true;
            this.lblTenantToEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTenantToEdit.Location = new System.Drawing.Point(10, 25);
            this.lblTenantToEdit.Name = "lblTenantToEdit";
            this.lblTenantToEdit.Size = new System.Drawing.Size(97, 19);
            this.lblTenantToEdit.TabIndex = 5;
            this.lblTenantToEdit.Text = "Tenant to edit:";
            // 
            // lbSupervisorsInfo
            // 
            this.lbSupervisorsInfo.FormattingEnabled = true;
            this.lbSupervisorsInfo.ItemHeight = 21;
            this.lbSupervisorsInfo.Location = new System.Drawing.Point(12, 295);
            this.lbSupervisorsInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbSupervisorsInfo.Name = "lbSupervisorsInfo";
            this.lbSupervisorsInfo.Size = new System.Drawing.Size(464, 172);
            this.lbSupervisorsInfo.TabIndex = 12;
            // 
            // lblSupervisorContactInfo
            // 
            this.lblSupervisorContactInfo.AutoSize = true;
            this.lblSupervisorContactInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSupervisorContactInfo.Location = new System.Drawing.Point(12, 272);
            this.lblSupervisorContactInfo.Name = "lblSupervisorContactInfo";
            this.lblSupervisorContactInfo.Size = new System.Drawing.Size(207, 21);
            this.lblSupervisorContactInfo.TabIndex = 11;
            this.lblSupervisorContactInfo.Text = "Supervisor(s) contact info";
            // 
            // lblTenantsContactInfo
            // 
            this.lblTenantsContactInfo.AutoSize = true;
            this.lblTenantsContactInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTenantsContactInfo.Location = new System.Drawing.Point(12, 14);
            this.lblTenantsContactInfo.Name = "lblTenantsContactInfo";
            this.lblTenantsContactInfo.Size = new System.Drawing.Size(165, 21);
            this.lblTenantsContactInfo.TabIndex = 10;
            this.lblTenantsContactInfo.Text = "Tenants contact info";
            // 
            // lbTenantsInfo
            // 
            this.lbTenantsInfo.FormattingEnabled = true;
            this.lbTenantsInfo.ItemHeight = 21;
            this.lbTenantsInfo.Location = new System.Drawing.Point(12, 38);
            this.lbTenantsInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTenantsInfo.Name = "lbTenantsInfo";
            this.lbTenantsInfo.Size = new System.Drawing.Size(464, 214);
            this.lbTenantsInfo.TabIndex = 9;
            // 
            // tabManageReports
            // 
            this.tabManageReports.Controls.Add(this.tbdescription);
            this.tabManageReports.Controls.Add(this.tbtitle);
            this.tabManageReports.Controls.Add(this.label2);
            this.tabManageReports.Controls.Add(this.label1);
            this.tabManageReports.Controls.Add(this.gbReport);
            this.tabManageReports.Controls.Add(this.lblSubmittedReports);
            this.tabManageReports.Location = new System.Drawing.Point(4, 30);
            this.tabManageReports.Name = "tabManageReports";
            this.tabManageReports.Size = new System.Drawing.Size(899, 480);
            this.tabManageReports.TabIndex = 5;
            this.tabManageReports.Text = "Manage Reports";
            this.tabManageReports.UseVisualStyleBackColor = true;
            // 
            // gbReport
            // 
            this.gbReport.Controls.Add(this.btnSendWarning);
            this.gbReport.Controls.Add(this.tbadressedPerson);
            this.gbReport.Controls.Add(this.cbTenantToSendWarning);
            this.gbReport.Controls.Add(this.lblSelectTenant);
            this.gbReport.Controls.Add(this.lblPersonAdressedTo);
            this.gbReport.Location = new System.Drawing.Point(416, 41);
            this.gbReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbReport.Name = "gbReport";
            this.gbReport.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbReport.Size = new System.Drawing.Size(444, 329);
            this.gbReport.TabIndex = 6;
            this.gbReport.TabStop = false;
            this.gbReport.Text = "Report";
            // 
            // btnSendWarning
            // 
            this.btnSendWarning.Location = new System.Drawing.Point(158, 275);
            this.btnSendWarning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendWarning.Name = "btnSendWarning";
            this.btnSendWarning.Size = new System.Drawing.Size(252, 37);
            this.btnSendWarning.TabIndex = 6;
            this.btnSendWarning.Text = "Send warning";
            this.btnSendWarning.UseVisualStyleBackColor = true;
            this.btnSendWarning.Click += new System.EventHandler(this.btnSendWarning_Click);
            // 
            // cbTenantToSendWarning
            // 
            this.cbTenantToSendWarning.FormattingEnabled = true;
            this.cbTenantToSendWarning.Location = new System.Drawing.Point(156, 127);
            this.cbTenantToSendWarning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTenantToSendWarning.Name = "cbTenantToSendWarning";
            this.cbTenantToSendWarning.Size = new System.Drawing.Size(252, 29);
            this.cbTenantToSendWarning.TabIndex = 5;
            // 
            // lblSelectTenant
            // 
            this.lblSelectTenant.AutoSize = true;
            this.lblSelectTenant.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectTenant.Location = new System.Drawing.Point(49, 133);
            this.lblSelectTenant.Name = "lblSelectTenant";
            this.lblSelectTenant.Size = new System.Drawing.Size(91, 19);
            this.lblSelectTenant.TabIndex = 4;
            this.lblSelectTenant.Text = "Select tenant:";
            // 
            // lblPersonAdressedTo
            // 
            this.lblPersonAdressedTo.AutoSize = true;
            this.lblPersonAdressedTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPersonAdressedTo.Location = new System.Drawing.Point(22, 72);
            this.lblPersonAdressedTo.Name = "lblPersonAdressedTo";
            this.lblPersonAdressedTo.Size = new System.Drawing.Size(128, 19);
            this.lblPersonAdressedTo.TabIndex = 2;
            this.lblPersonAdressedTo.Text = "Person adressed to:";
            // 
            // lblSubmittedReports
            // 
            this.lblSubmittedReports.AutoSize = true;
            this.lblSubmittedReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubmittedReports.Location = new System.Drawing.Point(30, 20);
            this.lblSubmittedReports.Name = "lblSubmittedReports";
            this.lblSubmittedReports.Size = new System.Drawing.Size(148, 21);
            this.lblSubmittedReports.TabIndex = 0;
            this.lblSubmittedReports.Text = "Submitted reports";
            // 
            // tabAssignTasks
            // 
            this.tabAssignTasks.Controls.Add(this.lbEvents);
            this.tabAssignTasks.Controls.Add(this.gbMakeAnnouncement);
            this.tabAssignTasks.Controls.Add(this.gbAssignTask);
            this.tabAssignTasks.Controls.Add(this.monthCalendarSupervisor);
            this.tabAssignTasks.Location = new System.Drawing.Point(4, 30);
            this.tabAssignTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAssignTasks.Name = "tabAssignTasks";
            this.tabAssignTasks.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAssignTasks.Size = new System.Drawing.Size(899, 480);
            this.tabAssignTasks.TabIndex = 6;
            this.tabAssignTasks.Text = "Assign tasks";
            this.tabAssignTasks.UseVisualStyleBackColor = true;
            // 
            // lbEvents
            // 
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.ItemHeight = 21;
            this.lbEvents.Location = new System.Drawing.Point(340, 44);
            this.lbEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(536, 151);
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
            this.gbMakeAnnouncement.Location = new System.Drawing.Point(494, 232);
            this.gbMakeAnnouncement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMakeAnnouncement.Name = "gbMakeAnnouncement";
            this.gbMakeAnnouncement.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMakeAnnouncement.Size = new System.Drawing.Size(382, 232);
            this.gbMakeAnnouncement.TabIndex = 3;
            this.gbMakeAnnouncement.TabStop = false;
            this.gbMakeAnnouncement.Text = "Make announcement";
            // 
            // btnSubmitAnnouncement
            // 
            this.btnSubmitAnnouncement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitAnnouncement.Location = new System.Drawing.Point(100, 192);
            this.btnSubmitAnnouncement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitAnnouncement.Name = "btnSubmitAnnouncement";
            this.btnSubmitAnnouncement.Size = new System.Drawing.Size(178, 28);
            this.btnSubmitAnnouncement.TabIndex = 11;
            this.btnSubmitAnnouncement.Text = "Submit announcement";
            this.btnSubmitAnnouncement.UseVisualStyleBackColor = true;
            this.btnSubmitAnnouncement.Click += new System.EventHandler(this.btnSubmitAnnouncement_Click);
            // 
            // tbAnnouncementDescription
            // 
            this.tbAnnouncementDescription.Location = new System.Drawing.Point(18, 100);
            this.tbAnnouncementDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAnnouncementDescription.Multiline = true;
            this.tbAnnouncementDescription.Name = "tbAnnouncementDescription";
            this.tbAnnouncementDescription.Size = new System.Drawing.Size(339, 78);
            this.tbAnnouncementDescription.TabIndex = 7;
            // 
            // lblAnnouncementDescription
            // 
            this.lblAnnouncementDescription.AutoSize = true;
            this.lblAnnouncementDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnnouncementDescription.Location = new System.Drawing.Point(18, 70);
            this.lblAnnouncementDescription.Name = "lblAnnouncementDescription";
            this.lblAnnouncementDescription.Size = new System.Drawing.Size(81, 19);
            this.lblAnnouncementDescription.TabIndex = 6;
            this.lblAnnouncementDescription.Text = "Description:";
            // 
            // tbAnnouncementTitle
            // 
            this.tbAnnouncementTitle.Location = new System.Drawing.Point(71, 29);
            this.tbAnnouncementTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAnnouncementTitle.Name = "tbAnnouncementTitle";
            this.tbAnnouncementTitle.Size = new System.Drawing.Size(190, 29);
            this.tbAnnouncementTitle.TabIndex = 5;
            // 
            // lblAnnouncementTitle
            // 
            this.lblAnnouncementTitle.AutoSize = true;
            this.lblAnnouncementTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnnouncementTitle.Location = new System.Drawing.Point(18, 32);
            this.lblAnnouncementTitle.Name = "lblAnnouncementTitle";
            this.lblAnnouncementTitle.Size = new System.Drawing.Size(37, 19);
            this.lblAnnouncementTitle.TabIndex = 4;
            this.lblAnnouncementTitle.Text = "Title:";
            // 
            // gbAssignTask
            // 
            this.gbAssignTask.Controls.Add(this.roomNr);
            this.gbAssignTask.Controls.Add(this.label3);
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
            this.gbAssignTask.Location = new System.Drawing.Point(33, 232);
            this.gbAssignTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAssignTask.Name = "gbAssignTask";
            this.gbAssignTask.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAssignTask.Size = new System.Drawing.Size(427, 232);
            this.gbAssignTask.TabIndex = 2;
            this.gbAssignTask.TabStop = false;
            this.gbAssignTask.Text = "Assign task";
            // 
            // btnSubmitTask
            // 
            this.btnSubmitTask.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitTask.Location = new System.Drawing.Point(118, 192);
            this.btnSubmitTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitTask.Name = "btnSubmitTask";
            this.btnSubmitTask.Size = new System.Drawing.Size(152, 28);
            this.btnSubmitTask.TabIndex = 10;
            this.btnSubmitTask.Text = "Submit task";
            this.btnSubmitTask.UseVisualStyleBackColor = true;
            this.btnSubmitTask.Click += new System.EventHandler(this.btnSubmitTask_Click);
            // 
            // cbTakeOutTheTrash
            // 
            this.cbTakeOutTheTrash.AutoSize = true;
            this.cbTakeOutTheTrash.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTakeOutTheTrash.Location = new System.Drawing.Point(242, 149);
            this.cbTakeOutTheTrash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTakeOutTheTrash.Name = "cbTakeOutTheTrash";
            this.cbTakeOutTheTrash.Size = new System.Drawing.Size(138, 23);
            this.cbTakeOutTheTrash.TabIndex = 9;
            this.cbTakeOutTheTrash.Text = "Take out the trash";
            this.cbTakeOutTheTrash.UseVisualStyleBackColor = true;
            // 
            // cbCleanTheLivingRoom
            // 
            this.cbCleanTheLivingRoom.AutoSize = true;
            this.cbCleanTheLivingRoom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCleanTheLivingRoom.Location = new System.Drawing.Point(242, 100);
            this.cbCleanTheLivingRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCleanTheLivingRoom.Name = "cbCleanTheLivingRoom";
            this.cbCleanTheLivingRoom.Size = new System.Drawing.Size(159, 23);
            this.cbCleanTheLivingRoom.TabIndex = 8;
            this.cbCleanTheLivingRoom.Text = "Clean the living room";
            this.cbCleanTheLivingRoom.UseVisualStyleBackColor = true;
            // 
            // cbCleanTheKitchen
            // 
            this.cbCleanTheKitchen.AutoSize = true;
            this.cbCleanTheKitchen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCleanTheKitchen.Location = new System.Drawing.Point(242, 124);
            this.cbCleanTheKitchen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCleanTheKitchen.Name = "cbCleanTheKitchen";
            this.cbCleanTheKitchen.Size = new System.Drawing.Size(134, 23);
            this.cbCleanTheKitchen.TabIndex = 7;
            this.cbCleanTheKitchen.Text = "Clean the kitchen";
            this.cbCleanTheKitchen.UseVisualStyleBackColor = true;
            // 
            // cbCleanTheStarirs
            // 
            this.cbCleanTheStarirs.AutoSize = true;
            this.cbCleanTheStarirs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCleanTheStarirs.Location = new System.Drawing.Point(13, 149);
            this.cbCleanTheStarirs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCleanTheStarirs.Name = "cbCleanTheStarirs";
            this.cbCleanTheStarirs.Size = new System.Drawing.Size(122, 23);
            this.cbCleanTheStarirs.TabIndex = 6;
            this.cbCleanTheStarirs.Text = "Clean the stairs";
            this.cbCleanTheStarirs.UseVisualStyleBackColor = true;
            // 
            // cbCleanBathroom2
            // 
            this.cbCleanBathroom2.AutoSize = true;
            this.cbCleanBathroom2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCleanBathroom2.Location = new System.Drawing.Point(13, 124);
            this.cbCleanBathroom2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCleanBathroom2.Name = "cbCleanBathroom2";
            this.cbCleanBathroom2.Size = new System.Drawing.Size(139, 23);
            this.cbCleanBathroom2.TabIndex = 5;
            this.cbCleanBathroom2.Text = "Clean bathroom 2";
            this.cbCleanBathroom2.UseVisualStyleBackColor = true;
            // 
            // cbCleanBathroom1
            // 
            this.cbCleanBathroom1.AutoSize = true;
            this.cbCleanBathroom1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCleanBathroom1.Location = new System.Drawing.Point(13, 100);
            this.cbCleanBathroom1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCleanBathroom1.Name = "cbCleanBathroom1";
            this.cbCleanBathroom1.Size = new System.Drawing.Size(139, 23);
            this.cbCleanBathroom1.TabIndex = 4;
            this.cbCleanBathroom1.Text = "Clean bathroom 1";
            this.cbCleanBathroom1.UseVisualStyleBackColor = true;
            // 
            // lblSelectTask
            // 
            this.lblSelectTask.AutoSize = true;
            this.lblSelectTask.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectTask.Location = new System.Drawing.Point(13, 79);
            this.lblSelectTask.Name = "lblSelectTask";
            this.lblSelectTask.Size = new System.Drawing.Size(76, 19);
            this.lblSelectTask.TabIndex = 3;
            this.lblSelectTask.Text = "Select task:";
            // 
            // cbSelectTenantToAssignTask
            // 
            this.cbSelectTenantToAssignTask.FormattingEnabled = true;
            this.cbSelectTenantToAssignTask.Location = new System.Drawing.Point(118, 21);
            this.cbSelectTenantToAssignTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSelectTenantToAssignTask.Name = "cbSelectTenantToAssignTask";
            this.cbSelectTenantToAssignTask.Size = new System.Drawing.Size(236, 29);
            this.cbSelectTenantToAssignTask.TabIndex = 2;
            // 
            // lblSelectTenantAssignTask
            // 
            this.lblSelectTenantAssignTask.AutoSize = true;
            this.lblSelectTenantAssignTask.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectTenantAssignTask.Location = new System.Drawing.Point(13, 24);
            this.lblSelectTenantAssignTask.Name = "lblSelectTenantAssignTask";
            this.lblSelectTenantAssignTask.Size = new System.Drawing.Size(91, 19);
            this.lblSelectTenantAssignTask.TabIndex = 1;
            this.lblSelectTenantAssignTask.Text = "Select tenant:";
            // 
            // monthCalendarSupervisor
            // 
            this.monthCalendarSupervisor.Location = new System.Drawing.Point(33, 38);
            this.monthCalendarSupervisor.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.monthCalendarSupervisor.Name = "monthCalendarSupervisor";
            this.monthCalendarSupervisor.TabIndex = 0;
            // 
            // lblStudentHouseBV
            // 
            this.lblStudentHouseBV.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblStudentHouseBV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudentHouseBV.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudentHouseBV.Image = global::Housing_Project.Properties.Resources.house;
            this.lblStudentHouseBV.Location = new System.Drawing.Point(12, 15);
            this.lblStudentHouseBV.Name = "lblStudentHouseBV";
            this.lblStudentHouseBV.Size = new System.Drawing.Size(904, 58);
            this.lblStudentHouseBV.TabIndex = 4;
            this.lblStudentHouseBV.Text = "Student House BV";
            this.lblStudentHouseBV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Report title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Report description:";
            // 
            // tbtitle
            // 
            this.tbtitle.Location = new System.Drawing.Point(177, 87);
            this.tbtitle.Name = "tbtitle";
            this.tbtitle.Size = new System.Drawing.Size(210, 29);
            this.tbtitle.TabIndex = 10;
            // 
            // tbadressedPerson
            // 
            this.tbadressedPerson.Location = new System.Drawing.Point(188, 66);
            this.tbadressedPerson.Name = "tbadressedPerson";
            this.tbadressedPerson.Size = new System.Drawing.Size(210, 29);
            this.tbadressedPerson.TabIndex = 12;
            // 
            // tbdescription
            // 
            this.tbdescription.Location = new System.Drawing.Point(177, 204);
            this.tbdescription.Name = "tbdescription";
            this.tbdescription.Size = new System.Drawing.Size(210, 77);
            this.tbdescription.TabIndex = 13;
            this.tbdescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Room:";
            // 
            // roomNr
            // 
            this.roomNr.Location = new System.Drawing.Point(118, 55);
            this.roomNr.Name = "roomNr";
            this.roomNr.Size = new System.Drawing.Size(100, 29);
            this.roomNr.TabIndex = 12;
            // 
            // FormSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 608);
            this.Controls.Add(this.lblStudentHouseBV);
            this.Controls.Add(this.tabControlSupervisor);
            this.Name = "FormSupervisor";
            this.Text = "Supervisor";
            this.tabControlSupervisor.ResumeLayout(false);
            this.tabRules.ResumeLayout(false);
            this.tabRules.PerformLayout();
            this.gbEditRules.ResumeLayout(false);
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
        private Label lblSubmittedReports;
        private RichTextBox tbRule;
        private Button btnAddRule;
        private ListBox lbRules;
        private Label lblStudentHouseBV;
        private Label lblHouseRules;
        private GroupBox gbEditRules;
        private Button btnSubmitChanges;
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
        private Label lblPersonAdressedTo;
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
        private TextBox tbadressedPerson;
        private TextBox tbtitle;
        private Label label2;
        private Label label1;
        private RichTextBox tbdescription;
        private TextBox roomNr;
        private Label label3;
    }
}