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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudent));
            this.tabControlStudent = new System.Windows.Forms.TabControl();
            this.tabHouseRules = new System.Windows.Forms.TabPage();
            this.lbSupervisorInfo = new System.Windows.Forms.ListBox();
            this.lbTenantsContactInfo = new System.Windows.Forms.ListBox();
            this.lblSupervisorContactInfo = new System.Windows.Forms.Label();
            this.lblTenantsContactInfo = new System.Windows.Forms.Label();
            this.lbHouseRules = new System.Windows.Forms.ListBox();
            this.lblHouseRules = new System.Windows.Forms.Label();
            this.tabEventSchedule = new System.Windows.Forms.TabPage();
            this.lblCompletedEvents = new System.Windows.Forms.Label();
            this.btnTaskCompleted = new System.Windows.Forms.Button();
            this.lbCompletedTasks = new System.Windows.Forms.ListBox();
            this.eventCalendar = new System.Windows.Forms.MonthCalendar();
            this.lbEvents = new System.Windows.Forms.ListBox();
            this.lblTasksFor = new System.Windows.Forms.Label();
            this.tabSupplies = new System.Windows.Forms.TabPage();
            this.lblPayments = new System.Windows.Forms.Label();
            this.lbPaymentsInfo = new System.Windows.Forms.ListBox();
            this.gbSupplies = new System.Windows.Forms.GroupBox();
            this.btnSubmitPayment = new System.Windows.Forms.Button();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.tbOtherProducts = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblOthers = new System.Windows.Forms.Label();
            this.cbGlassCleaner = new System.Windows.Forms.CheckBox();
            this.cbFiberCloth = new System.Windows.Forms.CheckBox();
            this.cbAntiCalcarSolution = new System.Windows.Forms.CheckBox();
            this.cbHygienizer = new System.Windows.Forms.CheckBox();
            this.cbAntiGreaseSolution = new System.Windows.Forms.CheckBox();
            this.cbFloorCleaner = new System.Windows.Forms.CheckBox();
            this.cbFreshener = new System.Windows.Forms.CheckBox();
            this.cbSoap = new System.Windows.Forms.CheckBox();
            this.cbMopCap = new System.Windows.Forms.CheckBox();
            this.lblCleaningProducts = new System.Windows.Forms.Label();
            this.cbLaundrySoftener = new System.Windows.Forms.CheckBox();
            this.cbLaundryPods = new System.Windows.Forms.CheckBox();
            this.cbToiletPaper = new System.Windows.Forms.CheckBox();
            this.lblBathroom = new System.Windows.Forms.Label();
            this.cbGarbageBags = new System.Windows.Forms.CheckBox();
            this.cbNapkins = new System.Windows.Forms.CheckBox();
            this.cbPaperRolls = new System.Windows.Forms.CheckBox();
            this.lblKitchen = new System.Windows.Forms.Label();
            this.cbDishSoap = new System.Windows.Forms.CheckBox();
            this.cbSponges = new System.Windows.Forms.CheckBox();
            this.tabAgreements = new System.Windows.Forms.TabPage();
            this.rbDisagree = new System.Windows.Forms.RadioButton();
            this.rbAgree = new System.Windows.Forms.RadioButton();
            this.lblPendingAgreements = new System.Windows.Forms.Label();
            this.btnCheckStatus = new System.Windows.Forms.Button();
            this.btnSubmitVote = new System.Windows.Forms.Button();
            this.lbPendingAgreements = new System.Windows.Forms.ListBox();
            this.lbAgreementsDisplay = new System.Windows.Forms.ListBox();
            this.lblAgreements = new System.Windows.Forms.Label();
            this.gbMakeAProposal = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePickerAgreements = new System.Windows.Forms.DateTimePicker();
            this.lblProposalDescription = new System.Windows.Forms.Label();
            this.tbProposalTitle = new System.Windows.Forms.TextBox();
            this.lblProposalTitle = new System.Windows.Forms.Label();
            this.btnSubmitProposal = new System.Windows.Forms.Button();
            this.tbProposalContent = new System.Windows.Forms.TextBox();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.lbWarnings = new System.Windows.Forms.ListBox();
            this.gbFileAReport = new System.Windows.Forms.GroupBox();
            this.lblReportDescription = new System.Windows.Forms.Label();
            this.tbReportTitle = new System.Windows.Forms.TextBox();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.btnSubmitReport = new System.Windows.Forms.Button();
            this.tbReportContent = new System.Windows.Forms.TextBox();
            this.cbTenantsToReport = new System.Windows.Forms.ComboBox();
            this.lblAdressReportToSomeone = new System.Windows.Forms.Label();
            this.lblWarnings = new System.Windows.Forms.Label();
            this.lblStudentHouseBV = new System.Windows.Forms.Label();
            this.logoutpicturebox = new System.Windows.Forms.PictureBox();
            this.tabControlStudent.SuspendLayout();
            this.tabHouseRules.SuspendLayout();
            this.tabEventSchedule.SuspendLayout();
            this.tabSupplies.SuspendLayout();
            this.gbSupplies.SuspendLayout();
            this.tabAgreements.SuspendLayout();
            this.gbMakeAProposal.SuspendLayout();
            this.tabReport.SuspendLayout();
            this.gbFileAReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutpicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlStudent
            // 
            this.tabControlStudent.Controls.Add(this.tabHouseRules);
            this.tabControlStudent.Controls.Add(this.tabEventSchedule);
            this.tabControlStudent.Controls.Add(this.tabSupplies);
            this.tabControlStudent.Controls.Add(this.tabAgreements);
            this.tabControlStudent.Controls.Add(this.tabReport);
            this.tabControlStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlStudent.Location = new System.Drawing.Point(10, 76);
            this.tabControlStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlStudent.Multiline = true;
            this.tabControlStudent.Name = "tabControlStudent";
            this.tabControlStudent.Padding = new System.Drawing.Point(45, 5);
            this.tabControlStudent.SelectedIndex = 0;
            this.tabControlStudent.Size = new System.Drawing.Size(1058, 552);
            this.tabControlStudent.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlStudent.TabIndex = 0;
            this.tabControlStudent.SelectedIndexChanged += new System.EventHandler(this.tabControlStudent_SelectedIndexChanged);
            // 
            // tabHouseRules
            // 
            this.tabHouseRules.BackgroundImage = global::Housing_Project.Properties.Resources._360_F_355607062_zYMS8jaz4SfoykpWz5oViRVKL32IabTP;
            this.tabHouseRules.Controls.Add(this.lbSupervisorInfo);
            this.tabHouseRules.Controls.Add(this.lbTenantsContactInfo);
            this.tabHouseRules.Controls.Add(this.lblSupervisorContactInfo);
            this.tabHouseRules.Controls.Add(this.lblTenantsContactInfo);
            this.tabHouseRules.Controls.Add(this.lbHouseRules);
            this.tabHouseRules.Controls.Add(this.lblHouseRules);
            this.tabHouseRules.Location = new System.Drawing.Point(4, 34);
            this.tabHouseRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHouseRules.Name = "tabHouseRules";
            this.tabHouseRules.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHouseRules.Size = new System.Drawing.Size(1050, 514);
            this.tabHouseRules.TabIndex = 0;
            this.tabHouseRules.Text = "House Rules & Contact Info";
            this.tabHouseRules.UseVisualStyleBackColor = true;
            // 
            // lbSupervisorInfo
            // 
            this.lbSupervisorInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSupervisorInfo.FormattingEnabled = true;
            this.lbSupervisorInfo.HorizontalScrollbar = true;
            this.lbSupervisorInfo.ItemHeight = 17;
            this.lbSupervisorInfo.Location = new System.Drawing.Point(550, 294);
            this.lbSupervisorInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbSupervisorInfo.Name = "lbSupervisorInfo";
            this.lbSupervisorInfo.Size = new System.Drawing.Size(464, 208);
            this.lbSupervisorInfo.TabIndex = 5;
            // 
            // lbTenantsContactInfo
            // 
            this.lbTenantsContactInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTenantsContactInfo.FormattingEnabled = true;
            this.lbTenantsContactInfo.HorizontalScrollbar = true;
            this.lbTenantsContactInfo.ItemHeight = 17;
            this.lbTenantsContactInfo.Location = new System.Drawing.Point(19, 294);
            this.lbTenantsContactInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTenantsContactInfo.Name = "lbTenantsContactInfo";
            this.lbTenantsContactInfo.Size = new System.Drawing.Size(464, 208);
            this.lbTenantsContactInfo.TabIndex = 4;
            // 
            // lblSupervisorContactInfo
            // 
            this.lblSupervisorContactInfo.AutoSize = true;
            this.lblSupervisorContactInfo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSupervisorContactInfo.Location = new System.Drawing.Point(651, 255);
            this.lblSupervisorContactInfo.Name = "lblSupervisorContactInfo";
            this.lblSupervisorContactInfo.Size = new System.Drawing.Size(243, 25);
            this.lblSupervisorContactInfo.TabIndex = 3;
            this.lblSupervisorContactInfo.Text = "Supervisor(s) contact info";
            // 
            // lblTenantsContactInfo
            // 
            this.lblTenantsContactInfo.AutoSize = true;
            this.lblTenantsContactInfo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTenantsContactInfo.Location = new System.Drawing.Point(130, 255);
            this.lblTenantsContactInfo.Name = "lblTenantsContactInfo";
            this.lblTenantsContactInfo.Size = new System.Drawing.Size(192, 25);
            this.lblTenantsContactInfo.TabIndex = 2;
            this.lblTenantsContactInfo.Text = "Tenants contact info";
            // 
            // lbHouseRules
            // 
            this.lbHouseRules.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHouseRules.FormattingEnabled = true;
            this.lbHouseRules.ItemHeight = 17;
            this.lbHouseRules.Location = new System.Drawing.Point(19, 53);
            this.lbHouseRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbHouseRules.Name = "lbHouseRules";
            this.lbHouseRules.Size = new System.Drawing.Size(995, 174);
            this.lbHouseRules.TabIndex = 1;
            // 
            // lblHouseRules
            // 
            this.lblHouseRules.AutoSize = true;
            this.lblHouseRules.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHouseRules.Location = new System.Drawing.Point(19, 20);
            this.lblHouseRules.Name = "lblHouseRules";
            this.lblHouseRules.Size = new System.Drawing.Size(121, 25);
            this.lblHouseRules.TabIndex = 0;
            this.lblHouseRules.Text = "House Rules";
            // 
            // tabEventSchedule
            // 
            this.tabEventSchedule.BackgroundImage = global::Housing_Project.Properties.Resources._360_F_355607062_zYMS8jaz4SfoykpWz5oViRVKL32IabTP;
            this.tabEventSchedule.Controls.Add(this.lblCompletedEvents);
            this.tabEventSchedule.Controls.Add(this.btnTaskCompleted);
            this.tabEventSchedule.Controls.Add(this.lbCompletedTasks);
            this.tabEventSchedule.Controls.Add(this.eventCalendar);
            this.tabEventSchedule.Controls.Add(this.lbEvents);
            this.tabEventSchedule.Controls.Add(this.lblTasksFor);
            this.tabEventSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabEventSchedule.Location = new System.Drawing.Point(4, 34);
            this.tabEventSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEventSchedule.Name = "tabEventSchedule";
            this.tabEventSchedule.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEventSchedule.Size = new System.Drawing.Size(1050, 514);
            this.tabEventSchedule.TabIndex = 2;
            this.tabEventSchedule.Text = "Event Schedule";
            this.tabEventSchedule.UseVisualStyleBackColor = true;
            this.tabEventSchedule.Click += new System.EventHandler(this.tabEventSchedule_Click);
            // 
            // lblCompletedEvents
            // 
            this.lblCompletedEvents.AutoSize = true;
            this.lblCompletedEvents.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCompletedEvents.Location = new System.Drawing.Point(45, 284);
            this.lblCompletedEvents.Name = "lblCompletedEvents";
            this.lblCompletedEvents.Size = new System.Drawing.Size(176, 25);
            this.lblCompletedEvents.TabIndex = 13;
            this.lblCompletedEvents.Text = "Completed Events:";
            // 
            // btnTaskCompleted
            // 
            this.btnTaskCompleted.Location = new System.Drawing.Point(748, 240);
            this.btnTaskCompleted.Name = "btnTaskCompleted";
            this.btnTaskCompleted.Size = new System.Drawing.Size(144, 35);
            this.btnTaskCompleted.TabIndex = 12;
            this.btnTaskCompleted.Text = "Task Completed";
            this.btnTaskCompleted.UseVisualStyleBackColor = true;
            this.btnTaskCompleted.Click += new System.EventHandler(this.btnTaskCompleted_Click);
            // 
            // lbCompletedTasks
            // 
            this.lbCompletedTasks.FormattingEnabled = true;
            this.lbCompletedTasks.ItemHeight = 21;
            this.lbCompletedTasks.Location = new System.Drawing.Point(45, 310);
            this.lbCompletedTasks.Name = "lbCompletedTasks";
            this.lbCompletedTasks.Size = new System.Drawing.Size(653, 193);
            this.lbCompletedTasks.TabIndex = 11;
            this.lbCompletedTasks.SelectedIndexChanged += new System.EventHandler(this.lbCompletedTasks_SelectedIndexChanged);
            this.lbCompletedTasks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbCompletedTasks_MouseDoubleClick);
            // 
            // eventCalendar
            // 
            this.eventCalendar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eventCalendar.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eventCalendar.Location = new System.Drawing.Point(748, 62);
            this.eventCalendar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.eventCalendar.MaxSelectionCount = 1;
            this.eventCalendar.Name = "eventCalendar";
            this.eventCalendar.TabIndex = 0;
            this.eventCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // lbEvents
            // 
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.HorizontalScrollbar = true;
            this.lbEvents.ItemHeight = 21;
            this.lbEvents.Location = new System.Drawing.Point(45, 62);
            this.lbEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(653, 214);
            this.lbEvents.TabIndex = 3;
            this.lbEvents.SelectedIndexChanged += new System.EventHandler(this.lbEvents_SelectedIndexChanged);
            this.lbEvents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbTasks_MouseDoubleClick);
            // 
            // lblTasksFor
            // 
            this.lblTasksFor.AutoSize = true;
            this.lblTasksFor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTasksFor.Location = new System.Drawing.Point(45, 36);
            this.lblTasksFor.Name = "lblTasksFor";
            this.lblTasksFor.Size = new System.Drawing.Size(153, 25);
            this.lblTasksFor.TabIndex = 1;
            this.lblTasksFor.Text = "Pending Events:";
            // 
            // tabSupplies
            // 
            this.tabSupplies.BackgroundImage = global::Housing_Project.Properties.Resources._360_F_355607062_zYMS8jaz4SfoykpWz5oViRVKL32IabTP;
            this.tabSupplies.Controls.Add(this.lblPayments);
            this.tabSupplies.Controls.Add(this.lbPaymentsInfo);
            this.tabSupplies.Controls.Add(this.gbSupplies);
            this.tabSupplies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabSupplies.Location = new System.Drawing.Point(4, 34);
            this.tabSupplies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSupplies.Name = "tabSupplies";
            this.tabSupplies.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSupplies.Size = new System.Drawing.Size(1050, 514);
            this.tabSupplies.TabIndex = 3;
            this.tabSupplies.Text = "Supplies";
            this.tabSupplies.UseVisualStyleBackColor = true;
            // 
            // lblPayments
            // 
            this.lblPayments.AutoSize = true;
            this.lblPayments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPayments.Location = new System.Drawing.Point(511, 25);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(85, 21);
            this.lblPayments.TabIndex = 2;
            this.lblPayments.Text = "Payments";
            // 
            // lbPaymentsInfo
            // 
            this.lbPaymentsInfo.FormattingEnabled = true;
            this.lbPaymentsInfo.ItemHeight = 21;
            this.lbPaymentsInfo.Location = new System.Drawing.Point(511, 48);
            this.lbPaymentsInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbPaymentsInfo.Name = "lbPaymentsInfo";
            this.lbPaymentsInfo.Size = new System.Drawing.Size(459, 340);
            this.lbPaymentsInfo.TabIndex = 1;
            this.lbPaymentsInfo.SelectedIndexChanged += new System.EventHandler(this.lbPaymentsInfo_SelectedIndexChanged);
            this.lbPaymentsInfo.DoubleClick += new System.EventHandler(this.lbPaymentsInfo_DoubleClick);
            // 
            // gbSupplies
            // 
            this.gbSupplies.Controls.Add(this.btnSubmitPayment);
            this.gbSupplies.Controls.Add(this.tbTotalPrice);
            this.gbSupplies.Controls.Add(this.tbOtherProducts);
            this.gbSupplies.Controls.Add(this.lblTotalPrice);
            this.gbSupplies.Controls.Add(this.lblOthers);
            this.gbSupplies.Controls.Add(this.cbGlassCleaner);
            this.gbSupplies.Controls.Add(this.cbFiberCloth);
            this.gbSupplies.Controls.Add(this.cbAntiCalcarSolution);
            this.gbSupplies.Controls.Add(this.cbHygienizer);
            this.gbSupplies.Controls.Add(this.cbAntiGreaseSolution);
            this.gbSupplies.Controls.Add(this.cbFloorCleaner);
            this.gbSupplies.Controls.Add(this.cbFreshener);
            this.gbSupplies.Controls.Add(this.cbSoap);
            this.gbSupplies.Controls.Add(this.cbMopCap);
            this.gbSupplies.Controls.Add(this.lblCleaningProducts);
            this.gbSupplies.Controls.Add(this.cbLaundrySoftener);
            this.gbSupplies.Controls.Add(this.cbLaundryPods);
            this.gbSupplies.Controls.Add(this.cbToiletPaper);
            this.gbSupplies.Controls.Add(this.lblBathroom);
            this.gbSupplies.Controls.Add(this.cbGarbageBags);
            this.gbSupplies.Controls.Add(this.cbNapkins);
            this.gbSupplies.Controls.Add(this.cbPaperRolls);
            this.gbSupplies.Controls.Add(this.lblKitchen);
            this.gbSupplies.Controls.Add(this.cbDishSoap);
            this.gbSupplies.Controls.Add(this.cbSponges);
            this.gbSupplies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbSupplies.Location = new System.Drawing.Point(27, 25);
            this.gbSupplies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSupplies.Name = "gbSupplies";
            this.gbSupplies.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSupplies.Size = new System.Drawing.Size(458, 468);
            this.gbSupplies.TabIndex = 0;
            this.gbSupplies.TabStop = false;
            this.gbSupplies.Text = "Supplies";
            // 
            // btnSubmitPayment
            // 
            this.btnSubmitPayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitPayment.Location = new System.Drawing.Point(284, 434);
            this.btnSubmitPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitPayment.Name = "btnSubmitPayment";
            this.btnSubmitPayment.Size = new System.Drawing.Size(82, 26);
            this.btnSubmitPayment.TabIndex = 17;
            this.btnSubmitPayment.Text = "Submit";
            this.btnSubmitPayment.UseVisualStyleBackColor = true;
            this.btnSubmitPayment.Click += new System.EventHandler(this.btnSubmitPayment_Click);
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Location = new System.Drawing.Point(128, 434);
            this.tbTotalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.Size = new System.Drawing.Size(151, 29);
            this.tbTotalPrice.TabIndex = 2;
            // 
            // tbOtherProducts
            // 
            this.tbOtherProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbOtherProducts.Location = new System.Drawing.Point(248, 243);
            this.tbOtherProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOtherProducts.Multiline = true;
            this.tbOtherProducts.Name = "tbOtherProducts";
            this.tbOtherProducts.Size = new System.Drawing.Size(193, 96);
            this.tbOtherProducts.TabIndex = 16;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrice.Location = new System.Drawing.Point(20, 436);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(94, 21);
            this.lblTotalPrice.TabIndex = 1;
            this.lblTotalPrice.Text = "Total price:";
            // 
            // lblOthers
            // 
            this.lblOthers.AutoSize = true;
            this.lblOthers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOthers.Location = new System.Drawing.Point(248, 212);
            this.lblOthers.Name = "lblOthers";
            this.lblOthers.Size = new System.Drawing.Size(57, 21);
            this.lblOthers.TabIndex = 12;
            this.lblOthers.Text = "Others";
            // 
            // cbGlassCleaner
            // 
            this.cbGlassCleaner.AutoSize = true;
            this.cbGlassCleaner.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbGlassCleaner.Location = new System.Drawing.Point(20, 390);
            this.cbGlassCleaner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGlassCleaner.Name = "cbGlassCleaner";
            this.cbGlassCleaner.Size = new System.Drawing.Size(107, 23);
            this.cbGlassCleaner.TabIndex = 2;
            this.cbGlassCleaner.Text = "Glass cleaner";
            this.cbGlassCleaner.UseVisualStyleBackColor = true;
            // 
            // cbFiberCloth
            // 
            this.cbFiberCloth.AutoSize = true;
            this.cbFiberCloth.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFiberCloth.Location = new System.Drawing.Point(20, 367);
            this.cbFiberCloth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFiberCloth.Name = "cbFiberCloth";
            this.cbFiberCloth.Size = new System.Drawing.Size(92, 23);
            this.cbFiberCloth.TabIndex = 15;
            this.cbFiberCloth.Text = "Fiber cloth";
            this.cbFiberCloth.UseVisualStyleBackColor = true;
            // 
            // cbAntiCalcarSolution
            // 
            this.cbAntiCalcarSolution.AutoSize = true;
            this.cbAntiCalcarSolution.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAntiCalcarSolution.Location = new System.Drawing.Point(20, 317);
            this.cbAntiCalcarSolution.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAntiCalcarSolution.Name = "cbAntiCalcarSolution";
            this.cbAntiCalcarSolution.Size = new System.Drawing.Size(144, 23);
            this.cbAntiCalcarSolution.TabIndex = 2;
            this.cbAntiCalcarSolution.Text = "Anti calcar solution";
            this.cbAntiCalcarSolution.UseVisualStyleBackColor = true;
            // 
            // cbHygienizer
            // 
            this.cbHygienizer.AutoSize = true;
            this.cbHygienizer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbHygienizer.Location = new System.Drawing.Point(20, 342);
            this.cbHygienizer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbHygienizer.Name = "cbHygienizer";
            this.cbHygienizer.Size = new System.Drawing.Size(92, 23);
            this.cbHygienizer.TabIndex = 14;
            this.cbHygienizer.Text = "Hygienizer";
            this.cbHygienizer.UseVisualStyleBackColor = true;
            // 
            // cbAntiGreaseSolution
            // 
            this.cbAntiGreaseSolution.AutoSize = true;
            this.cbAntiGreaseSolution.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAntiGreaseSolution.Location = new System.Drawing.Point(20, 292);
            this.cbAntiGreaseSolution.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAntiGreaseSolution.Name = "cbAntiGreaseSolution";
            this.cbAntiGreaseSolution.Size = new System.Drawing.Size(150, 23);
            this.cbAntiGreaseSolution.TabIndex = 13;
            this.cbAntiGreaseSolution.Text = "Anti grease solution";
            this.cbAntiGreaseSolution.UseVisualStyleBackColor = true;
            // 
            // cbFloorCleaner
            // 
            this.cbFloorCleaner.AutoSize = true;
            this.cbFloorCleaner.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFloorCleaner.Location = new System.Drawing.Point(20, 268);
            this.cbFloorCleaner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFloorCleaner.Name = "cbFloorCleaner";
            this.cbFloorCleaner.Size = new System.Drawing.Size(109, 23);
            this.cbFloorCleaner.TabIndex = 12;
            this.cbFloorCleaner.Text = "Floor Cleaner";
            this.cbFloorCleaner.UseVisualStyleBackColor = true;
            // 
            // cbFreshener
            // 
            this.cbFreshener.AutoSize = true;
            this.cbFreshener.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFreshener.Location = new System.Drawing.Point(248, 170);
            this.cbFreshener.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFreshener.Name = "cbFreshener";
            this.cbFreshener.Size = new System.Drawing.Size(88, 23);
            this.cbFreshener.TabIndex = 11;
            this.cbFreshener.Text = "Freshener";
            this.cbFreshener.UseVisualStyleBackColor = true;
            // 
            // cbSoap
            // 
            this.cbSoap.AutoSize = true;
            this.cbSoap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSoap.Location = new System.Drawing.Point(248, 145);
            this.cbSoap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSoap.Name = "cbSoap";
            this.cbSoap.Size = new System.Drawing.Size(58, 23);
            this.cbSoap.TabIndex = 10;
            this.cbSoap.Text = "Soap";
            this.cbSoap.UseVisualStyleBackColor = true;
            // 
            // cbMopCap
            // 
            this.cbMopCap.AutoSize = true;
            this.cbMopCap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMopCap.Location = new System.Drawing.Point(20, 243);
            this.cbMopCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMopCap.Name = "cbMopCap";
            this.cbMopCap.Size = new System.Drawing.Size(82, 23);
            this.cbMopCap.TabIndex = 2;
            this.cbMopCap.Text = "Mop cap";
            this.cbMopCap.UseVisualStyleBackColor = true;
            // 
            // lblCleaningProducts
            // 
            this.lblCleaningProducts.AutoSize = true;
            this.lblCleaningProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCleaningProducts.Location = new System.Drawing.Point(20, 212);
            this.lblCleaningProducts.Name = "lblCleaningProducts";
            this.lblCleaningProducts.Size = new System.Drawing.Size(136, 21);
            this.lblCleaningProducts.TabIndex = 9;
            this.lblCleaningProducts.Text = "Cleaning products";
            // 
            // cbLaundrySoftener
            // 
            this.cbLaundrySoftener.AutoSize = true;
            this.cbLaundrySoftener.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbLaundrySoftener.Location = new System.Drawing.Point(248, 120);
            this.cbLaundrySoftener.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLaundrySoftener.Name = "cbLaundrySoftener";
            this.cbLaundrySoftener.Size = new System.Drawing.Size(132, 23);
            this.cbLaundrySoftener.TabIndex = 8;
            this.cbLaundrySoftener.Text = "Laundry softener";
            this.cbLaundrySoftener.UseVisualStyleBackColor = true;
            // 
            // cbLaundryPods
            // 
            this.cbLaundryPods.AutoSize = true;
            this.cbLaundryPods.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbLaundryPods.Location = new System.Drawing.Point(248, 95);
            this.cbLaundryPods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLaundryPods.Name = "cbLaundryPods";
            this.cbLaundryPods.Size = new System.Drawing.Size(112, 23);
            this.cbLaundryPods.TabIndex = 1;
            this.cbLaundryPods.Text = "Laundry pods";
            this.cbLaundryPods.UseVisualStyleBackColor = true;
            // 
            // cbToiletPaper
            // 
            this.cbToiletPaper.AutoSize = true;
            this.cbToiletPaper.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbToiletPaper.Location = new System.Drawing.Point(248, 70);
            this.cbToiletPaper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbToiletPaper.Name = "cbToiletPaper";
            this.cbToiletPaper.Size = new System.Drawing.Size(99, 23);
            this.cbToiletPaper.TabIndex = 7;
            this.cbToiletPaper.Text = "Toilet paper";
            this.cbToiletPaper.UseVisualStyleBackColor = true;
            // 
            // lblBathroom
            // 
            this.lblBathroom.AutoSize = true;
            this.lblBathroom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBathroom.Location = new System.Drawing.Point(248, 40);
            this.lblBathroom.Name = "lblBathroom";
            this.lblBathroom.Size = new System.Drawing.Size(79, 21);
            this.lblBathroom.TabIndex = 6;
            this.lblBathroom.Text = "Bathroom";
            // 
            // cbGarbageBags
            // 
            this.cbGarbageBags.AutoSize = true;
            this.cbGarbageBags.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbGarbageBags.Location = new System.Drawing.Point(20, 170);
            this.cbGarbageBags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGarbageBags.Name = "cbGarbageBags";
            this.cbGarbageBags.Size = new System.Drawing.Size(113, 23);
            this.cbGarbageBags.TabIndex = 5;
            this.cbGarbageBags.Text = "Garbage bags";
            this.cbGarbageBags.UseVisualStyleBackColor = true;
            // 
            // cbNapkins
            // 
            this.cbNapkins.AutoSize = true;
            this.cbNapkins.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbNapkins.Location = new System.Drawing.Point(20, 145);
            this.cbNapkins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNapkins.Name = "cbNapkins";
            this.cbNapkins.Size = new System.Drawing.Size(77, 23);
            this.cbNapkins.TabIndex = 4;
            this.cbNapkins.Text = "Napkins";
            this.cbNapkins.UseVisualStyleBackColor = true;
            // 
            // cbPaperRolls
            // 
            this.cbPaperRolls.AutoSize = true;
            this.cbPaperRolls.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPaperRolls.Location = new System.Drawing.Point(20, 120);
            this.cbPaperRolls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPaperRolls.Name = "cbPaperRolls";
            this.cbPaperRolls.Size = new System.Drawing.Size(92, 23);
            this.cbPaperRolls.TabIndex = 3;
            this.cbPaperRolls.Text = "Paper rolls";
            this.cbPaperRolls.UseVisualStyleBackColor = true;
            // 
            // lblKitchen
            // 
            this.lblKitchen.AutoSize = true;
            this.lblKitchen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKitchen.Location = new System.Drawing.Point(20, 40);
            this.lblKitchen.Name = "lblKitchen";
            this.lblKitchen.Size = new System.Drawing.Size(61, 21);
            this.lblKitchen.TabIndex = 2;
            this.lblKitchen.Text = "Kitchen";
            // 
            // cbDishSoap
            // 
            this.cbDishSoap.AutoSize = true;
            this.cbDishSoap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbDishSoap.Location = new System.Drawing.Point(20, 95);
            this.cbDishSoap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDishSoap.Name = "cbDishSoap";
            this.cbDishSoap.Size = new System.Drawing.Size(88, 23);
            this.cbDishSoap.TabIndex = 1;
            this.cbDishSoap.Text = "Dish soap";
            this.cbDishSoap.UseVisualStyleBackColor = true;
            // 
            // cbSponges
            // 
            this.cbSponges.AutoSize = true;
            this.cbSponges.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSponges.Location = new System.Drawing.Point(20, 70);
            this.cbSponges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSponges.Name = "cbSponges";
            this.cbSponges.Size = new System.Drawing.Size(80, 23);
            this.cbSponges.TabIndex = 0;
            this.cbSponges.Text = "Sponges";
            this.cbSponges.UseVisualStyleBackColor = true;
            // 
            // tabAgreements
            // 
            this.tabAgreements.BackgroundImage = global::Housing_Project.Properties.Resources._360_F_355607062_zYMS8jaz4SfoykpWz5oViRVKL32IabTP;
            this.tabAgreements.Controls.Add(this.rbDisagree);
            this.tabAgreements.Controls.Add(this.rbAgree);
            this.tabAgreements.Controls.Add(this.lblPendingAgreements);
            this.tabAgreements.Controls.Add(this.btnCheckStatus);
            this.tabAgreements.Controls.Add(this.btnSubmitVote);
            this.tabAgreements.Controls.Add(this.lbPendingAgreements);
            this.tabAgreements.Controls.Add(this.lbAgreementsDisplay);
            this.tabAgreements.Controls.Add(this.lblAgreements);
            this.tabAgreements.Controls.Add(this.gbMakeAProposal);
            this.tabAgreements.Location = new System.Drawing.Point(4, 34);
            this.tabAgreements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAgreements.Name = "tabAgreements";
            this.tabAgreements.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAgreements.Size = new System.Drawing.Size(1050, 514);
            this.tabAgreements.TabIndex = 4;
            this.tabAgreements.Text = "Agreements";
            this.tabAgreements.UseVisualStyleBackColor = true;
            // 
            // rbDisagree
            // 
            this.rbDisagree.AutoSize = true;
            this.rbDisagree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbDisagree.Location = new System.Drawing.Point(481, 88);
            this.rbDisagree.Name = "rbDisagree";
            this.rbDisagree.Size = new System.Drawing.Size(89, 25);
            this.rbDisagree.TabIndex = 10;
            this.rbDisagree.TabStop = true;
            this.rbDisagree.Text = "Disagree";
            this.rbDisagree.UseVisualStyleBackColor = true;
            // 
            // rbAgree
            // 
            this.rbAgree.AutoSize = true;
            this.rbAgree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbAgree.Location = new System.Drawing.Point(481, 57);
            this.rbAgree.Name = "rbAgree";
            this.rbAgree.Size = new System.Drawing.Size(69, 25);
            this.rbAgree.TabIndex = 9;
            this.rbAgree.TabStop = true;
            this.rbAgree.Text = "Agree";
            this.rbAgree.UseVisualStyleBackColor = true;
            // 
            // lblPendingAgreements
            // 
            this.lblPendingAgreements.AutoSize = true;
            this.lblPendingAgreements.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPendingAgreements.Location = new System.Drawing.Point(24, 24);
            this.lblPendingAgreements.Name = "lblPendingAgreements";
            this.lblPendingAgreements.Size = new System.Drawing.Size(198, 25);
            this.lblPendingAgreements.TabIndex = 8;
            this.lblPendingAgreements.Text = "Pending Agreements";
            // 
            // btnCheckStatus
            // 
            this.btnCheckStatus.Location = new System.Drawing.Point(481, 191);
            this.btnCheckStatus.Name = "btnCheckStatus";
            this.btnCheckStatus.Size = new System.Drawing.Size(128, 38);
            this.btnCheckStatus.TabIndex = 7;
            this.btnCheckStatus.Text = "Check Status";
            this.btnCheckStatus.UseVisualStyleBackColor = true;
            this.btnCheckStatus.Click += new System.EventHandler(this.btnCheckStatus_Click);
            // 
            // btnSubmitVote
            // 
            this.btnSubmitVote.Location = new System.Drawing.Point(481, 131);
            this.btnSubmitVote.Name = "btnSubmitVote";
            this.btnSubmitVote.Size = new System.Drawing.Size(128, 39);
            this.btnSubmitVote.TabIndex = 6;
            this.btnSubmitVote.Text = "Submit Vote";
            this.btnSubmitVote.UseVisualStyleBackColor = true;
            this.btnSubmitVote.Click += new System.EventHandler(this.btnSubmitVote_Click);
            // 
            // lbPendingAgreements
            // 
            this.lbPendingAgreements.FormattingEnabled = true;
            this.lbPendingAgreements.ItemHeight = 21;
            this.lbPendingAgreements.Location = new System.Drawing.Point(24, 57);
            this.lbPendingAgreements.Name = "lbPendingAgreements";
            this.lbPendingAgreements.Size = new System.Drawing.Size(421, 172);
            this.lbPendingAgreements.TabIndex = 5;
            this.lbPendingAgreements.SelectedIndexChanged += new System.EventHandler(this.lbPendingAgreements_SelectedIndexChanged);
            this.lbPendingAgreements.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbPendingAgreements_MouseDoubleClick);
            // 
            // lbAgreementsDisplay
            // 
            this.lbAgreementsDisplay.FormattingEnabled = true;
            this.lbAgreementsDisplay.ItemHeight = 21;
            this.lbAgreementsDisplay.Location = new System.Drawing.Point(24, 281);
            this.lbAgreementsDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAgreementsDisplay.Name = "lbAgreementsDisplay";
            this.lbAgreementsDisplay.Size = new System.Drawing.Size(585, 193);
            this.lbAgreementsDisplay.TabIndex = 2;
            this.lbAgreementsDisplay.SelectedIndexChanged += new System.EventHandler(this.lbAgreementsDisplay_SelectedIndexChanged);
            // 
            // lblAgreements
            // 
            this.lblAgreements.AutoSize = true;
            this.lblAgreements.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAgreements.Location = new System.Drawing.Point(24, 244);
            this.lblAgreements.Name = "lblAgreements";
            this.lblAgreements.Size = new System.Drawing.Size(119, 25);
            this.lblAgreements.TabIndex = 1;
            this.lblAgreements.Text = "Agreements";
            // 
            // gbMakeAProposal
            // 
            this.gbMakeAProposal.Controls.Add(this.lblDate);
            this.gbMakeAProposal.Controls.Add(this.dateTimePickerAgreements);
            this.gbMakeAProposal.Controls.Add(this.lblProposalDescription);
            this.gbMakeAProposal.Controls.Add(this.tbProposalTitle);
            this.gbMakeAProposal.Controls.Add(this.lblProposalTitle);
            this.gbMakeAProposal.Controls.Add(this.btnSubmitProposal);
            this.gbMakeAProposal.Controls.Add(this.tbProposalContent);
            this.gbMakeAProposal.Location = new System.Drawing.Point(646, 57);
            this.gbMakeAProposal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMakeAProposal.Name = "gbMakeAProposal";
            this.gbMakeAProposal.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMakeAProposal.Size = new System.Drawing.Size(381, 364);
            this.gbMakeAProposal.TabIndex = 0;
            this.gbMakeAProposal.TabStop = false;
            this.gbMakeAProposal.Text = "Propose an agreement";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(13, 287);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 19);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date:";
            // 
            // dateTimePickerAgreements
            // 
            this.dateTimePickerAgreements.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerAgreements.Location = new System.Drawing.Point(62, 283);
            this.dateTimePickerAgreements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerAgreements.Name = "dateTimePickerAgreements";
            this.dateTimePickerAgreements.Size = new System.Drawing.Size(305, 25);
            this.dateTimePickerAgreements.TabIndex = 10;
            // 
            // lblProposalDescription
            // 
            this.lblProposalDescription.AutoSize = true;
            this.lblProposalDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProposalDescription.Location = new System.Drawing.Point(13, 74);
            this.lblProposalDescription.Name = "lblProposalDescription";
            this.lblProposalDescription.Size = new System.Drawing.Size(81, 19);
            this.lblProposalDescription.TabIndex = 9;
            this.lblProposalDescription.Text = "Description:";
            // 
            // tbProposalTitle
            // 
            this.tbProposalTitle.Location = new System.Drawing.Point(59, 29);
            this.tbProposalTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbProposalTitle.Name = "tbProposalTitle";
            this.tbProposalTitle.Size = new System.Drawing.Size(308, 29);
            this.tbProposalTitle.TabIndex = 8;
            // 
            // lblProposalTitle
            // 
            this.lblProposalTitle.AutoSize = true;
            this.lblProposalTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProposalTitle.Location = new System.Drawing.Point(13, 35);
            this.lblProposalTitle.Name = "lblProposalTitle";
            this.lblProposalTitle.Size = new System.Drawing.Size(37, 19);
            this.lblProposalTitle.TabIndex = 7;
            this.lblProposalTitle.Text = "Title:";
            // 
            // btnSubmitProposal
            // 
            this.btnSubmitProposal.Location = new System.Drawing.Point(284, 322);
            this.btnSubmitProposal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitProposal.Name = "btnSubmitProposal";
            this.btnSubmitProposal.Size = new System.Drawing.Size(82, 30);
            this.btnSubmitProposal.TabIndex = 1;
            this.btnSubmitProposal.Text = "Submit";
            this.btnSubmitProposal.UseVisualStyleBackColor = true;
            this.btnSubmitProposal.Click += new System.EventHandler(this.btnSubmitProposal_Click);
            // 
            // tbProposalContent
            // 
            this.tbProposalContent.Location = new System.Drawing.Point(13, 102);
            this.tbProposalContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbProposalContent.Multiline = true;
            this.tbProposalContent.Name = "tbProposalContent";
            this.tbProposalContent.Size = new System.Drawing.Size(354, 163);
            this.tbProposalContent.TabIndex = 0;
            // 
            // tabReport
            // 
            this.tabReport.BackgroundImage = global::Housing_Project.Properties.Resources._360_F_355607062_zYMS8jaz4SfoykpWz5oViRVKL32IabTP;
            this.tabReport.Controls.Add(this.lbWarnings);
            this.tabReport.Controls.Add(this.gbFileAReport);
            this.tabReport.Controls.Add(this.lblWarnings);
            this.tabReport.Location = new System.Drawing.Point(4, 34);
            this.tabReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabReport.Size = new System.Drawing.Size(1050, 514);
            this.tabReport.TabIndex = 5;
            this.tabReport.Text = "Report a problem ";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // lbWarnings
            // 
            this.lbWarnings.FormattingEnabled = true;
            this.lbWarnings.HorizontalScrollbar = true;
            this.lbWarnings.ItemHeight = 21;
            this.lbWarnings.Location = new System.Drawing.Point(27, 324);
            this.lbWarnings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbWarnings.Name = "lbWarnings";
            this.lbWarnings.Size = new System.Drawing.Size(950, 172);
            this.lbWarnings.TabIndex = 9;
            this.lbWarnings.SelectedIndexChanged += new System.EventHandler(this.lbWarnings_SelectedIndexChanged);
            // 
            // gbFileAReport
            // 
            this.gbFileAReport.BackColor = System.Drawing.SystemColors.Window;
            this.gbFileAReport.Controls.Add(this.lblReportDescription);
            this.gbFileAReport.Controls.Add(this.tbReportTitle);
            this.gbFileAReport.Controls.Add(this.lblReportTitle);
            this.gbFileAReport.Controls.Add(this.btnSubmitReport);
            this.gbFileAReport.Controls.Add(this.tbReportContent);
            this.gbFileAReport.Controls.Add(this.cbTenantsToReport);
            this.gbFileAReport.Controls.Add(this.lblAdressReportToSomeone);
            this.gbFileAReport.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbFileAReport.Location = new System.Drawing.Point(27, 22);
            this.gbFileAReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFileAReport.Name = "gbFileAReport";
            this.gbFileAReport.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFileAReport.Size = new System.Drawing.Size(949, 263);
            this.gbFileAReport.TabIndex = 8;
            this.gbFileAReport.TabStop = false;
            this.gbFileAReport.Text = "File a report";
            this.gbFileAReport.Enter += new System.EventHandler(this.gbFileAReport_Enter);
            // 
            // lblReportDescription
            // 
            this.lblReportDescription.AutoSize = true;
            this.lblReportDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReportDescription.Location = new System.Drawing.Point(13, 76);
            this.lblReportDescription.Name = "lblReportDescription";
            this.lblReportDescription.Size = new System.Drawing.Size(81, 19);
            this.lblReportDescription.TabIndex = 13;
            this.lblReportDescription.Text = "Description:";
            // 
            // tbReportTitle
            // 
            this.tbReportTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReportTitle.Location = new System.Drawing.Point(66, 35);
            this.tbReportTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbReportTitle.Name = "tbReportTitle";
            this.tbReportTitle.Size = new System.Drawing.Size(418, 32);
            this.tbReportTitle.TabIndex = 12;
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReportTitle.Location = new System.Drawing.Point(13, 38);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(37, 19);
            this.lblReportTitle.TabIndex = 11;
            this.lblReportTitle.Text = "Title:";
            // 
            // btnSubmitReport
            // 
            this.btnSubmitReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitReport.Location = new System.Drawing.Point(647, 126);
            this.btnSubmitReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitReport.Name = "btnSubmitReport";
            this.btnSubmitReport.Size = new System.Drawing.Size(164, 34);
            this.btnSubmitReport.TabIndex = 5;
            this.btnSubmitReport.Text = "Submit report";
            this.btnSubmitReport.UseVisualStyleBackColor = true;
            this.btnSubmitReport.Click += new System.EventHandler(this.btnSubmitReport_Click);
            // 
            // tbReportContent
            // 
            this.tbReportContent.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReportContent.Location = new System.Drawing.Point(106, 76);
            this.tbReportContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbReportContent.Multiline = true;
            this.tbReportContent.Name = "tbReportContent";
            this.tbReportContent.Size = new System.Drawing.Size(378, 163);
            this.tbReportContent.TabIndex = 10;
            // 
            // cbTenantsToReport
            // 
            this.cbTenantsToReport.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTenantsToReport.FormattingEnabled = true;
            this.cbTenantsToReport.Location = new System.Drawing.Point(569, 76);
            this.cbTenantsToReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTenantsToReport.Name = "cbTenantsToReport";
            this.cbTenantsToReport.Size = new System.Drawing.Size(307, 33);
            this.cbTenantsToReport.TabIndex = 3;
            // 
            // lblAdressReportToSomeone
            // 
            this.lblAdressReportToSomeone.AutoSize = true;
            this.lblAdressReportToSomeone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdressReportToSomeone.Location = new System.Drawing.Point(588, 38);
            this.lblAdressReportToSomeone.Name = "lblAdressReportToSomeone";
            this.lblAdressReportToSomeone.Size = new System.Drawing.Size(248, 19);
            this.lblAdressReportToSomeone.TabIndex = 2;
            this.lblAdressReportToSomeone.Text = "Do you adress this report to someone?";
            // 
            // lblWarnings
            // 
            this.lblWarnings.AutoSize = true;
            this.lblWarnings.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWarnings.Location = new System.Drawing.Point(27, 296);
            this.lblWarnings.Name = "lblWarnings";
            this.lblWarnings.Size = new System.Drawing.Size(187, 28);
            this.lblWarnings.TabIndex = 6;
            this.lblWarnings.Text = "Warnings received";
            // 
            // lblStudentHouseBV
            // 
            this.lblStudentHouseBV.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblStudentHouseBV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudentHouseBV.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudentHouseBV.Image = global::Housing_Project.Properties.Resources.house;
            this.lblStudentHouseBV.Location = new System.Drawing.Point(9, 16);
            this.lblStudentHouseBV.Name = "lblStudentHouseBV";
            this.lblStudentHouseBV.Size = new System.Drawing.Size(982, 58);
            this.lblStudentHouseBV.TabIndex = 1;
            this.lblStudentHouseBV.Text = "Student House BV";
            this.lblStudentHouseBV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoutpicturebox
            // 
            this.logoutpicturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutpicturebox.Image = ((System.Drawing.Image)(resources.GetObject("logoutpicturebox.Image")));
            this.logoutpicturebox.Location = new System.Drawing.Point(997, 16);
            this.logoutpicturebox.Name = "logoutpicturebox";
            this.logoutpicturebox.Size = new System.Drawing.Size(64, 58);
            this.logoutpicturebox.TabIndex = 3;
            this.logoutpicturebox.TabStop = false;
            this.logoutpicturebox.Click += new System.EventHandler(this.logoutpicturebox_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 628);
            this.Controls.Add(this.logoutpicturebox);
            this.Controls.Add(this.lblStudentHouseBV);
            this.Controls.Add(this.tabControlStudent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStudent";
            this.Text = "Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStudent_FormClosing);
            this.tabControlStudent.ResumeLayout(false);
            this.tabHouseRules.ResumeLayout(false);
            this.tabHouseRules.PerformLayout();
            this.tabEventSchedule.ResumeLayout(false);
            this.tabEventSchedule.PerformLayout();
            this.tabSupplies.ResumeLayout(false);
            this.tabSupplies.PerformLayout();
            this.gbSupplies.ResumeLayout(false);
            this.gbSupplies.PerformLayout();
            this.tabAgreements.ResumeLayout(false);
            this.tabAgreements.PerformLayout();
            this.gbMakeAProposal.ResumeLayout(false);
            this.gbMakeAProposal.PerformLayout();
            this.tabReport.ResumeLayout(false);
            this.tabReport.PerformLayout();
            this.gbFileAReport.ResumeLayout(false);
            this.gbFileAReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutpicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TabPage tabHouseRules;
        private Label lblStudentHouseBV;
        private TabPage tabEventSchedule;
        private TabPage tabSupplies;
        private TabPage tabAgreements;
        private TabPage tabReport;
        protected TabControl tabControlStudent;
        private ListBox lbHouseRules;
        private Label lblHouseRules;
        private Label lblSupervisorContactInfo;
        private Label lblTenantsContactInfo;
        private ListBox lbTenantsContactInfo;
        private ListBox lbSupervisorInfo;
        private MonthCalendar eventCalendar;
        private Label lblTasksFor;
        private ListBox lbEvents;
        private GroupBox gbSupplies;
        private CheckBox cbDishSoap;
        private CheckBox cbSponges;
        private Label lblKitchen;
        private CheckBox cbGarbageBags;
        private CheckBox cbNapkins;
        private CheckBox cbPaperRolls;
        private CheckBox cbLaundrySoftener;
        private CheckBox cbLaundryPods;
        private CheckBox cbToiletPaper;
        private Label lblBathroom;
        private CheckBox cbMopCap;
        private Label lblCleaningProducts;
        private GroupBox gbMakeAProposal;
        private Button btnSubmitProposal;
        private TextBox tbProposalContent;
        private Label lblAgreements;
        private Button btnSubmitReport;
        private ComboBox cbTenantsToReport;
        private Label lblAdressReportToSomeone;
        private ListBox lbAgreementsDisplay;
        private CheckBox cbSoap;
        private CheckBox cbAntiCalcarSolution;
        private CheckBox cbHygienizer;
        private CheckBox cbAntiGreaseSolution;
        private CheckBox cbFloorCleaner;
        private CheckBox cbFreshener;
        private CheckBox cbGlassCleaner;
        private CheckBox cbFiberCloth;
        private TextBox tbOtherProducts;
        private Label lblOthers;
        private Label lblTotalPrice;
        private TextBox tbTotalPrice;
        private Label lblPayments;
        private ListBox lbPaymentsInfo;
        private Button btnSubmitPayment;
        private Label lblWarnings;
        private Label lblProposalDescription;
        private TextBox tbProposalTitle;
        private Label lblProposalTitle;
        private GroupBox gbFileAReport;
        private Label lblReportDescription;
        private TextBox tbReportTitle;
        private Label lblReportTitle;
        private TextBox tbReportContent;
        private Label lblDate;
        private DateTimePicker dateTimePickerAgreements;
        private PictureBox logoutpicturebox;
        private ListBox lbWarnings;
        private Button btnTaskCompleted;
        private ListBox lbCompletedTasks;
        private ListBox lbPendingAgreements;
        private Label lblPendingAgreements;
        private Button btnCheckStatus;
        private Label lblCompletedEvents;
        private RadioButton rbDisagree;
        private RadioButton rbAgree;
        private Button btnSubmitVote;
    }
}