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
        public List<Order> OrderList = new List<Order>();

    //customer constructor
        public Customer(int AccountNo, string Name, string Address, string Email, int HPno)
        {
            accountNo = AccountNo;
            name = Name;
            address = Address;
            email = Email;
            hpno = HPno;
        }
        //
        public void CreateOrder()
        {
            int OrderNo =1;
            if (OrderList != null)
            {
                OrderNo = Globals.OrderList.Count;
            }
            DateTime time = DateTime.Now;
            List<OrderLine> orderlines = new List<OrderLine>();
            while (true){
                Console.Write("What item do you want to order: ");
                String Item = Console.ReadLine();
                int counter = 0;
                foreach(Menu m in Globals.MenuList)
                {
                    if (m.name.ToUpper() == Item.ToUpper())
                    {
                        Console.Write("Quantity: ");
                        string qty = Console.ReadLine();
                        int Qty = int.Parse(qty);
                        OrderLine ol = new OrderLine(Qty, m);
                        orderlines.Add(ol);
                        break;
                    }
                    counter += 1;
                }
                if (counter == Globals.MenuList.Count)
                {
                    Console.WriteLine("We could not find the item you were looking for");
                }
                Console.Write("Do you want to order another item: ");
                string Continue = Console.ReadLine();
                if (Continue.ToUpper() == "NO")
                {
                    break;
                }
            }
            string PaymentMethod = "";

            while (true)
            {
                Console.WriteLine("How would you like to pay for your order: ");
                Console.WriteLine("1. Credit card");
                Console.WriteLine("2. Online methods");
                Console.Write("Input Option: ");
                PaymentMethod = Console.ReadLine();
                if (PaymentMethod == "1")
                {
                    PaymentMethod = "Credit card";
                    break;
                }
                else if (PaymentMethod == "2")
                {
                    PaymentMethod = "Online methods";
                    break;
                }
                Console.WriteLine("Please choose a valid option.");
            }
            Order newOrder = new Order(OrderNo, "new",time,PaymentMethod, this, orderlines);
            float price = newOrder.subtotal();
            Console.WriteLine("You have paid $" + price.ToString("0.00") + " via " + PaymentMethod);
            OrderList.Add(newOrder);
            Globals.OrderList.Add(newOrder);
            Console.ReadLine();
        }
    }
}
