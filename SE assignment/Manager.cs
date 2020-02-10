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

        // Update single item
        public static void ManagerUpdateItem()
        {
            Console.WriteLine("\nChoose which to update");
            foreach (Menu m in Globals.MenuList)
            {
                Console.WriteLine("Item Name: " + m.name);
            }
            Console.Write("\nSelect Item name: ");
            String name = Console.ReadLine();
            foreach (Menu m in Globals.MenuList)
            {
                if (name.ToUpper() == m.name.ToUpper())
                {
                    Console.WriteLine("Name: " + m.name);
                    Console.WriteLine("Description: " + m.description);
                    Console.WriteLine("Price: " + m.price);
                    Console.WriteLine("Quantity: " + m.unit);

                    Console.WriteLine("\nUpdate item Info:");
                    Console.WriteLine("Input 'Same' if you want to keep the old information");
                    Console.Write("New Name: ");
                    string newname = Console.ReadLine();
                    Console.Write("New Description: ");
                    string newdesc = Console.ReadLine();
                    Console.Write("New Price: ");
                    string newprice = Console.ReadLine();
                    Console.Write("New Quantity: ");
                    string newQty = Console.ReadLine();
                    if (newname.ToUpper() != "SAME")
                    {
                        m.name = newname;
                    }

                    if (newdesc.ToUpper() != "SAME")
                    {
                        m.description = newdesc;
                    }
                    if (newprice.ToUpper() != "SAME")
                    {
                        m.price = float.Parse(newprice);
                    }
                    if (newQty.ToUpper() != "SAME")
                    {
                        m.unit = int.Parse(newQty);
                    }

                    Console.WriteLine("\nUpdate Successful!");
                    Console.WriteLine("Updated Information");
                    Console.WriteLine("Name: " + m.name);
                    Console.WriteLine("Description: " + m.description);
                    Console.WriteLine("Price: " + m.price);
                    Console.WriteLine("Quantity: " + m.unit);

                    break;
                }
            }
        }

        // Add single item
        public static void ManagerAddItem()
        {
            Console.WriteLine("\nFill in Item details");
            Console.Write("Name: ");
            string addItemName = Console.ReadLine();
            Console.Write("Description: ");
            string addItemDesc = Console.ReadLine();
            Console.Write("Price: ");
            string addItemPrice = Console.ReadLine();
            Console.Write("Quantity: ");
            string addItemQty = Console.ReadLine();

            int id = Globals.MenuList.Count + 1;
            FoodItem newitem = new FoodItem(id, addItemName, addItemDesc, float.Parse(addItemPrice), int.Parse(addItemQty));
            Console.WriteLine("Item added successfully!");
            Console.ReadLine();

        }

        public static void ManagerDeleteItem()
        {
            Console.WriteLine("\nSelect which to delete");
            foreach (Menu m in Globals.MenuList)
            {
                Console.WriteLine("Item Name: " + m.name);
            }
            Console.Write("\nSelect Item name: ");
            String name = Console.ReadLine();

            foreach (Menu m in Globals.MenuList)
            {
                if (name.ToUpper() == m.name.ToUpper())
                {

                }
            }
        }

        public static void managerViewOrder()
        {
            Console.WriteLine("All Orders:");
            foreach (Order o in Globals.OrderList)
            {
                Console.WriteLine("Order No:" + o.orderNo + ", Status:" + o.status + ", Payment Method:" + o.paymentMethod + ", Customer Name:" + o.cust.name + "\n");
            }
            Console.WriteLine("[1]View All\n[2]New\n[3]Preparing\n[4]Ready\n[5]Dispatched\n[6]Delivered\n[7]Cancelled\nEnter your filter:");

            //new, preparing, ready, dispatched, delivered, cancelled
            string filter = Console.ReadLine();
            List<Order> filtered = new List<Order>();
            if (filter == "1")
            {
                Console.WriteLine("Selected filter: View All");
                foreach (Order o in Globals.OrderList)
                {
                    filtered.Add(o);
                }
            }
            else if (filter == "2")
            {
                Console.WriteLine("Selected filter: New");
                foreach (Order o in Globals.OrderList)
                {
                    if (o.status == "New")
                    {
                        filtered.Add(o);
                    }
                }
            }
            else if (filter == "3")
            {
                Console.WriteLine("Selected filter: Preparing");
                foreach (Order o in Globals.OrderList)
                {
                    if (o.status == "Preparing")
                    {
                        filtered.Add(o);
                    }
                }
            }
            else if (filter == "4")
            {
                Console.WriteLine("Selected filter: Ready");
                foreach (Order o in Globals.OrderList)
                {
                    if (o.status == "Ready")
                    {
                        filtered.Add(o);
                    }
                }
            }
            else if (filter == "5")
            {
                Console.WriteLine("Selected filter: Dispatched");
                foreach (Order o in Globals.OrderList)
                {
                    if (o.status == "Dispatched")
                    {
                        filtered.Add(o);
                    }
                }
            }
            else if (filter == "6")
            {
                Console.WriteLine("Selected filter: Delivered");
                foreach (Order o in Globals.OrderList)
                {
                    if (o.status == "Delivered")
                    {
                        filtered.Add(o);
                    }
                }
            }
            else if (filter == "7")
            {
                Console.WriteLine("Selected filter: Cancelled");
                foreach (Order o in Globals.OrderList)
                {
                    if (o.status == "Cancelled")
                    {
                        filtered.Add(o);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid filter. Please Try again\n\n");
            }
            int c = filtered.Count;
            if (c == 0)
            {
                Console.WriteLine("There are no items in your filter. Please Try again\n\n");
                managerViewOrder();
            }
            else
            {
                foreach (Order o in filtered)
                {
                    Console.WriteLine("Order No:" + o.orderNo + ", Status:" + o.status + ", Payment Method:" + o.paymentMethod + ", Order Created Time:" + o.createDateTime + ", Customer ID:" + o.cust.accountNo + ", Customer Name:" + o.cust.name);
                    foreach (OrderLine ol in o.orderlineList)
                    {
                        Console.WriteLine("Food Name:" + ol.menu.name + ", Quantity:" + ol.menu.unit);
                    }
                    Console.WriteLine();
                }
            }

        }

    }
}

