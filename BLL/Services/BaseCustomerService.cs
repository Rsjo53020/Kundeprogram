using ABS.Interfaces.Models;
using ABS.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL.Services
{
    public abstract class BaseCustomerService : ICustomerService
    {
        private readonly ABS.Interfaces.RePo.ICustomerRePo _customerRePo;
        /// <summary>
        /// helpMetode to validate phone number format
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // kontrollere om telefonnummeret følger det ønskede mønster
            string pattern = @"^\d{1,8}$"; // Eksempel: 10203040

            return Regex.IsMatch(phoneNumber, pattern); //A Regular Expression (or Regex)

            
        }

        /// <summary>
        /// helpMetode to validate the e-mail format
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private bool IsValidEmail(string email)
        {
            // kontroller om e-mailadressen følger det ønskede mønster
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            //var resultat = pattern.Contains("@");


            if (pattern.Contains('@'))
            {
                return Regex.IsMatch(email, pattern);
            }
            else
            {
                throw new ArgumentException("Ugyldigt e-mail - mangler et @.");
            }
        }

               
        /// <summary>
        /// constructor for class
        /// </summary>
        /// <param name="customerRePo"></param>
        public BaseCustomerService(ABS.Interfaces.RePo.ICustomerRePo customerRePo)
        {
            _customerRePo = customerRePo;
        }

        /// <summary>
        /// Create a customer and  ensure that the inputs are validated
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="PhoneNr"></param>
        /// <param name="Mail"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public bool AddCustomer(string FirstName, string LastName, string PhoneNr, string Mail)
        {
            // Valider input
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(PhoneNr) || string.IsNullOrEmpty(Mail))
            {
                throw new ArgumentException("Alle felter skal udfyldes.");
            }

            // Valider telefonnummer format
            if (!IsValidPhoneNumber(PhoneNr))
            {
                throw new ArgumentException("Ugyldigt telefonnummer format.");
            }

            // Valider e-mail format
            if (!IsValidEmail(Mail))
            {
                throw new ArgumentException("Ugyldigt e-mail format.");
            }

            return _customerRePo.CreateCustomer(FirstName, LastName, PhoneNr, Mail);

            //Laver metoden om til en string ........

            //// Valider input
            //if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(PhoneNr) || string.IsNullOrEmpty(Mail))
            //{
            //    return "Alle felter skal udfyldes.";
            //}

            //// Valider telefonnummer format
            //if (!IsValidPhoneNumber(PhoneNr))
            //{
            //    return "Ugyldigt telefonnummer format.";
            //}

            //// Valider e-mail format
            //if (!IsValidEmail(Mail))
            //{
            //    return "Ugyldigt e-mail format.";
            //}

            //// Forsøg at oprette kunden
            //bool success = _customerRePo.CreateCustomer(FirstName, LastName, PhoneNr, Mail);

            //// Tjek om oprettelsen var vellykket
            //if (success)
            //{
            //    return "Kunden blev oprettet succesfuldt.";
            //}
            //else
            //{
            //    return "Der opstod en fejl under oprettelsen af kunden.";
            //}
        }



        public bool DeleteCustomer(int id)
        {
            return _customerRePo.DeleteCustomer(id);
        }

        public List<ICustomerModel> GetAllCustomers()
        {
            return _customerRePo.GetAllCustomers();
        }

        /// <summary>
        /// Find a customer by ID og validate the int input
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public ICustomerModel GetCustomerById(int id)
        {
            // Valider input


            if (id <= 0)
            {
                throw new ArgumentException("ID skal være større end nul.");
            }

            return _customerRePo.GetCustomerById(id);
        }
        /// <summary>
        /// Update a customer and validate the new inputs
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="PhoneNr"></param>
        /// <param name="Mail"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public bool UpdateCustomer(int Id, string FirstName, string LastName, string PhoneNr, string Mail)
        {
            // Valider input
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(PhoneNr) || string.IsNullOrEmpty(Mail))
            {
                throw new ArgumentException("Alle felter skal udfyldes.");
            }
            // Valider telefonnummer format
            if (!IsValidPhoneNumber(PhoneNr))
            {
                throw new ArgumentException("Ugyldigt telefonnummer format.");
            }

            // Valider e-mail format
            if (!IsValidEmail(Mail))
            {
                throw new ArgumentException("Ugyldigt e-mail format.");
            }


            return _customerRePo.UpdateCustomer(Id, FirstName, LastName, PhoneNr, Mail);
        }
    }
}
