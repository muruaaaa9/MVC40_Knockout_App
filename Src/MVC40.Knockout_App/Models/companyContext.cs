using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MVC40.Knockout_App.Models.Mapping;

namespace MVC40.Knockout_App.Models
{
    public partial class companyContext : DbContext
    {
        static companyContext()
        {
            Database.SetInitializer<companyContext>(null);
        }

        public companyContext()
            : base("Name=companyContext")
        {
        }

        public DbSet<EmployeeInfo> EmployeeInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeInfoMap());
        }
    }
}
