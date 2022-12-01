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
        private void OpenStudents()
        {
            this.Hide();
            FormStudent student = new FormStudent();
            student.ShowDialog();
            this.Close();
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
            if (loginemailtxt.Text == "admin" && loginpasswordtxt.Text == "123")
            {
                OpenStudents();
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
                ShowMessages(true,"register");
            }
            else
            {
                ClearFields();
                OpenStudents();
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