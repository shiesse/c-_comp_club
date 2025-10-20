using katharsis_code.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace katharsis_code
{
    public partial class FormComponent : Form
    {
        public FormComponent()
        {
            InitializeComponent();
            LoadFilters();
            dataGridComponentInit();
        }

        private void LoadFilters()
        {
            using (Context c = new Context())
            {
                // Загрузка типов компонентов в ComboBox
                var componentTypes = Enum.GetValues(typeof(ComponentType)).Cast<ComponentType>().ToList();
                var componentTypeList = new List<KeyValuePair<ComponentType?, string>>
                {
                    new KeyValuePair<ComponentType?, string>(null, "Все")
                };
                componentTypeList.AddRange(componentTypes.Select(ct => new KeyValuePair<ComponentType?, string>(ct, ct.ToString())));
                comboBoxComponentType.DataSource = componentTypeList;
                comboBoxComponentType.DisplayMember = "Value";
                comboBoxComponentType.ValueMember = "Key";

                // Загрузка производителей в ComboBox
                var manufacturers = c.Manufacturers.ToList();
                manufacturers.Insert(0, new Manufacturer { Id = -1, Name = "Все" });
                comboBoxManufacturer.DataSource = manufacturers;
                comboBoxManufacturer.DisplayMember = "Name";
                comboBoxManufacturer.ValueMember = "Id";

                // Загрузка компьютеров в ComboBox
                var computers = c.Computers.ToList();
                computers.Insert(0, new Computer { Id = -1, Inventory_Number = "Все" });
                comboBoxComputer.DataSource = computers;
                comboBoxComputer.DisplayMember = "Inventory_Number";
                comboBoxComputer.ValueMember = "Id";
            }
        }

        private void dataGridComponentInit()
        {
            using (Context c = new Context())
            {
                var query = c.Components.Include("Manufacturer").Include("Computer").AsQueryable();

                // Фильтрация по типу компонента
                if (comboBoxComponentType.SelectedIndex > 0)
                {
                    var selectedType = ((KeyValuePair<ComponentType?, string>)comboBoxComponentType.SelectedItem).Key;
                    if (selectedType.HasValue)
                    {
                        query = query.Where(comp => comp.ComponentType == selectedType.Value);
                    }
                }

                // Фильтрация по производителю
                if (comboBoxManufacturer.SelectedIndex > 0)
                {
                    int selectedManufacturerId = (int)comboBoxManufacturer.SelectedValue;
                    if (selectedManufacturerId != -1)
                    {
                        query = query.Where(comp => comp.Manufacturer.Id == selectedManufacturerId);
                    }
                }

                // Фильтрация по компьютеру
                if (comboBoxComputer.SelectedIndex > 0)
                {
                    int selectedComputerId = (int)comboBoxComputer.SelectedValue;
                    if (selectedComputerId != -1)
                    {
                        query = query.Where(comp => comp.Computer.Id == selectedComputerId);
                    }
                }

                // Фильтрация по наименованию
                string nameFilter = textBoxNameFilter.Text.Trim();
                if (!string.IsNullOrEmpty(nameFilter))
                {
                    query = query.Where(comp => comp.Name.Contains(nameFilter));
                }

                var data = query.Select(comp => new
                {
                    comp.Id,
                    comp.Name,
                    comp.ComponentType,
                    ManufacturerName = comp.Manufacturer.Name,
                    ComputerInventoryNumber = comp.Computer.Inventory_Number,
                }).ToList();

                dataGridViewComponent.DataSource = data;
                dataGridViewComponent.Columns[0].HeaderText = "ID";
                dataGridViewComponent.Columns[1].HeaderText = "Наименование";
                dataGridViewComponent.Columns[2].HeaderText = "Тип";
                dataGridViewComponent.Columns[3].HeaderText = "Производитель";
                dataGridViewComponent.Columns[4].HeaderText = "Компьютер";

                comboBoxComponentType.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxComputer.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxManufacturer.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }


        private void buttonComponentListExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddComponent_Click(object sender, EventArgs e)
        {
            FormAddComponent formAddComponent = new FormAddComponent();
            formAddComponent.ShowDialog();
            dataGridComponentInit();
        }

        private void buttonEditComponent_Click(object sender, EventArgs e)
        {
            int r_index = dataGridViewComponent.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridViewComponent.Rows[r_index].Cells[0].Value);

            Component component = ComponentLogic.GetComponent(id);
            if (component != null)
            {
                FormEditComponent formEditComponent = new FormEditComponent(component);
                formEditComponent.ShowDialog();
                dataGridComponentInit();
            }
        }

        private void buttonDeleteComponent_Click(object sender, EventArgs e)
        {
            int r_index = dataGridViewComponent.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridViewComponent.Rows[r_index].Cells[0].Value);

            Component component = ComponentLogic.GetComponent(id);
            if (component != null)
            {
                DialogResult result = MessageBox.Show(
                   "Вы точно хотите удалить компоненту?",
                   "Окно подтверждения",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {
                    ComponentLogic.DeleteComponent(id);
                    dataGridComponentInit();
                }
                this.TopMost = true;
            }
        }

        private void comboBoxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridComponentInit();
        }
        private void textBoxNameFilter_TextChanged(object sender, EventArgs e)
        {
            dataGridComponentInit();
        }

    }
}
