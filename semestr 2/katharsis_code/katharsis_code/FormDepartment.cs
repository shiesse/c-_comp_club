using katharsis_code.Logic;
using katharsis_code.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace katharsis_code
{
    public partial class FormDepartment : Form
    {
        public FormDepartment()
        {
            InitializeComponent();
            dataGridViewDepartmentInit();
        }
        private void dataGridViewDepartmentInit()
        {
            using (Context c = new Context())
            {
                List<Department> departments;

                if (string.IsNullOrWhiteSpace(textBoxFilter.Text))
                {
                    departments = c.Departments.ToList();
                }
                else
                {
                    string searchText = textBoxFilter.Text.ToLower();
                    departments = c.Departments
                                   .Where(d => d.Name.ToLower().Contains(searchText))
                                   .ToList();
                }

                dataGridViewDepartment.DataSource = departments;
                dataGridViewDepartment.Columns[0].HeaderText = "ID";
                dataGridViewDepartment.Columns[1].HeaderText = "Название";
                dataGridViewDepartment.Columns[2].Visible = false;
            }
        }


        private void buttonCloseDepartment_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddDepartment_Click(object sender, EventArgs e)
        {
            FormAddDepartment formAddDepartment = new FormAddDepartment();
            formAddDepartment.ShowDialog();
            dataGridViewDepartmentInit();
        }

        private void buttonEditDepartment_Click(object sender, EventArgs e)
        {
            int r_index = dataGridViewDepartment.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridViewDepartment.Rows[r_index].Cells[0].Value);

            Department department = DepartmentLogic.GetDepartment(id);
            if (department != null)
            {
                FormEditDepartment formEditDepartment = new FormEditDepartment(department);
                formEditDepartment.ShowDialog();
                dataGridViewDepartmentInit();
            }
        }

        private void buttonDeleteDepartment_Click(object sender, EventArgs e)
        {
            int r_index = dataGridViewDepartment.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridViewDepartment.Rows[r_index].Cells[0].Value);

            Department department = DepartmentLogic.GetDepartment(id);
            if (department != null)
            {
                DialogResult result = MessageBox.Show(
                    "Вы точно хотите удалить отдел?",
                    "Окно подтверждения",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {
                    DepartmentLogic.DeleteDepartment(id);
                    dataGridViewDepartmentInit();
                }
                this.TopMost = true;
            }
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            dataGridViewDepartmentInit();
        }

    }
}
