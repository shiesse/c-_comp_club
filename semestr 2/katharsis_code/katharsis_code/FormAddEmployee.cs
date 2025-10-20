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
    public partial class FormAddEmployee : Form
    {
        public FormAddEmployee()
        {
            InitializeComponent();
            InitAddPeripheralForm();
        }

        private void buttonCloseFormAddEmployee_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            EmployeeLogic.AddEmployee(textBoxFIO.Text, 
                (EmployeePosition)comboBoxEmployeePosition.SelectedIndex, 
                EmployeeStatus.working,
                Convert.ToInt32(comboBoxDepartment.SelectedValue));
            Close();
        }

        private void InitAddPeripheralForm()
        {
            Dictionary<string, string> positions = new Dictionary<string, string>();
            positions.Add("system_administrator", "Системный администратор");
            positions.Add("worker", "Работник");
            comboBoxEmployeePosition.DataSource = new BindingSource(positions, null);
            comboBoxEmployeePosition.DisplayMember = "Value";
            comboBoxEmployeePosition.ValueMember = "Key";


            Context c1 = new Context();
            comboBoxDepartment.DataSource = c1.Departments.ToList();
            comboBoxDepartment.DisplayMember = "Name";
            comboBoxDepartment.ValueMember = "Id";

            comboBoxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmployeePosition.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
