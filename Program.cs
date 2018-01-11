using System;
using System.Collections.Generic;
using bangazon.departments;
using bangazon.humanresources;
using bangazon.informationtechnology;
using bangazon.marketing;
using bangazon.sales;

namespace bangazon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();

            double baseBudget = 75000.00;

            // Create some instances
            HumanResources hr = new HumanResources("HR", "Jack Reacher", 2);
            InformationTechnology it = new InformationTechnology("IT", "John Wick", 12);
            Marketing mkt = new Marketing("Marketing", "John McClane", 12);
            Sales sls = new Sales("Sales", "Brian Mills", 22);

            // Add derived departments to the list
            departments.Add(hr);
            departments.Add(it);
            departments.Add(mkt);
            departments.Add(sls);

            // Iterate over all items in the list and output a string
            // representation of the class
            foreach(Department d in departments)
            {
                d.SetBudget(baseBudget);
                Console.WriteLine($"{d.toString()}");
            }
        }
    }
}
