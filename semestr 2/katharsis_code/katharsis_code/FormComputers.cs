using katharsis_code.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace katharsis_code
{
    public partial class FormComputers : Form
    {
        public FormComputers()
        {
            InitializeComponent();
            LoadFilters();
            dataGridCompInit();
        }

        private void LoadFilters()
        {
            using (Context c = new Context())
            {
                // Загрузка сотрудников в combobox
                var employees = c.Employees.ToList();
                employees.Insert(0, new Employee { Id = -1, Full_name = "Все" });
                comboBoxEmployee.DataSource = employees;
                comboBoxEmployee.DisplayMember = "Full_name";
                comboBoxEmployee.ValueMember = "Id";

                // Загрузка компонентов в combobox
                var cpus = c.Components.Where(comp => comp.ComponentType == ComponentType.CPU).ToList();
                cpus.Insert(0, new Component { Id = -1, Name = "Все" });
                comboBoxCPU.DataSource = cpus;
                comboBoxCPU.DisplayMember = "Name";
                comboBoxCPU.ValueMember = "Id";

                var motherboards = c.Components.Where(comp => comp.ComponentType == ComponentType.motherboard).ToList();
                motherboards.Insert(0, new Component { Id = -1, Name = "Все" });
                comboBoxMotherBoard.DataSource = motherboards;
                comboBoxMotherBoard.DisplayMember = "Name";
                comboBoxMotherBoard.ValueMember = "Id";

                var hdds = c.Components.Where(comp => comp.ComponentType == ComponentType.HDD).ToList();
                hdds.Insert(0, new Component { Id = -1, Name = "Все" });
                comboBoxHDD.DataSource = hdds;
                comboBoxHDD.DisplayMember = "Name";
                comboBoxHDD.ValueMember = "Id";

                // Загрузка статусов в combobox
                var computerStatuses = new Dictionary<string, string>
                {
                    { "-1", "Все" },
                    { ComputerStatus.stable.ToString(), "Работает" },
                    { ComputerStatus.on_reapair.ToString(), "На ремонте" },
                    { ComputerStatus.decommissioned.ToString(), "Списан" }
                };
                comboBoxStatus.DataSource = new BindingSource(computerStatuses, null);
                comboBoxStatus.DisplayMember = "Value";
                comboBoxStatus.ValueMember = "Key";

                comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxCPU.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxHDD.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxMotherBoard.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void dataGridCompInit()
        {
            using (Context c = new Context())
            {
                var query = from comp in c.Computers.Include("Employee").Include("CPU").Include("MotherBoard").Include("HDD")
                            select comp;

                // Фильтрация по инвентарному номеру
                if (!string.IsNullOrWhiteSpace(textBoxInventoryNumber.Text))
                {
                    string inventoryNumber = textBoxInventoryNumber.Text.ToLower();
                    query = query.Where(comp => comp.Inventory_Number.ToLower().Contains(inventoryNumber));
                }

                // Фильтрация по статусу
                if (comboBoxStatus.SelectedIndex > 0)
                {
                    string selectedStatus = ((KeyValuePair<string, string>)comboBoxStatus.SelectedItem).Key;
                    if (selectedStatus != "-1")
                    {
                        ComputerStatus computerStatus = (ComputerStatus)Enum.Parse(typeof(ComputerStatus), selectedStatus);
                        query = query.Where(comp => comp.ComputerStatus == computerStatus);
                    }
                }

                // Фильтрация по сотруднику
                if (comboBoxEmployee.SelectedIndex > 0)
                {
                    int selectedEmployeeId = (int)comboBoxEmployee.SelectedValue;
                    if (selectedEmployeeId != -1)
                    {
                        query = query.Where(comp => comp.Employee.Id == selectedEmployeeId);
                    }
                }

                // Фильтрация по CPU
                if (comboBoxCPU.SelectedIndex > 0)
                {
                    int selectedCPUId = (int)comboBoxCPU.SelectedValue;
                    if (selectedCPUId != -1)
                    {
                        query = query.Where(comp => comp.CPU.Id == selectedCPUId);
                    }
                }

                // Фильтрация по MotherBoard
                if (comboBoxMotherBoard.SelectedIndex > 0)
                {
                    int selectedMotherBoardId = (int)comboBoxMotherBoard.SelectedValue;
                    if (selectedMotherBoardId != -1)
                    {
                        query = query.Where(comp => comp.MotherBoard.Id == selectedMotherBoardId);
                    }
                }

                // Фильтрация по HDD
                if (comboBoxHDD.SelectedIndex > 0)
                {
                    int selectedHDDId = (int)comboBoxHDD.SelectedValue;
                    if (selectedHDDId != -1)
                    {
                        query = query.Where(comp => comp.HDD.Id == selectedHDDId);
                    }
                }

                var data = query.Select(comp => new
                {
                    comp.Id,
                    comp.Inventory_Number,
                    comp.ComputerStatus,
                    EmployeeFullName = comp.Employee.Full_name,
                    CPUName = comp.CPU.Name,
                    MotherBoardName = comp.MotherBoard.Name,
                    HDDName = comp.HDD.Name,
                }).ToList();

                dataGridViewComputer.DataSource = data;
                dataGridViewComputer.Columns[0].HeaderText = "ID";
                dataGridViewComputer.Columns[1].HeaderText = "Инвентарный номер";
                dataGridViewComputer.Columns[2].HeaderText = "Статус";
                dataGridViewComputer.Columns[3].HeaderText = "Сотрудник";
                dataGridViewComputer.Columns[4].HeaderText = "Процессор";
                dataGridViewComputer.Columns[5].HeaderText = "Материнская плата";
                dataGridViewComputer.Columns[6].HeaderText = "Жесткий диск";
            }
        }

        private void FormComputers_Load(object sender, EventArgs e)
        {
            dataGridCompInit();
        }

        private void buttonComputerExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddComputer_Click(object sender, EventArgs e)
        {
            FormAddComputer formAddComputer = new FormAddComputer();
            formAddComputer.ShowDialog();
            dataGridCompInit();
        }

        private void buttonEditComputer_Click(object sender, EventArgs e)
        {
            int r_index = dataGridViewComputer.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridViewComputer.Rows[r_index].Cells[0].Value);

            Computer computer = ComputerLogic.GetComputer(id);
            if (computer != null)
            {
                FormEditComp formEditComponent = new FormEditComp(computer);
                formEditComponent.ShowDialog();
                dataGridCompInit();
            }
        }

        private void button_Comp_delete_Click(object sender, EventArgs e)
        {
            int r_index = dataGridViewComputer.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridViewComputer.Rows[r_index].Cells[0].Value);

            Computer computer = ComputerLogic.GetComputer(id);
            if (computer != null)
            {
                DialogResult result = MessageBox.Show(
                  "Вы точно хотите удалить компьютер?",
                  "Окно подтверждения",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Information,
                  MessageBoxDefaultButton.Button1,
                  MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {
                    ComputerLogic.DeleteComputer(computer.Id);
                    dataGridCompInit();
                    MessageBox.Show("Компьютер удален!");
                }
                this.TopMost = true;
            }
        }
        private void button_Comp_decomm_Click(object sender, EventArgs e)
        {
            int r_index = dataGridViewComputer.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridViewComputer.Rows[r_index].Cells[0].Value);

            Computer computer = ComputerLogic.GetComputer(id);
            if (computer != null)
            {
                if (computer.ComputerStatus != ComputerStatus.decommissioned)
                {
                    FormDecommissionComputer formDecommissionComputer = new FormDecommissionComputer(computer);
                    formDecommissionComputer.ShowDialog();
                    dataGridCompInit();
                }
                else
                {
                    MessageBox.Show("Компьютер уже списан!");
                }
            }    
        }

        private void comboBoxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridCompInit();
        }

        private void textBoxInventoryNumber_TextChanged(object sender, EventArgs e)
        {
            dataGridCompInit();
        }
    }
}
