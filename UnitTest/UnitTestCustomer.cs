using RePo.MockRePo;
using System.Net.NetworkInformation;

namespace UnitTest
{
    [TestClass]
    public class UnitTestCustomer
    {
        [TestMethod]
        public async void AddCustomer()
        {
            //Arrange
            ABS.Interfaces.RePo.ICustomerRePo CustRepo = new RePo.MockRePo.CustomerMockRePo();
            ABS.Interfaces.Services.ICustomerService customerService = new BLL.Services.PrivatCustomerService(CustRepo);
            List<BLL.Models.CustomerModel> list = new List<BLL.Models.CustomerModel>();
           

            //Act
            var result = customerService.AddCustomerAsync("Test", "Test", "Test", "Test");

            var CustomerList = await customerService.GetAllCustomersAsync();
            var lastCustomer = CustomerList.LastOrDefault();

            //Assert
            
            Assert.AreSame(lastCustomer.FirstName, "Test");
        }

        [TestMethod]
        public async void DeleteCustomer()
        {
            //Arrange
            ABS.Interfaces.RePo.ICustomerRePo CustRepo = new RePo.MockRePo.CustomerMockRePo();
            ABS.Interfaces.Services.ICustomerService customerService = new BLL.Services.PrivatCustomerService(CustRepo);
            var TestID = 1;


            //Act
            var result = customerService.DeleteCustomerAsync(TestID);

            ABS.Interfaces.Models.ICustomerModel customer = await customerService.GetCustomerByIdAsync(TestID);

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
            var List = customerService.GetAllCustomersAsync();

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
            var Customer = customerService.GetCustomerByIdAsync(1);

            //Assert
            Assert.IsNotNull(Customer);
        }

        [TestMethod]
        public async void UpdateCustomer()
        {
            //Arrange
            ABS.Interfaces.RePo.ICustomerRePo CustRepo = new RePo.MockRePo.CustomerMockRePo();
            ABS.Interfaces.Services.ICustomerService customerService = new BLL.Services.PrivatCustomerService(CustRepo);
            
            var selectedID = 1;
            ABS.Interfaces.Models.ICustomerModel Customer = await customerService.GetCustomerByIdAsync(selectedID);
            string nameBeforeChange = Customer.FirstName + " " + Customer.LastName;

            //Act
            var updatedCustomer = customerService.UpdateCustomerAsync(selectedID, "test", "test", "test", "test");
            ABS.Interfaces.Models.ICustomerModel result = await customerService.GetCustomerByIdAsync(selectedID);
            string nameAfterChange = result.FirstName + " " + result.LastName;

            //Assert
            Assert.AreNotSame(nameBeforeChange, nameAfterChange);
        }
    }
}