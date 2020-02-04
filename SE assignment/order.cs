using System;
using System.Collections.Generic;
using System.Text;

namespace SE_assignment
{
    class Order
    {
        private int OrderNo;
        private string Status; //new, preparing, ready, dispatched, delivered, cancelled
        private DateTime DateTime; // Date & Time order is submitted
        private float Subtotal;
        private float DeliveryCharge;
        private float GST;
        private float TotalPaymentAmt;
        private string PaymentMethod;
        private DateTime TimeReady; // Time the food is fully prepared
        private DateTime ETA; // ESTIMATED time the customer will receive the food
        private DateTime TimeDelivered; // ACTUAL time the customer receive the food
        private Customer customer;
        

        public Order(int OrderNo, string Status, DateTime DateTime, float Subtotal, float DeliveryCharge, float GST, float TotalPaymentAmt, string PaymentMethod, DateTime TimeReady, DateTime ETA, DateTime TimeDelivered, Customer customer) 
        {
            
        }
        


    }
}
