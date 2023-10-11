namespace UnitTest
{
    [TestClass]
    public class UnitTestCustomer
    {
        [TestMethod]
        public void AddCustomer()
        {
            //Arrange
            ABS.Interfaces.Services.ICustomerService customerService = new BLL.Services.CustomerService();
            
            //Act
            customerService.AddCustomer("Test", "Test", "Test", "Test");

            //Assert
            return true;
        }

        [TestMethod]
        public void DeleteCustomer()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void GetAllCustomers()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void GetCustomerById()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void UpdateCustomer()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}