using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace PandIDExcelAddin
{
    public class ExProperties
    {
        public int Order { get; set; }

        public Excel.Application ExApp { get; set; }
        public Excel._Worksheet ExSheet { get; set;  }

        public Excel.Range ExRange { get; set; }

        public virtual void WriteToExcel()  { }

    }
}
