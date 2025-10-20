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
    public partial class FormAddComputer : Form
    {
        public FormAddComputer()
        {
            InitializeComponent();
            InitAddComputerForm();
        }
        private void InitAddComputerForm()
        {
            Dictionary<string, string> statuses = new Dictionary<string, string>();
            statuses.Add("stable", "Работает");
            statuses.Add("on_reapair", "На ремонте");
            statuses.Add("decommissioned", "Списан");

            Context c1 = new Context();
            comboBox_addComputer_Employee.DataSource = c1.Employees.ToList();

            List<Component> CPU = new List<Component>();
            List<Component> Motherboard = new List<Component>();
            List<Component> HDD = new List<Component>();
            foreach (Component comp in c1.Components.Include("Computer"))
            {
                if (comp.Computer == null)
                {
                    if (comp.ComponentType == ComponentType.CPU) { CPU.Add(comp); }
                    if (comp.ComponentType == ComponentType.motherboard) { Motherboard.Add(comp); }
                    if (comp.ComponentType == ComponentType.HDD) { HDD.Add(comp); }
                }
            }
            comboBox_addComputer_CPU.DataSource = CPU;
            comboBox_addComputer_Motherboard.DataSource = Motherboard;
            comboBox_addComputer_HDD.DataSource = HDD;

            comboBox_addComputer_CPU.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_addComputer_Employee.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_addComputer_HDD.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_addComputer_Motherboard.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonAddComputerExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddComputerSave_Click(object sender, EventArgs e)
        {
            ComputerLogic.AddComputer(textBox_addComputer_InvNum.Text, 
            (Employee)comboBox_addComputer_Employee.SelectedItem, (Component)comboBox_addComputer_CPU.SelectedItem, 
            (Component)comboBox_addComputer_Motherboard.SelectedItem, (Component)comboBox_addComputer_HDD.SelectedItem);
            Close();
        }
    }
}