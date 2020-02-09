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
            Menu m2 = new Menu(1, "Chicken Whole", "Tasty Chicken ", 12, 1, "Available");
            OrderLine ol2 = new OrderLine(2, m2);

            orderLineList1.Add(ol1);
            orderLineList1.Add(ol2);

            FoodItem f1 = new FoodItem(1, "French Fries", "Crispy Potatoes", 3, 1, "Available");
            FoodItem f2 = new FoodItem(2, "Cheeseburger", "Potato buns filled with beef patty and pickles", 4, 1, "Available");

            foodItemList1.Add(f1);
            foodItemList1.Add(f2);

            List<Menu> menuList = new List<Menu>();
            menuList.Add(f1);
            menuList.Add(f2);


            Order a = new Order(1, "New", DateTime.Now, 36, 3, 1, 40, "Credit Card", DateTime.Now, DateTime.Now, DateTime.Now, cust1, disp1, orderLineList1);

            //Test Data 2
            Customer cust2 = new Customer(1, "Diego", "Ngee Ann Poly", "avin@np.com", 91234567);
            Dispatcher disp2 = new Dispatcher("Ali", 1, "S9912313C", "Male", 97654321, DateTime.Now, "new");
            List<OrderLine> orderLineList2 = new List<OrderLine>();

            Menu m3 = new Menu(1, "Chicken Nugget", "Tasty Chicken Nugget", 12, 1, "Available");
            OrderLine ol3 = new OrderLine(1, m1);
            Menu m4 = new Menu(1, "Chicken Whole", "Tasty Chicken ", 12, 1, "Available");
            OrderLine ol4 = new OrderLine(2, m2);

            orderLineList2.Add(ol1);
            orderLineList2.Add(ol2);

            Order b = new Order(2, "New", DateTime.Now, 36, 3, 1, 40, "Cash", DateTime.Now, DateTime.Now, DateTime.Now, cust2, disp2, orderLineList1);

            List<Order> orderList = new List<Order>();
            orderList.Add(a);
            orderList.Add(b);


            //Message
            Console.WriteLine("\nWhat is your role? \n[1]Customer\n[2]Manager\n[3]Chef\nInput Option:");
            string role = Console.ReadLine();
            if (role == "1")
            {
                customerProcess();
            }
            else if (role == "2")
            {
                managerProcess(orderList);
            }
            else if (role == "3")
            {
                chefProcess();
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

            }
            //View Current and past orders
            else if (option == "B")
            {

            }
            else
            {
                Console.WriteLine("Option does not exist! Try again!");
                customerProcess();
            }
        }

        static void managerProcess(List<Order> ol) {
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
                        addItem();
                    }

                    else if (addOption == "2")
                    {
                        
                    }
                }

                else if (managerOption == "2")
                {
                    //updateItem();
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
                Console.WriteLine("All Orders:");
                foreach (Order o in ol) {
                    //",Created Time:"+o.createDateTime+
                    Console.WriteLine("Order No:"+o.orderNo+", Status:"+o.status+", Total Payment Amount:"+o.totalPaymentAmt+", Payment Method:"+o.paymentMethod+", Time Ready:"+o.timeReady+", Time Delivered:"+o.timeDelivered+", Customer Name:"+o.cust.name+", Dispatcher Name:"+o.disp.name+"\n");
                }
                Console.WriteLine("Enter your filter");
                //new, preparing, ready, dispatched, delivered, cancelled

                string optioasn = Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Option does not exist! Try again!");
                managerProcess(ol);
            }
        }

        static void chefProcess()
        {
            Console.WriteLine("\nYou have selected Chef!\n[show list of orders?]\nInput order you wish to prepare:");
            string orderNum = Console.ReadLine();
            //Allow a chef to select the order he wishes to prepare and update the order for dispatch once the order is ready.
        }

        static void addItem()
        {
            Console.WriteLine("Insert item information");

        }

        static void updateItem(List<FoodItem> item)
        {
            Console.WriteLine("Please select item to update");
            foreach(FoodItem f in item)
            {
                Console.WriteLine("Item: "+f.name);
            }
            
        }
        
    }
}
