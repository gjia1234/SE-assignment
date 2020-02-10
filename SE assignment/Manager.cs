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
            int count = 0;
            foreach (Menu m in Globals.MenuList)
            {
                if (name.ToUpper() == m.name.ToUpper())
                {
                    break;
                }
                count += 1;
            }
            Console.WriteLine(Globals.MenuList[count].name);
            Globals.MenuList.RemoveAt(count);
            Console.WriteLine("Delete Succesful!");
            foreach (Menu m in Globals.MenuList)
            {
                Console.WriteLine("Item Name: " + m.name);
            }
            Console.ReadLine();
        }

    }
    
}

