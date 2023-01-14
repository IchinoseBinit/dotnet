using System;

namespace Calculator
{
    public class Student
    {
        private String[] names = new String[5];

        // student[0] = "Binit";
        // student[0];
        
        public string this[int i] {
            get {
                return names[i];
            }

            set  {
                this.names[i] = value;
            }
        }


        // properties
        private String address;
        public String GetAddress()
        {
            return this.address;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }
    }
}
