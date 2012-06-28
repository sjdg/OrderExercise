
namespace SJDGOrder
{
    using System.Collections.Generic;

    public class Order : IOrder
    {

        public ICustomer Payer { get; set; }

        public ICustomer Recipient { get; set; }

        public IList<IOrderItem> Items { get; set; }

        public void AddOrderItem(IOrderItem item)
        {
            throw new System.NotImplementedException();
        }

        public void removeOrderItem(IOrderItem item)
        {
            throw new System.NotImplementedException();
        }
    }
}
