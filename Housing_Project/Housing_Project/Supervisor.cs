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
using Rule = Housing_Project.Classes.Agreements_Problems.Rule;

namespace Housing_Project
{
    public partial class FormSupervisor : Form
    {
        //we need to make class rule and class tenant in order to add objects to the lists instead of strings
        //List<Classes.Agreements_Problems.Rule> rules;

        private int selectedIndex;
        public FormSupervisor()
        {
            InitializeComponent();

            selectedIndex = -1;
            btnSubmitChanges.Visible = false;
            btnSubmitChangesTenant.Visible= false;
        }
        private void tabControlSupervisor_Click(object sender, EventArgs e)
        {
            if (tabControlSupervisor.SelectedTab == tabRules)
            {
                Refresh("tabRules");
            }
            else if (tabControlSupervisor.SelectedTab == tabContactInfo)
            {
                Refresh("tabContactInfo");
            }
            

        }
        private void Refresh(string Tab)
        {

            selectedIndex = -1; //both

            if (Tab=="tabRules")
            {
                btnSubmitChanges.Visible = false;
                showinfobtn.Visible = true; //supervisor
                //supervisor
                subjecttxt.Text = "";
                tbRule.Text = "";
                indexBox.Clear(); //supervisor
                lbRules.Items.Clear();//supervisor
                lbRules.SelectionMode = SelectionMode.One;

                for (int i = 0; i < Rule.GetRules().Count; i++)
                {
                    lbRules.Items.Add($"Number {i + 1}: {Rule.GetRules()[i].GetInfo("short")}");
                }
            }

            else if (Tab== "tabContactInfo")
            {
                btnAddTenant.Visible = true;
                edittenantbtn.Visible = true;
                btnSubmitChangesTenant.Visible = false;
                indexboxTenants.Clear(); //tenant
                //tenant
                tbTenantName.Text = "";
                tbTenantEmail.Text = "";
                tbTenantPhone.Text = "";
                tbRoomNumber.Text = "";

                lbTenantsInfo.Items.Clear(); //tenant
                lbTenantsInfo.SelectionMode = SelectionMode.One;
                for (int i = 0; i < Tenant.GetTenants().Count; i++)
                {
                    lbTenantsInfo.Items.Add($"Number {i + 1}: {Tenant.GetTenants()[i].GetInfo()}");
                }
            }
            
        }
        private void EditUser(string supervisorOrtenant)
        {
            if (supervisorOrtenant == "supervisor")
            {
                if (lbRules.SelectedIndex != -1)
                {
                    btnSubmitChanges.Visible = false;
                    showinfobtn.Visible = false;
                    for (int i = 0; i < Rule.GetRules().Count; i++)
                    {
                        if (lbRules.SelectedItem.ToString() == $"Number {i + 1}: {Rule.GetRules()[i].GetInfo("short")}")//
                        {
                            editbtn.Visible = false;
                            btnSubmitChanges.Visible = true;

                            subjecttxt.Text = Rule.GetRules()[i].Subject;
                            tbRule.Text = Rule.GetRules()[i].Message;
                            selectedIndex = i;
                            indexBox.Text = (selectedIndex + 1).ToString();
                        }
                    }
                    lbRules.SelectionMode = SelectionMode.None;
                }
            }

            if (supervisorOrtenant == "tenant")
            {
                if (lbTenantsInfo.SelectedIndex != -1)
                {
                    btnAddTenant.Visible = false;
                    for (int i = 0; i < Tenant.GetTenants().Count; i++)
                    {
                        if (lbTenantsInfo.SelectedItem.ToString() == $"Number {i + 1}: {Tenant.GetTenants()[i].GetInfo()}")
                        {
                            edittenantbtn.Visible = false;
                            btnSubmitChangesTenant.Visible = true;

                            tbTenantName.Text = Tenant.GetTenants()[i].Name;
                            tbTenantEmail.Text = Tenant.GetTenants()[i].Email;
                            tbTenantPhone.Text = Tenant.GetTenants()[i].PhoneNumber;
                            tbRoomNumber.Text = (Tenant.GetTenants()[i].RoomNumber).ToString();

                            selectedIndex = i;
                            indexboxTenants.Text = (selectedIndex + 1).ToString();
                        }
                    }
                    lbTenantsInfo.SelectionMode = SelectionMode.None;
                }
            }
        }
        private void SubmitChanges(string supervisorOrtenant)
        {
            if (supervisorOrtenant == "supervisor")
            {
                if (tbRule.Text != "" && subjecttxt.Text != "")
                {
                    Rule.PushChanges(indexBox, subjecttxt, tbRule);
                }
                Refresh("tabRules");
            }

            if (supervisorOrtenant == "tenant")
            {
                if (tbTenantName.Text != "" && tbTenantEmail.Text != "" && tbTenantPhone.Text != "" && tbRoomNumber.Text != "")
                {
                    Tenant.PushChanges(indexboxTenants, tbTenantName, tbTenantEmail, tbTenantPhone, tbRoomNumber);
                }
                Refresh("tabContactInfo");
            }
        }

        //Supervisor
        private void addNewRule_Click(object sender, EventArgs e)
        {
            Rule.AddRule(subjecttxt,tbRule);
            Refresh("tabRules");
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            EditUser("supervisor");
        }

        private void btnSubmitChanges_Click(object sender, EventArgs e)
        {
            SubmitChanges("supervisor");
        }

        private void showinfobtn_Click(object sender, EventArgs e)
        {
            if (lbRules.SelectedIndex != -1)
            {
                Rule.DisplayFullInfo(lbRules);
            }
        }

        //Tenant
        private void btnAddTenant_Click(object sender, EventArgs e)
        {
            Tenant.AddTenant(tbTenantName, tbTenantEmail,tbTenantPhone,tbRoomNumber);
            Refresh("tabContactInfo");
        }

        private void edittenantbtn_Click(object sender, EventArgs e)
        {
            EditUser("tenant");
        }

        private void btnSubmitChangesTenant_Click(object sender, EventArgs e)
        {
            SubmitChanges("tenant");
        }
    }
}
