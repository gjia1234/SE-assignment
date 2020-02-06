using System;
using System.Collections.Generic;
using System.Text;

namespace SE_assignment
{
    class Order
    {
        private int orderNo;
        private string status; //new, preparing, ready, dispatched, delivered, cancelled
        private DateTime createDateTime; // Date & Time order is submitted
        private float subtotal;
        private float deliveryCharge;
        private float GST;
        private float totalPaymentAmt;
        private string paymentMethod;
        private DateTime timeReady; // Time the food is fully prepared
        private DateTime ETA; // ESTIMATED time the customer will receive the food
        private DateTime timeDelivered; // ACTUAL time the customer receive the food
        private Customer cust;
        private Dispatcher disp;
        private List<OrderLine> orderList;
        

        public Order(int OrderNo, string Status, DateTime CreateDateTime, float Subtotal, float DeliveryCharge, float goodServiceTax, float TotalPaymentAmt, string PaymentMethod, DateTime TimeReady, DateTime estimatedTimeArrival, DateTime TimeDelivered, Customer customer, Dispatcher dispatcher) 
        {
            orderNo = OrderNo;
            status = Status;
            createDateTime = CreateDateTime;
            subtotal = Subtotal;
            deliveryCharge = DeliveryCharge;
            GST = goodServiceTax;
            totalPaymentAmt = TotalPaymentAmt;
            paymentMethod = PaymentMethod;
            timeReady = TimeReady;
            ETA = estimatedTimeArrival;
            timeDelivered = TimeDelivered;
            cust = customer;
            disp = dispatcher;
        }
        


    }
}
