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
	public partial class FormEditComp : Form
	{
        private int comp_id;
		public FormEditComp(Computer computer)
		{
			InitializeComponent();
            InitEditComputerForm();
            comp_id = computer.Id;
            textBox_EditComputer_InvNum.Text = computer.Inventory_Number;
            comboBox_EditComp_status.SelectedIndex = Convert.ToInt32(computer.ComputerStatus);
            //comboBox_EditComputer_Employee.SelectedValue = computer.Employee.Id;
            //comboBox_EditComputer_CPU.SelectedValue = computer.CPU;
            //comboBox_EditComputer_Motherboard.SelectedValue = computer.MotherBoard.Id;
            //comboBox_EditComputer_HDD.SelectedValue = computer.HDD.Id;
        }
        private void InitEditComputerForm()
        {
            Dictionary<string, string> statuses = new Dictionary<string, string>();
            statuses.Add("stable", "Работает");
            statuses.Add("on_reapair", "На ремонте");
            statuses.Add("decommissioned", "Списан");
            comboBox_EditComp_status.DataSource = new BindingSource(statuses, null);
            comboBox_EditComp_status.DisplayMember = "Value";

            Context c1 = new Context();
            comboBox_EditComputer_Employee.DataSource = c1.Employees.ToList();
            //comboBox_EditComputer_Employee.DisplayMember = "Name";
            //comboBox_EditComputer_Employee.ValueMember = "Id";

            List<Component> CPU = new List<Component>();
            List<Component> Motherboard = new List<Component>();
            List<Component> HDD = new List<Component>();
            foreach (Component comp in c1.Components)
            {
                if (comp.ComponentType == ComponentType.CPU) { CPU.Add(comp); }
                if (comp.ComponentType == ComponentType.motherboard) { Motherboard.Add(comp); }
                if (comp.ComponentType == ComponentType.HDD) { HDD.Add(comp); }
            }
            comboBox_EditComputer_CPU.DataSource = CPU;
            comboBox_EditComputer_Motherboard.DataSource = Motherboard;
            comboBox_EditComputer_HDD.DataSource = HDD;

            comboBox_EditComputer_CPU.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_EditComputer_Employee.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_EditComputer_HDD.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_EditComputer_Motherboard.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_EditComp_status.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonEditComputerExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void buttonEditComputerSave_Click(object sender, EventArgs e)
		{
            ComputerLogic.EditComputer(comp_id, textBox_EditComputer_InvNum.Text, (ComputerStatus)comboBox_EditComp_status.SelectedIndex, 
                (Employee)comboBox_EditComputer_Employee.SelectedItem, (Component)comboBox_EditComputer_CPU.SelectedItem,
                (Component)comboBox_EditComputer_Motherboard.SelectedItem, (Component)comboBox_EditComputer_HDD.SelectedItem);
            Close();
		}
	}
}
