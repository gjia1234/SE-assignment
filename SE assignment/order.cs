using System;
using System.Collections.Generic;
using System.Text;

namespace SE_assignment
{
    interface IOrder
    {
        IOrderListIterator CreateIterator();
    }
    class Order : IOrder
    {

        public int orderNo { get; set; }
        public string status { get; set; } //new, preparing, ready, dispatched, delivered, cancelled
        public DateTime createDateTime { get; set; }
        public float deliveryCharge { get; set; }
        public float GST { get; set; }
        public float totalPaymentAmt { get; set; }
        public string paymentMethod { get; set; }
        public DateTime timeReady { get; set; }// Time the food is fully prepared
        public DateTime ETA {
            get { return createDateTime.AddHours(1); }
        }// ESTIMATED time the customer will receive the food
        public DateTime timeDelivered { get; set; }// ACTUAL time the customer receive the food
        public Customer cust { get; set; }
        public Dispatcher disp { get; set; }
        public List<OrderLine> orderlineList { get; set; }
        public object this[int index]
        {
            get { return orderlineList[index]; }
        }

        public Order(int OrderNo, string Status, DateTime CreateDateTime, string PaymentMethod, Customer customer, List<OrderLine> OrderLineList) 
        {
            orderNo = OrderNo;
            status = Status;
            createDateTime = CreateDateTime;
            paymentMethod = PaymentMethod;
            cust = customer;
            orderlineList = OrderLineList;
        }
        public OrderListIterator CreateIterator()
        {
            return new OrderListIterator(this);
        }
        public float subtotal()
        {
            float total = 0;
            OrderListIterator iterator = CreateIterator();
            for(
                OrderLine item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                total += item.menu.price *item.qty;
            }
            return total;
        }
        

        public static void managerViewOrder()
        {
            Console.WriteLine("All Orders:");
            foreach (Order o in Globals.OrderList)
            {
                Console.WriteLine("Order No:" + o.orderNo + ", Status:" + o.status + ", Payment Method:" + o.paymentMethod + ", Customer Name:" + o.cust.name + "\n");
            }
            Console.WriteLine("[1]View All\n[2]New\n[3]Preparing\n[4]Ready\n[5]Dispatched\n[6]Delivered\n[7]Cancelled\nEnter your filter:");

            //new, preparing, ready, dispatched, delivered, cancelled
            string filter = Console.ReadLine();
            List<Order> filtered = new List<Order>();
            if (filter == "1")
            {
                Console.WriteLine("Selected filter: View All");
                foreach (Order o in Globals.OrderList)
                {
                    filtered.Add(o);
                }
            }
            else if (filter == "2")
            {
                Console.WriteLine("Selected filter: New");
                foreach (Order o in Globals.OrderList)
                {
                    if (o.status == "New")
                    {
                        filtered.Add(o);
                    }
                }
            }
            else if (filter == "3")
            {
                Console.WriteLine("Selected filter: Preparing");
                foreach (Order o in Globals.OrderList)
                {
                    if (o.status == "Preparing")
                    {
                        filtered.Add(o);
                    }
                }
            }
            else if (filter == "4")
            {
                Console.WriteLine("Selected filter: Ready");
                foreach (Order o in Globals.OrderList)
                {
                    if (o.status == "Ready")
                    {
                        filtered.Add(o);
                    }
                }
            }
            else if (filter == "5")
            {
                Console.WriteLine("Selected filter: Dispatched");
                foreach (Order o in Globals.OrderList)
                {
                    if (o.status == "Dispatched")
                    {
                        filtered.Add(o);
                    }
                }
            }
            else if (filter == "6")
            {
                Console.WriteLine("Selected filter: Delivered");
                foreach (Order o in Globals.OrderList)
                {
                    if (o.status == "Delivered")
                    {
                        filtered.Add(o);
                    }
                }
            }
            else if (filter == "7")
            {
                Console.WriteLine("Selected filter: Cancelled");
                foreach (Order o in Globals.OrderList)
                {
                    if (o.status == "Cancelled")
                    {
                        filtered.Add(o);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid filter. Please Try again\n\n");
            }
            int c = filtered.Count;
            if (c == 0) {
                Console.WriteLine("There are no items in your filter. Please Try again\n\n");
                managerViewOrder();
            }
            else { 
                foreach (Order o in filtered)
                {
                
                    Console.WriteLine("Order No:" + o.orderNo + ", Status:" + o.status + ", Payment Method:" + o.paymentMethod + ", Customer Name:" + o.cust.name);
                }
            }
            
        }

        IOrderListIterator IOrder.CreateIterator()
        {
            throw new NotImplementedException();
        }
    }
}
