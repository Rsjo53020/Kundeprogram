using AllInOne;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;
using Microsoft.Extensions.Hosting;
using ABS.Interfaces.Services;
using ABS.Interfaces.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using RePo.ModelsRePo;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace GUI
{
    public partial class login : Form
    {
        public static IServiceProvider? ServiceProvider { get; private set; }
        ABS.Interfaces.Services.ICustomerService customerService;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<Form1>();
            // andre tjenester
        }

        public login()
        {
            InitializeComponent();
        }


        private void bt_LogIn_Click(object sender, EventArgs e)
        {
            if (tb_UserName.Text == "Demo" && tb_password.Text == "Demo123")
            {
                var host = CreateHostBuilder().Build();
                ServiceProvider = host.Services;

                Application.Run(ServiceProvider.GetRequiredService<Form1>());

                this.Hide(); // Hide the login form

            }

            else
            {
                MessageBox.Show("The user name or password is incorrect. Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_UserName.Clear();
                tb_password.Clear();
                tb_UserName.Focus();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            tb_UserName.Clear();
            tb_password.Clear();
            tb_UserName.Focus();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        static IHostBuilder CreateHostBuilder()
        {

            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<ABS.Interfaces.Services.ICustomerService, BLL.Services.PrivatCustomerService>(); // Replace with actual implementation
                    services.AddTransient<ABS.Interfaces.RePo.ICustomerRePo, RePo.DBRePo.SqlRePo>();
                    services.AddTransient<ABS.Interfaces.Models.IAdressModel, RePo.ModelsRePo.Adress>();
                    services.AddTransient<ABS.Interfaces.Models.ICustomerModel, RePo.ModelsRePo.Customer>();
                    services.AddTransient<login>();
                });
        }
    }
}
