namespace SJDGOrder
{
    using System.Collections.Generic;

    public interface IOrder
    {
        ICustomer Payer { get; set; }

        ICustomer Recipient { get; set; }

        IList<IOrderItem> Items { get; set; }

        void AddOrderItem( IOrderItem item);

        void removeOrderItem(IOrderItem item);
    }
}