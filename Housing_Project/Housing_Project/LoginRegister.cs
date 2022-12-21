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
        PaymentManager paymentManager = new PaymentManager();
        RuleManager ruleManager = new RuleManager();
        ReportManager reportManager = new ReportManager();
        Tenant tenant;
        Supervisor supervisor;

        //The code of Alex vvvv
        public LoginRegister()
        {
            InitializeComponent();
            tabControlLoginRegister.SelectTab("tabPageLogin");
        }

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
        private void OpenUser(Object user)
        {
            Type t = user.GetType();
            if (t == typeof(Tenant)) //if the user is a tenant it will open the TenantForm
            {
                this.Hide();
                FormStudent student = new FormStudent(user, userManager, paymentManager, agreementManager, ruleManager, reportManager);
                student.ShowDialog();
                this.Close();
            }

            if (t == typeof(Supervisor)) //if the user is a supervisor it will open the SupervisorForm
            {
                this.Hide();
                FormSupervisor supervisor = new FormSupervisor(user, userManager, ruleManager, reportManager);
                supervisor.ShowDialog();
                this.Close();
            }

        }


        //update this when tenant or supervisor objects are created from the register button
        private void loginbtn_Click(object sender, EventArgs e,object user) // actual log in button
        {
            string userName = loginemailtxt.Text;
            if (userName.Contains("student.com")  && userName.Contains("student.com") )
            {
               OpenUser(user);
               

            }
            else if (userName.Contains("supervisor.com") && userName.Contains("supervisor.com") )
            {
                OpenUser(user);
            }
            else 
            {
                if (loginemailtxt.Text!="" || loginpasswordtxt.Text != "")
                {
                    ClearFields();
                }
                else
                {
                    ClearFields();
                }
            }
        }
        private void registerbtn_Click_1(object sender, EventArgs e)// actial register
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
                        foreach(Tenant t in userManager.GetTenants())
                        {
                            if (t.Email == email)
                            {
                                MessageBox.Show("Allready registered with this email");
                            }
                            else
                            {
                                tenant = new Tenant(name, phone, email, password);
                            }
                        } 
                    }

                    else if (email.Contains("supervisor.com"))
                    {
                        foreach (Supervisor s in userManager.GetSupervisors())
                        {
                            if (s.Email == email)
                            {
                                MessageBox.Show("Allready registered with this email");
                            }
                            else
                            {
                                supervisor = new Supervisor(name, phone, email, password);
                            }
                        }
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("You need to complete all fields!");
                return;
            }
        }

        private void tabControlLoginRegister_Click(object sender, EventArgs e) //CreateAccountTAB
        {
            registerwrongcredentialslbl.Visible = false;
            loginwrongcredentialslbl.Visible=false;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string email = loginemailtxt.Text;
            string password = loginpasswordtxt.Text;

            if (email.Contains("student.com"))
            {
                foreach (Tenant t in userManager.GetTenants())
                {
                    if (t.Password == password)
                    {
                        OpenUser(t);
                    }
                    else
                    {
                        MessageBox.Show("Password is incorrect!");
                    }
                }
            }

            else if (email.Contains("supervisor.com"))
            {
                foreach (Supervisor s in userManager.GetSupervisors())
                {
                    if (s.Password == password)
                    {
                        OpenUser(s);
                    }
                    else
                    {
                        MessageBox.Show("Password is incorrect!");
                    }
                }
            }
        }

        //The code of Alex ^^^^
    }
}