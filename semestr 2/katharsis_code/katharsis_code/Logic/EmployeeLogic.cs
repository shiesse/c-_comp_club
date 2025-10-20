using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace katharsis_code.Logic
{
    public class EmployeeLogic
    {
        public static void AddEmployee(string full_name, EmployeePosition
            employeePosition, EmployeeStatus employeeStatus, int department_id)
        {
            try
            {
                Context c = new Context();
                Department department = c.Departments.Find(department_id);
                Employee employee = new Employee();
                employee.Full_name = full_name;
                employee.EmployeePosition = employeePosition;
                employee.EmployeeStatus = employeeStatus;
                employee.Department = department;
                c.Employees.Add(employee);

                c.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static Employee GetEmployee(int id)
        {
            try
            {
                Context c = new Context();
                return (from Employee in c.Employees.Include("Department") where 
                        Employee.Id == id select Employee).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public static void EditEmployee(int employee_id, 
            string full_name, 
            EmployeePosition employeePosition,
            EmployeeStatus employeeStatus, 
            int department_id)
        {
            try
            {
                Context c = new Context();
                Employee edit_e = (from employee in c.Employees.Include("Department")
                                   where employee.Id == employee_id
                                   select employee).FirstOrDefault();
                Department d = c.Departments.Find(department_id);
                edit_e.EmployeePosition = employeePosition;
                edit_e.EmployeeStatus = employeeStatus;
                edit_e.Full_name = full_name;
                edit_e.Department = d;
                c.Entry(edit_e).State = EntityState.Modified;
                c.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void DeleteEmployee(int employee_id
            )
        {

            
            try
            {
                Context c = new Context();
                var employer = new Employee { Id = employee_id };
                c.Entry(employer).State = EntityState.Deleted;
                c.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
