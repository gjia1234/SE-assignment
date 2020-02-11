using System;
using System.Collections.Generic;
using System.Text;

namespace SE_assignment
{
    abstract class Menu
    {

        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public int unit  { get; set; }
        public bool status {
            get { return unit > 0; }
        }
        public List<FoodItem> foodItemList { get; set; }
        public int prepTime { get; set; }

        public Menu() { }

        public Menu(int ID, string Name, string Description, float Price, int Unit, int PrepTime)
        {
            id = ID;
            name = Name;
            description = Description;
            price = Price;
            unit = Unit;
            prepTime = PrepTime;
        }

    }
}
