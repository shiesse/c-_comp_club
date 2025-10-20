using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace katharsis_code
{
    public enum PeripheralType { monitor, printer, scaner, plotter, router }
    public enum PeripheralStatus { stable, on_repair, decommissioned}
    public class PeripheralDevice
    {
        public int Id { get; set; }
        public string Inventory_Number { get; set; }
        public PeripheralType PeripheralType { get; set; }
        public PeripheralStatus PeripheralStatus { get; set;}
        public Manufacturer Manufacturer { get; set; }
        public Employee Employee { get; set; }
        public int? WriteOffReportId { get; set; }
        public WriteOffReport WriteOffReport { get; set; }
    }
}
