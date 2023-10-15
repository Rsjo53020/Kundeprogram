using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace RePo.DBRePo
{

    public class CustomerDBRepoContext : DbContext 
    {
        
        public DbSet<ModelsRePo.Customer> Customers { get; set; } = null!;
        public DbSet<ModelsRePo.Adress> Adresses { get; set; } = null!;

        //public CustomerDBRepoContext()
        //{
        //    connPath = ConfigurationManager.ConnectionStrings["default"].ToString();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=mssql12.unoeuro.com;Initial Catalog=aleeex_dk_db_database;Persist Security Info=True;User ID=aleeex_dk;Password=Ghtbd2R6wkxa3Efmycg9;TrustServerCertificate=True;");
        }



        //add-migration sigendeting

        //update-database
    }
}
