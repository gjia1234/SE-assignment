﻿using System;
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
                if(m is FoodItem)
                {
                    Console.WriteLine("Item Name: " + m.name);
                }
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

        //Update Set Meal
        public static void ManagerUpdateSetMeal()
        {
            Console.Write("Which meal do you want to update?");
            foreach (Menu m in Globals.MenuList)
            {
                if (m is SetMeal)
                {
                    Console.WriteLine("Name: " + m.name);
                }
            }

            Console.Write("\nSelect Item name: ");
            String name = Console.ReadLine();

            Console.WriteLine("How would you like to update the Items in the Set Meal?");
            Console.WriteLine("[1]Create new list");
            Console.WriteLine("[2]Remove Item from list");
            Console.WriteLine("[3]Add Item to list");
            Console.WriteLine("[4]Keep the List the same");

            string updatingOptions = Console.ReadLine();
            if (updatingOptions == "1")
            {
                List<FoodItem> newFooditemlist = new List<FoodItem>();
                while (true)
                {

                    Console.Write("What item do you want to add:");
                    string item = Console.ReadLine();
                    foreach (Menu m in Globals.MenuList)
                    {
                        if (m is FoodItem)
                        {
                            if (m.name.ToUpper() == item.ToUpper())
                            {
                                FoodItem newitem = m as FoodItem;
                                newFooditemlist.Add(newitem);
                                Console.WriteLine("Item added successfully");
                                break;
                            }
                        }
                    }
                    Console.Write("Do you want to add another item? (YES/NO): ");
                    string choice = Console.ReadLine();
                    if (choice.ToUpper() == "NO")
                    {
                        break;
                    }
                }


            }

            if (updatingOptions == "4")
            {
                foreach (SetMeal m in Globals.MenuList)
                {
                    if (name.ToUpper() == m.name.ToUpper())
                    {
                        Console.WriteLine("Name: " + m.name);
                        Console.WriteLine("Description: " + m.description);
                        Console.WriteLine("Price: " + m.price);
                        Console.WriteLine("Quantity: " + m.unit);
                        Console.WriteLine("Size: " + m.size);

                        Console.WriteLine("\nUpdate item Info:");
                        Console.WriteLine("Input 'Same' if you want to keep the old information");
                        Console.Write("New Name: ");
                        string newSetname = Console.ReadLine();
                        Console.Write("New Description: ");
                        string newSetdesc = Console.ReadLine();
                        Console.Write("New Price: ");
                        string newSetprice = Console.ReadLine();
                        Console.Write("New Quantity: ");
                        string newSetQty = Console.ReadLine();
                        Console.Write("New Size: ");
                        string newSetSize = Console.ReadLine();

                        if (newSetname.ToUpper() != "SAME")
                        {
                            m.name = newSetname;
                        }

                        if (newSetdesc.ToUpper() != "SAME")
                        {
                            m.description = newSetdesc;
                        }
                        if (newSetprice.ToUpper() != "SAME")
                        {
                            m.price = float.Parse(newSetprice);
                        }
                        if (newSetQty.ToUpper() != "SAME")
                        {
                            m.unit = int.Parse(newSetQty);
                        }
                        if (newSetSize.ToUpper() != "SAME")
                        {
                            m.size = int.Parse(newSetSize);
                        }


                        Console.WriteLine("Update Successful!");
                        Console.WriteLine("\nUpdated Information");
                        Console.WriteLine("Name: " + m.name);
                        Console.WriteLine("Description: " + m.description);
                        Console.WriteLine("Price: " + m.price);
                        Console.WriteLine("Quantity: " + m.unit);
                        Console.WriteLine("Size: " + m.size);

                        break;

                    }
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
            Console.WriteLine("\nItem added successfully!");
            foreach (Menu m in Globals.MenuList)
            {
                if(m is FoodItem)
                {
                    Console.WriteLine("Item Name: " + m.name);
                }
                
            }
            Console.ReadLine();

        }

        //Add new Set Meal
        public static void ManagerAddSetMeal()
        {
            Console.WriteLine("\nFill in new Set Meal details");
            Console.Write("Name: ");
            string addSetName = Console.ReadLine();
            List<FoodItem> newFooditemlist = new List<FoodItem>();
            while (true)
            {

                Console.Write("What item do you want to add:");
                string item = Console.ReadLine();
                foreach(Menu m in Globals.MenuList)
                {
                    if(m is FoodItem)
                    {
                        if(m.name.ToUpper() == item.ToUpper())
                        {
                            FoodItem newitem = m as FoodItem;
                            newFooditemlist.Add(newitem);
                            Console.WriteLine("Item added successfully");
                            break;
                        }
                    }
                }
                Console.Write("Do you want to add another item? (YES/NO): ");
                string choice = Console.ReadLine();
                if(choice.ToUpper() == "NO")
                {
                    break;
                }
            }
            Console.Write("Description: ");
            string addSetDesc = Console.ReadLine();
            Console.Write("Price: ");
            string addSetPrice = Console.ReadLine();
            Console.Write("Quantity: ");
            string addSetQty = Console.ReadLine();
            Console.Write("Size: ");
            string addSetSize = Console.ReadLine();

            int id = Globals.MenuList.Count + 1;
            SetMeal newSet = new SetMeal(id, addSetName, newFooditemlist, addSetDesc, float.Parse(addSetPrice), int.Parse(addSetQty), int.Parse(addSetSize));
            Globals.MenuList.Add(newSet);
            Console.WriteLine("\nSet meal added successfully!");
            foreach (Menu m in Globals.MenuList)
            {
                if (m is SetMeal)
                {
                    Console.WriteLine("Meal Name: " + m.name);
                }
                
            }
            Console.ReadLine();

        }

        //Delete single item
        public static void ManagerDeleteItem()
        {
            Console.WriteLine("\nSelect which to delete");
            foreach (Menu m in Globals.MenuList)
            {
                if (m is FoodItem)
                {
                    Console.WriteLine("Item Name: " + m.name);
                }
                
            }
            Console.Write("\nSelect Item name: ");
            String name = Console.ReadLine();
            int count = 0;
            foreach (Menu m in Globals.MenuList)
            {
                if (name.ToUpper() == m.name.ToUpper())
                {
                    break;
                }
                count += 1;
            }
            //Console.WriteLine(Globals.MenuList[count].name);
            Globals.MenuList.RemoveAt(count);
            Console.WriteLine("\nDelete Succesful!");
            foreach (Menu m in Globals.MenuList)
            {
                if (m is FoodItem)
                {
                    Console.WriteLine("Item Name: " + m.name);
                }
                
            }
            Console.ReadLine();
        }

        //Delete Set Meal
        public static void ManagerDeleteSetMeal()
        {
            Console.WriteLine("Select which Set Meal to delete");
            foreach (Menu m in Globals.MenuList)
            {
                if (m is SetMeal)
                {
                    Console.WriteLine("Name: " + m.name);
                }
            }
            Console.WriteLine("\nSelect Set Meal Name: ");
            String name = Console.ReadLine();
            int count = 0;
            foreach (Menu m in Globals.MenuList)
            {
                if (name.ToUpper() == m.name.ToUpper())
                {
                    break;
                }
                count += 1;
            }
            //Console.WriteLine(Globals.MenuList[count].name);
            Globals.MenuList.RemoveAt(count);
            Console.WriteLine("Delete Succesful!");

        public static void managerViewOrder()
        {
            Console.WriteLine("All Orders:");
            foreach (Order o in Globals.OrderList)
            {
                Console.WriteLine("Order No:" + o.orderNo + ", Status:" + o.status + ", Payment Method:" + o.paymentMethod + ", Customer Name:" + o.cust.name + "\n");
            }
            Console.WriteLine("[1]View All\n[2]New\n[3]Preparing\n[4]Ready\n[5]Dispatched\n[6]Delivered\n[7]Cancelled\nEnter your filter:");

            foreach (Menu m in Globals.MenuList)
            {
                if (m is SetMeal)
                {
                    Console.WriteLine("Set Meal Name: " + m.name);
                }
                
            }
            Console.ReadLine();
        }
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

