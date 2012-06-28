
namespace SJDGOrder
{
    public interface IAddress
    {
        void SetAddress(string address);
        string GetFormattedAddress();
        void AddAddressType(AddressType type);
        bool RemoveAddressType(AddressType type);
        bool IsAddressType(AddressType type);
    }
}
