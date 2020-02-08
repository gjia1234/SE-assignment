using System;
using System.Collections.Generic;
using System.Text;

namespace SE_assignment
{
    class Employee
    {
        public string name { get; set; }
        public int number { get; set; }
        public string nric { get; set; }
        public string gender { get; set; }
        public int contactNo { get; set; }
        public DateTime dateJoin { get; set; }
        public string status { get; set; }

        public Employee(string Name, int Number, string NRIC, string Gender, int ContactNo, DateTime DateJoin, string Status)
        {
            name = Name;
            number = Number;
            nric = NRIC;
            gender = Gender;
            contactNo = ContactNo;
            dateJoin = DateJoin;
            status = Status;
        }
    }
}
