using katharsis_code.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace katharsis_code
{
    public partial class FormAddPeripheral : Form
    {
        public FormAddPeripheral()
        {
            InitializeComponent();
            InitAddPeripheralForm();
        }
        private void InitAddPeripheralForm()
        {
            Dictionary<string, string> items = new Dictionary<string, string>();
            items.Add("monitor", "Монитор");
            items.Add("printer", "Принтер");
            items.Add("scaner", "Сканер");
            items.Add("plotter", "Плоттер");
            items.Add("router", "Роутер");
            comboBox_addPeripheral_type.DataSource = new BindingSource(items, null);
            comboBox_addPeripheral_type.DisplayMember = "Value";
            comboBox_addPeripheral_type.ValueMember = "Key";

            Context c1 = new Context();
            comboBox_addPeripheral_manufacturer.DataSource = c1.Manufacturers.ToList();
            comboBox_addPeripheral_manufacturer.DisplayMember = "Name";
            comboBox_addPeripheral_manufacturer.ValueMember = "Id";

            comboBox_addPeripheral_manufacturer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_addPeripheral_type.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void buttonAddPeripheralExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonAddPeripheralSave_Click(object sender, EventArgs e)
        {
            PeripheralLogic.AddPeripheral(textBox_addPeripheral_InvNum.Text,
                                         (PeripheralType)comboBox_addPeripheral_type.SelectedIndex,
                                         PeripheralStatus.stable, Convert.ToInt32(comboBox_addPeripheral_manufacturer.SelectedValue));
            Close();
        }
    }
}