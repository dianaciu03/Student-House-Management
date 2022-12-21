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
        //denitsa VVV
        cleaningTask cleaning;
        CheckBox [] checkBoxes;
        private Supervisor currentUser;
        private UserManager userManager;
        private RuleManager ruleManager;
        private ReportManager reportManager;
        cleaningTask task;
        Announcement announcement;

        public FormSupervisor(Object currentUser, UserManager userManager, RuleManager ruleManager, ReportManager reportManager)
        {
            InitializeComponent();
       
            this.currentUser = (Supervisor)currentUser;
            this.userManager = userManager;
            this.ruleManager = ruleManager;
            this.reportManager = reportManager;

            foreach (Tenant t in userManager.Tenants)
                cbSelectTenantToAssignTask.Items.Add(t);
            

            this.Text = $"{currentUser}";//upper bar text
            btnSubmitChanges.Visible = false;
            btnSubmitChangesTenant.Visible = false;

            checkBoxes = new CheckBox[]
           {
                cbCleanBathroom1,cbCleanBathroom2,cbCleanTheKitchen,cbCleanTheLivingRoom,cbCleanTheStarirs,cbTakeOutTheTrash

           };
        }

        //Update tab on click
        private void tabControlSupervisor_Click(object sender, EventArgs e)
        {
            if (tabControlSupervisor.SelectedTab == tabRules)
            {
                UpdateListBox("tabRules");
                ClearFields("tabRules");
            }
            else if (tabControlSupervisor.SelectedTab == tabContactInfo)
            {
                UpdateListBox("tabContactInfo");
                ClearFields("tabContactInfoTenant");
                ClearFields("tabContactInfoSupervisor");
            }
            else if (tabControlSupervisor.SelectedTab == tabManageReports)
            {
                UpdateListBox("tabManageReports");
                ClearFields("tabManageReports");
            }
        }

        //Method to update the listbox from a tab
        private void UpdateListBox(string tab)
        {

            if (tab == "tabRules")
            {
                rulesListBox.Items.Clear();
                foreach (Rule r in ruleManager.GetRules())
                    rulesListBox.Items.Add(r);
            }
            else if (tab == "tabContactInfo")
            {
                lbTenantsInfo.Items.Clear();
                foreach (Tenant t in userManager.GetTenants())
                    lbTenantsInfo.Items.Add(t);
            }
            else if (tab == "tabManageReports")
            {
                lbReceivedReports.Items.Clear();
                cbTenantToSendWarning.Items.Clear();

                foreach(Tenant t in userManager.GetTenants())
                    cbTenantToSendWarning.Items.Add(t);

                foreach (Report r in reportManager.GetReports())
                    lbReceivedReports.Items.Add(r);
            }
        }

        //Method to clear the fields from a tab
        private void ClearFields(string tab)
        {
            if (tab == "tabRules")
            {
                indexBox.Clear();
                subjecttxt.Clear();
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
        }
        
        //
        //RULE TAB
        //

        private void addNewRule_Click(object sender, EventArgs e)
        {
            try
            {
                string subject = subjecttxt.Text;
                string description = tbRule.Text;

                if (!String.IsNullOrEmpty(subject) && !String.IsNullOrEmpty(description))
                    ruleManager.AddRuleToList(subject, description, currentUser);

                UpdateListBox("tabRules");
            }
            catch (Exception)
            {
                return;
            }
        }

        //Open message box for more details about selected rule
        private void rulesListBox_DoubleClick(object sender, EventArgs e) 
        {
            int index = rulesListBox.SelectedIndex;
            MessageBox.Show(ruleManager.GetRule(index).GetInfoRule());
        }

        //Push details about the selected rule back in the textboxes
        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Rule rule = (Rule)rulesListBox.SelectedItem;
                indexBox.Text = rule.RuleID.ToString();
                subjecttxt.Text = rule.Subject;
                tbRule.Text = rule.Message;

                editbtnRules.Visible = false;
                btnSubmitChanges.Visible = true;

                rulesListBox.SelectionMode = SelectionMode.None;
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
                Rule rule = (Rule)rulesListBox.SelectedItem;

                if (!String.IsNullOrEmpty(subjecttxt.Text))
                    rule.Subject = subjecttxt.Text;
                if (!String.IsNullOrEmpty(tbRule.Text))
                    rule.Message = tbRule.Text;

                editbtnRules.Visible = true;
                btnSubmitChanges.Visible = false;

                UpdateListBox("tabRules");
                ClearFields("tabRules");
                rulesListBox.SelectionMode = SelectionMode.One;
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

                UpdateListBox("tabContactInfo");
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
                //indexboxUsers.Text = tenant.TenantID.ToString();
                tbTenantEmail.Text = tenant.Email;
                tbTenantName.Text = tenant.Name;
                tbTenantPhone.Text = tenant.PhoneNumber;

                edittenantbtn.Visible = false;
                btnSubmitChangesTenant.Visible = true;
                lbTenantsInfo.SelectionMode = SelectionMode.None;
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
                btnSubmitChangesTenant.Visible = false;
                lbTenantsInfo.SelectionMode = SelectionMode.One;
            }
            catch (Exception)
            {
                return;
            }

        }

        //
        //MANAGE REPORTS TAB
        //
        private void lbReceivedReports_DoubleClick(object sender, EventArgs e)
        {
            int index = lbReceivedReports.SelectedIndex;
            MessageBox.Show(reportManager.GetReport(index).GetInfoReport());
        }
        private void btnRemoveReport_Click(object sender, EventArgs e)
        {
            try
            {
                Report report = (Report)lbReceivedReports.SelectedItem;
                reportManager.RemoveReportFromList(report);
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
                    userManager.AddWarningToTenantList(warningAdressedTo, warning);
                }
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


            List<cleaningTask> tasks = new List<cleaningTask>();
            string assignedPerson1 = cbSelectTenantToAssignTask.Text; 
            //foreach (CheckBox checkBox in checkBoxes)
            //{
            //    if (checkBox.Checked)
            //    {
            //        task.tasks1.Add(checkBox.Text);
            //    }
            //}
           string date =  dateTimePicker1.Text;
            task = new cleaningTask(assignedPerson1, date);
            lbEvents.Items.Add(task.GetInfo());
        }

        private void btnSubmitAnnouncement_Click(object sender, EventArgs e)
        {
            string announcement1 = tbAnnouncementTitle.Text;
            string description = tbAnnouncementDescription.Text;
            string date = dateTimePicker2.Text;
            announcement = new Announcement(announcement1, description, date);
            MessageBox.Show(announcement.GetAnnouncementInfo());
        }

        //Log out button
        private void logoutpicturebox_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginRegister loginpage = new LoginRegister();
            this.Close();
            loginpage.ShowDialog();
        }

        private void tbAnnouncementDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
