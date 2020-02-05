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
        private float goodServiceTax;
        private float totalPaymentAmt;
        private string paymentMethod;
        private DateTime timeReady; // Time the food is fully prepared
        private DateTime estimatedTimeArrival; // ESTIMATED time the customer will receive the food
        private DateTime timeDelivered; // ACTUAL time the customer receive the food
        private Customer cust;
        

        public Order(int OrderNo, string Status, DateTime CreateDateTime, float Subtotal, float DeliveryCharge, float GST, float TotalPaymentAmt, string PaymentMethod, DateTime TimeReady, DateTime ETA, DateTime TimeDelivered, Customer customer) 
        {
            orderNo = OrderNo;
            status = Status;
            createDateTime = CreateDateTime;
            subtotal = Subtotal;
            deliveryCharge = DeliveryCharge;
            goodServiceTax = GST;
            totalPaymentAmt = TotalPaymentAmt;
            paymentMethod = PaymentMethod;
            timeReady = TimeReady;
            estimatedTimeArrival = ETA;
            timeDelivered = TimeDelivered;
            cust = customer;
        }
        


    }
}
