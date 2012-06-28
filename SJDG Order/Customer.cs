
namespace SJDGOrder
{
    using System.Collections.Generic;

    public class Customer : ICustomer
    {
        /// <summary>
        /// This is the primary key in the repository
        /// </summary>
        public int Id { get; set; }

        public IName Name { get; set; }

        public IList<IAddress> Addresses { get; set; }
    }
}
