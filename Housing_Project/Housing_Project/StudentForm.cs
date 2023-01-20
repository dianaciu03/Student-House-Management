using Housing_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Rule = Housing_Project.Classes.Rule;
using System.Security.Cryptography.X509Certificates;

namespace Housing_Project
{
    public partial class FormStudent : Form
    {
        List<CheckBox> checkBoxes  = new List<CheckBox>();
        private Tenant currentUser;
        private UserManager userManager;
        private PaymentManager paymentManager;
        private AgreementManager agreementManager;
        private RuleManager ruleManager;
        private ReportManager reportManager;
        private WarningManager warningManager;
        private CleaningTaskManager cleaningTaskManager;
        private AnnouncementManager announcementManager;
        FileManager fileManager = new FileManager();
        public FormStudent(Tenant currentUser, UserManager userManager, PaymentManager paymentManager, AgreementManager agreementManager, RuleManager ruleManager, ReportManager reportManager, WarningManager warningManager, CleaningTaskManager cleaningTaskManager, AnnouncementManager announcementManager)
        {
            InitializeComponent();
            InitializeManagers(currentUser, userManager, paymentManager, agreementManager, ruleManager, reportManager, warningManager, cleaningTaskManager, announcementManager);
            InitializeStudentComboBoxes();
            this.Text = $"{currentUser}";
            UpdateListBox();
            
            //Array of checkboxes
            checkBoxes = new List<CheckBox>
            {
                cbSponges, cbDishSoap, cbPaperRolls, cbNapkins, cbGarbageBags, cbToiletPaper, cbLaundryPods, cbLaundrySoftener, cbSoap,
                cbFreshener, cbMopCap, cbFloorCleaner, cbAntiGreaseSolution, cbAntiCalcarSolution, cbHygienizer, cbFiberCloth, cbGlassCleaner
            };
        }

        private void tabControlStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearFiealds();
            UpdateListBox();
        }

        private void InitializeManagers(Tenant currentUser, UserManager userManager, PaymentManager paymentManager, AgreementManager agreementManager, RuleManager ruleManager, ReportManager reportManager, WarningManager warningManager, CleaningTaskManager cleaningTaskManager, AnnouncementManager announcementManager)
        {
            this.announcementManager = announcementManager;
            this.currentUser = currentUser;
            this.userManager = userManager;
            this.paymentManager = paymentManager;
            this.agreementManager = agreementManager;
            this.ruleManager = ruleManager;
            this.reportManager = reportManager;
            this.warningManager = warningManager;
            this.cleaningTaskManager = cleaningTaskManager;
           
            this.warningManager = warningManager.LoadWarning("warningData.txt");
            agreementManager.SetSessionTenant(currentUser);
            this.cleaningTaskManager=cleaningTaskManager.LoadCleaningTask("cleaningTaskData.txt");
            this.announcementManager=announcementManager.LoadAnnouncement("announcementData.txt");

            this.agreementManager = agreementManager.LoadAgreement("agreementData.txt");
        }

        private void InitializeStudentComboBoxes()
        {
            foreach (Tenant t in userManager.Tenants)
            {
                if (t != currentUser)
                {
                    cbTenantsToReport.Items.Add(t);
                }
            }

            foreach(Warning w in warningManager.GetWarningsTenant(currentUser))
                lbWarnings.Items.Add(w);
        }
        
        private void UpdateListBox()
        {
            if (tabControlStudent.SelectedTab == tabHouseRules)
            {
                lbHouseRules.Items.Clear();
                lbTenantsContactInfo.Items.Clear();
                lbSupervisorInfo.Items.Clear();

                foreach (Rule r in ruleManager.GetRules())
                    lbHouseRules.Items.Add(r);


                foreach (Tenant t in userManager.GetTenants())
                    lbTenantsContactInfo.Items.Add(t.GetInfo());
                foreach (Supervisor s in userManager.GetSupervisors())
                    lbSupervisorInfo.Items.Add(s.GetInfo());
            }
            else if (tabControlStudent.SelectedTab == tabEventSchedule)
            {
                monthCalendar_DateChanged(this,DateRangeEventArgs.Empty);
            }
            else if (tabControlStudent.SelectedTab == tabSupplies)
            {
                lbPaymentsInfo.Items.Clear();
                foreach (Payment p in paymentManager.GetPayments())
                    lbPaymentsInfo.Items.Add(p);
            }
            else if (tabControlStudent.SelectedTab == tabAgreements)
            {
                lbPendingAgreements.Items.Clear();
                foreach (Agreement a in agreementManager.GetNoncompletedAgreements(agreementManager))
                    lbPendingAgreements.Items.Add(a);
                lbAgreementsDisplay.Items.Clear();
                foreach (Agreement a in agreementManager.GetCompletedAgreements(agreementManager))
                    lbAgreementsDisplay.Items.Add(a);
            }
            else if (tabControlStudent.SelectedTab == tabReport)
            {
                lbWarnings.Items.Clear();
                foreach (Warning w in warningManager.GetWarningsTenant(currentUser))
                {
                    lbWarnings.Items.Add(w.GetInfoWarning());
                }
            }
        }

        private void ClearFiealds()
        {
            if (tabControlStudent.SelectedTab == tabSupplies)
            {
                foreach (CheckBox checkBox in checkBoxes)
                {
                    if (checkBox.Checked)
                    {
                        checkBox.Checked = false;
                    }
                }
                tbTotalPrice.Clear();
                tbOtherProducts.Clear();
            }
            else if (tabControlStudent.SelectedTab == tabAgreements)
            {
                tbProposalTitle.Clear();
                tbReportContent.Clear();
            }
            else if (tabControlStudent.SelectedTab == tabReport)
            {
                tbReportTitle.Clear();
                tbReportContent.Clear();
                cbTenantsToReport.SelectedIndex = -1;
            }
        }

        //
        //EVENT SCHEDULE TAB
        //

        private void btnTaskCompleted_Click(object sender, EventArgs e)
        {
            agreementManager.CompleteAgreementById(lbEvents.SelectedIndex);
        }
        private void monthCalendar_DateChanged(object sender, EventArgs e)
        {
            lbEvents.Items.Clear();
            lbCompletedTasks.Items.Clear();
            DateTime selectedDate = eventCalendar.SelectionRange.Start;
            
            foreach (Agreement agreementInfo in agreementManager.GetAgreementsOnDate(selectedDate))
            {
                if (agreementInfo.completion == false)
                {
                    lbEvents.Items.Add(agreementInfo.GetInfoAgreementDisplay());
                }
                else if (agreementInfo.completion == true)
                {
                    lbCompletedTasks.Items.Add(agreementInfo);
                }
            }
            foreach(CleaningTask cleaningTask in cleaningTaskManager.GetCleaningTaskOnDate(selectedDate))
            {
                lbEvents.Items.Add(cleaningTask.GetInfo());
            }
            foreach (Announcement announcement in announcementManager.GetAnnouncementsOnDate(selectedDate))
            {
                lbEvents.Items.Add(announcement.GetAnnouncementInfo());
            }
        }
        private void lbTasks_MouseDoubleClick(object sender, MouseEventArgs e)//lbvents
        {
            try
            {
                if (lbEvents.Items.Count > 0)
                {
                    foreach (Announcement announcement in announcementManager.GetAnnouncemens())
                    {
                        if (lbEvents.SelectedItem.ToString() == announcement.GetAnnouncementInfo().ToString())
                        {
                            MessageBox.Show(announcement.GetAnnouncementInfo()); // edit the message box
                        }
                    }
                    foreach (CleaningTask cleaningTask in cleaningTaskManager.GetCleaningTasks())
                    {
                        if (lbEvents.SelectedItem.ToString() == cleaningTask.GetInfo().ToString())// edit the message box
                        {
                            MessageBox.Show(cleaningTask.GetInfo());
                        }
                    }
                    foreach (Agreement agreement in agreementManager.GetAgreements())
                    {
                        if (lbEvents.SelectedItem.ToString() == agreement.GetInfoAgreementDisplay().ToString())// edit the message box
                        {
                            MessageBox.Show(agreement.GetInfoAgreement());
                        }
                    }
                    //int index = lbEvents.SelectedIndex;

                }
            }
            catch (Exception exception) {}
        }

        private void lbCompletedTasks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbCompletedTasks.Items.Count > 0)
            {
                int index = lbCompletedTasks.SelectedIndex;
                MessageBox.Show(agreementManager.GetAgreement(index).GetInfoAgreement());
            }
        }
        private void tabEventSchedule_Click(object sender, EventArgs e)
        {
            if (lbCompletedTasks.SelectedIndex != -1)
            {
                lbEvents.Items.Add(lbCompletedTasks.SelectedValue);
            }
        }
        //
        //SUPPLIES TAB
        //

        private void btnSubmitPayment_Click(object sender, EventArgs e)
        {
            try
            {
                lbPaymentsInfo.Items.Clear();
                List<string> items = new List<string>();
                Tenant buyer = currentUser;
                double totalPrice = 0;
                totalPrice = Convert.ToDouble(tbTotalPrice.Text);

                // Loop through the array of checkboxes
                foreach (CheckBox checkBox in checkBoxes)
                {
                    if (checkBox.Checked)
                    {
                        items.Add(checkBox.Text);
                    }
                }

                if (!String.IsNullOrEmpty(tbOtherProducts.Text))
                    items.Add(tbOtherProducts.Text);

                if (items.Count > 0 && totalPrice > 0)
                {
                    Payment payment = new Payment(items, buyer, totalPrice);
                    paymentManager.AddPaymentToList(payment);
                    paymentManager.WritePaymentManagerData(paymentManager, "paymentData.txt");
                }
                UpdateListBox();
                ClearFiealds();                
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
            }
        }

        //Get more details about a payment
        private void lbPaymentsInfo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Payment payment = (Payment)lbPaymentsInfo.SelectedItem;
                double pricePerPerson = paymentManager.CalculatePricePerPerson(payment, userManager.NumberOfTenants());
                MessageBox.Show(payment.GetInfoPayment(pricePerPerson));
            }
            catch (Exception exception){}
        }

        //
        //AGREEMENTS TAB
        //
        private void btnSubmitProposal_Click(object sender, EventArgs e)
        {
            lbPendingAgreements.Items.Clear();

            try
            {
                string title = tbProposalTitle.Text;
                string description = tbProposalContent.Text;
                DateTime date = dateTimePickerAgreements.Value;

                if(!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(description))
                {
                    agreementManager.AddAgreementToList(title, description, date);
                    agreementManager.SaveAgreement(agreementManager, "agreementData.txt");
                    //agreementManager.SaveRecruiter(agreementManager);
                    
                }       
                UpdateListBox();
                ClearFiealds();
                tbProposalContent.Clear();
            }
            catch(Exception) {}
        }
        private void lbPendingAgreements_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (lbPendingAgreements.Items.Count > 0)
                {
                    int index = lbPendingAgreements.SelectedIndex;
                    MessageBox.Show(agreementManager.GetAgreement(index).GetInfoAgreement());
                }
            }
            catch (Exception exception){}

        }
        private void btnSubmitVote_Click(object sender, EventArgs e)
        {
            string itemString = lbPendingAgreements.SelectedItem.ToString();
            int id = Convert.ToInt32(itemString.Split(".")[0]) -1;
            if (rbAgree.Checked)
            {
                rbAgree.Visible = true;
                rbDisagree.Visible = true;
                btnSubmitVote.Visible= true;    
                agreementManager.AgreeToAgreement(id);
                foreach (Agreement a in agreementManager.GetAgreements())
                    lbAgreementsDisplay.Items.Add(a);
            }
            if (rbDisagree.Checked)
            {
                rbAgree.Visible = true;
                rbDisagree.Visible = true;
                btnSubmitVote.Visible = true;
                agreementManager.DisagreeToAgreement(id);
            }
            lbPendingAgreements_SelectedIndexChanged(sender, e);
        }
        private void lbPendingAgreements_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string itemString = lbPendingAgreements.SelectedItem.ToString();
                int id = Convert.ToInt32(itemString.Split(".")[0]) - 1;
                if (agreementManager.HasTenantVotedForAgreementByID(id))
                {
                    rbAgree.Visible = false;
                    rbDisagree.Visible = false;
                    btnSubmitVote.Visible = false;
                }
                else
                {
                    rbAgree.Visible = true;
                    rbDisagree.Visible = true;
                    btnSubmitVote.Visible = true;
                }
                agreementManager.SaveAgreement(agreementManager, "agreementData.txt");
                //fileManager.SaveRecruiter(agreementManager, "agreementData.txt");
            }
            catch (Exception exception){}
            
        }
        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            string itemString = lbPendingAgreements.SelectedItem.ToString();
            int id = Convert.ToInt32(itemString.Split(".")[0]) - 1;
            int[] votes = agreementManager.GetAgreementVotesByID(id);
            MessageBox.Show($"Agree: {votes[0]}\n\nDisagree: {votes[1]}");
        }

        //
        //REPORT TAB
        //

        //Create a report and send it to the supervisor
        private void btnSubmitReport_Click(object sender, EventArgs e)
        {
            try
            {
                string title = tbReportTitle.Text;
                string description = tbReportContent.Text;
                Tenant personAdress = (Tenant)cbTenantsToReport.SelectedItem;

                if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(description))
                {
                    if(personAdress != null)
                    {
                        Report report = new Report(title, description, personAdress);
                        reportManager.AddReportToList(report);
                        reportManager.SaveReport(reportManager, "reportData.txt");
                        MessageBox.Show("Report has been sent successfully!");
                        ClearFiealds();
                    }                        
                    else
                    {
                        Report report = new Report(title, description);
                        reportManager.AddReportToList(report);
                        reportManager.SaveReport(reportManager, "reportData.txt");
                        MessageBox.Show("Report has been sent successfully!");
                        ClearFiealds();
                    }                                                                                                                                                                                                                                                                                                                                                                                                             
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid input!");
            }
        }

        //
        //Logout
        //
        private void logoutpicturebox_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginRegister loginpage= new LoginRegister();
            loginpage.ShowDialog();
        }

        private void FormStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            agreementManager.SaveAgreement(agreementManager, "agreementData.txt");
            announcementManager.SaveAnnouncement(announcementManager, "announcementData.txt");
            warningManager.SaveWarning(warningManager, "warningData.txt");
            cleaningTaskManager.SaveCleaningTask(cleaningTaskManager, "cleaningTaskData.txt");
        }

        private void gbFileAReport_Enter(object sender, EventArgs e)
        {

        }

        private void lbWarnings_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lbAgreementsDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbPaymentsInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbCompletedTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
