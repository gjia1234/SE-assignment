using System;
using System.Collections.Generic;
using System.Text;

namespace SE_assignment
{
    class Chef : Employee
    {
        public Chef(string Name, int Number, string NRIC, string Gender, int ContactNo, DateTime DateJoin, string Status) : base(Name, Number, NRIC, Gender, ContactNo, DateJoin, Status)
        {
        }

        public void selectOrder(Order o)
        {
            o.status = "Preparing";
            Console.WriteLine("Press enter when order is ready.");
            Console.ReadLine();
            o.status = "Ready";
            o.timeReady = DateTime.Now;
            Console.WriteLine("Order is done.");
            Console.WriteLine("Press enter again to close.");
            Console.ReadLine();
        }

    }
}
