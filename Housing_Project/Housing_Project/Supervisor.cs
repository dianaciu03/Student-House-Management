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
    public partial class Supervisor : Form
    {
        
        List<string> rules = new List<string>();
        Tenant tenant;
       
        public Supervisor()
        {
            InitializeComponent();
            tbrule.Visible = false;
            lbresult2.Visible = false;
            
            
        }

        private void Supervisor_Load(object sender, EventArgs e)
        {

        }

        private void report_problem_Click(object sender, EventArgs e)
        {
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void editRul_Click(object sender, EventArgs e)
        {
            tbrule.Visible = true;
            int numberofrule = Convert.ToInt32(tbnumberofrule.Text);
            string found_rule = rules.ElementAt(numberofrule);
            string new_rule = tbrule.Text;
            rules.Remove(found_rule);
            rules.Add(new_rule);
        }

        private void addNewRule_Click(object sender, EventArgs e)
        {
            tbrule.Visible = true;
            string rule_to_be_added = tbrule.Text;
            rules.Add(rule_to_be_added);
        }

        private void Add_user_Click(object sender, EventArgs e)
        {

        }

        private void add_user_Click_1(object sender, EventArgs e)
        {
            lbresult2.Visible = true;
            tenant = new Tenant(tbname.Text, tbemail.Text, tbnrofapartment.Text);

        }

        private void add_tenant_Click(object sender, EventArgs e)
        {
            CheckBox dynamicCheckBox = new CheckBox();
            dynamicCheckBox.Text = tenant.GetTenant();
            Controls.Add(dynamicCheckBox);
        }
    }
}
