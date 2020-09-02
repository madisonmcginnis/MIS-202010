using System;
using System.Collections.Generic;
using System.Text;

namespace StudentUMLExample
{
    class Student
    {
        public int SoonerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsOnProbation { get; set; }
        public double GPA { get; set; }

        private double BursarBalance;

        /// <summary>
        /// Default/Empty constructor for the Student
        /// </summary>
        public Student()
        {
            SoonerID = -1;
            FirstName = string.Empty;
            LastName = "";
            IsOnProbation = false;
            GPA = 0;
            BursarBalance = 1000;
        }

        /// <summary>
        /// overloaded constructor that will set the default values of soonerid, firstname, lastname, and bursarbalance
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="BursarBalance"></param>
        public Student(int id, string fName, string lName, double BursarBalance)
        {
            SoonerID = id;
            FirstName = fName;
            LastName = lName;
            IsOnProbation = false;
            GPA = 0;
            this.BursarBalance = BursarBalance;
        }

        /// <summary>
        /// Make a payment on your bursar balance
        /// </summary>
        /// <param name="amount"></param>a non-negative value to reduce bursar balance
        public void MakePayment(double amount)
        {
            //BursarBalance -= amount;
            if (amount > 0)
            {
                BursarBalance = BursarBalance - amount;
            }
            else
            {
                throw new Exception();
            }
            
        }

        /// <summary>
        /// the current state of your bursar account
        /// </summary>
        /// <returns></returns> how much you owe on your bursar
        public double CheckBalance()
        {
            return BursarBalance;
        }

        /// <summary>
        /// create a string representation of our instance of the class
        /// </summary>
        /// <returns>the current state of the student</returns>
        public override string ToString()
        {
            string output = $"{FirstName} {LastName} ({SoonerID})";
            if (IsOnProbation == true)
            {
                output += " is on probation.\n";
            }
            else
            {
                output += " is not on probation.\n";
            }
            output += $"They have a {GPA.ToString("N2")} GPA and they owe {BursarBalance.ToString("C2")}\n";

            

            return output;
        }
    }
}
