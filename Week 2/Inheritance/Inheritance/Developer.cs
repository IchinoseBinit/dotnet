using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Developer
    {
        private string platform;
        private string interviewerName;
        private string developerName;
        private int workingHours;

        public Developer(string platform, string interviewerName, int workingHours)
        {
            this.platform = platform;
            this.interviewerName = interviewerName;
            this.developerName = "";
            this.workingHours = workingHours;
        }

        public string Platform
        {
            get { return platform; }
        }

        public string InterviewerName
        {
            get { return interviewerName; }
        }

        public string DeveloperName
        {
            get { return developerName; }
            set { developerName = value; }
        }

        public int WorkingHours
        {
            get { return workingHours; }
        }

        public virtual void Display()
        {
            Console.WriteLine("The platform is " + platform); ;
            Console.WriteLine("The working hour is " + workingHours); 
            Console.WriteLine("The interviewer name is " + interviewerName); 
            if (developerName != "")
            {
                Console.WriteLine("The developer name is " + developerName);
            }
        }
    }
}
