using ABS.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllInOne;
using ABS.Interfaces.Services;
using Microsoft.EntityFrameworkCore.Infrastructure;
using RePo.ModelsRePo;
using System.Windows.Forms;

namespace GUI
{
    public partial class Customer :  Form

    {
        private readonly ABS.Interfaces.Services.ICustomerService _customerService;
        List<ABS.Interfaces.Models.ICustomerModel> _customers;

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
                MessageBox.Show("Ugyldigt e-mail - mangler et @.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void ShowCustomerdetails(ICustomerModel customer)
        {
            tb_ID.Text = customer.Id.ToString();
            tb_FirstName.Text = customer.FirstName;
            tb_LastName.Text = customer.LastName;
            tb_PhoneNr.Text = customer.Phonenumber;
            tb_mail.Text = customer.Email;

        }





        public Customer(ABS.Interfaces.Services.ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
        }

        public void UpdateDataGridView()
        {
            BindingList<ABS.Interfaces.Models.ICustomerModel> customerModels = new BindingList<ICustomerModel>(_customers);
            dataGridView1.DataSource = customerModels;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_DeletedCustomer_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Vil du slette Kunde?", "Advarsel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (answer == DialogResult.Yes)
            {
                _customerService.DeleteCustomerAsync(int.Parse(tb_ID.Text));
                Customer_Load(sender, e);
            }
            else
            {

            }
        }

        private void btn_ShowAllCustomer_Click(object sender, EventArgs e)
        {
            Customer_Load(sender, e);
        }

        /// <summary>
        /// Click event there add a customer. the metode validate the imput from UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_AddCustomer_Click(object sender, EventArgs e)
        {

            // Valider input
            if (string.IsNullOrEmpty(tb_FirstName.Text) || string.IsNullOrEmpty(tb_LastName.Text) || string.IsNullOrEmpty(tb_PhoneNr.Text) || string.IsNullOrEmpty(tb_mail.Text))
            {
                MessageBox.Show("Alle felter skal udfyldes.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Valider telefonnummer format
            if (!IsValidPhoneNumber(tb_PhoneNr.Text))
            {
                MessageBox.Show("Ugyldigt telefonnummer format.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Valider e-mail format
            if (!IsValidEmail(tb_mail.Text))
            {
                MessageBox.Show("Ugyldigt e-mail format.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Fortsæt med at tilføje kunden
            bool success = await _customerService.AddCustomerAsync(tb_FirstName.Text, tb_LastName.Text, tb_PhoneNr.Text, tb_mail.Text);
            // Tjek om oprettelsen var vellykket
            if (success)
            {
                MessageBox.Show("Kunden blev oprettet succesfuldt.", "Gennemført", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Der opstod en fejl under oprettelsen af kunden.", "Gennemført", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            Customer_Load(sender, e);
        }

        private async void Customer_Load(object sender, EventArgs e)
        {


            _customers = await _customerService.GetAllCustomersAsync();

            //foreach (ICustomerModel customer in _customers)
            //{
            //    LB_INFO.Items.Add(customer.FirstName + " "
            //        + customer.LastName + " "
            //        + customer.Email + " "
            //        + customer.Id + " "
            //        + customer.Phonenumber);
            //}
            UpdateDataGridView();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ShowCustomerdetails((ICustomerModel)dataGridView1.SelectedRows[0].DataBoundItem);
            }
        }

        /// <summary>
        /// find a customer by ID and validate the input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_ShowOneCustomer_Click(object sender, EventArgs e)
        {
            // Valider ID
            if (!int.TryParse(tb_ID.Text, out int id) || id <= 0)
            {

                MessageBox.Show("Indtast et gyldig ID.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hent og vis kundeoplysninger
            var Customer = await _customerService.GetCustomerByIdAsync(id);
            if (Customer != null)
            {
                tb_FirstName.Text = Customer.FirstName;
                tb_LastName.Text = Customer.LastName;
                tb_mail.Text = Customer.Email;
                tb_PhoneNr.Text = Customer.Phonenumber;
            }
            else
            {
                MessageBox.Show("Ingen kunde fundet med det angivne ID.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_UpdateCustomer_Click(object sender, EventArgs e)
        {
            // Valider input
            if (string.IsNullOrEmpty(tb_FirstName.Text) || string.IsNullOrEmpty(tb_LastName.Text) || string.IsNullOrEmpty(tb_PhoneNr.Text) || string.IsNullOrEmpty(tb_mail.Text))
            {
                MessageBox.Show("Alle felter skal udfyldes.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Valider telefonnummer format
            if (!IsValidPhoneNumber(tb_PhoneNr.Text))
            {
                MessageBox.Show("Ugyldigt telefonnummer format.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Valider e-mail format
            if (!IsValidEmail(tb_mail.Text))
            {
                MessageBox.Show("Ugyldigt e-mail format.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            await _customerService.UpdateCustomerAsync(int.Parse(tb_ID.Text), tb_FirstName.Text, tb_LastName.Text, tb_mail.Text, tb_PhoneNr.Text);
            Customer_Load(sender, e);
        }




    }
}

