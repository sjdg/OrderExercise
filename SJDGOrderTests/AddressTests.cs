
namespace SJDGOrderTests
{
    using NUnit.Framework;
    using SJDGOrder;

    [TestFixture]
    class AddressTests
    {
        private IAddress address;

        [SetUp]
        public void Setup()
        {
            address = new Address();  
        }

        [Test]
        public void GivenAnAddress_GetFormattedAddress_ReturnsCorrectValue()
        {
            // default value from constructor
            Assert.That(address.GetFormattedAddress(), Is.EqualTo(string.Empty));

            // set to null
            address.SetAddress(null);
            Assert.That(address.GetFormattedAddress(), Is.EqualTo(string.Empty));

            // valid addredd
            address.SetAddress("123 My Street");
            Assert.That(address.GetFormattedAddress(), Is.EqualTo("123 My Street"));
        }

        [Test]
        public void AfterAddAddressType_IsAddressType_IsTrueForThatAddressType()
        {
            address.AddAddressType(AddressType.BillingAddress);
            Assert.That(address.IsAddressType(AddressType.BillingAddress), Is.True);
        }

        [Test]
        public void AfterAddingATypeTwice_AddressTypesList_ContainsThatTypeOnlyOnce()
        {
            TestAddress testAddress = new TestAddress();

            testAddress.AddAddressType(AddressType.BillingAddress);
            testAddress.AddAddressType(AddressType.BillingAddress);
            Assert.That(testAddress.GetAddressTypeCount(), Is.EqualTo(1));
        }

        [Test]
        public void GivenMultipleAddressTypes_IsAddressType_IsTrueFor_TheGivenValues()
        {
            address.AddAddressType(AddressType.BillingAddress);
            address.AddAddressType(AddressType.ShippingAddress);

            Assert.That(address.IsAddressType(AddressType.BillingAddress), Is.True);
            Assert.That(address.IsAddressType(AddressType.ShippingAddress), Is.True);
            Assert.That(address.IsAddressType(AddressType.SoldToAddress), Is.False);
        }

        [Test]
        public void AfterRemovingAnAddressType_IsAddressType_ReturnsFalseForThatType()
        {
            address.AddAddressType(AddressType.BillingAddress);
            Assert.That(address.IsAddressType(AddressType.BillingAddress), Is.True);

            address.RemoveAddressType(AddressType.BillingAddress);
            Assert.That(address.IsAddressType(AddressType.BillingAddress), Is.False);
        }

        [Test]
        public void RemovingAnAddressTypeContainedInTheList_ReturnTrue()
        {
            address.AddAddressType(AddressType.SoldToAddress);
            Assert.That(address.RemoveAddressType(AddressType.SoldToAddress), Is.True);
        }

        [Test]
        public void RemovingAnAddressTypeThatIsNotInTheList_ReturnFalse()
        {
            // Remove from empty list
            Assert.That(address.RemoveAddressType(AddressType.ShippingAddress), Is.False);
            
            // remove item not in list
            address.AddAddressType(AddressType.ShippingAddress);
            Assert.That(address.RemoveAddressType(AddressType.BillingAddress), Is.False);

            // remove item already removed from list
            address.RemoveAddressType(AddressType.ShippingAddress); 
            Assert.That(address.RemoveAddressType(AddressType.ShippingAddress), Is.False);
        }

        class TestAddress : Address
        {
             public int GetAddressTypeCount()
             {
                 return base.addressTypes.Count;
             }
        }
    }
}
