using System;
using System.Collections.Generic;
using System.Text;

namespace SE_assignment
{
    class SetMeal : Menu
    {
        public int size { get; set; }
        public List<FoodItem> FoodItemList = new List<FoodItem>();

        public SetMeal(int ID, string Name,List<FoodItem> fooditemlist, string Description, float Price, int Unit, int Size) : base(ID, Name, Description, Price, Unit)
        {
            size = Size;
            FoodItemList = fooditemlist;
        }
    }
}
