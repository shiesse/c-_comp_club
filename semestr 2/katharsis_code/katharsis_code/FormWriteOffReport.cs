using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace katharsis_code
{
    public partial class FormWriteOffReport : Form
    {

        public FormWriteOffReport()
        {
            
            InitializeComponent();
            dataGridWriteOffReportInit();
            InitializeComboBoxData();
            dateTimePicker1.Value = DateTimePicker.MinimumDateTime;
        }
        private void InitializeComboBoxData()
        {
            Dictionary<string, string> techTypes = new Dictionary<string, string>
            {
                {"all", "Все" },
                {"computer", "Компьютер"},
                { "peripheralDevice", "Периферия" },
            };
            comboBoxType.DataSource = new BindingSource(techTypes, null);
            comboBoxType.DisplayMember = "Value";
            comboBoxType.ValueMember = "Key";  
        }

        private void dataGridWriteOffReportInit()
        {


            using (Context c = new Context())
            {
                var write = c.WriteOffReports.AsQueryable();
                if (!string.IsNullOrWhiteSpace(textBoxResponsiblePerson.Text))
                {
                    string searchName = textBoxResponsiblePerson.Text.ToLower();
                    write = write.Where(e => e.ResponsiblePersons.ToLower().Contains(searchName));
                }

                if (comboBoxType.SelectedIndex > -1 && comboBoxType.SelectedItem != null)
                {
                    var selectedPosition = ((KeyValuePair<string, string>)comboBoxType.SelectedItem).Key;
                    if (selectedPosition != "all")
                    {
                        write = write.Where(e => e.TechType.ToString() == selectedPosition);
                    }
                }

                if (!string.IsNullOrWhiteSpace(textBoxNum.Text))
                {
                    string searchNum = textBoxNum.Text.ToLower();
                    write = write.Where(e => e.Inventory_number.ToLower().Contains(searchNum));
                }
                
                DateTime date = dateTimePicker1.Value;
                DateTime date2 = dateTimePicker2.Value;
                if(date == date2)
                {
                    date = date.AddDays(-1);
                }
                if (date != null)
                {
                    write = write.Where(e => (e.Date >= date && e.Date <= date2));
                }

                dataGridViewWriteOffReport.DataSource = write.ToList();
                dataGridViewWriteOffReport.Columns[0].HeaderText = "ID";
                dataGridViewWriteOffReport.Columns[1].HeaderText = "Дата";
                dataGridViewWriteOffReport.Columns[2].HeaderText = "Тип техники";
                dataGridViewWriteOffReport.Columns[3].HeaderText = "Инвентарный номер";
                dataGridViewWriteOffReport.Columns[4].HeaderText = "Ответственные лица";

                comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void buttonWriteOffReportListExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridWriteOffReportInit();
        }
        private void textBoxNameFilter_TextChanged(object sender, EventArgs e)
        {
            dataGridWriteOffReportInit();
        }
    }
}
