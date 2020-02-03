using System;

namespace SE_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer(1, "Jacob", "Woodlands St 41", "gjia@gmail.com", 94232602);
            c.print();
            Console.ReadLine();
        }
    }
}
