﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Formats.Asn1;

namespace Housing_Project.Classes
{
    public class RuleManager
    {
        private int ruleIdSeeder = 1;
        private List<Rule> rules = new List<Rule>();

        public void AddRuleToList(string title, string message, Supervisor sender)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("rules_info.txt", FileMode.Create, FileAccess.Write);

            rules.Add(new Rule(ruleIdSeeder, title, message, sender));

            formatter.Serialize(stream, rules);
            stream.Close();

            ruleIdSeeder++;
        }

        public Rule[] GetRules()
        {
            return rules.ToArray();
        }

        public Rule GetRule(int index)
        {
            return rules[index];
        }
    }
}