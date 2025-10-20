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
    public partial class FormAddManufacturer : Form
    {
        public FormAddManufacturer()
        {
            InitializeComponent();
        }
        private void InitAddManufacturerForm()
        {   

        }
        private void buttonAddManufacturerSave_Click(object sender, EventArgs e)
        {
            ManufacturerLogic.AddManufacturer(textBox_addManufacturer_Name.Text);
            Close();
        }
        private void buttonAddManufacturerExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
