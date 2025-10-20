using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katharsis_code
{
    public enum TechType { computer, peripheralDevice}
    public class WriteOffReport
    {
        public int Id { get; set; }
        public DateTime Date {  get; set; }
        public TechType TechType { get; set; }
        public string Inventory_number { get; set; }
        public string ResponsiblePersons{ get; set; }
    }
}
