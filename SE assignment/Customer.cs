﻿using System;
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
        private Order order;

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
