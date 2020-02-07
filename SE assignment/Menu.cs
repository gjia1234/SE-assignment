using System;
using System.Collections.Generic;
using System.Text;

namespace SE_assignment
{
    class Menu
    {
        private int id;
        private string name;
        private string description;
        private int price;
        private int unit;
        private string status;

        public Menu(int ID, string Name, string Description, int Price, int Unit, string Status)
        {
            id = ID;
            name = Name;
            description = Description;
            price = Price;
            unit = Unit;
            status = Status;
        }
    }
}
