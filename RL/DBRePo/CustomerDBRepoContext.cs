using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace RePo.DBRePo
{

    public class CustomerDBRepoContext : DbContext 
    {
        
        public DbSet<ModelsRePo.Customer> Customers { get; set; } = null!;
        public DbSet<ModelsRePo.Adress> Adresses { get; set; } = null!;

        //man må ikke lave en constructor 

        //public CustomerDBRepoContext()
        //{
        //    connPath = ConfigurationManager.ConnectionStrings["default"].ToString();
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{ // kan ikke finde ud af at gemme strengen væk

        //    var connString = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        //    IConfiguration config = connString.Build();

        //    string connectionString = config.GetConnectionString("connString");

        //    //optionsBuilder.UseSqlServer("Data Source=mssql12.unoeuro.com;Initial Catalog=aleeex_dk_db_database;Persist Security Info=True;User ID=aleeex_dk;Password=Ghtbd2R6wkxa3Efmycg9;TrustServerCertificate=True;");
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = connString.Build();

            string connectionString = config.GetConnectionString("Default");

            optionsBuilder.UseSqlServer(connectionString);
        }


        //add-migration sigendeting

        //update-database
    }
}
