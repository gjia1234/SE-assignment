using System;
using System.Collections.Generic;
using System.Text;

namespace SE_assignment
{
    class SetMeal : Menu
    {
        public int size { get; set; }

        public SetMeal(int ID, string Name, string Description, int Price, int Unit, string Status, int Size) : base(ID, Name, Description, Price, Unit, Status)
        {
            size = Size;
        }
    }
}
