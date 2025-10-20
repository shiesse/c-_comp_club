using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace katharsis_code.Logic
{
    public class PeripheralLogic
    {
        public static void AddPeripheral(string inventory_nubmer, PeripheralType peripheralType,
                                         PeripheralStatus peripheralStatus, int manufacturer_id)
        {
            try
            {
                Context c = new Context();
                Manufacturer manufacturer = c.Manufacturers.Find(manufacturer_id);
                PeripheralDevice peripheralDevice = new PeripheralDevice();
                peripheralDevice.Inventory_Number = inventory_nubmer;
                peripheralDevice.PeripheralType = peripheralType;
                peripheralDevice.PeripheralStatus = peripheralStatus;
                peripheralDevice.Manufacturer = manufacturer;
                c.PeripheralDevices.Add(peripheralDevice);
                c.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static PeripheralDevice GetPeripheral(int id)
        {
            try
            {
                Context c = new Context();
                return (from peripheralDevice in c.PeripheralDevices.Include("Manufacturer").Include("Employee") where peripheralDevice.Id == id select peripheralDevice).FirstOrDefault();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public static void EditPeripheral(int peripheral_id, string inventory_nubmer, PeripheralType peripheralType,
                                    PeripheralStatus peripheralStatus, int manufacturer_id,
                                    int employee_id)
        {
            try 
            { 
                Context c = new Context();
                PeripheralDevice edit_pd = (from peripheralDevice in c.PeripheralDevices.Include("Manufacturer").Include("Employee")
                                            where peripheralDevice.Id == peripheral_id
                                            select peripheralDevice).FirstOrDefault();
                Manufacturer m = c.Manufacturers.Find(manufacturer_id);
                Employee e = c.Employees.Find(employee_id);
                edit_pd.Inventory_Number = inventory_nubmer;
                edit_pd.PeripheralType = peripheralType;
                edit_pd.PeripheralStatus = peripheralStatus;
                edit_pd.Manufacturer = m;
                edit_pd.Employee = e;
                c.Entry(edit_pd).State = EntityState.Modified;
                c.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void DeletePeripheral(int peripheral_id)
        {
            try
            {
                Context c = new Context();
                PeripheralDevice delete_pd = (from peripheralDevice in c.PeripheralDevices.Include("Manufacturer").Include("Employee")
                                              where peripheralDevice.Id == peripheral_id
                                              select peripheralDevice).FirstOrDefault();
                c.Entry(delete_pd).State = EntityState.Deleted;
                c.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void DecommissionPeripheral(int peripheral_id)
        {
            try
            {
                Context c = new Context();
                PeripheralDevice decom_pd = (from peripheralDevice in c.PeripheralDevices.Include("Manufacturer").Include("Employee")
                                              where peripheralDevice.Id == peripheral_id
                                              select peripheralDevice).FirstOrDefault();
                decom_pd.PeripheralStatus = PeripheralStatus.decommissioned;
                decom_pd.WriteOffReport = c.WriteOffReports.ToList().Last();
                c.Entry(decom_pd).State = EntityState.Modified;
                c.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
