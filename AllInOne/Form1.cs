using ABS.Interfaces.Models;
using ABS.Interfaces.Services;
using RePo.ModelsRePo;
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
            _customerService.AddCustomer(TB_FirstName.Text, TB_LastName.Text, TB_PhoneNr.Text, TB_Mail.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<ICustomerModel> customers = _customerService.GetAllCustomers();

            foreach (ICustomerModel customer in customers)
            {
                LB_INFO.Items.Add(customer.FirstName + " "
                    + customer.LastName + " "
                    + customer.Email + " "
                    + customer.Id + " "
                    + customer.Phonenumber);
            }

            dataGridView1.DataSource = _customerService.GetAllCustomers();
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

        private void BTN_ShowOneCustomer_Click(object sender, EventArgs e)
        {
            _customerService.GetCustomerById(int.Parse(TB_id.Text));

        }

        private void BTN_ShowAllCustomer_Click(object sender, EventArgs e)
        {
            _customerService.GetAllCustomers();

        }

        private void BTN_UpdateCustome_Click(object sender, EventArgs e)
        {

            _customerService.UpdateCustomer(int.Parse(TB_id.Text), TB_id.Text, TB_LastName.Text, TB_Mail.Text, TB_PhoneNr.Text);

            _customerService.GetAllCustomers();


        }
    }
}