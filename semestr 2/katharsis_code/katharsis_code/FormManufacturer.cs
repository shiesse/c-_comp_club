using katharsis_code.Logic;
using katharsis_code.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace katharsis_code
{
    public partial class FormManufacturer : Form
    {
        public FormManufacturer()
        {
            InitializeComponent();
            dataGridManufacturerInit();
        }
        private void dataGridManufacturerInit()
        {
            using (Context c = new Context())
            {
                List<Manufacturer> manufacturers;

                if (string.IsNullOrWhiteSpace(textBoxFilter.Text))
                {
                    manufacturers = c.Manufacturers.ToList();
                }
                else
                {
                    string searchText = textBoxFilter.Text.ToLower();
                    manufacturers = c.Manufacturers
                                     .Where(d => d.Name.ToLower().Contains(searchText))
                                     .ToList();

                }
                dataGridViewManufacturer.DataSource = manufacturers;

                dataGridViewManufacturer.Columns[0].HeaderText = "ID";
                dataGridViewManufacturer.Columns[1].HeaderText = "Наименование";

            }
            
        }
        private void buttonManufacturerListExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonAddManufacturer_Click(object sender, EventArgs e)
        {
            FormAddManufacturer formAddManufacturer = new FormAddManufacturer();
            formAddManufacturer.ShowDialog();
            dataGridManufacturerInit();
        }

        private void buttonEditManufacturer_Click(object sender, EventArgs e)
        {
            int r_index = dataGridViewManufacturer.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridViewManufacturer.Rows[r_index].Cells[0].Value);

            Manufacturer manufacturer = ManufacturerLogic.GetManufacturer(id);
            if(manufacturer != null)
            {
                FormEditManufacturer formEditManufacturer = new FormEditManufacturer(manufacturer);
                formEditManufacturer.ShowDialog();
                dataGridManufacturerInit();
            }
        }

        private void buttonDeleteManufacturer_Click(object sender, EventArgs e)
        {
            int r_index = dataGridViewManufacturer.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridViewManufacturer.Rows[r_index].Cells[0].Value);

            Manufacturer manufacturer = ManufacturerLogic.GetManufacturer(id);
            if (manufacturer != null)
            {
                DialogResult result = MessageBox.Show(
                    "Вы точно хотите удалить производителя?",
                    "Окно подтверждения",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {
                    ManufacturerLogic.DeleteManufacturer(id);
                    dataGridManufacturerInit();
                }
                this.TopMost = true;
            }
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            dataGridManufacturerInit();
        }
    }
}