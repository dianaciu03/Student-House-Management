using Housing_Project.Classes;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Housing_Project
{
    public partial class LoginRegister : Form
    {
        UserManager userManager = new UserManager();
        AgreementManager agreementManager = new AgreementManager();
        PaymentManager paymentManager = new PaymentManager();
        RuleManager ruleManager = new RuleManager();
        ReportManager reportManager = new ReportManager();

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
        private void loginbtn_Click(object sender, EventArgs e) // actual log in button
        {
            if (loginemailtxt.Text == "1" && loginpasswordtxt.Text == "1" || (loginemailtxt.Text == "0" && loginpasswordtxt.Text == "0"))
            {
                OpenUser(user);
                

            }
            else if (loginemailtxt.Text == "2" && loginpasswordtxt.Text == "2" || (loginemailtxt.Text == "3" && loginpasswordtxt.Text == "3"))
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
                    //check the email to see what type of user you create
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

        //The code of Alex ^^^^
    }
}