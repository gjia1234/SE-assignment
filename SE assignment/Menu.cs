using System;
using System.Collections.Generic;
using System.Text;

namespace SE_assignment
{
    class Menu
    {

        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public int unit  { get; set; }
        public string status { get; set; }
        public List<FoodItem> foodItemList { get; set; }


        public Menu(int ID, string Name, string Description, float Price, int Unit, string Status)
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
