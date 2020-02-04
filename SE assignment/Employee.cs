using System;
using System.Collections.Generic;
using System.Text;

namespace SE_assignment
{
    class Employee
    {
        private string name;
        private int number;
        private string nric;
        private string gender;
        private int contactNo;
        private DateTime dateJoin;
        private string status;

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
