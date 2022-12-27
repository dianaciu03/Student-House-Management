using Housing_Project.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Housing_Project
{
    public partial class LoginRegister : Form
    {
        UserManager userManager = new UserManager();
        AgreementManager agreementManager = new AgreementManager();
        AnnouncementManager announcementManager = new AnnouncementManager();
        CleaningTaskManager cleaningTaskManager = new CleaningTaskManager();
        PaymentManager paymentManager = new PaymentManager();
        ReportManager reportManager = new ReportManager();
        RuleManager ruleManager = new RuleManager();
        WarningManager warningManager = new WarningManager();

        public LoginRegister()
        {
            InitializeComponent();
            tabControlLoginRegister.SelectTab("tabPageLogin");
            loginwrongcredentialslbl.Visible = false;
            registerlbl.Visible = false;

            LoadData();  //load all data from the files
        }

        //Method to deserialise all managers with their specific content from the files
        public void LoadData()
        {
            try
            {
                userManager = userManager.LoadData();
                agreementManager = agreementManager.LoadData();
                announcementManager = announcementManager.LoadData();
                cleaningTaskManager = cleaningTaskManager.LoadData();
                paymentManager = paymentManager.LoadData();
                reportManager = reportManager.LoadData();
                ruleManager = ruleManager.LoadData();
                warningManager = warningManager.LoadData();
            }
            catch (Exception)
            {
                return;
            }
        }

        //Method to reset the fields
        private void ClearFields()
        {
            //Login field
            loginpasswordtxt.Clear();
            loginemailtxt.Clear();
            //Register fields
            fullnametxt.Clear();
            emailadresstxt.Clear();
            passwordtxt.Clear();
            phonenumbertxt.Clear();
        }

        //Method to open the specific form based on who is logging in
        private void OpenUser(Object user)
        {
            Type t = user.GetType();
            if (t == typeof(Tenant)) //if the user is a tenant it will open the TenantForm
            {
                this.Hide();
                FormStudent student = new FormStudent((Tenant)user, userManager, paymentManager, agreementManager, ruleManager, reportManager, warningManager, cleaningTaskManager);
                student.ShowDialog();
                this.Close();
            }

            else if (t == typeof(Supervisor)) //if the user is a supervisor it will open the SupervisorForm
            {
                this.Hide();
                FormSupervisor supervisor = new FormSupervisor((Supervisor)user, userManager, announcementManager, ruleManager, reportManager, warningManager, cleaningTaskManager);
                supervisor.ShowDialog();
                this.Close();
            }
        }

        private void registerbtn_Click_1(object sender, EventArgs e)
        {
            try 
            {
                string name = fullnametxt.Text;
                string email = emailadresstxt.Text;
                string phone = phonenumbertxt.Text;
                string password = passwordtxt.Text;

                if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(email) && !String.IsNullOrEmpty(phone) && !String.IsNullOrEmpty(password))
                {
                    if (email.Contains("student.com"))
                    {
                        if (userManager.GetTenants().Length > 0)
                        {
                            foreach (Tenant t in userManager.GetTenants())
                            {
                                if (t.Email == email)
                                {
                                    registerlbl.Visible = true;
                                    registerlbl.Text = "Already registered with this email";
                                    ClearFields();
                                }
                                else
                                {
                                    Tenant tenant = new Tenant(name, phone, email, password);
                                    userManager.AddTenantToList(tenant);
                                    MessageBox.Show("Account created successfully!");
                                    userManager.WriteData(userManager);
                                    ClearFields();
                                }
                            }
                        }
                            
                        else
                        {
                            Tenant tenant = new Tenant(name, phone, email, password);
                            userManager.AddTenantToList(tenant);
                            MessageBox.Show("Account created successfully!");
                            userManager.WriteData(userManager);
                            ClearFields();
                        }
                    }

                    else if (email.Contains("supervisor.com"))
                    {
                        if (userManager.GetSupervisors().Length > 0)
                        {
                            foreach (Supervisor s in userManager.GetSupervisors())
                            {
                                if (s.Email == email)
                                {
                                    registerlbl.Visible = true;
                                    registerlbl.Text = "Already registered with this email";
                                    ClearFields();
                                }
                                else
                                {
                                    Supervisor supervisor = new Supervisor(name, phone, email, password);
                                    userManager.AddSupervisorToList(supervisor);
                                    MessageBox.Show("Account created successfully!");
                                    userManager.WriteData(userManager);
                                    ClearFields();
                                }
                            } 
                        }

                        else
                        {
                            Supervisor supervisor = new Supervisor(name, phone, email, password);
                            userManager.AddSupervisorToList(supervisor);
                            MessageBox.Show("Account created successfully!");
                            userManager.WriteData(userManager);
                            ClearFields();
                        }
                        
                    }
                }
                else
                {
                    registerlbl.Visible = true;
                    registerlbl.Text = "You need to complete all fields!";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void tabControlLoginRegister_Click(object sender, EventArgs e) //CreateAccountTAB
        {
            registerlbl.Visible = false;
            registerlbl.Visible = false;
            ClearFields();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string email = loginemailtxt.Text;
            string password = loginpasswordtxt.Text;

            if (email.Contains("student.com"))
            {
                foreach (Tenant t in userManager.GetTenants())
                {
                    if (t.Email == email && t.Password == password)
                    {
                        OpenUser(t);
                        break;
                    }
                    else
                        loginwrongcredentialslbl.Visible = true;
                }
            }

            else if (email.Contains("supervisor.com"))
            {
                foreach (Supervisor s in userManager.GetSupervisors())
                {
                    if (s.Email == email && s.Password == password)
                    {
                        OpenUser(s);
                        break;
                    }
                    else
                        loginwrongcredentialslbl.Visible = true;
                }
            }
        }

        private void LoginRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            userManager.WriteData(userManager);
        }
    }
}