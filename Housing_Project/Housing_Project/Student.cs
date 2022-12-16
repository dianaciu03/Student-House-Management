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

namespace Housing_Project
{
    public partial class FormStudent : Form
    {
        CheckBox[] checkBoxes;
        public FormStudent()
        {
            InitializeComponent();
            //we need to add info to list boxes in contact info tab when we initialize the FormStudent


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
           // DateTime date = MonthCalendar.ModifierKeys
        }
        
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            lbTasks.Items.Clear();
            DateTime selectedDate = eventCalendar.SelectionRange.Start;
            List<Agreement> selectedAgreements = new List<Agreement>();
            selectedAgreements = AgreementManager.GetAgreementsOnDate(selectedDate);
            
            foreach (Agreement agreementInfo in selectedAgreements)
            {
                lbTasks.Items.Add(agreementInfo);
                
            }

        }
        private void lbTasks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbTasks.SelectedIndex;
            MessageBox.Show(AgreementManager.GetAgreement(index).GetInfoAgreement());
        }

        //
        //SUPPLIES TAB
        //

        private void btnSubmitPayment_Click(object sender, EventArgs e)
        {
            lbPaymentsInfo.Items.Clear();
            
            List<string> items = new List<string>();
            string buyer = "CurrentTenant.Name";
            double totalPrice = 0;
 
            try
            {
                totalPrice = Convert.ToDouble(tbTotalPrice.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
            }

            // Loop through the array of checkboxes
            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    items.Add(checkBox.Text);
                }
            }

            try
            {
                if (!String.IsNullOrEmpty(tbOtherProducts.Text))
                    items.Add(tbOtherProducts.Text);
            }
            catch(Exception)
            {
                return;
            }

            if (items.Count > 0 && totalPrice > 0)
            {
                PaymentManager.AddPaymentToList(items, buyer, totalPrice);
            }

            foreach (Payment p in PaymentManager.GetPayments())
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

        private void lbPaymentsInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbPaymentsInfo.SelectedIndex;
            PaymentManager.CalculatePricePerPerson(PaymentManager.GetPayment(index));
            MessageBox.Show(PaymentManager.GetPayment(index).GetInfoPayment());
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
                    AgreementManager.AddAgreementToList(title, description, date);
                }

                foreach (Agreement a in AgreementManager.GetAgreements()) 
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
            MessageBox.Show(AgreementManager.GetAgreement(index).GetInfoAgreement());
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

                //foreach (Agreement a in AgreementManager.GetAgreements())
                    //lbAgreementsDisplay.Items.Add(a);
            }
            catch(Exception)
            {
                return;
            }
        }

        private void tabControlStudent_Click(object sender, EventArgs e)
        {

        }

        private void logoutpicturebox_Click(object sender, EventArgs e)
        {

        }
    }
}
