using katharsis_code;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace katharsis_code.Logic
{
    public class ComponentLogic
    {
        public static void AddComponent(string name, ComponentType componentType,
                                    int manufacturer_id)
        {
            try
            {
                Context c = new Context();
                Manufacturer manufacturer = c.Manufacturers.Find(manufacturer_id);
                Component component = new Component();
                component.Name = name;
                component.ComponentType = componentType;
                component.Manufacturer = manufacturer;
                c.Components.Add(component);
                c.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static Component GetComponent(int id)
        {
            try
            {
                Context c = new Context();
                return (from component in c.Components.Include("Manufacturer").Include("Computer") where component.Id == id select component).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public static void EditComponent(int component_id, string name, ComponentType componentType,
                                    int manufacturer_id)
        {
            try
            {
                Context c = new Context();
                Component edit_cmp = (from component in c.Components.Include("Manufacturer").Include("Computer")
                                            where component.Id == component_id
                                            select component).FirstOrDefault();
                Manufacturer m = c.Manufacturers.Find(manufacturer_id);
                edit_cmp.Name = name;
                edit_cmp.ComponentType = componentType;
                edit_cmp.Manufacturer = m;
                c.Entry(edit_cmp).State = EntityState.Modified;
                c.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void DeleteComponent(int component_id)
        {
            try
            {
                Context c = new Context();
                Component del_cmp = (from component in c.Components.Include("Manufacturer").Include("Computer")
                                     where component.Id == component_id
                                     select component).FirstOrDefault();
                if (del_cmp.Computer == null)
                {
                    c.Entry(del_cmp).State = EntityState.Deleted;
                    c.SaveChanges();
                    MessageBox.Show("Компонента удалена!");
                } else
                {
                    Computer comp = c.Computers.Find(del_cmp.Computer.Id);
                    if (comp.ComputerStatus == ComputerStatus.decommissioned)
                    {
                        c.Entry(del_cmp).State = EntityState.Deleted;
                        c.SaveChanges();
                        MessageBox.Show("Компонента удалена!(Она стояла в списанном компьютере)");
                    } else
                    {
                        MessageBox.Show("Используется в рабочем компьютере");
                    }
                }     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}