using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace katharsis_code
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenDepatment_Click(object sender, EventArgs e)
        {
            FormDepartment formDepartment = new FormDepartment();
            formDepartment.ShowDialog();
        }

        private void buttonOpenComputers_Click(object sender, EventArgs e)
        {
            FormComputers formCopmuters = new FormComputers();
            formCopmuters.ShowDialog();
        }

        private void buttonOpenPeripheral_Click(object sender, EventArgs e)
        {
            FormPeripheral formPeripheral = new FormPeripheral();
            formPeripheral.ShowDialog();
        }
        private void buttonOpenWriteOffReport_Click(object sender, EventArgs e)
        {
            FormWriteOffReport formWriteOffReport = new FormWriteOffReport();
            formWriteOffReport.ShowDialog();
        }

        private void buttonOpenManufacturer_Click(object sender, EventArgs e)
        {
            FormManufacturer formManufacturer = new FormManufacturer();
            formManufacturer.ShowDialog();
        }

        private void buttonOpenEmployee_Click(object sender, EventArgs e)
        {
            FormEmployee formEmployee = new FormEmployee();
            formEmployee.ShowDialog();
        }

        private void buttonOpenComponent_Click(object sender, EventArgs e)
        {
            FormComponent formComponent = new FormComponent();
            formComponent.ShowDialog();
        }

        private void button_generateReport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if(folder.ShowDialog() == DialogResult.OK)
            {
                GenerateExcelWriteOffReport(folder.SelectedPath);
                GenerateExcelComputer(folder.SelectedPath);
                GenerateExcelPeripheral(folder.SelectedPath);
            }
        }

        private void GenerateExcelWriteOffReport(string path)
        {
            XLWorkbook workbook = new XLWorkbook();
            IXLWorksheet worksheet1 = workbook.Worksheets.Add("Акты о списании");

            Context c = new Context();
            List<WriteOffReport> writeOffReports = c.WriteOffReports.ToList();

            int currentRow = 1;
            worksheet1.Cell(currentRow, 1).Value = "ID акта";
            worksheet1.Cell(currentRow, 2).Value = "Дата";
            worksheet1.Cell(currentRow, 3).Value = "Тип техники";
            worksheet1.Cell(currentRow, 4).Value = "Инвентарный номер";
            worksheet1.Cell(currentRow, 5).Value = "Ответственные лица";
            currentRow++;

            foreach (WriteOffReport writeOffReport in writeOffReports)
            {
                worksheet1.Cell(currentRow, 1).Value = writeOffReport.Id;
                worksheet1.Cell(currentRow, 2).Value = writeOffReport.Date;
                string techType = "";
                if (writeOffReport.TechType == TechType.computer)
                {
                    techType = "Компьютер";
                }
                else if (writeOffReport.TechType == TechType.peripheralDevice)
                {
                    techType = "Периферия";
                }
                worksheet1.Cell(currentRow, 3).Value = techType;
                worksheet1.Cell(currentRow, 4).Value = writeOffReport.Inventory_number;
                worksheet1.Cell(currentRow, 5).Value = writeOffReport.ResponsiblePersons;
                currentRow++;
            }
            worksheet1.Columns().AdjustToContents();

            try
            {
                workbook.SaveAs(path + "\\" + DateTime.Today.ToLongDateString() + " отчет об актах о списании.xlsx");
                MessageBox.Show("Отчет об актах о списании сгенерирован");
            }
            catch
            {
                MessageBox.Show("Не удалось создать отчет об актах о списании");
            }
        }

        private void GenerateExcelComputer(string path)
        {
            XLWorkbook workbook = new XLWorkbook();
            IXLWorksheet worksheet1 = workbook.Worksheets.Add("Компьютеры");

            Context c = new Context();
            List<Computer> computers = c.Computers.ToList();

            int currentRow = 1;
            worksheet1.Cell(currentRow, 1).Value = "ID компьютера";
            worksheet1.Cell(currentRow, 2).Value = "Инвентарный номер";
            worksheet1.Cell(currentRow, 3).Value = "Статус";
            currentRow++;
            foreach (Computer computer in computers)
            {
                worksheet1.Cell(currentRow, 1).Value = computer.Id;
                worksheet1.Cell(currentRow, 2).Value = computer.Inventory_Number;

                string status = "";
                if (computer.ComputerStatus == ComputerStatus.stable) status = "Работает";
                else if (computer.ComputerStatus == ComputerStatus.on_reapair) status = "На ремонте";
                else if (computer.ComputerStatus == ComputerStatus.decommissioned) status = "Списан";
                worksheet1.Cell(currentRow, 3).Value = status;
                currentRow++;
            }
            worksheet1.Columns().AdjustToContents();

            try
            {
                workbook.SaveAs(path + "\\" + DateTime.Today.ToLongDateString() + " отчет о компьютерах.xlsx");
                MessageBox.Show("Отчет о компьютерах сгенерирован");
            }
            catch
            {
                MessageBox.Show("Не удалось создать отчет о компьютерах");
            }
        }

        private void GenerateExcelPeripheral(string path)
        {
            XLWorkbook workbook = new XLWorkbook();
            IXLWorksheet worksheet1 = workbook.Worksheets.Add("Компьютеры");

            Context c = new Context();
            List<PeripheralDevice> devices = c.PeripheralDevices.ToList();

            int currentRow = 1;
            worksheet1.Cell(currentRow, 1).Value = "ID периферии";
            worksheet1.Cell(currentRow, 2).Value = "Инвентарный номер";
            worksheet1.Cell(currentRow, 3).Value = "Тип";
            worksheet1.Cell(currentRow, 4).Value = "Статус";
            currentRow++;
            foreach (PeripheralDevice device in devices)
            {
                worksheet1.Cell(currentRow, 1).Value = device.Id;
                worksheet1.Cell(currentRow, 2).Value = device.Inventory_Number;

                string type = "";
                if (device.PeripheralType == PeripheralType.printer) type = "Принтер";
                else if (device.PeripheralType == PeripheralType.scaner) type = "Сканер";
                else if (device.PeripheralType == PeripheralType.plotter) type = "Плоттер";
                else if (device.PeripheralType == PeripheralType.monitor) type = "Монитор";
                else if (device.PeripheralType == PeripheralType.router) type = "Роутер";
                worksheet1.Cell(currentRow, 3).Value = type;

                string status = "";
                if (device.PeripheralStatus == PeripheralStatus.stable) status = "Работает";
                else if (device.PeripheralStatus == PeripheralStatus.on_repair) status = "На ремонте";
                else if (device.PeripheralStatus == PeripheralStatus.decommissioned) status = "Списан";
                worksheet1.Cell(currentRow, 4).Value = status;
                currentRow++;
            }
            worksheet1.Columns().AdjustToContents();

            try
            {
                workbook.SaveAs(path + "\\" + DateTime.Today.ToLongDateString() + " отчет о периферии.xlsx");
                MessageBox.Show("Отчет о периферии сгенерирован");
            }
            catch
            {
                MessageBox.Show("Не удалось создать отчет о периферии");
            }
        }
    }
}