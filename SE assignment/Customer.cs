using System;
using System.Collections.Generic;
using System.Text;

namespace SE_assignment
{
    class Customer
    {

        public int accountNo { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public int hpno { get; set; }



        public Customer(int AccountNo, string Name, string Address, string Email, int HPno)
        {
            accountNo = AccountNo;
            name = Name;
            address = Address;
            email = Email;
            hpno = HPno;
        }
    }
}
