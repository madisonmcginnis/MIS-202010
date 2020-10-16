using System;
using System.Collections.Generic;
using System.Text;

namespace GraduationHandout
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
        public Address Address { get; set; }

        string distinction;

        public Student()
        {
            FirstName = "";
            LastName = "";
            Major = "";
            GPA = 0;
        }
        public Student(string firstName, string lastName, string major, double gpa)
        {
            firstName = FirstName;
            lastName = LastName;
            major = Major;
            gpa = GPA;
        }
        public string CalculateDistinction()
        {
            if (GPA >= 3.40 && GPA <= 3.59)
            {
                distinction = "cum laude";
            }
            else if (GPA >= 3.60 && GPA <= 3.79)
            {
                distinction = "magna cum laude";
            }
            else if (GPA >= 3.80 && GPA <= 4.00)
            {
                distinction = "summa cum laude";
            }
            else
            {
                distinction = "none";
            }

            return distinction;
        }

        public void SetAddress(int streetNumber, string streetName, string state, string city, int zipcode)
        {
            streetNumber = Address.StreetNumber;
            streetName = Address.StreetName;
            state = Address.State;
            city = Address.City;
            zipcode = Address.Zipcode;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Major}, {distinction}";
        }
    }
}
