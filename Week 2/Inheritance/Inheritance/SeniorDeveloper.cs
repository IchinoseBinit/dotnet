using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class SeniorDeveloper : Developer
    {
        private double salary;
        private string joiningDate;
        private string staffRoomNumber;
        private int contractPeriod;
        private double advanceSalary;
        private bool appointed;
        private bool terminated;

        public SeniorDeveloper(string platform, string interviewerName, int workingHours, double salary, int contractPeriod) : base(platform, interviewerName, workingHours)
        {
            this.salary = salary;
            this.contractPeriod = contractPeriod;
            this.joiningDate = "";
            this.staffRoomNumber = "";
            this.advanceSalary = 0.0;
            this.appointed = false;
            this.terminated = false;
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string JoiningDate
        {
            get { return joiningDate; }
        }

        public string StaffRoomNumber
        {
            get { return staffRoomNumber; }
        }

        public int ContractPeriod
        {
            get { return contractPeriod; }
            set { contractPeriod = value; }
        }

        public double AdvanceSalary
        {
            get { return advanceSalary; }
        }

        public bool Appointed
        {
            get { return appointed; }
        }

        public bool Terminated
        {
            get { return terminated; }
        }

        public void HireDeveloper(string developerName, string joiningDate, double advanceSalary, string staffRoomNumber) {
            if (appointed == true)
            {
                Console.WriteLine("The developer " + base.DeveloperName + " is already appointed and the room number is " + staffRoomNumber);
            } else
            {
                base.DeveloperName = developerName;
                this.joiningDate = joiningDate;
                this.advanceSalary = advanceSalary;
                this.staffRoomNumber = staffRoomNumber;
                this.appointed = true;
                this.terminated = false;
            }
        }

        public void TerminateDeveloper()
        {
            if (terminated == true)
            {
                Console.WriteLine("The developer is already terminated");
            } else
            {
                base.DeveloperName = "";
                this.joiningDate = "";
                this.advanceSalary = 0.0;
                this.appointed = false;
                this.terminated = true;
            }
        }

        public void print()
        {
            Console.WriteLine("The platform is " + base.Platform);
            Console.WriteLine("The interviewer name is " + base.InterviewerName);
            Console.WriteLine("The salary is " + salary);
        }

        public override void Display()
        {
            base.Display();
            if (appointed == true)
            {
                Console.WriteLine("The termination status is " + terminated);
                Console.WriteLine("The joining date is " + joiningDate);
                Console.WriteLine("The advance salary is " + advanceSalary);
            }
        }
    }
}
