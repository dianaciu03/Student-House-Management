﻿using Housing_Project.Classes;
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

namespace Housing_Project
{
    public partial class FormStudent : Form
    {
        
        CheckBox[] checkBoxes;
        private Tenant currentUser;
        private UserManager userManager;
        private PaymentManager paymentManager;
        private AgreementManager agreementManager;
        private RuleManager ruleManager;
        private ReportManager reportManager;
        
        public FormStudent(Object currentUser, UserManager userManager, PaymentManager paymentManager, AgreementManager agreementManager, RuleManager ruleManager, ReportManager reportManager)
        {
            
            InitializeComponent();
            this.currentUser = (Tenant) currentUser;
            this.userManager = userManager;
            this.paymentManager = paymentManager;
            this.agreementManager = agreementManager;
            this.ruleManager = ruleManager;
            this.reportManager = reportManager;

            //we need to add info to list boxes in contact info tab when we initialize the FormStudent
            this.Text = $"{currentUser}";

            //Array of checkboxes
            checkBoxes = new CheckBox[]
            {
                cbSponges, cbDishSoap, cbPaperRolls, cbNapkins, cbGarbageBags, cbToiletPaper, cbLaundryPods, cbLaundrySoftener, cbSoap,
                cbFreshener, cbMopCap, cbFloorCleaner, cbAntiGreaseSolution, cbAntiCalcarSolution, cbHygienizer, cbFiberCloth, cbGlassCleaner
            };
        }

        //
        //EVENT SCHEDULE TAB
        //

        private void btnSendReportTask_Click(object sender, EventArgs e)
        {
            //nothing yet
        }
        
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            lbTasks.Items.Clear();
            DateTime selectedDate = eventCalendar.SelectionRange.Start;
            List<Agreement> selectedAgreements = new List<Agreement>();
            selectedAgreements = agreementManager.GetAgreementsOnDate(selectedDate);
            
            foreach (Agreement agreementInfo in selectedAgreements)
            {
                lbTasks.Items.Add(agreementInfo);
            }

        }
        private void lbTasks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbTasks.SelectedIndex;
            MessageBox.Show(agreementManager.GetAgreement(index).GetInfoAgreement());
        }

        //
        //SUPPLIES TAB
        //

        private void btnSubmitPayment_Click(object sender, EventArgs e)
        {
            lbPaymentsInfo.Items.Clear();
            List<string> items = new List<string>();

            Tenant buyer = currentUser;
            double totalPrice = 0;
 
            try
            {
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
                    paymentManager.AddPaymentToList(items, buyer, totalPrice);
                
                //make method to update listboxes like in supervisor page
                foreach (Payment p in paymentManager.GetPayments())
                    lbPaymentsInfo.Items.Add(p);

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
                }

                foreach (Agreement a in agreementManager.GetAgreements()) 
                    lbAgreementsDisplay.Items.Add(a);
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
                    
                }

                foreach (Agreement a in agreementManager.GetAgreements())
                    lbAgreementsDisplay.Items.Add(a);
            }
            catch(Exception)
            {
                return;
            }
        }

        private void tabControlStudent_Click(object sender, EventArgs e)
        {
            //update tabs like in supervisor form
        }

        private void logoutpicturebox_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginRegister loginpage= new LoginRegister();
            this.Close();
            loginpage.ShowDialog();
            
        }

        private void lbPaymentsInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

  
    }
}
