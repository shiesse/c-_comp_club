using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace katharsis_code.Logic
{
    public class DepartmentLogic
    {
        public static void AddDepartment(string name)
        {
            try
            {
                Context c = new Context();
                Department d = new Department();
                d.Name = name;
                c.Departments.Add(d);
                c.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static Department GetDepartment(int id)
        {
            try
            {
                Context c = new Context();
                Department department = (from dep in c.Departments
                                         where dep.Id == id
                                         select dep).FirstOrDefault();
                return department;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public static void EditDepartment(int department_id, string name)
        {
            try
            {
                Context c = new Context();
                Department edit_department = (from dep in c.Departments
                                              where dep.Id == department_id
                                              select dep).FirstOrDefault();
                edit_department.Name = name;
                c.Entry(edit_department).State = EntityState.Modified;
                c.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void DeleteDepartment(int department_id)
        {
            try
            {
                Context c = new Context();
                Department del_dprt = (from dep in c.Departments
                                       where dep.Id == department_id
                                       select dep).FirstOrDefault();
                c.Entry(del_dprt).State = EntityState.Deleted;
                c.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
