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
    public partial class FormDecommissionComputer : Form
    {
        private Computer computer;
        public FormDecommissionComputer(Computer computer)
        {
            InitializeComponent();
            InitDecommisionCompForm();
            this.computer = computer;
        }

        private void InitDecommisionCompForm()
        {
            Context c = new Context();

            comboBox_repsonPerson1.DataSource = c.Employees.ToList();
            comboBox_repsonPerson1.DisplayMember = "Full_name";
            comboBox_repsonPerson1.ValueMember = "Id";

            comboBox_repsonPerson2.DataSource = c.Employees.ToList();
            comboBox_repsonPerson2.DisplayMember = "Full_name";
            comboBox_repsonPerson2.ValueMember = "Id";

            comboBox_repsonPerson3.DataSource = c.Employees.ToList();
            comboBox_repsonPerson3.DisplayMember = "Full_name";
            comboBox_repsonPerson3.ValueMember = "Id";

            comboBox_repsonPerson1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_repsonPerson2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_repsonPerson3.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox_repsonPerson1.SelectedIndex = -1;
            comboBox_repsonPerson2.SelectedIndex = -1;
            comboBox_repsonPerson3.SelectedIndex = -1;
        }

        private void button_deccommissionCompExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_decommissionCompAgree_Click(object sender, EventArgs e)
        {
            if (compare_three_strings(comboBox_repsonPerson1.SelectedItem.ToString(), comboBox_repsonPerson2.SelectedItem.ToString(), comboBox_repsonPerson3.SelectedItem.ToString()))
            {
                string persons = comboBox_repsonPerson1.SelectedItem + "\n" + comboBox_repsonPerson2.SelectedItem + "\n" + comboBox_repsonPerson3.SelectedItem;

                WriteOffReportLogic.AddReport(DateTime.Now, TechType.computer, computer.Inventory_Number, persons);

                ComputerLogic.DecommissionComputer(computer.Id);

                Close();
            } else
            {
                MessageBox.Show("Нужно выбрать трех уникальных");
            }
            
        }
        public bool compare_three_strings(string str1, string str2, string str3)
        {
            if (!str1.Equals(str2))
            {
                if(!str1.Equals(str3)) 
                { 
                    if (!str2.Equals(str3))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
