using katharsis_code.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace katharsis_code
{
    public partial class FormEditEmployee : Form
    {
        private int employeeId;
        public FormEditEmployee(Employee employee)
        {
            InitializeComponent();
            employeeId = employee.Id;
            InitEditEmployeeForm();
            textBoxEditEmployeeFIO.Text = employee.Full_name;
            if (employee.Department != null) comboBoxEditEmployeeDepartment.SelectedValue = employee.Department.Id;
            comboBoxEditEmployeePosition.SelectedIndex = Convert.ToInt32(employee.EmployeePosition);
            comboBoxEditEmployeeStatus.SelectedIndex = Convert.ToInt32(employee.EmployeeStatus);
        }
        public void InitEditEmployeeForm()
        {
            Dictionary<string, string> employeeStatuses = new Dictionary<string, string>();
            employeeStatuses.Add("working", "Работает");
            employeeStatuses.Add("on_vacation", "Отпуск");
            employeeStatuses.Add("on_sick_leave", "На больничном");
            comboBoxEditEmployeeStatus.DataSource = new BindingSource(employeeStatuses, null);
            comboBoxEditEmployeeStatus.DisplayMember = "Value";
            comboBoxEditEmployeeStatus.ValueMember = "Key";



            Dictionary<string, string> positions = new Dictionary<string, string>();
            positions.Add("system_administrator", "Системный администратор");
            positions.Add("worker", "Работник");
            comboBoxEditEmployeePosition.DataSource = new BindingSource(positions, null);
            comboBoxEditEmployeePosition.DisplayMember = "Value";
            comboBoxEditEmployeePosition.ValueMember = "Key";

            Context c1 = new Context();
            comboBoxEditEmployeeDepartment.DataSource = c1.Departments.ToList();
            comboBoxEditEmployeeDepartment.DisplayMember = "Name";
            comboBoxEditEmployeeDepartment.ValueMember = "Id";

            comboBoxEditEmployeeDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEditEmployeePosition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEditEmployeeStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonEditEmployeeExit_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void buttonEditEmployeeSave_Click(object sender, EventArgs e)
        {
            EmployeeLogic.EditEmployee(employeeId,
                textBoxEditEmployeeFIO.Text,
                (EmployeePosition)comboBoxEditEmployeePosition.SelectedIndex,
                (EmployeeStatus)comboBoxEditEmployeeStatus.SelectedIndex,
                Convert.ToInt32(comboBoxEditEmployeeDepartment.SelectedValue));
            Close();
        }
    }
}
