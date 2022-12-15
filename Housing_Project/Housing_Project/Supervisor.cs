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

namespace Housing_Project
{
    public partial class FormSupervisor : Form
    {
        Report report;
        cleaningTask cleaning;
        //we need to make class rule and class tenant in order to add objects to the lists instead of strings
        List<string> rules = new List<string>();
        List<string> tenants = new List<string>();
       
        public FormSupervisor()
        {
            cbSelectTenantToAssignTask.Text = "E";
            InitializeComponent();        
        }

        private void btnSubmitChanges_Click(object sender, EventArgs e)
        {
            //int numberofrule = Convert.ToInt32(numRuleNr.Text);
            //string found_rule = rules.ElementAt(numberofrule);
            string new_rule = tbRule.Text;
            //rules.Remove(found_rule);
            rules.Add(new_rule);
        }
        private void addNewRule_Click(object sender, EventArgs e)
        {
            string rule_to_be_added = tbRule.Text;
            rules.Add(rule_to_be_added);
        }

        private void btnEditSelectedRule_Click(object sender, EventArgs e)
        {
            //int ruleID = Convert.ToInt32(numRuleNr.Text);
            //tbRule.Show(Rule.GetDescription(ruleID));
        }

        private void btnAddTenant_Click(object sender, EventArgs e)
        {
            //we need constructor for tenant
            //Tenant tenant = new Tenant(tbTenantName.Text, tbTenantEmail.Text, tbTenantPhone.Text, Convert.ToInt32(tbRoomNr.Text));
            //tenants.Add(tenant);
        }

        private void btnSendWarning_Click(object sender, EventArgs e)
        {
            report = new Report(tbtitle.Text,tbdescription.Text,tbadressedPerson.Text);
            MessageBox.Show(report.GetInfo());
        }

        private void btnSubmitTask_Click(object sender, EventArgs e)
        {
            //DateRangeEventHandler dateSelected = monthCalendarSupervisor.selcte;
            //cleaning.SetDate(monthCalendarSupervisor.ToString())
            cleaning.GetDate(); 
            if (cbCleanBathroom1.Checked)
            {
                lbEvents.Text = cbCleanBathroom1.Text + cleaning.GetInfo();
               
            }
           else  if (cbCleanBathroom2.Checked)
            {
                lbEvents.Text = cbCleanBathroom2.Text + cleaning.GetInfo();
            }
           else if (cbCleanTheKitchen.Checked)
            {
                lbEvents.Text = cbCleanTheKitchen.Text + cleaning.GetInfo();
            }
           else if (cbCleanTheLivingRoom.Checked)
            {
                lbEvents.Text = cbCleanTheLivingRoom.Text + cleaning.GetInfo();
            }
            else if (cbCleanTheStarirs.Checked)
            {
                lbEvents.Text = cbCleanTheStarirs.Text + cleaning.GetInfo();
            }
  
            else if (cbTakeOutTheTrash.Checked)
            {
                lbEvents.Text = cbTakeOutTheTrash.Text + cleaning.GetInfo();
            }
       
        }

        private void btnSubmitAnnouncement_Click(object sender, EventArgs e)
        {
            string announcement = tbAnnouncementTitle.Text;
            string description = tbAnnouncementDescription.Text;
            MessageBox.Show($"Title:{announcement},Description:{description}");

        }
    }
}
