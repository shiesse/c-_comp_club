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
    public partial class FormAddComponent : Form
    {
        public FormAddComponent()
        {
            InitializeComponent();
            InitAddComponentForm();
        }
        public void InitAddComponentForm()
        {
            Dictionary<string, string> items = new Dictionary<string, string>();
            items.Add("CPU", "Процессор");
            items.Add("motherboard", "Материнская плата");
            items.Add("HDD", "Жесткий диск");
            comboBox_addComponent_type.DataSource = new BindingSource(items, null);
            comboBox_addComponent_type.DisplayMember = "Value";
            comboBox_addComponent_type.ValueMember = "Key";

            Context c = new Context();
            comboBox_addComponent_manufacturer.DataSource = c.Manufacturers.ToList();
            comboBox_addComponent_manufacturer.DisplayMember = "Name";
            comboBox_addComponent_manufacturer.ValueMember = "Id";

            comboBox_addComponent_manufacturer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_addComponent_type.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void buttonAddComponentExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddComponentSave_Click(object sender, EventArgs e)
        {
            ComponentLogic.AddComponent(textBox_addComponent_Name.Text,
                                       (ComponentType)comboBox_addComponent_type.SelectedIndex,
                                       Convert.ToInt32(comboBox_addComponent_manufacturer.SelectedValue));
            Close();
        }
    }
}
