using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace katharsis_code.Logic
{
    public class ManufacturerLogic
    {
        public static void AddManufacturer(string name)
        {
            try
            {
                Context c = new Context();
                Manufacturer manufacturer = new Manufacturer();
                manufacturer.Name = name;
                c.Manufacturers.Add(manufacturer);
                c.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static Manufacturer GetManufacturer(int id)
        {
            try
            {
                Context c = new Context();
                return (from manufacturer in c.Manufacturers 
                        where manufacturer.Id == id 
                        select manufacturer).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public static void EditManufacturer(int manufacturer_id, string name)
        {
            try
            {
                Context c = new Context();
                Manufacturer edit_manufacturer = (from manufacturer in c.Manufacturers
                                                  where manufacturer.Id == manufacturer_id
                                                  select manufacturer).FirstOrDefault();
                edit_manufacturer.Name = name;
                c.Entry(edit_manufacturer).State = EntityState.Modified;
                c.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void DeleteManufacturer(int manufacturer_id)
        {
            try
            {
                Context c = new Context();
                Manufacturer del_mnf = (from manufacturer in c.Manufacturers
                                        where manufacturer.Id == manufacturer_id
                                        select manufacturer).First();
                c.Entry(del_mnf).State = EntityState.Deleted;
                c.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }
    }
}
