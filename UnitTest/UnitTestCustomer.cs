using RePo.MockRePo;
using System.Net.NetworkInformation;

namespace UnitTest
{
    [TestClass]
    public class UnitTestCustomer
    {
        [TestMethod]
        public void AddCustomer()
        {
            //Arrange
            ABS.Interfaces.RePo.ICustomerRePo CustRepo = new RePo.MockRePo.CustomerMockRePo();
            ABS.Interfaces.Services.ICustomerService customerService = new BLL.Services.PrivatCustomerService(CustRepo);
            List<BLL.Models.CustomerModel> list = new List<BLL.Models.CustomerModel>();
           

            //Act
            var result = customerService.AddCustomer("Test", "Test", "Test", "Test");

            var CustomerList = customerService.GetAllCustomers();
            var lastCustomer = CustomerList.LastOrDefault();

            //Assert
            
            Assert.AreSame(lastCustomer.FirstName, "Test");
        }

        [TestMethod]
        public void DeleteCustomer()
        {
            //Arrange
            ABS.Interfaces.RePo.ICustomerRePo CustRepo = new RePo.MockRePo.CustomerMockRePo();
            ABS.Interfaces.Services.ICustomerService customerService = new BLL.Services.PrivatCustomerService(CustRepo);
            var TestID = 1;


            //Act
            var result = customerService.DeleteCustomer(TestID);

            ABS.Interfaces.Models.ICustomerModel customer = customerService.GetCustomerById(TestID);

            //Assert
            Assert.IsNull(customer);
        }

        [TestMethod]
        public void GetAllCustomers()
        {
            //Arrange
            ABS.Interfaces.RePo.ICustomerRePo CustRepo = new RePo.MockRePo.CustomerMockRePo();
            ABS.Interfaces.Services.ICustomerService customerService = new BLL.Services.PrivatCustomerService(CustRepo);

            //Act
            var List = customerService.GetAllCustomers();

            //Assert
            Assert.IsNotNull(List);
        }

        [TestMethod]
        public void GetCustomerById()
        {
            //Arrange
            ABS.Interfaces.RePo.ICustomerRePo CustRepo = new RePo.MockRePo.CustomerMockRePo();
            ABS.Interfaces.Services.ICustomerService customerService = new BLL.Services.PrivatCustomerService(CustRepo);

            //Act
            var Customer = customerService.GetCustomerById(1);

            //Assert
            Assert.IsNotNull(Customer);
        }

        [TestMethod]
        public void UpdateCustomer()
        {
            //Arrange
            ABS.Interfaces.RePo.ICustomerRePo CustRepo = new RePo.MockRePo.CustomerMockRePo();
            ABS.Interfaces.Services.ICustomerService customerService = new BLL.Services.PrivatCustomerService(CustRepo);
            
            var selectedID = 1;
            ABS.Interfaces.Models.ICustomerModel Customer = customerService.GetCustomerById(selectedID);
            string nameBeforeChange = Customer.FirstName + " " + Customer.LastName;

            //Act
            var updatedCustomer = customerService.UpdateCustomer(selectedID, "test", "test", "test", "test");
            ABS.Interfaces.Models.ICustomerModel result = customerService.GetCustomerById(selectedID);
            string nameAfterChange = result.FirstName + " " + result.LastName;

            //Assert
            Assert.AreNotSame(nameBeforeChange, nameAfterChange);
        }
    }
}