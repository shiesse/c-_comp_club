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
    public partial class FormEditComponent : Form
    {
        private int componentId;
        public FormEditComponent(Component component)
        {
            InitializeComponent();
            componentId = component.Id;
            InitEditComponentForm();
            textBox_editComponent_Name.Text = component.Name;
            comboBox_editComponent_type.SelectedIndex = Convert.ToInt32(component.ComponentType);
            comboBox_editComponent_manufacturer.SelectedValue = component.Manufacturer.Id;
        }
        public void InitEditComponentForm()
        {
            Dictionary<string, string> items = new Dictionary<string, string>();
            items.Add("CPU", "Процессор");
            items.Add("motherboard", "Материнская плата");
            items.Add("HDD", "Жесткий диск");
            comboBox_editComponent_type.DataSource = new BindingSource(items, null);
            comboBox_editComponent_type.DisplayMember = "Value";
            comboBox_editComponent_type.ValueMember = "Key";

            Context c = new Context();
            comboBox_editComponent_manufacturer.DataSource = c.Manufacturers.ToList();
            comboBox_editComponent_manufacturer.DisplayMember = "Name";
            comboBox_editComponent_manufacturer.ValueMember = "Id";

            comboBox_editComponent_manufacturer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_editComponent_type.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonEditComponentExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEditComponentSave_Click(object sender, EventArgs e)
        {
            ComponentLogic.EditComponent(componentId, textBox_editComponent_Name.Text,
                                        (ComponentType)comboBox_editComponent_type.SelectedIndex,
                                        Convert.ToInt32(comboBox_editComponent_manufacturer.SelectedValue));
            Close();
        }
    }
}
