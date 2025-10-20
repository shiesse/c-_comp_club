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
    public partial class FormEditManufacturer : Form
    {
        private int manufacturerId;
        public FormEditManufacturer(Manufacturer manufacturer)
        {
            InitializeComponent();
            manufacturerId = manufacturer.Id;
            textBox_editManufacturer_Name.Text = manufacturer.Name;
        }

        private void buttonEditManufacturerExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEditManufacturerSave_Click(object sender, EventArgs e)
        {
            ManufacturerLogic.EditManufacturer(manufacturerId, textBox_editManufacturer_Name.Text);
            Close();
        }
    }
}
