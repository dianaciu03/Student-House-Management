using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
using Housing_Project.Classes;
using Microsoft.VisualBasic;
using Rule = Housing_Project.Classes.Rule;
using System.Xml.Linq;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace Housing_Project
{
    public partial class FormSupervisor : Form
    {
        CheckBox [] checkBoxes;
        private Supervisor currentUser;
        private UserManager userManager;
        private AnnouncementManager announcementManager;
        private RuleManager ruleManager;
        private ReportManager reportManager;
        private WarningManager warningManager;
        private CleaningTaskManager cleaningTaskManager;
        //FileManagerAnnouncement fileManagerAnnouncement;

        public FormSupervisor(Supervisor currentUser, UserManager userManager, AnnouncementManager announcementManager, RuleManager ruleManager, ReportManager reportManager, WarningManager warningManager, CleaningTaskManager cleaningTaskManager)
        {
            InitializeComponent();
            InitializeManagers(currentUser, userManager, announcementManager, ruleManager, reportManager, warningManager, cleaningTaskManager);
            InitializeTenantComboBoxes();
            UpdateListBox();

            this.Text = $"{currentUser}";//upper bar text

            checkBoxes = new CheckBox[]
            {
                cbCleanBathroom1,cbCleanBathroom2,cbCleanTheKitchen,cbCleanTheLivingRoom,cbCleanTheStarirs,cbTakeOutTheTrash
            };
        }

        private void InitializeManagers(Supervisor currentUser, UserManager userManager, AnnouncementManager announcementManager, RuleManager ruleManager, ReportManager reportManager, WarningManager warningManager, CleaningTaskManager cleaningTaskManager)
        {
            this.currentUser = currentUser;
            this.userManager = userManager;
            this.announcementManager = announcementManager;
            this.ruleManager = ruleManager;
            this.reportManager = reportManager;
            this.warningManager = warningManager;
            this.cleaningTaskManager = cleaningTaskManager;
        }

        private void InitializeTenantComboBoxes()
        {
            foreach (Tenant t in userManager.Tenants)
                cbSelectTenantToAssignTask.Items.Add(t);

            foreach (Tenant t in userManager.Tenants)
                cbTenantToSendWarning.Items.Add(t);
        }

        //Update content when chaging tabs
        private void tabControlSupervisor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlSupervisor.SelectedTab == tabRules)
            {
                UpdateListBox();
                ClearFields("tabRules");
            }
            else if (tabControlSupervisor.SelectedTab == tabContactInfo)
            {
                UpdateListBox();
                ClearFields("tabContactInfoTenant");
                ClearFields("tabContactInfoSupervisor");
            }
            else if (tabControlSupervisor.SelectedTab == tabManageReports)
            {
                UpdateListBox();
                ClearFields("tabManageReports");
            }
            else if (tabControlSupervisor.SelectedTab == tabAddEvents)
            {
                UpdateListBox();
                ClearFields("tabAddEventsAnnouncement");
            }
        }

        //Method to update the listbox from a tab
        private void UpdateListBox()
        {
            if (tabControlSupervisor.SelectedTab == tabRules)
            {
                rulesListBox.Items.Clear();
                foreach (Rule r in ruleManager.GetRules())
                    rulesListBox.Items.Add(r);
            }
            else if (tabControlSupervisor.SelectedTab == tabContactInfo)
            {
                lbTenantsInfo.Items.Clear();
                foreach (Tenant t in userManager.GetTenants())
                    lbTenantsInfo.Items.Add(t);
                lbSupervisorsInfo.Items.Clear();
                foreach (Supervisor s in userManager.GetSupervisors())
                    lbSupervisorsInfo.Items.Add(s);
            }
            else if (tabControlSupervisor.SelectedTab == tabManageReports)
            {
                lbReceivedReports.Items.Clear();
                cbTenantToSendWarning.Items.Clear();

                foreach(Tenant t in userManager.GetTenants())
                    cbTenantToSendWarning.Items.Add(t);

                foreach (Report r in reportManager.GetReports())
                    lbReceivedReports.Items.Add(r);
            }
            else if (tabControlSupervisor.SelectedTab == tabAddEvents)
            {
                lbEvents.Items.Clear();

                foreach (Announcement a in announcementManager.GetAnnouncemens())
                {
                    lbEvents.Items.Add(a.Title);
                }

                foreach (CleaningTask t in cleaningTaskManager.GetCleaningTasks())
                {
                    lbEvents.Items.Add(t.GetInfo());
                }
            }
        }

        //Method to clear the fields from a tab
        private void ClearFields(string tab)
        {
            if (tab == "tabRules")
            {
                indexBox.Clear();
                tbRule.Clear();
            }
            else if (tab == "tabContactInfoTenant")
            {
                tbTenantName.Clear();
                tbTenantEmail.Clear();
                tbTenantPhone.Clear();
                tbRoomNumber.Clear();
                indexboxUsers.Clear();
            }
            else if (tab == "tabContactInfoSupervisor")
            {
                tbSupervisorName.Clear();
                tbSupervisorEmail.Clear();
                tbSupervisorPhone.Clear();
                indexboxUsers.Clear();
            }
            else if (tab == "tabManageReports")
            {
                cbTenantToSendWarning.SelectedIndex = -1;
                tbWarningSubject.Clear();
                tbWarningDescription.Clear();
            }
            else if (tab == "tabAddEventsCleaningTask")
            {
                cbSelectTenantToAssignTask.SelectedIndex = -1;
                foreach (CheckBox checkBox in checkBoxes)
                {
                    if (checkBox.Checked)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
            else if (tab == "tabAddEventsAnnouncements")
            {
                tbAnnouncementTitle.Clear();
                tbAnnouncementDescription.Clear();
            }
        }

        //
        //RULE TAB
        //

        private void addNewRule_Click(object sender, EventArgs e)
        {
            try
            {
                string description = tbRule.Text;

                if (!String.IsNullOrEmpty(description))
                    ruleManager.AddRuleToList(description, currentUser);
                UpdateListBox();
                ruleManager.WriteRuleManagerData( ruleManager, "ruleData.txt");
            }
            catch (Exception)
            {
                return;
            }
        }

        //Open message box for more details about selected rule
        private void rulesListBox_DoubleClick(object sender, EventArgs e)
        {
            Rule rule = (Rule)rulesListBox.SelectedItem;
            MessageBox.Show(rule.GetInfoRule());
        }

        //Push details about the selected rule back in the textboxes
        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                btnSubmitChanges.Visible = true;
                editingrulenumberrules.Visible = true;
                indexBox.Visible = true;

                Rule rule = (Rule)rulesListBox.SelectedItem;
                indexBox.Text = rule.RuleID.ToString();
                tbRule.Text = rule.Message;
            }
            catch (Exception)
            {
                return;
            }
        }

        //Submit changes made to the rule 
        private void btnSubmitChanges_Click(object sender, EventArgs e)
        {
            try
            {
                btnSubmitChanges.Visible = false;
                editingrulenumberrules.Visible = false;
                indexBox.Visible = false;

                Rule rule = (Rule)rulesListBox.SelectedItem;
                if (!String.IsNullOrEmpty(tbRule.Text))
                    rule.Message = tbRule.Text;

                UpdateListBox();
                ruleManager.WriteRuleManagerData(ruleManager, "ruleData.txt");
                ClearFields("tabRules");
            }
            catch (Exception)
            {
                return;
            }
        }

        //
        //CONTACT INFO
        //

        //Manage Tenant Details
        private void btnAddTenant_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbTenantName.Text;
                string email = tbTenantEmail.Text;
                string phone = tbTenantPhone.Text;
                int roomNumber = Convert.ToInt32(tbRoomNumber.Text);

                if(!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(email) && !String.IsNullOrEmpty(phone) && !String.IsNullOrEmpty(roomNumber.ToString())) 
                {
                    Tenant tenant = new Tenant(name, email, phone);
                    userManager.AddTenantToList(tenant);
                }
                userManager.SaveRecruiter(userManager, "userData.txt");
                UpdateListBox();
                ClearFields("tabContactInfoTenant");
            }
            catch(Exception)
            {
                return;
            }           
        }

        //Push details about the selected tenant back in the textboxes
        private void edittenantbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Tenant tenant = (Tenant)lbTenantsInfo.SelectedItem;
                indexboxUsers.Text = (1 + lbTenantsInfo.SelectedIndex).ToString();
                tbTenantEmail.Text = tenant.Email;
                tbTenantName.Text = tenant.Name;
                tbTenantPhone.Text = tenant.PhoneNumber;

                edittenantbtn.Visible = false;
                btnAddTenant.Visible = false;
                btnSubmitChangesTenant.Visible = true;
            }
            catch(Exception)
            {
                return;
            }
        }

        //Submit changes made to the tenant
        private void btnSubmitChangesTenant_Click(object sender, EventArgs e)
        {
            try
            {
                Tenant tenant = (Tenant)lbTenantsInfo.SelectedItem;

                if (!String.IsNullOrEmpty(tbTenantName.Text))
                    tenant.Name = tbTenantName.Text;
                if (!String.IsNullOrEmpty(tbTenantEmail.Text))
                    tenant.Email = tbTenantEmail.Text;
                if (!String.IsNullOrEmpty(tbTenantPhone.Text))
                    tenant.PhoneNumber = tbTenantPhone.Text;

                edittenantbtn.Visible = true;
                btnAddTenant.Visible = true;
                btnSubmitChangesTenant.Visible = false;
                ClearFields("tabContactInfoSupervisor");
                userManager.SaveRecruiter(userManager, "userData.txt");
            }
            catch (Exception)
            {
                return;
            }
        }

        //Manage Supervisor Details
        private void btnAddSupervisor_Click(object sender, EventArgs e)
        {
            try
            {
                string email = tbSupervisorEmail.Text;
                string name = tbSupervisorName.Text;
                string phone = tbSupervisorPhone.Text;

                if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(email) && !String.IsNullOrEmpty(phone))
                {
                    Supervisor supervisor = new Supervisor(name, email, phone);
                    userManager.AddSupervisorToList(supervisor);
                }

                UpdateListBox();
                ClearFields("tabContactInfoTenant");
                userManager.SaveRecruiter(userManager, "userData.txt");
            }
            catch (Exception)
            {
                return;
            }
        }

        //Push details about the selected tenant back in the textboxes
        private void btnEditSupervisor_Click(object sender, EventArgs e)
        {
            try
            {
                Supervisor supervisor = (Supervisor)lbSupervisorsInfo.SelectedItem;
                indexboxUsers.Text = (1 + lbSupervisorsInfo.SelectedIndex).ToString();
                tbSupervisorEmail.Text = supervisor.Email;
                tbSupervisorName.Text = supervisor.Name;
                tbSupervisorPhone.Text = supervisor.PhoneNumber;

                btnEditSupervisor.Visible = false;
                btnAddSupervisor.Visible = false;
                btnSubmitChangesSupervisor.Visible = true;
            }
            catch (Exception)
            {
                return;
            }
        }

        //Submit changes made to the supervisor
        private void btnSubmitChangesSupervisor_Click(object sender, EventArgs e)
        {
            try
            {
                Supervisor supervisor = (Supervisor)lbSupervisorsInfo.SelectedItem;

                if (!String.IsNullOrEmpty(tbSupervisorName.Text))
                    supervisor.Name = tbSupervisorName.Text;
                if (!String.IsNullOrEmpty(tbSupervisorEmail.Text))
                    supervisor.Email = tbSupervisorEmail.Text;
                if (!String.IsNullOrEmpty(tbSupervisorPhone.Text))
                    supervisor.PhoneNumber = tbSupervisorPhone.Text;

                btnEditSupervisor.Visible = true;
                btnAddSupervisor.Visible = true;
                btnSubmitChangesSupervisor.Visible = false;
                ClearFields("tabContactInfoSupervisor");
                userManager.SaveRecruiter(userManager, "userData.txt");
            }
            catch (Exception)
            {
                return;
            }
        }

        //
        //MANAGE REPORTS TAB
        //

        //Get more info if you double click on the report
        private void lbReceivedReports_DoubleClick(object sender, EventArgs e)
        {
            Report report = (Report)lbReceivedReports.SelectedItem;
            MessageBox.Show(report.GetInfoReport());
        }

        //When an issue is solved, the report is removed
        private void btnRemoveReport_Click(object sender, EventArgs e)
        {
            try
            {
                Report report = (Report)lbReceivedReports.SelectedItem;
                reportManager.RemoveReportFromList(report);
                reportManager.SaveReport(reportManager, "reportData.txt");
            }
            catch(Exception)
            {
                return;
            }
        }

        private void btnSendWarning_Click(object sender, EventArgs e)
        {
            try
            {
                Tenant warningAdressedTo = (Tenant)cbTenantToSendWarning.SelectedItem;
                string title = tbWarningSubject.Text;
                string message = tbWarningDescription.Text;

                if(!String.IsNullOrEmpty(title) && !String.IsNullOrEmpty(message))
                {
                    Warning warning = new Warning(title, message, warningAdressedTo, currentUser);
                    warningManager.AddWarningToList(warning);
                    MessageBox.Show("Warning sent successfully!");
                    warningManager.SaveWarning(warningManager, "warningData.txt");
                }
                cbTenantToSendWarning.Text = "";
                tbWarningDescription.Text = "";
                tbWarningSubject.Text = "";
            }
            catch (Exception)
            {
                return;
            }
        }

        //
        //ASSIGN TASKS TAB
        //
        private void btnSubmitTask_Click(object sender, EventArgs e)
        {
            try
            {
                Tenant assignedPerson = (Tenant)cbSelectTenantToAssignTask.SelectedItem; 
                DateTime date = dateTimePickerTask.Value;
                List<string> content = new List<string>();

                foreach (CheckBox checkBox in checkBoxes)
                {
                    if (checkBox.Checked)
                    {
                        content.Add(checkBox.Text);
                    }
                }

                if(content.Count > 0)
                {

                    CleaningTask cleaningTask = new CleaningTask(assignedPerson, date, content);
                    cleaningTaskManager.AddCleaningTaskToList(cleaningTask);
                    lbEvents.Items.Add(cleaningTask.GetInfo());
                    cleaningTaskManager.SaveCleaningTask(cleaningTaskManager, "cleaningTaskData.txt");
                    ClearFields("tabAddEventsCleaningTask");
                }
            }
            catch(Exception)
            {
                return;
            }
        }

        private void btnSubmitAnnouncement_Click(object sender, EventArgs e)
        {
            string title = tbAnnouncementTitle.Text;
            string description = tbAnnouncementDescription.Text;
            DateTime date = dateTimePickerAnnouncement.Value;

            if (!String.IsNullOrEmpty(title) && !String.IsNullOrEmpty(description))
            {
                try
                {

                    if (!String.IsNullOrEmpty(title) && !String.IsNullOrEmpty(description))
                    {
                        Announcement announcement = new Announcement(title, description, date);
                        announcementManager.AddAnnouncementToList(announcement);
                        lbEvents.Items.Add(announcement.GetAnnouncementInfo());
                        announcementManager.SaveAnnouncement(announcementManager, "announcementData.txt");
                    }
                }
                catch(Exception) { return; }
            }
        }

        //Log out button
        private void logoutpicturebox_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginRegister loginPage = new LoginRegister();
            this.Close();
            loginPage.ShowDialog();
        }

        private void FormSupervisor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //fileManagerAnnouncement.SaveRecruiter(announcementManager, "announcementData.txt");
           
            userManager.SaveRecruiter(userManager, "userData.txt");
            //ruleManager.SaveRecruiter(ruleManager, "ruleData.txt");
            //reportManager.SaveRecruiter(reportManager, "reportData.txt");
            //warningManager.SaveRecruiter(warningManager, "warningData.txt");
            //cleaningTaskManager.SaveRecruiter(cleaningTaskManager, "cleaningTaskData.txt");
        }
    }
}
