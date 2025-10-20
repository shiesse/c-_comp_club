using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katharsis_code
{
    public enum ComputerStatus { stable, on_reapair, decommissioned }
    public class Computer
    {
        public int Id { get; set; }
        public string Inventory_Number { get; set; }
        public ComputerStatus ComputerStatus { get; set; }
        public Employee Employee { get; set; }
        public Component CPU { get; set; }
        public Component MotherBoard { get; set; }
        public Component HDD { get; set; }
        public int? WriteOffReportId { get; set; }
        public WriteOffReport WriteOffReport { get; set; }
        //public ICollection<Component> Components { get; set; }
        public override string ToString()
        {
            return this.Inventory_Number;
        }
    }
}
