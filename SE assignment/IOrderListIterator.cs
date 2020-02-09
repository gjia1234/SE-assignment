namespace SE_assignment
{
    interface IOrderListIterator
    {
        OrderLine First();
        OrderLine Next();
        bool IsDone { get; }
        OrderLine CurrentLine { get; }
    }

    class OrderListIterator : IOrderListIterator
    {
        private Order _order;
        private int _current = 0;
        private int _step = 1;

        public OrderListIterator(Order o)
        {
            _order = o;
        }
        public OrderLine First()
        {
            _current = 0;
            return _order.orderlineList[_current] as OrderLine;
        }
        public OrderLine Next()
        {
            _current += _step;
            if (!IsDone)
            {
                return _order.orderlineList[_current] as OrderLine;
            }
            return null;
        }

        public OrderLine CurrentLine
        {
            get { return _order.orderlineList[_current] as OrderLine; }
        }

        public bool IsDone
        {
            get { return _current >= _order.orderlineList.Count; }
        }

    }
}