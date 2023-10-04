using ABS.Interfaces.Models;
using System.Windows.Forms;

namespace AllInOne
{
    public partial class Form1 : Form
    {
        private readonly ABS.Interfaces.Services.ICustomerService _customerService;
        public Form1(ABS.Interfaces.Services.ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
        }



        private void BTN_AddCustomer_Click(object sender, EventArgs e)
        {
            customer.AddCustomer(Convert.ToInt32(TB_id.Text), TB_FirstName.Text, TB_LastName.Text, TB_PhoneNr.Text, TB_Mail.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LB_INFO = _customerService.GetAllCustomers();
        }

        private void LB_INFO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LB_INFO.SelectedItems.Count > 0)
            {
                ShowCustomerdetails((ICustomerModel)LB_INFO.SelectedItems[0]);
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
    }
}