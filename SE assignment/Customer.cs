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
        public List<Order> OrderList { get; set; }


    public Customer(int AccountNo, string Name, string Address, string Email, int HPno)
        {
            accountNo = AccountNo;
            name = Name;
            address = Address;
            email = Email;
            hpno = HPno;
        }
        public void CreateOrder()
        {
            int orderNo = 1;
            if (OrderList != null)
            {

                orderNo = OrderList.Count+1;
            }
            DateTime time = DateTime.Now;
            Console.WriteLine("How would you like to pay for your order: ");
            Console.WriteLine("1. Credit card");
            Console.WriteLine("2. Online methods");
            Console.Write("Input Option: ");
            string PaymentMethod = Console.ReadLine();
            List<OrderLine> orderlines = new List<OrderLine>();
            while (true){
                Console.Write("What item do you want to order: ");
                String Item = Console.ReadLine();
                foreach(Menu m in Globals.MenuList)
                {
                    if (m.name.ToUpper() == Item.ToUpper())
                    {
                        Console.Write("Quantity: ");
                        string qty = Console.ReadLine();
                        int Qty = int.Parse(qty);
                        OrderLine ol = new OrderLine(Qty, m);
                        orderlines.Add(ol);
                    }
                }
                Console.Write("Do you want to order another item: ");
                string Continue = Console.ReadLine();
                if (Continue == "No")
                {
                    break;
                }
            }
            if (PaymentMethod == "1")
            {
                PaymentMethod = "Credit card";
            }
            else
            {
                PaymentMethod = "Online methods";
            }
            Order newOrder = new Order(orderNo,"Created",time,PaymentMethod, this, orderlines);
        }
    }
}
