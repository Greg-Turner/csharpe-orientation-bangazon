using System;
using System.Collections.Generic;

using bangazon.departments;

namespace bangazon.sales
{

    /*
        Class for representing Sales department.

        It is very important to note here that since Sales
        inherits from the Department type, any object instance
        is both of type Sales AND Department.

        Remember, inheritance denotes an is-a relationship.
    */
    public class Sales : Department
    {
        private Dictionary<string, string> _salesEvent = new Dictionary<string, string>();

        public Sales(string dept_name, string supervisor, int employees) : base(dept_name, supervisor, employees)
        {
        }

        // Publicly accessible method to add a Sales Event
        public void AddSalesEvent(string title, string text)
        {
            _salesEvent.Add(title, text);

            foreach (KeyValuePair<string, string> salesEvent in _salesEvent)
            {
                Console.WriteLine($"{salesEvent.Value}");
            }
        }
        public override void SetBudget(double budget)
        {
            // The sales department needs more money than most others
            this.Budget += budget + 100000.00;
        }
    }
}