using System;
using System.Collections.Generic;

using bangazon.departments;

namespace bangazon.informationtechnology
{
    /*
        Class for representing Information Technology department.

        It is very important to note here that since InformationTechnology
        inherits from the Department type, any object instance
        is both of type InformationTechnology AND Department.

        Remember, inheritance denotes an is-a relationship.
    */
    public class InformationTechnology : Department
    {
        private Dictionary<string, string> _policies = new Dictionary<string, string>();

        public InformationTechnology(string dept_name, string supervisor, int employees) : base(dept_name, supervisor, employees)
        {
        }

        // Publicly accessible method to add an IT policy
        public void AddPolicy(string title, string text)
        {
            _policies.Add(title, text);

            foreach (KeyValuePair<string, string> policy in _policies)
            {
                Console.WriteLine($"{policy.Value}");
            }
        }
    }
}