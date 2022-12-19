using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes
{
    public class Rule
    {
        private string subject;
        private string message;
        private string currentUser;

        static List<Rule> rules = new List<Rule>();
        
        
        public Rule(string Subject, string Message)
        {
            subject = Subject;
            message = Message;
            subject = Subject;
            message = Message;
            //this.sender = Sender;
        }
        public Rule(string Subject, string Message,string CurrentUser)
        {
            subject = Subject;
            message = Message;
            subject = Subject;
            message = Message;
            //this.sender = Sender;
            this.currentUser = CurrentUser;
        }

        public string Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }

        //private string Sender
        //{
        //    get
        //    {
        //        return sender;
        //    }
        //    set
        //    {
        //        sender = value;
        //    }
        //}

        static public void AddRule(RichTextBox subjextBox, RichTextBox messageBox, string currentUser)
        {
            if (messageBox.Text != "")
            {
                string subject = subjextBox.Text;
                string rule_to_be_added = messageBox.Text;
                
                Rule newRule = new Rule(subject, rule_to_be_added, currentUser);

                rules.Add(newRule);
                subjextBox.Text = "";
                messageBox.Text = "";
            }
            else
            {
                MessageBox.Show("Box is empty");
            }
        }
        static public void AddExampleRule()
        {
            Rule example1 = new Rule("Example Subject1", "Example Message1", "User1");
            Rule example2 = new Rule("Example Subject2", "Example Message2", "User2");
            Rule example3 = new Rule("Example Subject3", "Example Message3", "User3");
            rules.Add(example1);
            rules.Add(example2);
            rules.Add(example3);
        }

        static public void PushChanges(TextBox indexBox, RichTextBox subjectBox, RichTextBox messageBox)
        {
            try
            {
                rules[int.Parse(indexBox.Text) - 1].Message = messageBox.Text;
                rules[int.Parse(indexBox.Text) - 1].Subject = subjectBox.Text;
                MessageBox.Show("Success");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid details");
                throw;
            }
        }

        public string GetInfo(string shortOrfull)
        {
            if (shortOrfull == "short")
            {
                return $"Subject: {Subject}    Sender: {currentUser}";
            }

            if (shortOrfull == "long")
            {
                return $"Subject: {Subject}\nMessage: {Message}\nSender: {currentUser}";
            }

            return null;
        }

        static public void DisplayFullInfo(ListBox listOfRules)
        {
            MessageBox.Show($"{rules[listOfRules.SelectedIndex].GetInfo("long")}");
        }

        static public List<Rule> GetRules()
        {
            return rules;
        }
    }
}
