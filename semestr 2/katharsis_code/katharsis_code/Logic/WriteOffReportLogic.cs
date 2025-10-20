using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace katharsis_code.Logic
{
    public class WriteOffReportLogic
    {
        public static void AddReport(DateTime Date, TechType techType, 
                                    string inventory_number, string responsiblePersons)
        {
            try
            {
                Context c = new Context();
                WriteOffReport writeOffReport = new WriteOffReport();
                writeOffReport.Date = Date;
                writeOffReport.TechType = techType;
                writeOffReport.Inventory_number = inventory_number;
                writeOffReport.ResponsiblePersons = responsiblePersons;

                c.WriteOffReports.Add(writeOffReport);

                c.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public static WriteOffReport GetReport(int id)
        {
            try
            {
                Context c = new Context();
                return (from report in c.WriteOffReports where report.Id == id select report).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return null;
        }
    }
}