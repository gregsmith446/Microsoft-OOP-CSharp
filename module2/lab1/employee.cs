using System;

namespace Lab1
{
    abstract class Employee
    // any method declared in an abstract class that will contain some implementation in the abstract class, but can be overridden 
    // in the sub class, you decorate with the virtual keyword.
    {
        // 3 private member variables: employeeName, employeeBaseSalary, and employeeId
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;

        // Public properties
        public string Name
        {
            get
            {
                return employeeName;
            }

            set
            {
                employeeName = value;
            }
        }
        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }

            set
            {
                employeeBaseSalary = value;
            }
        }
        public int ID
        {
            get
            {
                return employeeId;
            }

            set
            {
                employeeId = value;
            }
        }     

        // Constructor
        public Employee(String name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }  

        // This method returns the employee's base salary
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }

        // This method returns the employee's name
        public String getName()
        {
            return this.Name;
        }

        // This method returns the employee's ID
        public int getEmployeeID()
        {
            return this.ID;
        }

        // This method returns the employee's ID and Name
        public String toString()
        {
            return this.ID + " " + this.Name;
        }

        // This method returns the employee's ID and Name and confirms that the employee is in the system
        // making this abstract = all subclasses of our Employeee() Class are required to implement the employeeStatus() method.
        public abstract String employeeStatus()
        {
            return toString() + " is in the company's system"; 
        }	

        // Creates integer variable called "employeeCount" and assigns value to 1
        private static int employeeCount = 1;

    }
}