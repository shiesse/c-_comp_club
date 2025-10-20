using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katharsis_code
{
    public enum ComponentType { CPU, motherboard, HDD}
    public class Component
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ComponentType ComponentType { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Computer Computer { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
