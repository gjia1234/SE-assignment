using System;
using System.Collections.Generic;
using System.Text;

namespace SE_assignment
{
    class Order
    {

        public int orderNo { get; set; }
        public string status { get; set; } //new, preparing, ready, dispatched, delivered, cancelled
        public DateTime createDateTime { get; set; }
        public float subtotal { get; set; }
        public float deliveryCharge { get; set; }
        public float GST { get; set; }
        public float totalPaymentAmt { get; set; }
        public string paymentMethod { get; set; }
        public DateTime timeReady { get; set; }// Time the food is fully prepared
        public DateTime ETA { get; set; }// ESTIMATED time the customer will receive the food
        public DateTime timeDelivered { get; set; }// ACTUAL time the customer receive the food
        public Customer cust { get; set; }
        public Dispatcher disp { get; set; }
        public List<OrderLine> orderlineList { get; set; }

        public Order(int OrderNo, string Status, DateTime CreateDateTime, string PaymentMethod, Customer customer, List<OrderLine> OrderLineList) 
        {
            orderNo = OrderNo;
            status = Status;
            createDateTime = CreateDateTime;
            paymentMethod = PaymentMethod;
            cust = customer;
            orderlineList = OrderLineList;
        }
        


    }
}
