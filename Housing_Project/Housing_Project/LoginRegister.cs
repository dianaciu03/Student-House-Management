namespace Housing_Project
{
    public partial class LoginRegister : Form
    {
        public LoginRegister()
        {
            InitializeComponent();
            ShowMessages(false);
            ShowRegisterField(false);
        }

        private void ShowRegisterField(bool trueorfalse)
        { 
            fullnamelbl.Visible = trueorfalse;
            fullnametxt.Visible = trueorfalse;
            phonenumberlbl.Visible = trueorfalse;
            phonenumbertxt.Visible = trueorfalse;
            emailadresslbl.Visible = trueorfalse;
            emailadresstxt.Visible = trueorfalse;
            passwordtxt.Visible = trueorfalse;
            passwordlbl.Visible = trueorfalse;
            registerbtn.Visible = trueorfalse; // actual register btn
            registerbtnshow.Visible = !trueorfalse; // show the register form btn

            loginbtn.Visible = !trueorfalse; // actual log in btn
            loginshowbtn.Visible = trueorfalse; // show the log in form

        }
        private void ShowLoginField(bool trueorfalse)
        {
            loginemaillbl.Visible = trueorfalse;
            loginemailtxt.Visible = trueorfalse;
            loginpasswordlbl.Visible = trueorfalse;
            loginpasswordtxt.Visible = trueorfalse;

            loginbtn.Visible = trueorfalse;
            loginshowbtn.Visible = !trueorfalse;
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
        private void ShowMessages(bool trueorfalse) 
        {
            wrongcredentialslbl.Visible = trueorfalse;
        }

        private void loginshowbtn_Click(object sender, EventArgs e) // show log in form
        {
            ShowMessages(false);
            ShowRegisterField(false);
            ShowLoginField(true);

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
                    ShowMessages(true);
                    ClearFields();
                }
                else
                {
                    ClearFields();
                }
            }
        }

        private void registerbtn_Click_1(object sender, EventArgs e) // show register form
        {
            ShowMessages(false);
            ShowRegisterField(true);
            ShowLoginField(false);
        }

        private void registerbtn_Click(object sender, EventArgs e) // actial register
        {      
            //this.Hide()
            //Student student = new Student();
            //student.ShowDialog();
            //this.Close();

            if (fullnametxt.Text == "" 
                || phonenumbertxt.Text == "" 
                || emailadresstxt.Text == "" 
                || passwordtxt.Text == "")
            {
                ShowMessages(true);
            }
            else
            {
                ClearFields();
                OpenStudents();
            }
        }

    }
}