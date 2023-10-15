using ABS.Interfaces.Models;
using ABS.Interfaces.Services;
using Microsoft.EntityFrameworkCore.Infrastructure;
using RePo.ModelsRePo;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AllInOne
{
    public partial class Form1 : Form
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
        public Form1(ABS.Interfaces.Services.ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
        }

        public void UpdateDataGridView()
        {
            BindingList<ABS.Interfaces.Models.ICustomerModel> customerModels = new BindingList<ICustomerModel>(_customers);
            dataGridView1.DataSource = customerModels;
        }

        /// <summary>
        /// Click event there add a customer. the metode validate the imput from UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_AddCustomer_Click(object sender, EventArgs e)
        {
            // Valider input
            if (string.IsNullOrEmpty(TB_FirstName.Text) || string.IsNullOrEmpty(TB_LastName.Text) || string.IsNullOrEmpty(TB_PhoneNr.Text) || string.IsNullOrEmpty(TB_Mail.Text))
            {
                MessageBox.Show("Alle felter skal udfyldes.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Valider telefonnummer format
            if (!IsValidPhoneNumber(TB_PhoneNr.Text))
            {
                MessageBox.Show("Ugyldigt telefonnummer format.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Valider e-mail format
            if (!IsValidEmail(TB_Mail.Text))
            {
                MessageBox.Show("Ugyldigt e-mail format.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Fortsæt med at tilføje kunden
            bool success = _customerService.AddCustomer(TB_FirstName.Text, TB_LastName.Text, TB_PhoneNr.Text, TB_Mail.Text);
            // Tjek om oprettelsen var vellykket
            if (success)
            {
                MessageBox.Show("Kunden blev oprettet succesfuldt.", "Gennemført", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Der opstod en fejl under oprettelsen af kunden.", "Gennemført", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            Form1_Load(sender, e);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            _customers = _customerService.GetAllCustomers();

            foreach (ICustomerModel customer in _customers)
            {
                LB_INFO.Items.Add(customer.FirstName + " "
                    + customer.LastName + " "
                    + customer.Email + " "
                    + customer.Id + " "
                    + customer.Phonenumber);
            }
            UpdateDataGridView();
        }

        private void LB_INFO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LB_INFO.SelectedItems.Count > 0)
            {
                ShowCustomerdetails((ICustomerModel)LB_INFO.SelectedItems[0]);
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ShowCustomerdetails((ICustomerModel)dataGridView1.SelectedRows[0].DataBoundItem);
            }
        }

        private void ShowCustomerdetails(ICustomerModel customer)
        {
            TB_id.Text = customer.Id.ToString();
            TB_FirstName.Text = customer.FirstName;
            TB_LastName.Text = customer.LastName;
            TB_PhoneNr.Text = customer.Phonenumber;
            TB_Mail.Text = customer.Email;

        }
        /// <summary>
        /// find a customer by ID and validate the input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_ShowOneCustomer_Click(object sender, EventArgs e)
        {
            // Valider ID
            if (!int.TryParse(TB_id.Text, out int id) || id <= 0)
            {

                MessageBox.Show("Indtast et gyldig ID.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hent og vis kundeoplysninger
            var Customer = _customerService.GetCustomerById(id);
            if (Customer != null)
            {
                TB_FirstName.Text = Customer.FirstName;
                TB_LastName.Text = Customer.LastName;
                TB_Mail.Text = Customer.Email;
                TB_PhoneNr.Text = Customer.Phonenumber;
            }
            else
            {
                MessageBox.Show("Ingen kunde fundet med det angivne ID.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void BTN_ShowAllCustomer_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void BTN_UpdateCustome_Click(object sender, EventArgs e)
        {
            // Valider input
            if (string.IsNullOrEmpty(TB_FirstName.Text) || string.IsNullOrEmpty(TB_LastName.Text) || string.IsNullOrEmpty(TB_PhoneNr.Text) || string.IsNullOrEmpty(TB_Mail.Text))
            {
                MessageBox.Show("Alle felter skal udfyldes.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Valider telefonnummer format
            if (!IsValidPhoneNumber(TB_PhoneNr.Text))
            {
               MessageBox.Show("Ugyldigt telefonnummer format.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Valider e-mail format
            if (!IsValidEmail(TB_Mail.Text))
            {
                MessageBox.Show("Ugyldigt e-mail format.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                _customerService.UpdateCustomer(int.Parse(TB_id.Text), TB_FirstName.Text, TB_LastName.Text, TB_Mail.Text, TB_PhoneNr.Text);
            Form1_Load(sender, e);
        }

        private void BTN_DeletedCustome_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Vil du slette Kunde?", "Advarsel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (answer == DialogResult.Yes)
            {
                _customerService.DeleteCustomer(int.Parse(TB_id.Text));
                Form1_Load(sender, e);
            }
            else
            {

            }
        }
    }
}