using System;
using System.Collections.Generic;
using System.Text;

namespace SE_assignment
{
    class SetMeal : Menu
    {
        public int size { get; set; }
        public List<FoodItem> FoodItemList = new List<FoodItem>();

        public SetMeal(int ID, string Name,List<FoodItem> fooditemlist, string Description, float Price, int Unit, int Size, int PrepTime) : base(ID, Name, Description, Price, Unit, PrepTime)
        {
            size = Size;
            FoodItemList = fooditemlist;
        }
    }
}
