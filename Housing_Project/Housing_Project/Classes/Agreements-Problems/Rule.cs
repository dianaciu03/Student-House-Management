using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes.Agreements_Problems
{
    public class Rule
    {
        private string subject;
        private string message;
        private string sender = "CurrentUser";

        static List<Rule> rules = new List<Rule>();

        public Rule(string Subject, string Message)
        {
            this.subject = Subject;
            this.message = Message;
            this.subject = Subject;
            this.message = Message;
            //this.sender = Sender;
        }

        public string Subject
        {
            get
            {
                return this.subject;
            }
            set
            {
                this.subject = value;
            }
        }

        public string Message
        {
            get
            {
                return this.message;
            }
            set
            {
                this.message = value;
            }
        }

        private string Sender
        {
            get
            {
                return this.sender;
            }
            set
            {
                this.sender = value;
            }
        }

        static public void AddRule(RichTextBox subjextBox, RichTextBox messageBox)
        {
            if (messageBox.Text != "")
            {
                string subject = subjextBox.Text;
                string rule_to_be_added = messageBox.Text;

                Classes.Agreements_Problems.Rule newRule = new Classes.Agreements_Problems.Rule(subject, rule_to_be_added);

                rules.Add(newRule);
                subjextBox.Text = "";
                messageBox.Text = "";
            }
            else
            {
                MessageBox.Show("Box is empty");
            }
        }

        static public void PushChanges(TextBox indexBox,RichTextBox subjectBox ,RichTextBox messageBox)
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
            if (shortOrfull =="short")
            {
                return $"Subject: {Subject}    Sender: {Sender}";
            }

            if (shortOrfull =="long")
            {
                return $"Subject: {Subject}\nMessage: {Message}\nSender: {Sender}";
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
