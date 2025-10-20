using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katharsis_code
{
    public enum EmployeePosition { system_administrator, worker}
    public enum EmployeeStatus { working, on_vacation, on_sick_leave}
    public class Employee
    {
        public int Id { get; set; }
        public string Full_name {  get; set; }
        public EmployeePosition EmployeePosition { get; set; }
        public EmployeeStatus EmployeeStatus { get; set;}
        public Department Department { get; set; }
        public ICollection<Computer> Computer { get; set; }
        public ICollection<PeripheralDevice> PeripheralDevices { get; set; }
        public override string ToString()
        {
            return this.Full_name;
        }
    }
}
