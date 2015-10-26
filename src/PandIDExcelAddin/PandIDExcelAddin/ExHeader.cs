using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace PandIDExcelAddin
{
    public class ExHeader : ExProperties
    {
        public string Title { get; set; }
        public string Project { get; set; }
        public string Name { get; set; }
        public string Customer { get; set; }
        public string ClassSoc { get; set; }
        public string Number { get; set; }
        public float L { get; set; }
        public float W { get; set; }
        public float D { get; set; }
        public float BRT
        {
            get
            {
                return (L * W * D) / 3;
            }
        }

        public ExHeader()
        {
            ExApp = Globals.ThisAddIn.Application as Excel.Application;
            ExSheet = ExApp.ActiveSheet as Excel._Worksheet;
            ExRange = ExSheet.get_Range("A1", "D6");
        }

        private void WriteCells(int row, string propDesc, string PropVal)
        {
            Excel.Range ProjectRange = ExSheet.Cells[row, 1];
            ProjectRange.Font.Bold = true;
            ProjectRange.Font.Size = Properties.Settings.Default.BasicFontSize;
            ProjectRange.Value = propDesc;
            ProjectRange = ExSheet.Cells[row, 2];
            ProjectRange.Font.Bold = false;
            ProjectRange.Font.Size = Properties.Settings.Default.BasicFontSize;
            ProjectRange.Value = PropVal;
        }

        public override void WriteToExcel()
        {
            base.WriteToExcel();

            //Header Block
            ExRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Properties.Settings.Default.BorderColorBlock);
            ExRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(Properties.Settings.Default.BackgroundColorMain);
           // ExRange.Font.Name = Properties.Settings.Default.BasicFont;

            // Title
            Excel.Range TitleRange = ExSheet.get_Range("A1", "D1");
            TitleRange.Merge();
            TitleRange.Font.Size = Properties.Settings.Default.TitleFontSize;
            TitleRange.Font.Bold = Properties.Settings.Default.TitleFontBold;
            TitleRange.Value = "Calculations for " + Title + " system";

            // Write Properties
            WriteCells(2, "Project :", Number + " - " + Name);
            WriteCells(3, "Customer", Customer);
            WriteCells(4, "Classification society:", ClassSoc);
            WriteCells(5, "BRT:", Convert.ToString(BRT));

        }
    }
}
