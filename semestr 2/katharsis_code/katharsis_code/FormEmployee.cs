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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
            dataGridEmployeeInit();
            InitializeComboBoxData();
        }
        private void InitializeComboBoxData()
        {
            Dictionary<string, string> employeeStatuses = new Dictionary<string, string>
            {
                {"all", "Все"},
                { "working", "Работает" },
                { "on_vacation", "Отпуск" },
                { "on_sick_leave", "На больничном" }
            };
            comboBoxStatus.DataSource = new BindingSource(employeeStatuses, null);
            comboBoxStatus.DisplayMember = "Value";
            comboBoxStatus.ValueMember = "Key";

            Dictionary<string, string> positions = new Dictionary<string, string>
            {
                {"all", "Все"},
                { "system_administrator", "Системный администратор" },
                { "worker", "Работник" }
            };
            comboBoxPosition.DataSource = new BindingSource(positions, null);
            comboBoxPosition.DisplayMember = "Value";
            comboBoxPosition.ValueMember = "Key";

            using (Context c = new Context())
            {
                var departments = c.Departments.ToList();
                departments.Insert(0, new Department { Id = -1, Name = "Все" });
                comboBoxDepartment.DataSource = departments;
                comboBoxDepartment.DisplayMember = "Name";
                comboBoxDepartment.ValueMember = "Id";
            }
        }



        private void dataGridEmployeeInit()
        {
            using (Context c = new Context())
            {
                var employees = c.Employees.Include("Department").AsQueryable();

                if (!string.IsNullOrWhiteSpace(textBoxSearchFullName.Text))
                {
                    string searchName = textBoxSearchFullName.Text.ToLower();
                    employees = employees.Where(e => e.Full_name.ToLower().Contains(searchName));
                }

                if (comboBoxPosition.SelectedIndex > -1 && comboBoxPosition.SelectedItem != null)
                {
                    var selectedPosition = ((KeyValuePair<string, string>)comboBoxPosition.SelectedItem).Key;
                    if (selectedPosition != "all") // Проверка выбранного значения
                    {
                        employees = employees.Where(e => e.EmployeePosition.ToString() == selectedPosition);
                    }
                }

                if (comboBoxStatus.SelectedIndex > -1 && comboBoxStatus.SelectedItem != null)
                {
                    var selectedStatus = ((KeyValuePair<string, string>)comboBoxStatus.SelectedItem).Key;
                    if (selectedStatus != "all") // Проверка выбранного значения
                    {
                        employees = employees.Where(e => e.EmployeeStatus.ToString() == selectedStatus);
                    }
                }

                if (comboBoxDepartment.SelectedIndex > -1 && comboBoxDepartment.SelectedItem != null)
                {
                    if (comboBoxDepartment.SelectedValue is int selectedDepartmentId && selectedDepartmentId != -1)
                    {
                        employees = employees.Where(e => e.Department.Id == selectedDepartmentId);
                    }
                }

                dataGridViewEmployee.DataSource = employees.ToList();
                dataGridViewEmployee.Columns[0].HeaderText = "ID";
                dataGridViewEmployee.Columns[1].HeaderText = "ФИО";
                dataGridViewEmployee.Columns[2].HeaderText = "Должность";
                dataGridViewEmployee.Columns[3].HeaderText = "Статус";
                dataGridViewEmployee.Columns[4].HeaderText = "Отдел";
                dataGridViewEmployee.Columns[5].Visible = false;
                dataGridViewEmployee.Columns[6].Visible = false;

                comboBoxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxPosition.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }





        private void FiltersChanged(object sender, EventArgs e)
        {
            dataGridEmployeeInit();
        }


        private void buttonCloseFormEmployee_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            FormAddEmployee formAddEmployee = new FormAddEmployee();
            formAddEmployee.ShowDialog();
            dataGridEmployeeInit();
        }

        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            int r_index = dataGridViewEmployee.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridViewEmployee.Rows[r_index].Cells[0].Value);

            Employee employee = EmployeeLogic.GetEmployee(id);
            if(employee != null)
            {
                FormEditEmployee formEditEmployee = new FormEditEmployee(employee);
                formEditEmployee.ShowDialog();
                dataGridEmployeeInit();
            }
        }

        private void buttonFormEmployeeDelete_Click(object sender, EventArgs e)
        {
            int r_index = dataGridViewEmployee.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridViewEmployee.Rows[r_index].Cells[0].Value);

            Employee employee = EmployeeLogic.GetEmployee(id);
            if (employee != null)
            {
                DialogResult result = MessageBox.Show(
                   "Вы точно хотите удалить сотрудника?",
                   "Окно подтверждения",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {
                    EmployeeLogic.DeleteEmployee(id);
                    dataGridEmployeeInit();
                }
                this.TopMost = true;
            }
        }
    }
}