using System;
using System.Collections.Generic;

namespace SE_assignment
{
    class Program
    {
        static void Main(string[] args)
        {   

            //Test Data for Order
            //Test Data 1

            Customer cust1 = new Customer(1, "Avin", "Ngee Ann Poly", "avin@np.com", 91234567);
            Dispatcher disp1 = new Dispatcher("mohd", 1, "S9912313C", "Male", 97654321, DateTime.Now, "new");
            List<OrderLine> orderLineList1 = new List<OrderLine>();

            Menu m1 = new Menu(1, "Chicken Nugget", "Tasty Chicken Nugget", 12, 1, "Available");
            OrderLine ol1 = new OrderLine(1, m1);
            Menu m2 = new Menu(1, "Whole Chicken", "Tasty Chicken ", 12, 1, "Available");
            OrderLine ol2 = new OrderLine(2, m2);

            orderLineList1.Add(ol1);
            orderLineList1.Add(ol2);

            Order a = new Order(1, "New", DateTime.Now, "Credit Card", cust1, orderLineList1);

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
            Order b = new Order(2, "New", DateTime.Now, "Cash", cust2, orderLineList1);

            Globals.MenuList.Add(m1);
            Globals.MenuList.Add(m2);
            Globals.MenuList.Add(m3);
            Globals.MenuList.Add(m4);
            Globals.CustomerList.Add(cust1);
            Globals.OrderList.Add(a);
            Globals.OrderList.Add(b);


            //Message
            Console.Write("What is your role? \n[1]Customer\n[2]Manager\n[3]Chef\nInput Option: ");
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
                chefProcess();
            }
            else {
                Console.WriteLine("Option does not exist! Try again!");
                Main(args);
            }
        }

        static void customerProcess(Customer c) {
            Console.Write("You have selected Customer!\nSelect your option:\n[A]Create a new order\n[B]View Current and Past Orders\nInput Option: ");
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
            }
            customerProcess(c);
        }

        static void managerProcess() {
            Console.WriteLine("You have selected Manager!\nSelect your option:\n[A]Manage food items and menus\n[B]View Orders\nInput Option: ");
            string option = Console.ReadLine();
            //Manage food items and menus, including adding/updating/deleting of food items and menus
            if (option == "A")
            {

            }
            //View orders using various filters such as new, cancelled, delivered, etc
            else if (option == "B")
            {
                Order.managerViewOrder();

            }
            else
            {
                Console.WriteLine("Option does not exist! Try again!");
                managerProcess();
            }
        }

        static void chefProcess()
        {
            Console.WriteLine("You have selected Chef!\n[show list of orders?]\nInput order you wish to prepare: ");
            string orderNum = Console.ReadLine();
            if (orderNum == "1")
            {
                Console.WriteLine("GG");
            }
            //Allow a chef to select the order he wishes to prepare and update the order for dispatch once the order is ready.
        }
        
    }
}
