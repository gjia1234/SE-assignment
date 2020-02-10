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

            FoodItem m1 = new FoodItem(1, "Chicken Nugget", "Tasty Chicken Nugget", 12, 1);
            OrderLine ol1 = new OrderLine(1, m1);
            FoodItem m2 = new FoodItem(1, "Whole Chicken", "Tasty Chicken ", 12, 1);
            OrderLine ol2 = new OrderLine(2, m2);

            //SetMeal sm1 = new SetMeal(1, "Chicken Nugget Meal", "Comes with tasty fries, 6pc nuggets", 20, 1, 2);
           // SetMeal sm2 = new SetMeal(2, "Spring Chicken Meal", "Comes with Whole Fried Chicken and fries", 25, 1, 4);

            orderLineList1.Add(ol1);
            orderLineList1.Add(ol2);
            

            Order a = new Order(1, "New", DateTime.Now, "Cash", cust1, orderLineList1);

            //Test Data 2
            Customer cust2 = new Customer(1, "Diego", "Ngee Ann Poly", "avin@np.com", 91234567);
            Dispatcher disp2 = new Dispatcher("Ali", 1, "S9912313C", "Male", 97654321, DateTime.Now, "new");
            List<OrderLine> orderLineList2 = new List<OrderLine>();

            FoodItem m3 = new FoodItem(1, "Chicken Burger", "Tasty Chicken Patty", 12, 1);
            OrderLine ol3 = new OrderLine(1, m1);
            FoodItem m4 = new FoodItem(1, "Pasta", "Tasty Chicken ", 12, 1);
            OrderLine ol4 = new OrderLine(2, m2);

            //new, preparing, ready, dispatched, delivered, cancelled
            orderLineList2.Add(ol1);
            orderLineList2.Add(ol2);
            Order b = new Order(2, "Preparing", DateTime.Now, "Cash", cust2, orderLineList2);
            Order c = new Order(3, "Ready", DateTime.Now, "Cash", cust2, orderLineList2);
            Order d = new Order(4, "Dispatched", DateTime.Now, "Cash", cust2, orderLineList2);
            Order e = new Order(5, "Delivered", DateTime.Now, "Cash", cust2, orderLineList2);
            Order f = new Order(6, "Cancelled", DateTime.Now, "Cash", cust2, orderLineList2);

            Globals.MenuList.Add(m1);
            Globals.MenuList.Add(m2);
            Globals.MenuList.Add(m3);
            Globals.MenuList.Add(m4);
            Globals.CustomerList.Add(cust1);
            Globals.OrderList.Add(a);
            Globals.OrderList.Add(b);
            Globals.OrderList.Add(c);
            Globals.OrderList.Add(d);
            Globals.OrderList.Add(e);
            Globals.OrderList.Add(f);

            //Message
            while (true)
            {
                Console.Write("\nWhat is your role? \n[1]Customer\n[2]Manager\n[3]Chef\nInput Option:");
                string role = Console.ReadLine();
                if (role == "1")
                {
                    customerProcess(cust1);
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
                else
                {
                    Console.WriteLine("Option does not exist! Try again!");
                    Main(args);
                }
            }
        }

        static void customerProcess(Customer c) {
            Console.Write("\nYou have selected Customer!\nSelect your option:\n[A]Create a new order\n[B]View Current and Past Orders\nInput Option:");
            string option = Console.ReadLine();
            //Create new order function
            if (option == "A")
            {
                c.CreateOrder();
            }
            //View Current and past orders
            else if (option == "B")
            {

            }
            else
            {
                Console.WriteLine("Option does not exist! Try again!");
                customerProcess(c);
            }
            
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

                    // Add single item
                    if (addOption == "1") 
                    {
                        Manager.ManagerAddItem();
                    }

                    // Add Set Meal
                    else if (addOption == "2")
                    {
                        
                    }
                }

                // Update Item/Set meal
                else if (managerOption == "2") 
                {

                    Console.WriteLine("\nSelect which to update");
                    Console.WriteLine("[1]Update item");
                    Console.WriteLine("[2]Update set meal");
                    Console.WriteLine("Input selection: ");

                    string updateOption = Console.ReadLine();

                    // Update single item
                    if (updateOption == "1") 
                    {
                        Manager.ManagerUpdateItem();
                        Console.ReadLine();
                    }

                    //Update set meal
                    else if (updateOption == "2") 
                    {

                    }
                   
                }

                // Delete item/set meal
                else if (managerOption == "3" ) 
                {
                    Console.WriteLine("\nSelect which to delete from");
                    Console.WriteLine("[1]Delete Item");
                    Console.WriteLine("[2]Delete Set Meal");
                    Console.WriteLine("Input Selection: ");

                    string deleteOption = Console.ReadLine();

                    //delete single item
                    if(deleteOption == "1")
                    {
                        Manager.ManagerDeleteItem();
                    }
                    
                    //delete single set meal
                    else if (deleteOption == "2")
                    {

                    }
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
