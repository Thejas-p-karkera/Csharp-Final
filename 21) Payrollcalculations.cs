//	To implement a C# application that performs its payrollcalculations polymorphic way. 
//	a. Design the class	Diagram. 
//	b. Implement the code to fulfil the requirement.
//	c. Calculation must be done in polymorphic way usingthe below given information
//A company pays its employees weekly. Theemployees are of four types:
//1. Salaried employees are paid a fixed weekly salaryregardless of the number of hours worked
//2. Hourly employees are paid by the hour and receiveovertime pay for all hours worked more than 40 hours
//3. Commission employees are paid a percentage of theirsales
//4. Salaried-Commission employees receive a base salaryplus a percentage of their sales.
//For the current pay period, the company has decided toreward salariedcommission employees by adding 10% totheir base salaries.

//-------------------------------------------------------------------------------------------


//                      +--------------------+
//                      |   Employee         |       
//                      +--------------------+
//                      | - Name: string     |
//                      | - ID: int          |
//                      |--------------------|
//                      | + Earnings(): double |
//                      +--------------------+
//                                ▲
//                                │
//      +----------------------+----------------+----------------------+
//      |                      |                |                      |
//  +----------------+  +------------+  +-----------------+  +--------------------------+
//  | Salaried       |  | Hourly     |  | Commission      |  | SalariedCommission       |
//  | Employee       |  | Employee   |  | Employee        |  | Employee                 |
//  +----------------+  +------------+  +-----------------+  +--------------------------+
//  | - weeklySalary |  | - wage     |  |- commissionRate |  |- baseSalary              |
//  |                |  |-hoursWorked|  |- sales          |  |- commissionRate          |
//  +----------------+  +------------+  +-----------------+  +--------------------------+
//  | + Earnings()   |  | +Earnings()|  |   + Earnings()  |  |  + Earnings()            |
//  +----------------+  +------------+  +-----------------+  +--------------------------+



using System;
using System.Collections.Generic;

abstract class Employee
{
    public string Name { get; set; }
    public int ID { get; set; }

    public Employee(string name, int id)
    {
        Name = name;
        ID = id;
    }

    public abstract double Earnings(); // Polymorphic method

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Earnings: +{Earnings():F2}";
    }
}

// Salaried Employee
class SalariedEmployee : Employee
{
    private double weeklySalary;

    public SalariedEmployee(string name, int id, double salary) : base(name, id)
    {
        weeklySalary = salary;
    }

    public override double Earnings()
    {
        return weeklySalary;
    }
}

// Hourly Employee
class HourlyEmployee : Employee
{
    private double wage;
    private double hoursWorked;

    public HourlyEmployee(string name, int id, double wage, double hoursWorked) : base(name, id)
    {
        this.wage = wage;
        this.hoursWorked = hoursWorked;
    }

    public override double Earnings()
    {
        if (hoursWorked <= 40)
            return wage * hoursWorked;
        else
            return (40 * wage) + ((hoursWorked - 40) * wage * 1.5); // Overtime pay
    }
}

// Commission Employee
class CommissionEmployee : Employee
{
    private double sales;
    private double commissionRate;

    public CommissionEmployee(string name, int id, double sales, double commissionRate) : base(name, id)
    {
        this.sales = sales;
        this.commissionRate = commissionRate;
    }

    public override double Earnings()
    {
        return sales * commissionRate;
    }
}

// Salaried-Commission Employee
class SalariedCommissionEmployee : CommissionEmployee
{
    private double baseSalary;

    public SalariedCommissionEmployee(string name, int id, double baseSalary, double sales, double commissionRate)
        : base(name, id, sales, commissionRate)
    {
        this.baseSalary = baseSalary;
    }

    public override double Earnings()
    {
        return (baseSalary * 1.10) + base.Earnings(); // 10% increase in base salary
    }
}

// Payroll System
class PayrollSystem
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        Console.Write("Enter the number of employees: ");
        int numEmployees = int.Parse(Console.ReadLine());

        for (int i = 0; i < numEmployees; i++)
        {
            Console.WriteLine($"\nEnter details for Employee {i + 1}:");
            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Select Employee Type:");
            Console.WriteLine("1. Salaried Employee");
            Console.WriteLine("2. Hourly Employee");
            Console.WriteLine("3. Commission Employee");
            Console.WriteLine("4. Salaried-Commission Employee");
            Console.Write("Enter choice (1-4): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Weekly Salary: ");
                    double salary = double.Parse(Console.ReadLine());
                    employees.Add(new SalariedEmployee(name, id, salary));
                    break;

                case 2:
                    Console.Write("Enter Hourly Wage: ");
                    double wage = double.Parse(Console.ReadLine());
                    Console.Write("Enter Hours Worked: ");
                    double hoursWorked = double.Parse(Console.ReadLine());
                    employees.Add(new HourlyEmployee(name, id, wage, hoursWorked));
                    break;

                case 3:
                    Console.Write("Enter Total Sales: ");
                    double sales = double.Parse(Console.ReadLine());
                    Console.Write("Enter Commission Rate (as a decimal, e.g., 0.10 for 10%): ");
                    double commissionRate = double.Parse(Console.ReadLine());
                    employees.Add(new CommissionEmployee(name, id, sales, commissionRate));
                    break;

                case 4:
                    Console.Write("Enter Base Salary: ");
                    double baseSalary = double.Parse(Console.ReadLine());
                    Console.Write("Enter Total Sales: ");
                    double salesSc = double.Parse(Console.ReadLine());
                    Console.Write("Enter Commission Rate (as a decimal, e.g., 0.08 for 8%): ");
                    double commissionRateSc = double.Parse(Console.ReadLine());
                    employees.Add(new SalariedCommissionEmployee(name, id, baseSalary, salesSc, commissionRateSc));
                    break;

                default:
                    Console.WriteLine("Invalid choice! Skipping this employee.");
                    break;
            }
        }

        Console.WriteLine("\nCompany Payroll:");
        foreach (var emp in employees)
        {
            Console.WriteLine(emp);
        }
    }
}

