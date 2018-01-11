using System;
using System.Collections.Generic;

using bangazon.departments;

namespace bangazon.marketing
{

    /*
        Class for representing Marketing department.

        It is very important to note here that since Marketing
        inherits from the Department type, any object instance
        is both of type Marketing AND Department.

        Remember, inheritance denotes an is-a relationship.
    */
    public class Marketing : Department
    {
        private Dictionary<string, string> _campaign = new Dictionary<string, string>();

        public Marketing(string dept_name, string supervisor, int employees) : base(dept_name, supervisor, employees)
        {
        }

        // Publicly accessible method to add a Marketing campaign
        public void AddCampaign(string title, string text)
        {
            _campaign.Add(title, text);

            foreach (KeyValuePair<string, string> campaign in _campaign)
            {
                Console.WriteLine($"{campaign.Value}");
            }
        }
    }
}