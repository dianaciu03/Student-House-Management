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

            userManager.LoadData();
            paymentManager.LoadData();
            agreementManager.LoadData();
            ruleManager.LoadData();
            reportManager.LoadData();
            warningManager.LoadData();
            cleaningTaskManager.LoadData();
        }

        private void InitializeStudentComboBoxes()
        {
            foreach (Tenant t in userManager.Tenants)
                cbTenantsToReport.Items.Add(t);

            foreach (Tenant t in userManager.Tenants)
                cbTenantToReportTask.Items.Add(t);
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
                    lbTenantsContactInfo.Items.Add(t);
                foreach(Supervisor s in userManager.GetSupervisors())
                    lbSupervisorInfo.Items.Add(s);
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
                lbAgreementsDisplay.Items.Clear();
                foreach (Agreement a in agreementManager.GetAgreements())
                    lbAgreementsDisplay.Items.Add(a);
            }
            else if (tabControlStudent.SelectedTab == tabReport)
            {
                lbWarnings.Items.Clear();
                foreach (Warning w in warningManager.GetWarningsTenant(currentUser))
                    lbWarnings.Items.Add(w);
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
            catch(Exception)
            {
                return;
            }
        }
        
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            lbEvents.Items.Clear();
            DateTime selectedDate = eventCalendar.SelectionRange.Start;
            
            foreach (Agreement agreementInfo in agreementManager.GetAgreementsOnDate(selectedDate))
            {
                lbEvents.Items.Add(agreementInfo);
            }

        }
        private void lbTasks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbEvents.SelectedIndex;
            MessageBox.Show(agreementManager.GetAgreement(index).GetInfoAgreement());
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
                    paymentManager.WriteData(paymentManager);
                }

                UpdateListBox();
                ClearFiealds();                
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
            }
        }

        private void lbPaymentsInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbPaymentsInfo.SelectedIndex;
            double pricePerPerson = paymentManager.CalculatePricePerPerson(paymentManager.GetPayment(index), userManager.NumberOfTenants());
            MessageBox.Show(paymentManager.GetPayment(index).GetInfoPayment(pricePerPerson));
        }

        //
        //AGREEMENTS TAB
        //
        private void btnSubmitProposal_Click(object sender, EventArgs e)
        {
            lbAgreementsDisplay.Items.Clear();

            try
            {
                string title = tbProposalTitle.Text;
                string description = tbProposalContent.Text;
                DateTime date = dateTimePickerAgreements.Value;

                if(!String.IsNullOrEmpty(title) && !String.IsNullOrEmpty(description))
                {
                    agreementManager.AddAgreementToList(title, description, date);
                    agreementManager.WriteData(agreementManager);
                }
                UpdateListBox();
            }
            catch(Exception)
            {
                return;
            }
        }

        private void lbAgreementsDisplay_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbAgreementsDisplay.SelectedIndex;
            MessageBox.Show(agreementManager.GetAgreement(index).GetInfoAgreement());
        }


        //
        //REPORT TAB
        //
        private void btnSubmitReport_Click(object sender, EventArgs e)
        {
            try
            {
                string title = tbReportTitle.Text;
                string description = tbReportContent.Text;
                tbReportTitle.Text = "";
                tbReportContent.Text = "";
                if (!String.IsNullOrEmpty(title) && !String.IsNullOrEmpty(description))
                {
                    //needs implementation
                }

            }
            catch(Exception)
            {
                return;
            }
        }

        private void logoutpicturebox_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginRegister loginpage= new LoginRegister();
            this.Close();
            loginpage.ShowDialog();
            
        }

        private void FormStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            userManager.WriteData(userManager);
            paymentManager.WriteData(paymentManager);
            agreementManager.WriteData(agreementManager);
            ruleManager.WriteData(ruleManager);
            reportManager.WriteData(reportManager);
            warningManager.WriteData(warningManager);
            cleaningTaskManager.WriteData(cleaningTaskManager);
        }


    }
}
