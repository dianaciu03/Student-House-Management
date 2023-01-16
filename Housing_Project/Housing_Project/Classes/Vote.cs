using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes
{
    public class Vote
    {
        private int numberAgre;
        private int numberDisagree;
        public Tenant Tenant { get; set; }
        public Choice Choice { get; set; }

        public Vote(Tenant tenant, Choice choice)
        {
            Tenant = tenant;
            Choice = choice;
        }
        public void Agree()
        {
            numberAgre++;
        }
        public void Disagree()
        {
            numberDisagree++;
        }
    }

    public enum Choice
    {
        Agree,
        Disagree,
        Unknown
    }

}
