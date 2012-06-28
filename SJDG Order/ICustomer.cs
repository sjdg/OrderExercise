

namespace SJDGOrder
{
    using System.Collections.Generic;

    public interface ICustomer
    {
        int Id { get;  set; }
        IName Name { get; set; }
        IList<IAddress> Addresses { get; set; }

    }
}
