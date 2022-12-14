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

namespace Housing_Project
{
    public partial class FormSupervisor : Form
    {
        //we need to make class rule and class tenant in order to add objects to the lists instead of strings
        List<string> rules = new List<string>();
        List<string> tenants = new List<string>();
       
        public FormSupervisor()
        {
            InitializeComponent();        
        }

        private void btnSubmitChanges_Click(object sender, EventArgs e)
        {
            //
            //string found_rule = rules.ElementAt(numberofrule);
            //string new_rule = tbRule.Text;
            //rules.Remove(found_rule);
            //rules.Add(new_rule);
        }
        private void addNewRule_Click(object sender, EventArgs e)
        {
            string rule_to_be_added = tbRule.Text;
            rules.Add(rule_to_be_added);
        }

        //private void btnEditSelectedRule_Click(object sender, EventArgs e)
        //{
        //    int ruleID = Convert.ToInt32(numRuleNr.Text);
        //    //tbRule.Show(Rule.GetDescription(ruleID));
        //}

        private void btnAddTenant_Click(object sender, EventArgs e)
        {
            //we need constructor for tenant
            //Tenant tenant = new Tenant(tbTenantName.Text, tbTenantEmail.Text, tbTenantPhone.Text, Convert.ToInt32(tbRoomNr.Text));
            //tenants.Add(tenant);
        }
    }
}
