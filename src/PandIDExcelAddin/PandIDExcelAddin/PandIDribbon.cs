using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using MySql.Data.MySqlClient;
using System.Globalization;
using Excel = Microsoft.Office.Interop.Excel;

namespace PandIDExcelAddin
{
    public partial class PandIDribbon
    {
        private ExHeader SheetHeader { get; set; }

        private void PandIDribbon_Load(object sender, RibbonUIEventArgs e)
        {
            //fill the various fields from the SQL database
            fillRibonDropDown(ref dropDownDiagrams, "SELECT name FROM diagrams where useincalcsheet!=0",  "name");
            fillRibonDropDown(ref dropDownProject, "SELECT * FROM projects", "number");
            RibbonDropDownItem selectedItem = dropDownProject.Items[0];
            fillLabel(ref labelCustomer, "SELECT customer FROM projects where number=" + selectedItem.Label);
            fillLabel(ref labelClass, "SELECT classsoc FROM projects where number=" + selectedItem.Label);
            fillRibonDropDown(ref dropDownFluid, "SELECT DISTINCT type FROM pandid.diagrams ORDER BY type ASC", "type");
            fillRibonDropDown(ref dropDownType, "SELECT DISTINCT Type FROM pandid.complookup ORDER BY Type ASC", "Type");
            fillRibonDropDown(ref dropDownNorm, "SELECT DISTINCT norm FROM pandid.pipes ORDER BY norm ASC", "norm");
            dropDownNorm_SelectionChanged(dropDownNorm, null);
            GetBlocks();
        }

        private void BuildHeader()
        {
            SheetHeader = new ExHeader();
            SheetHeader.Number = dropDownProject.SelectedItem.Label;
            SheetHeader.Title = dropDownDiagrams.SelectedItem.Label;

            using (var connection = new MySqlConnection(Properties.Settings.Default.pandidConnectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand("SELECT * FROM projects WHERE number=" + dropDownProject.SelectedItem.Label, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    SheetHeader.Name = reader.GetString("name");
                                    SheetHeader.Customer = reader.GetString("customer");
                                    SheetHeader.ClassSoc = reader.GetString("classsoc");
                                    SheetHeader.L = reader.GetFloat("length");
                                    SheetHeader.W = reader.GetFloat("width");
                                    SheetHeader.D = reader.GetFloat("depth");
                                }
                                catch (System.Data.SqlTypes.SqlNullValueException ex)
                                {
                                    //item.Label = "None";
                                }
                            }
                        }
                    }
                }
            }
        }

        private void GetBlocks()
        {
            BuildHeader();
        }

        private void ClearSheet()
        {
            // Clear sheet
            Excel.Application ExApp = Globals.ThisAddIn.Application as Excel.Application;
            Excel._Worksheet ExSheet = ExApp.ActiveSheet as Excel._Worksheet;

            //find the complete range
            Excel.Range first = ExSheet.Cells[1, 1];
            Excel.Range last = ExSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            Excel.Range workRange = ExSheet.get_Range(first, last);
            workRange.Value = "";
            workRange.ClearFormats();
        }

        private void RebuildSheet()
        {
            ClearSheet();

        }

        private void fillRibonDropDown(ref RibbonDropDown rbControl, string query, string col)
        {
            rbControl.Items.Clear();
            using (var connection = new MySqlConnection(Properties.Settings.Default.pandidConnectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                RibbonDropDownItem item = Globals.Factory.GetRibbonFactory().CreateRibbonDropDownItem();
                                try
                                {
                                    item.Label = reader.GetString(col);
                                    rbControl.Items.Add(item);
                                }
                                catch (System.Data.SqlTypes.SqlNullValueException ex)
                                {
                                    //item.Label = "None";
                                }
                            }
                        }
                    }
                }
            }
        }

        private void fillLabel(ref RibbonLabel rbLabel, string query)
        {
            using (var connection = new MySqlConnection(Properties.Settings.Default.pandidConnectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                rbLabel.Label = reader.GetString(0);
                            }
                        }
                    }
                }
            }
        }

        private void dropDownProject_SelectionChanged(object sender, RibbonControlEventArgs e)
        {
            RibbonDropDown rb = (RibbonDropDown)sender;
            RibbonDropDownItem selectedItem = rb.SelectedItem;
            fillLabel(ref labelCustomer, "SELECT customer FROM projects where number=" + selectedItem.Label);
            fillLabel(ref labelClass, "SELECT classsoc FROM projects where number=" + selectedItem.Label);

            BuildHeader();
        }

        private void dropDownDiagrams_SelectionChanged(object sender, RibbonControlEventArgs e)
        {
            RibbonDropDown rb = (RibbonDropDown)sender;
            string searchstr = rb.SelectedItem.Label;
            
            using (var connection = new MySqlConnection(Properties.Settings.Default.pandidConnectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand("SELECT type FROM diagrams where name=\"" + searchstr + "\"", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string typestr = reader.GetString(0);
                                foreach (RibbonDropDownItem li in dropDownFluid.Items)
                                {
                                    if (li.Label.CompareTo(typestr) == 0)
                                    {
                                        dropDownFluid.SelectedItem = li;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            BuildHeader();
        }

        private string getFirstValue(string sqlSearch)
        {
            string retvalue = null;

            using (var connection = new MySqlConnection(Properties.Settings.Default.pandidConnectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(sqlSearch, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                return reader.GetString(0);
                            }
                        }
                    }
                }
            }
            return retvalue;
        }

        private void dropDownType_SelectionChanged(object sender, RibbonControlEventArgs e)
        {
            RibbonDropDown rb = (RibbonDropDown)sender;
            string searchstr = rb.SelectedItem.Label;

            string retVal = getFirstValue("SELECT useDia FROM norms where norm=\"" + dropDownNorm.SelectedItem.Label + "\"");
            if (retVal.CompareTo("dn") == 0)
            {
                fillRibonDropDown(ref dropDownComponent, "SELECT DISTINCT SuppCode FROM pandid.complookup WHERE Type LIKE \'" + searchstr + "%\' AND NS=" + dropDownDia.SelectedItem.Label + " ORDER BY SuppCode ASC", "SuppCode");
            }
            else if (retVal.CompareTo("inch") == 0)
            {
                string searchdn = getFirstValue("SELECT DISTINCT dn FROM pipes WHERE inch LIKE \'" + dropDownDia.SelectedItem.Label + "\'");
                fillRibonDropDown(ref dropDownComponent, "SELECT DISTINCT SuppCode FROM pandid.complookup WHERE Type LIKE \'" + searchstr + "%\' AND NS=" + searchdn + " ORDER BY SuppCode ASC", "SuppCode");
            }
            else if (retVal.CompareTo("od") == 0)
            {
                float odfloat = Convert.ToSingle(dropDownDia.SelectedItem.Label);
                string odsearch = Convert.ToString(odfloat, CultureInfo.InvariantCulture);
                string searchdn = getFirstValue("SELECT DISTINCT dn FROM pipes WHERE outdia=" + odsearch);
                fillRibonDropDown(ref dropDownComponent, "SELECT DISTINCT SuppCode FROM pandid.complookup WHERE Type LIKE \'" + searchstr + "%\' AND NS=" + searchdn + " ORDER BY SuppCode ASC", "SuppCode");
            }
            
        }

        private void dropDownNorm_SelectionChanged(object sender, RibbonControlEventArgs e)
        {
            RibbonDropDown rb = (RibbonDropDown)sender;
            string searchstr = rb.SelectedItem.Label;

            string retVal = getFirstValue("SELECT useDia FROM norms where norm=\"" + searchstr + "\"");
            if (retVal.CompareTo("dn") == 0)
            {
                fillRibonDropDown(ref dropDownDia, "SELECT DISTINCT dn FROM pandid.pipes WHERE norm LIKE \'" + searchstr + "%\' ORDER BY dn ASC", "dn");
            }
            else if (retVal.CompareTo("inch") == 0)
            {
                fillRibonDropDown(ref dropDownDia, "SELECT DISTINCT inch FROM pandid.pipes WHERE norm LIKE \'" + searchstr + "%\' ORDER BY dn ASC", "inch");
            }
            else if (retVal.CompareTo("od") == 0)
            {
                fillRibonDropDown(ref dropDownDia, "SELECT DISTINCT outdia FROM pandid.pipes WHERE norm LIKE \'" + searchstr + "%\' ORDER BY dn ASC", "outdia");
            }
        }

        private void buttonAddPipe_Click(object sender, RibbonControlEventArgs e)
        {
            RebuildSheet();
            SheetHeader.WriteToExcel();
        }
    }
}
