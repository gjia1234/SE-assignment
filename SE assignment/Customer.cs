using System;
using System.Collections.Generic;
using System.Text;

namespace SE_assignment
{
    class Customer
    {
        private int accountNo;
        private string name;
        private string address;
        private string email;
        private int hpno;

        public Customer(int AccountNo, string Name, string Address, string Email, int HPno)
        {
            accountNo = AccountNo;
            name = Name;
            address = Address;
            email = Email;
            hpno = HPno;
        }
        public void print()
        {
            Console.WriteLine("account No.: " + accountNo);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("HP No.: " + hpno);
        }
    }
}
