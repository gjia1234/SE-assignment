using System;
using System.Collections.Generic;
using System.Text;

namespace SE_assignment
{
    class FoodItem : Menu
    {
        public FoodItem(int ID, string Name, string Description, int Price, int Unit, string Status) : base(ID, Name, Description, Price, Unit, Status)
        {

        }

        public static void ManagerUpdateItem()
        {
            Console.WriteLine("Choose which to update");
            foreach (FoodItem f in Globals.MenuList)
            {
                Console.WriteLine("Item Name: " +f.name);
            }
        }

        public static void ManagerAddItem()
        {
            Console.WriteLine("Fill in details");
        }
    }
}
