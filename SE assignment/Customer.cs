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
            if (Globals.OrderList != null)
            {
                OrderNo = Globals.OrderList.Count +1;
            }
            DateTime time = DateTime.Now;
            List<OrderLine> orderlines = new List<OrderLine>();
            while (true){
                foreach (Menu m in Globals.MenuList)
                {
                    if (m is FoodItem)
                    {
                        Console.WriteLine("Item Name: " + m.name + ", Price: $" + m.price + ", Preperation Time: "+m.prepTime+"min");
                    }
                }
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
            Order newOrder = new Order(OrderNo, "New",time,PaymentMethod, this, orderlines);
            float price = newOrder.subtotal();
            Console.WriteLine("You have paid $" + price.ToString("0.00") + " via " + PaymentMethod);
            OrderList.Add(newOrder);
            Globals.OrderList.Add(newOrder);
            Console.ReadLine();
        }

        public void custViewOrder(Customer c)
        {
            Console.WriteLine("YOUR ORDER(S)");
            Console.WriteLine("______________________________________________________________\n");

            List<Order> filtered = new List<Order>();
            List<Order> history = new List<Order>();
            List<Order> current = new List<Order>();
            foreach (Order o in Globals.OrderList)
            {
                if (o.cust.accountNo == c.accountNo) {
                    filtered.Add(o);
                }
            }
            foreach (Order ord in filtered)
            {
                if (ord.status == "Delivered" || ord.status == "Cancelled")
                {
                    history.Add(ord);
                }
                else {
                    current.Add(ord);
                }
            }
            int counthList = history.Count;
            int countpList = current.Count;

            //Current Orders
            Console.WriteLine("CURRENT ORDERS: \n");
            if (countpList == 0)
            {
                Console.WriteLine("Nothing Here!");
            }
            else
            {
                foreach (Order p in current)
                {
                    
                    Console.WriteLine("Order No:" + p.orderNo + ", Status:" + p.status + ", Est Time of Arrival:" + p.ETA + ", Payment Method:" + p.paymentMethod + ", Order Created Time:" + p.createDateTime + ", Customer ID:" + p.cust.accountNo + ", Customer Name:" + p.cust.name);
                }
            }

            //Past Orders
            Console.WriteLine("\n\nPAST ORDERS: \n");
            if (counthList == 0) {
                Console.WriteLine("Nothing Here!");
            }
            else
            {
                foreach (Order h in history)
                {
                    Console.WriteLine("Order No:" + h.orderNo + ", Status:" + h.status + ", Payment Method:" + h.paymentMethod + ", Order Created Time:" + h.createDateTime + ", Customer ID:" + h.cust.accountNo + ", Customer Name:" + h.cust.name);
                }
            }
            Console.WriteLine("______________________________________________________________\n");
        }
    }

}
