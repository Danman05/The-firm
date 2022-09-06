using System;

namespace The_firm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creation of objects that will functions from Employee object
            Employee projectManager = new ProjectManager("Bob", "Nielsen", "000000-0000", "12 12 12 12", "BobNielsen@mail.dk");
            Employee manager = new Manager("Daniel", "Spurrell","000000-0000","81 81 81 81");
            Employee employee = new Employee("Torben","Torben", "000000-0000");

            // Creating of objects that will have functions from every class
            ProjectManager proj = (ProjectManager)projectManager;
            Manager man = (Manager)manager;
            Employee emp = (Employee)employee;

            // Runs the method for printing the objects details
            Console.WriteLine(emp.PrintEmpDetails());
            Console.WriteLine(man.PrintManDetails());
            Console.WriteLine(proj.PrintProjDetails());

            Console.ReadLine(); // Keeps program alive

           
        }
    }
}
