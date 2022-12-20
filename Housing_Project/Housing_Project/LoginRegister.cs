using Housing_Project.Classes;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Housing_Project
{
    public partial class LoginRegister : Form
    {
     
        //The code of Alex vvvv
        public LoginRegister()
        {
            InitializeComponent();
            ShowMessages(false,"login");
            ShowMessages(false, "register");
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
        private void OpenUser(string user, string name)
        {
            if (user == "student")
            {
                this.Hide();
                FormStudent student = new FormStudent(name);
                student.ShowDialog();
                this.Close();
            }

            if (user == "supervisor")
            {
                this.Hide();
                FormSupervisor supervisor = new FormSupervisor(name);
                supervisor.ShowDialog();
                this.Close();
            }

        }
        private void ShowMessages(bool trueorfalse,string RegisterOrLogin) 
        {
            
            if (RegisterOrLogin == "register")
            {
                registerwrongcredentialslbl.Visible = trueorfalse;
            }
            if (RegisterOrLogin == "login")
            {
                loginwrongcredentialslbl.Visible = trueorfalse;
            }
        }

        private void loginbtn_Click(object sender, EventArgs e) // actual log in button
        {
        


            if (loginemailtxt.Text == "1" && loginpasswordtxt.Text == "1" || (loginemailtxt.Text == "0" && loginpasswordtxt.Text == "0"))
            {
                OpenUser("student", loginemailtxt.Text);
                

            }
            else if (loginemailtxt.Text == "2" && loginpasswordtxt.Text == "2" || (loginemailtxt.Text == "3" && loginpasswordtxt.Text == "3"))
            {
                OpenUser("supervisor",loginemailtxt.Text);
            }
            else 
            {
                if (loginemailtxt.Text!="" || loginpasswordtxt.Text != "")
                {
                    ShowMessages(true,"login");
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
            if (fullnametxt.Text == ""
                || phonenumbertxt.Text == ""
                || emailadresstxt.Text == ""
                || passwordtxt.Text == "")
            {
                ShowMessages(true, "register");
            }
            else
            {
                ClearFields();
                OpenUser("student", loginemailtxt.Text);
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