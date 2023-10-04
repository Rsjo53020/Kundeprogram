using ABS.Interfaces.Models;

namespace AllInOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_AddCustomer_Click(object sender, EventArgs e)
        {
            ABS.Interfaces.Services.ICustomerService.AddCustomer(Convert.ToInt32(TB_id), TB_FirstName.Text, TB_LastName.Text, TB_PhoneNr.Text, TB_Mail.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}