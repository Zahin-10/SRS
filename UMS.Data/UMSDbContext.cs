using UMS.Entity;
using System.Data.Entity;

namespace UMS.Data
{
    internal class UMSDbContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Authentication> Authentication { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeType> EmployeeType { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<ItemType> ItemType { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<PackageDetails> PackageDetails { get; set; }
        public DbSet<PackageItem> PackageItem { get; set; }
        public DbSet<UserType> UserType { get; set; }
        public DbSet<Promotion> Promotion { get; set; }

        public UMSDbContext()
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}
