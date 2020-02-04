using System;
using System.Collections.Generic;
using System.Text;

namespace SE_assignment
{
    class Manager : Employee
    {
        public Manager(string Name, int Number, string NRIC, string Gender, int ContactNo, DateTime DateJoin, string Status) : base(Name, Number, NRIC, Gender, ContactNo, DateJoin, Status)
        {
        }
    }
}
