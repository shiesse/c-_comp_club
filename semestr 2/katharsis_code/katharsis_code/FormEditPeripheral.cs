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
    public partial class FormEditPeripheral : Form
    {
        private int peripheralDeviceId;
        public FormEditPeripheral(PeripheralDevice peripheralDevice)
        {
            InitializeComponent();
            peripheralDeviceId = peripheralDevice.Id;
            InitEditPeripheralForm();
            textBox_editPeripheral_InvNum.Text = peripheralDevice.Inventory_Number;
            comboBox_editPeripheral_type.SelectedIndex = Convert.ToInt32(peripheralDevice.PeripheralType);
            comboBox_editPeripheral_status.SelectedIndex = Convert.ToInt32(peripheralDevice.PeripheralStatus);
            comboBox_editPeripheral_manufacturer.SelectedValue = peripheralDevice.Manufacturer.Id;
            if (peripheralDevice.Employee != null)
            {
                comboBox_editPeripheral_employee.SelectedValue = peripheralDevice.Employee.Id;
            }
        }
        public void InitEditPeripheralForm()
        {
            Dictionary<string, string> peripheralTypes = new Dictionary<string, string>();
            peripheralTypes.Add("monitor", "Монитор");
            peripheralTypes.Add("printer", "Принтер");
            peripheralTypes.Add("scaner", "Сканер");
            peripheralTypes.Add("plotter", "Плоттер");
            peripheralTypes.Add("router", "Роутер");
            comboBox_editPeripheral_type.DataSource = new BindingSource(peripheralTypes, null);
            comboBox_editPeripheral_type.DisplayMember = "Value";
            comboBox_editPeripheral_type.ValueMember = "Key";

            Dictionary<string, string> peripheralStatuses = new Dictionary<string, string>();
            peripheralStatuses.Add("stable", "Работает");
            peripheralStatuses.Add("on_repair", "На ремонте");
            peripheralStatuses.Add("decommissioned", "Списан");
            comboBox_editPeripheral_status.DataSource = new BindingSource(peripheralStatuses, null);
            comboBox_editPeripheral_status.DisplayMember = "Value";
            comboBox_editPeripheral_status.ValueMember = "Key";

            Context c1 = new Context();
            comboBox_editPeripheral_manufacturer.DataSource = c1.Manufacturers.ToList();
            comboBox_editPeripheral_manufacturer.DisplayMember = "Name";
            comboBox_editPeripheral_manufacturer.ValueMember = "Id";

            comboBox_editPeripheral_employee.DataSource = c1.Employees.ToList();
            comboBox_editPeripheral_employee.DisplayMember = "Full_name";
            comboBox_editPeripheral_employee.ValueMember = "Id";

            comboBox_editPeripheral_employee.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_editPeripheral_manufacturer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_editPeripheral_status.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_editPeripheral_type.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonEditPeripheralExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEditPeripheralSave_Click(object sender, EventArgs e)
        {
            PeripheralLogic.EditPeripheral(peripheralDeviceId, textBox_editPeripheral_InvNum.Text,
                             (PeripheralType)comboBox_editPeripheral_type.SelectedIndex,
                             (PeripheralStatus)comboBox_editPeripheral_status.SelectedIndex,
                             Convert.ToInt32(comboBox_editPeripheral_manufacturer.SelectedValue),
                             Convert.ToInt32(comboBox_editPeripheral_employee.SelectedValue));
            Close();
        }
    }
}
