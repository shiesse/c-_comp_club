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
    public partial class FormAddDepartment : Form
    {
        public FormAddDepartment()
        {
            InitializeComponent();
        }

        private void FormAddDepartment_Load(object sender, EventArgs e)
        {
            
            
        }

        private void buttonFormAddDepartment_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonFormAddDeparment_Add_Click(object sender, EventArgs e)
        {
            DepartmentLogic.AddDepartment(textBoxFormAddDepartment.Text);
            Close();
        }
    }
}
