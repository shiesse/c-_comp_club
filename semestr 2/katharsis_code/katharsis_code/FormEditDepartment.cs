using katharsis_code.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace katharsis_code.Models
{
    public partial class FormEditDepartment : Form
    {
        private int departmentId;
        public FormEditDepartment(Department department)
        {
            InitializeComponent();
            departmentId = department.Id;
            textBox_editDepartment_Name.Text = department.Name;
        }

        private void buttonEditDepartmentExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEditDepartmentSave_Click(object sender, EventArgs e)
        {
            DepartmentLogic.EditDepartment(departmentId, textBox_editDepartment_Name.Text);
            Close();
        }
    }
}
