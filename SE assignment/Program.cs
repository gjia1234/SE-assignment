using System;

namespace SE_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your role? \n[1]Customer\n[2]Manager\n[3]Chef\nInput Option:");
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
                chefProcess();
            }
            else {
                Console.WriteLine("Option does not exist! Try again!");
                Main(args);
            }
        }

        static void customerProcess() {
            Console.WriteLine("You have selected Customer!\nSelect your option:\n[A]Create a new order\n[B]View Current and Past Orders\nInput Option:");
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

        static void managerProcess() {
            Console.WriteLine("You have selected Manager!\nSelect your option:\n[A]Manage food items and menus\n[B]View Orders\nInput Option:");
            string option = Console.ReadLine();
            //Manage food items and menus, including adding/updating/deleting of food items and menus
            if (option == "A")
            {

            }
            //View orders using various filters such as new, cancelled, delivered, etc
            else if (option == "B")
            {

            }
            else
            {
                Console.WriteLine("Option does not exist! Try again!");
                managerProcess();
            }
        }

        static void chefProcess()
        {
            Console.WriteLine("You have selected Chef!\n[show list of orders?]\nInput order you wish to prepare:");
            string orderNum = Console.ReadLine();
            //Allow a chef to select the order he wishes to prepare and update the order for dispatch once the order is ready.
        }
    }
}
