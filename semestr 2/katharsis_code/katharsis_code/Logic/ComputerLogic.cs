using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Office.CustomUI;

namespace katharsis_code.Logic
{
    public class ComputerLogic
    {
        public static void AddComputer(string InvNum, Employee employee, 
            Component CPU, Component Motherboard, Component HDD)
        {
            try
            {
                Context c = new Context();
                Computer computer = new Computer();
                computer.Inventory_Number = InvNum;
                computer.ComputerStatus = ComputerStatus.stable;
                //computer.Employee = c.Employees.Find(employee.Id);
                computer.Employee = c.Employees.FirstOrDefault(e => e.Id == employee.Id);

                var query = c.Components.Include("Manufacturer").Include("Computer").AsQueryable();
                Component new_cpu = query.Where(comp => comp.Id == CPU.Id).FirstOrDefault();
                Component new_mb = query.Where(comp => comp.Id == Motherboard.Id).FirstOrDefault();
                Component new_hdd = query.Where(comp => comp.Id == HDD.Id).FirstOrDefault();

                if (new_cpu.Computer == null && new_mb.Computer == null && new_hdd.Computer == null)   
                {
                    computer.CPU = c.Components.Find(CPU.Id);
                    computer.MotherBoard = c.Components.Find(Motherboard.Id);
                    computer.HDD = c.Components.Find(HDD.Id);
                    computer.CPU.Computer = computer;
                    computer.MotherBoard.Computer = computer;
                    computer.HDD.Computer = computer;
                    c.Computers.Add(computer);
                    c.SaveChanges();
                } else
                {
                    MessageBox.Show("Выбранный(ые) компоненты уже находятся в компьютере");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static Computer GetComputer(int id)
        {
            try
            {
                Context c = new Context();
                return (from Computer in c.Computers
                        where
                        Computer.Id == id
                        select Computer).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public static void EditComputer(int id, string InvNum, ComputerStatus status, Employee employee, 
            Component CPU, Component Motherboard, Component HDD)
        {
            try
            {
                Context c = new Context();
                Computer edit_comp = (from computer in c.Computers.Include("Employee")
                                      where computer.Id == id
                                      select computer).FirstOrDefault();
                edit_comp.Inventory_Number = InvNum;
                edit_comp.ComputerStatus = status;
                edit_comp.Employee = c.Employees.Find(employee.Id);
                //edit_comp.CPU.computer = null;
                //edit_comp.MotherBoard.computer = null;
                //edit_comp.HDD.computer = null;
                edit_comp.CPU = c.Components.Find(CPU.Id);
                edit_comp.CPU.Computer = edit_comp;
                edit_comp.MotherBoard = c.Components.Find(Motherboard.Id);
                edit_comp.MotherBoard.Computer = edit_comp;
                edit_comp.HDD = c.Components.Find(HDD.Id);
                edit_comp.HDD.Computer = edit_comp;
                c.Entry(edit_comp).State = EntityState.Modified;
                c.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void DeleteComputer(int computer_id)
        {
            try
            {
                Context c = new Context();
                Computer del_comp = (from computer in c.Computers.Include("Employee")
                                     where computer.Id == computer_id
                                     select computer).FirstOrDefault();

                c.Entry(del_comp).State = EntityState.Deleted;
                c.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void DecommissionComputer(int computer_id)
        {
            try
            {
                Context c = new Context();
                Computer del_comp = (from computer in c.Computers.Include("Employee")
                                     where computer.Id == computer_id
                                     select computer).FirstOrDefault();
     
                del_comp.ComputerStatus = ComputerStatus.decommissioned;
                del_comp.WriteOffReport = c.WriteOffReports.ToList().Last();
                c.Entry(del_comp).State = EntityState.Modified;
                c.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}