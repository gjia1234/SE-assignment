using System;
using System.Collections.Generic;
using System.Text;

namespace SE_assignment
{
    class Manager : Employee
    {
        private DateTime startTime { get; set; }

        public Manager(string Name, int Number, string NRIC, string Gender, int ContactNo, DateTime DateJoin, string Status, DateTime StartTime) : base(Name, Number, NRIC, Gender, ContactNo, DateJoin, Status)
        {
            startTime = StartTime;
        }

        public static void ManagerUpdateItem()
        {
            Console.WriteLine("Choose which to update");
            foreach (Menu m in Globals.MenuList)
            {
                Console.WriteLine("Item Name: " + m.name);
            }
        }

        public static void ManagerAddItem()
        {
            Console.WriteLine("Fill in details");
        }
    }
        
        
    
}

