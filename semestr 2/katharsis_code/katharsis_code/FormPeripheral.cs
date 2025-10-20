using katharsis_code.Logic;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace katharsis_code
{
    public partial class FormPeripheral : Form
    {
        public FormPeripheral()
        {
            InitializeComponent();
            InitializeComboBoxData();
            dataGridPeripheralInit();
        }

        private void InitializeComboBoxData()
        {
            Dictionary<string, string> peripheralTypes = new Dictionary<string, string>
            {
                { "-1", "Все" },
                { "monitor", "Монитор" },
                { "printer", "Принтер" },
                { "scaner", "Сканер" },
                { "plotter", "Плоттер" },
                { "router", "Роутер" }
            };
            comboBoxType.DataSource = new BindingSource(peripheralTypes, null);
            comboBoxType.DisplayMember = "Value";
            comboBoxType.ValueMember = "Key";

            Dictionary<string, string> peripheralStatuses = new Dictionary<string, string>
            {
                { "-1", "Все" },
                { "stable", "Работает" },
                { "on_repair", "На ремонте" },
                { "decommissioned", "Списан" }
            };
            comboBoxStatus.DataSource = new BindingSource(peripheralStatuses, null);
            comboBoxStatus.DisplayMember = "Value";
            comboBoxStatus.ValueMember = "Key";

            using (Context c = new Context())
            {
                var manufacturers = c.Manufacturers.ToList();
                manufacturers.Insert(0, new Manufacturer { Id = -1, Name = "Все" });
                comboBoxManufacturer.DataSource = manufacturers;
                comboBoxManufacturer.DisplayMember = "Name";
                comboBoxManufacturer.ValueMember = "Id";

                var employees = c.Employees.ToList();
                employees.Insert(0, new Employee { Id = -1, Full_name = "Все" });
                comboBoxEmployee.DataSource = employees;
                comboBoxEmployee.DisplayMember = "Full_name";
                comboBoxEmployee.ValueMember = "Id";
            }
        }

        private void dataGridPeripheralInit()
        {
            using (Context c = new Context())
            {
                var peripherals = c.PeripheralDevices.Include("Manufacturer").Include("Employee").AsQueryable();

                if (!string.IsNullOrWhiteSpace(textBoxInventoryNumber.Text))
                {
                    string inventoryNumber = textBoxInventoryNumber.Text.ToLower();
                    peripherals = peripherals.Where(pd => pd.Inventory_Number.ToLower().Contains(inventoryNumber));
                }

                if (comboBoxType.SelectedIndex > 0)
                {
                    string selectedType = ((KeyValuePair<string, string>)comboBoxType.SelectedItem).Key;
                    if (selectedType != "-1")
                    {
                        PeripheralType peripheralType = (PeripheralType)Enum.Parse(typeof(PeripheralType), selectedType);
                        peripherals = peripherals.Where(pd => pd.PeripheralType == peripheralType);
                    }
                }

                if (comboBoxStatus.SelectedIndex > 0)
                {
                    string selectedStatus = ((KeyValuePair<string, string>)comboBoxStatus.SelectedItem).Key;
                    if (selectedStatus != "-1")
                    {
                        PeripheralStatus peripheralStatus = (PeripheralStatus)Enum.Parse(typeof(PeripheralStatus), selectedStatus);
                        peripherals = peripherals.Where(pd => pd.PeripheralStatus == peripheralStatus);
                    }
                }

                if (comboBoxManufacturer.SelectedIndex > 0)
                {
                    int selectedManufacturerId = (int)comboBoxManufacturer.SelectedValue;
                    if (selectedManufacturerId != -1)
                    {
                        peripherals = peripherals.Where(pd => pd.Manufacturer.Id == selectedManufacturerId);
                    }
                }

                if (comboBoxEmployee.SelectedIndex > 0)
                {
                    int selectedEmployeeId = (int)comboBoxEmployee.SelectedValue;
                    if (selectedEmployeeId != -1)
                    {
                        peripherals = peripherals.Where(pd => pd.Employee.Id == selectedEmployeeId);
                    }
                }

                dataGridViewPeripheral.DataSource = peripherals.ToList();
                dataGridViewPeripheral.Columns[0].HeaderText = "ID";
                dataGridViewPeripheral.Columns[1].HeaderText = "Инвентарный номер";
                dataGridViewPeripheral.Columns[2].HeaderText = "Тип";
                dataGridViewPeripheral.Columns[3].HeaderText = "Статус";
                dataGridViewPeripheral.Columns[4].HeaderText = "Производитель";
                dataGridViewPeripheral.Columns[5].HeaderText = "Сотрудник";
                dataGridViewPeripheral.Columns[6].Visible = false;
                dataGridViewPeripheral.Columns[7].Visible = false;

                comboBoxEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxManufacturer.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void buttonPeripheralListExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddPeripheral_Click(object sender, EventArgs e)
        {
            FormAddPeripheral formAddPeripheral = new FormAddPeripheral();
            formAddPeripheral.ShowDialog();
            dataGridPeripheralInit();
        }

        private void buttonEditPeripheral_Click(object sender, EventArgs e)
        {
            int r_index = dataGridViewPeripheral.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridViewPeripheral.Rows[r_index].Cells[0].Value);

            PeripheralDevice peripheralDevice = PeripheralLogic.GetPeripheral(id);
            if (peripheralDevice != null)
            {
                FormEditPeripheral formEditPeripheral = new FormEditPeripheral(peripheralDevice);
                formEditPeripheral.ShowDialog();
                dataGridPeripheralInit();
            }
        }

        private void buttonDeletePeripheral_Click(object sender, EventArgs e)
        {
            int r_index = dataGridViewPeripheral.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridViewPeripheral.Rows[r_index].Cells[0].Value);

            PeripheralDevice peripheralDevice = PeripheralLogic.GetPeripheral(id);
            if (peripheralDevice != null)
            {
                DialogResult result = MessageBox.Show(
                   "Вы точно хотите удалить периферию?",
                   "Окно подтверждения",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {
                    PeripheralLogic.DeletePeripheral(id);
                    dataGridPeripheralInit();
                }
                this.TopMost = true;
            }
        }

        private void buttonDecommissionPeripheral_Click(object sender, EventArgs e)
        {
            int r_index = dataGridViewPeripheral.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridViewPeripheral.Rows[r_index].Cells[0].Value);

            PeripheralDevice peripheralDevice = PeripheralLogic.GetPeripheral(id);
            if (peripheralDevice != null)
            {
                if (peripheralDevice.PeripheralStatus != PeripheralStatus.decommissioned)
                {
                    FormDecommissionPeripheral formDecommissionPeripheral = new FormDecommissionPeripheral(peripheralDevice);
                    formDecommissionPeripheral.ShowDialog();
                    dataGridPeripheralInit();
                }
                else
                {
                    MessageBox.Show("Периферия уже списана!");
                }
            }
        }

        private void comboBoxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridPeripheralInit();
        }

        private void textBoxInventoryNumber_TextChanged(object sender, EventArgs e)
        {
            dataGridPeripheralInit();
        }
    }
}
