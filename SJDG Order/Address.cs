
namespace SJDGOrder
{
    using System.Collections.Generic;

    public class Address : IAddress
    {
        protected IList<AddressType> addressTypes = new List<AddressType>();
        private string address;

        #region IAddress Members

        public string GetFormattedAddress()
        {
            return string.IsNullOrEmpty(this.address) ? string.Empty : this.address;
        }

        public void AddAddressType(AddressType type)
        {
            if (!this.IsAddressType(type))
            {
                this.addressTypes.Add(type);
            }
        }

        public bool RemoveAddressType(AddressType type)
        {
             return this.addressTypes.Remove(type);
        }

        public bool IsAddressType(AddressType type)
        {
            return this.addressTypes.Contains(type);
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        #endregion
    }
}
