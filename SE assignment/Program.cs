using System;
using System.Collections.Generic;

namespace SE_assignment
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Food Ordering System";
            //Test Data for Order
            //Test Data 1

            Customer cust1 = new Customer(1, "Avin", "Ngee Ann Poly", "avin@np.com", 91234567);
            Dispatcher disp1 = new Dispatcher("mohd", 1, "S9912313C", "Male", 97654321, DateTime.Now, "new");
            List<OrderLine> orderLineList1 = new List<OrderLine>();
            List<SetMeal> setMealList1 = new List<SetMeal>();
            List<FoodItem> foodItemList1 = new List<FoodItem>();

            Menu m1 = new Menu(1, "Chicken Nugget", "Tasty Chicken Nugget", 12, 1, "Available");
            OrderLine ol1 = new OrderLine(1, m1);
            Menu m2 = new Menu(1, "Whole Chicken", "Tasty Chicken ", 12, 1, "Available");
            OrderLine ol2 = new OrderLine(2, m2);

            orderLineList1.Add(ol1);
            orderLineList1.Add(ol2);

            //FoodItem f1 = new FoodItem(1, "French Fries", "Crispy Potatoes", 3, 1, "Available");
            //FoodItem f2 = new FoodItem(2, "Cheeseburger", "Potato buns filled with beef patty and pickles", 4, 1, "Available");

            //Globals.MenuList.Add(f1);
            //Globals.MenuList.Add(f2);

            List<Menu> menuList = new List<Menu>();
            menuList.Add(f1);
            menuList.Add(f2);


            Order a = new Order(1, "New", DateTime.Now, "Cash", cust1, orderLineList1);

            //Test Data 2
            Customer cust2 = new Customer(1, "Diego", "Ngee Ann Poly", "avin@np.com", 91234567);
            Dispatcher disp2 = new Dispatcher("Ali", 1, "S9912313C", "Male", 97654321, DateTime.Now, "new");
            List<OrderLine> orderLineList2 = new List<OrderLine>();

            Menu m3 = new Menu(1, "Chicken Burger", "Tasty Chicken Nugget", 12, 1, "Available");
            OrderLine ol3 = new OrderLine(1, m1);
            Menu m4 = new Menu(1, "Pasta", "Tasty Chicken ", 12, 1, "Available");
            OrderLine ol4 = new OrderLine(2, m2);

            orderLineList2.Add(ol1);
            orderLineList2.Add(ol2);
            Order b = new Order(2, "New", DateTime.Now, "Cash", cust2, orderLineList2);

            Globals.MenuList.Add(m1);
            Globals.MenuList.Add(m2);
            Globals.MenuList.Add(m3);
            Globals.MenuList.Add(m4);
            Globals.CustomerList.Add(cust1);
            Globals.OrderList.Add(a);
            Globals.OrderList.Add(b);

            //Message
            Console.WriteLine("\nWhat is your role? \n[1]Customer\n[2]Manager\n[3]Chef\nInput Option:");
            string role = Console.ReadLine();
            if (role == "1")
            {
                customerProcess();
            }
            else if (role == "2")
            {
                managerProcess();
            }
            else if (role == "3")
            {
                Chef chef = new Chef("Darren", 1, "S101010G", "MTF", 12345678, DateTime.Now, "Gay");
                chefProcess(chef);
            }
            else {
                Console.WriteLine("Option does not exist! Try again!");
                Main(args);
            }
        }

        static void customerProcess() {
            Console.WriteLine("\nYou have selected Customer!\nSelect your option:\n[A]Create a new order\n[B]View Current and Past Orders\nInput Option:");
            string option = Console.ReadLine();
            //Create new order function
            if (option == "A")
            {
                //c.CreateOrder();
            }
            //View Current and past orders
            else if (option == "B")
            {

            }
            else
            {
                Console.WriteLine("Option does not exist! Try again!");
            }
            customerProcess();
        }

        static void managerProcess() {
            Console.WriteLine("\nYou have selected Manager!\nSelect your option:\n[1]Manage food items and menus\n[2]View Orders\nInput Option:");
            string option = Console.ReadLine();
            //Manage food items and menus, including adding/updating/deleting of food items and menus
            if (option == "1")
            {
                Console.WriteLine("\nChoose which to manage!\n[1]Add item/set meal\n[2]Update item/set meal\n[3]Delete item/set meal\nInput what to manage:");
                string managerOption = Console.ReadLine();
                if (managerOption == "1")
                {
                    Console.WriteLine("\nChoose which to add\n[1]Add new item\n[2]Add new set meal\nInput selection:");
                    string addOption = Console.ReadLine();
                    if (addOption == "1")
                    {
                        //addItem();
                    }

                    else if (addOption == "2")
                    {
                        
                    }
                }

                else if (managerOption == "2")
                {
                    FoodItem.ManagerUpdateItem();
                }
                else if (managerOption == "3" )
                {

                }
                else
                {
                    Console.WriteLine("Option does not exist! Try again!");
                }
            }
            //View orders using various filters such as new, cancelled, delivered, etc
            else if (option == "2")
            {
                Order.managerViewOrder();

            }
            else
            {
                Console.WriteLine("Option does not exist! Try again!");
                managerProcess();
            }
        }

        

        static void chefProcess(Chef c)
        {
            while(true)
            {
                string Options = "You have selected Chef!\n";
                foreach (Order o in Globals.OrderList)
                {
                    if (o.status == "New")
                    {
                        Options += o.orderNo + "\n";
                    }
                }
                Options += "Input order you wish to prepare: ";
                Console.Write(Options);
                string orderNum = Console.ReadLine();
                c.selectOrder(Globals.OrderList[int.Parse(orderNum) - 1]);
                Console.Write("Do you want to complete another order?");
                string choice = Console.ReadLine();
                if(choice.ToLower() == "no")
                {
                    break;
                }
            }

            //Allow a chef to select the order he wishes to prepare and update the order for dispatch once the order is ready.
        }

  
        
        
    }
}
