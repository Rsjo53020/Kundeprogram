using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace RePo.DBRePo
{

    public class CustomerDBRepoContext : DbContext 
    {
        string connPath;
        
        public DbSet<ModelsRePo.Customer> Customers { get; set; } = null!;
        public DbSet<ModelsRePo.Adress> Adresses { get; set; } = null!;

        public CustomerDBRepoContext()
        {
            connPath = ConfigurationManager.ConnectionStrings["default"].ToString();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connPath);

            }
        }



        //add-migration sigendeting

        //update-databasen
    }
}
