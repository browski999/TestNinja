using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        private CustomerController _customerController;

        [SetUp]
        public void Setup()
        {
            _customerController = new CustomerController();
        }

        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var result = _customerController.GetCustomer(0);

            //NotFound object
            Assert.That(result, Is.TypeOf<NotFound>());

            //NotFound or one of its derivatives
            Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOK()
        {
            var result = _customerController.GetCustomer(1);

            //OK object
            Assert.That(result, Is.TypeOf<Ok>());

            //OK, or one of its derivatives
            Assert.That(result, Is.InstanceOf<Ok>());
        }
    }
}
