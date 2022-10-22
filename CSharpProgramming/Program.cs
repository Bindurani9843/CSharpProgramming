using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// Inheritance-Code Reusability
    /// Types-Single,Multi-level,Hybrid,Hierarchial
    /// Multiple Inheritance-Not supported-instead Interfaces are used
    /// protected access specifier
    /// </summary>
    /// BASE CLASS 
    internal class Employee
    {
        protected int EID;
        protected string EName;
        protected int TDID;
        protected string TDName;
        protected void Display()
        {
            Console.WriteLine("BASE CLASS");
        }
    }
    /// <summary>
    /// Child Class - Department
    /// Single-level
    /// </summary>
    internal class Department : Employee
    {
        protected int DID;
        protected string DName;

    }
    /// <summary>
    /// Hierarchial Inheritance
    /// </summary>
    internal class TrainingDepartment : Employee
    {
        public void GetTDetails()
        {
            base.Display();
            TDID = 101;
            TDName = "DOTNET";
            Console.WriteLine($"TDID is {TDID} and TDName is {TDName}");
        }
    }
    internal class Inheritance
    {
        public static void Main()
        {
            //Single-level
            // Department department = new Department();
            // department.GetEmployeeDetails();
            // department.Display();

            //Multi-level


            //Hierarchial
            TrainingDepartment trainingDepartment = new TrainingDepartment();
            trainingDepartment.GetTDetails();

        }
    }
}
    
