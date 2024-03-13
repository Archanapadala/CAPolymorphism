

namespace CAPolymorphism
{

    // Base class Employee
    class Employee
    {
        public string Name;
        public int EmployeeID;
        public double Salary;

        // Constructor to initialize attributes
        public Employee(string name, int employeeID, double salary)
        {
            Name = name;
            EmployeeID = employeeID;
            Salary = salary;
        }

        // Method to calculate pay (to be overridden by subclasses)
        public virtual double CalculatePay()
        {
            return Salary;
        }
    }

    // Subclass FullTimeEmployee
    class FullTimeEmployee : Employee
    {
        // Constructor to initialize attributes
        public FullTimeEmployee(string name, int employeeID, double salary) : base(name, employeeID, salary)
        {
        }

        // Override method to calculate pay for full-time employee
        public override double CalculatePay()
        {
            // Assuming full-time employees get their monthly salary
            return Salary;
        }
    }

    // Subclass PartTimeEmployee
    class PartTimeEmployee : Employee
    {
        private int hoursWorked;

        // Constructor to initialize attributes
        public PartTimeEmployee(string name, int employeeID, double hourlyRate, int hoursWorked) : base(name, employeeID, hourlyRate)
        {
            this.hoursWorked = hoursWorked;
        }

        // Override method to calculate pay for part-time employee
        public override double CalculatePay()
        {
            // Assuming part-time employees get paid based on hours worked
            return Salary * hoursWorked;
        }
    }

    // Subclass ContractEmployee
    class ContractEmployee : Employee
    {
        // Constructor to initialize attributes
        public ContractEmployee(string name, int employeeID, double contractAmount) : base(name, employeeID, contractAmount)
        {
        }

        // Override method to calculate pay for contract employee
        public override double CalculatePay()
        {
            // Assuming contract employees receive a fixed contract amount
            return Salary;
        }
    }

    class assignment2
    {
        static void Main(string[] args)
        {
            // Create a list of employees
            List<Employee> employees = new List<Employee>();
            employees.Add(new FullTimeEmployee("John", 101, 5000));
            employees.Add(new PartTimeEmployee("Alice", 102, 20, 40));
            employees.Add(new ContractEmployee("Bob", 103, 3000));

            // Calculate pay for each employee and display
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"Employee: {employees[i].Name}, ID: {employees[i].EmployeeID}, Pay: {employees[i].CalculatePay()}");
            }
        }
    }
}

