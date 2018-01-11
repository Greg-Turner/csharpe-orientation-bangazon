using System;

namespace bangazon.departments
{

    // Parent class for all departments
    public class Department
    {
        protected string _name;
        protected string _supervisor;
        protected int _employee_count;
        protected double _budget;

        // You can create properties, if needed
        // Simple property that doesn't allow blank values for EmployeeName
        public string DeptName
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != "")
                {
                    _name = value;
                }
            }
        }

        // Simple property that doesn't allow blank values for Supervisor
        public string Supervisor
        {
            get
            {
                return _supervisor;
            }
            set
            {
                _supervisor = value;
            }
        }

        // Simple property of integer total count of employees in the department
        public int EmpCount
        {
            get
            {
                return _employee_count;
            }
            set
            {
                _employee_count = value;
            }
        }
        // Simple property of double total budget of the department
        public double Budget
        {
            get
            {
                return _budget;
            }
            set
            {
                _budget = value;
            }
        }
        // Constructor method
        public Department(string name, string supervisor, int employees)
        {
            _name = name;
            _supervisor = supervisor;
            _employee_count = employees;
        }
        public virtual void SetBudget(double budget) 
        {
            // Sets the budget of the department
            _budget = budget;
        }
        // Overriding the default toString() method for each object instance
        public string toString() => $"Department: {_name} \t Managing Supervisor: {_supervisor} \t Total Staff: {_employee_count} \t Budget: ${_budget}";
    }
}