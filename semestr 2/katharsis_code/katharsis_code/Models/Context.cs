using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace katharsis_code
{
    public class Context : DbContext
    {
        public Context(): base("KatharsisConn") { }
        public DbSet<PeripheralDevice> PeripheralDevices { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<WriteOffReport> WriteOffReports { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
