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
        FileManager fileManager = new FileManager();
        public FormStudent(Tenant currentUser, UserManager userManager, PaymentManager paymentManager, AgreementManager agreementManager, RuleManager ruleManager, ReportManager reportManager, WarningManager warningManager, CleaningTaskManager cleaningTaskManager)
        {
            InitializeComponent();
            InitializeManagers(currentUser, userManager, paymentManager, agreementManager, ruleManager, reportManager, warningManager, cleaningTaskManager);
            InitializeStudentComboBoxes();
            this.Text = $"{currentUser}";
            UpdateListBox();
            
            //Array of checkboxes
            checkBoxes = new List<CheckBox>
            {
                cbSponges, cbDishSoap, cbPaperRolls, cbNapkins, cbGarbageBags, cbToiletPaper, cbLaundryPods, cbLaundrySoftener, cbSoap,
                cbFreshener, cbMopCap, cbFloorCleaner, cbAntiGreaseSolution, cbAntiCalcarSolution, cbHygienizer, cbFiberCloth, cbGlassCleaner
            };
            
            foreach (var item in warningManager.GetWarningsTenant(currentUser))
            {
                lbWarnings.Items.Add(item.GetInfoWarningDisplay());
            }
        }

        private void tabControlStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearFiealds();
            UpdateListBox();
        }

        private void InitializeManagers(Tenant currentUser, UserManager userManager, PaymentManager paymentManager, AgreementManager agreementManager, RuleManager ruleManager, ReportManager reportManager, WarningManager warningManager, CleaningTaskManager cleaningTaskManager)
        {
            this.currentUser = currentUser;
            this.userManager = userManager;
            this.paymentManager = paymentManager;
            this.agreementManager = agreementManager;
            this.ruleManager = ruleManager;
            this.reportManager = reportManager;
            this.warningManager = warningManager;
            this.cleaningTaskManager = cleaningTaskManager;
            agreementManager.SetSessionTenant(currentUser);
        }

        private void InitializeStudentComboBoxes()
        {
            foreach (Tenant t in userManager.Tenants)
                cbTenantsToReport.Items.Add(t);

            foreach (Tenant t in userManager.Tenants)
                cbTenantToReportTask.Items.Add(t);
            foreach(Warning w in warningManager.GetWarningsTenant(currentUser)) { lbWarnings.Items.Add(w); }    
        }
        
        private void UpdateListBox()
        {
            if(tabControlStudent.SelectedTab == tabHouseRules)
            {
                lbHouseRules.Items.Clear();
                lbTenantsContactInfo.Items.Clear();
                lbSupervisorInfo.Items.Clear();

                foreach (Rule r in ruleManager.GetRules())
                    lbHouseRules.Items.Add(r);
                
                
                foreach(Tenant t in userManager.GetTenants())
                    lbTenantsContactInfo.Items.Add(t.GetInfo());
                foreach(Supervisor s in userManager.GetSupervisors())
                    lbSupervisorInfo.Items.Add(s.GetInfo());
            }
            else if(tabControlStudent.SelectedTab == tabEventSchedule)
            {
                lbEvents.Items.Clear();
            }
            else if(tabControlStudent.SelectedTab == tabSupplies)
            {
                lbPaymentsInfo.Items.Clear();
                foreach (Payment p in paymentManager.GetPayments())
                    lbPaymentsInfo.Items.Add(p);
            }
            else if (tabControlStudent.SelectedTab == tabAgreements)
            {
                lbPendingAgreements.Items.Clear();
                foreach (Agreement a in agreementManager.GetNoncompletedAgreements())
                    lbPendingAgreements.Items.Add(a);
                lbAgreementsDisplay.Items.Clear();
                foreach (Agreement a in agreementManager.GetCompletedAgreements())
                    lbAgreementsDisplay.Items.Add(a);
            }
            else if (tabControlStudent.SelectedTab == tabReport)
            {
                lbWarnings.Items.Clear();
                foreach (Warning w in warningManager.GetWarningsTenant(currentUser))
                {
                    lbWarnings.Items.Add(w.GetInfoWarning());
                }
                //^^^^ this needs fixing
            }
        }

        private void ClearFiealds()
        {
            if (tabControlStudent.SelectedTab == tabEventSchedule)
            {
                cbReportTask.SelectedIndex = -1;
                tbCommentReportTask.Clear();
            }
            else if (tabControlStudent.SelectedTab == tabSupplies)
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

        private void btnSendReportTask_Click(object sender, EventArgs e)
        {
            try
            {
                string reportTitle = cbReportTask.Text;
                string reportContent = tbCommentReportTask.Text;
                Tenant personReported = (Tenant)cbTenantToReportTask.SelectedItem;

                //needs implemenation
            }
            catch(Exception) {}
        }
        private void btnTaskCompleted_Click(object sender, EventArgs e)
        {
            agreementManager.CompleteAgreementById(lbEvents.SelectedIndex);
        }
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            lbEvents.Items.Clear();
            lbCompletedTasks.Items.Clear();
            DateTime selectedDate = eventCalendar.SelectionRange.Start;
            
            foreach (Agreement agreementInfo in agreementManager.GetAgreementsOnDate(selectedDate))
            {
                if (agreementInfo.completion == false)
                {
                    lbEvents.Items.Add(agreementInfo);
                }
                else if (agreementInfo.completion == true)
                {
                    lbCompletedTasks.Items.Add(agreementInfo);
                }
            }
        }
        private void lbTasks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbEvents.SelectedIndex;
            MessageBox.Show(agreementManager.GetAgreement(index).GetInfoAgreement());
        }
        private void lbCompletedTasks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbCompletedTasks.SelectedIndex;
            MessageBox.Show(agreementManager.GetAgreement(index).GetInfoAgreement());
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
                    paymentManager.WritePaymentManagerData(paymentManager);
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
            Payment payment = (Payment)lbPaymentsInfo.SelectedItem;
            double pricePerPerson = paymentManager.CalculatePricePerPerson(payment, userManager.NumberOfTenants());
            MessageBox.Show(payment.GetInfoPayment(pricePerPerson));
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
                    fileManager.SaveRecruiter(agreementManager, "agreementData.txt"); 
                    
                }       
                UpdateListBox();
            }
            catch(Exception) {}
        }
        private void lbPendingAgreements_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbPendingAgreements.SelectedIndex;
            MessageBox.Show(agreementManager.GetAgreement(index).GetInfoAgreement());
        }
        private void btnSubmitVote_Click(object sender, EventArgs e)
        {
            string itemString = lbPendingAgreements.SelectedItem.ToString();
            int id = Convert.ToInt32(itemString.Split(".")[0]) -1;
            if (rbAgree.Checked)
            {
                agreementManager.AgreeToAgreement(id);
            }
            if (rbDisagree.Checked)
            {
                agreementManager.DisagreeToAgreement(id);
            }
            lbPendingAgreements_SelectedIndexChanged(sender, e);
        }
        private void lbPendingAgreements_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemString = lbPendingAgreements.SelectedItem.ToString();
            int id = Convert.ToInt32(itemString.Split(".")[0]) - 1;
            if (agreementManager.HasTenantVotedForAgreementByID(id))
            {
                rbAgree.Visible= false;
                rbDisagree.Visible= false;
                btnSubmitVote.Visible= false;
            }
            else
            {
                rbAgree.Visible= true;
                rbDisagree.Visible= true;
                btnSubmitVote.Visible= true;
            }
            fileManager.SaveRecruiter(agreementManager, "agreementData.txt");
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
                        reportManager.WriteReportManagerData(reportManager);
                        MessageBox.Show("Report has been sent successfully!");
                        ClearFiealds();
                    }                        
                    else
                    {
                        Report report = new Report(title, description);
                        reportManager.AddReportToList(report);
                        reportManager.WriteReportManagerData(reportManager);
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
            fileManager.SaveRecruiter(agreementManager, "agreementData.txt");

            warningManager.SaveRecruiter(warningManager, "warningData.txt");
            cleaningTaskManager.SaveRecruiter(cleaningTaskManager, "cleaningTaskData.txt");
        }

        private void gbFileAReport_Enter(object sender, EventArgs e)
        {

        }

        private void lbWarnings_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.warningManager = warningManager.LoadRecruiter("warningData.txt");
            foreach (var item in warningManager.GetWarningsTenant(this.currentUser))
            {
                lbWarnings.Items.Add(item.GetInfoWarningDisplay());
            }
        }

        private void lbHouseRules_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
