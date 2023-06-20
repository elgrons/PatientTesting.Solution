using Microsoft.EntityFrameworkCore;  
using PatientTesting.Models;  

namespace PatientTesting.DataAccess  
{  
    public class PostgreSqlContext: DbContext  
    {  
        public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options) : base(options)  
        {  
        }  

        public DbSet<TestingPatients> testingpatients { get; set; }  

        protected override void OnModelCreating(ModelBuilder builder)  
        {  
            base.OnModelCreating(builder);  
        }  

        public override int SaveChanges()  
        {  
            ChangeTracker.DetectChanges();  
            return base.SaveChanges();  
        }  
    }  
}  