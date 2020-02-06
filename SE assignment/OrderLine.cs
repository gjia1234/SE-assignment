using System;
using System.Collections.Generic;
using System.Text;

namespace SE_assignment
{
    class OrderLine
    {

        public int qty { get; set; }
        public Menu menu { get; set; }


        public OrderLine(int Qty,Menu Menu)
        {
            qty = Qty;
            menu = Menu;
        }
    }
}
