using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using MySql.Data.MySqlClient;

namespace PandIDExcelAddin
{
    public partial class PandIDribbon
    {
        private void PandIDribbon_Load(object sender, RibbonUIEventArgs e)
        {
            fillRibonDropDown(ref dropDownDiagrams, "SELECT name FROM diagrams where useincalcsheet!=0",  "name");
            fillRibonDropDown(ref dropDownProject, "SELECT * FROM projects", "number");
        }

        private void fillRibonDropDown(ref RibbonDropDown rbControl, string query, string col)
        {
            using (var connection = new MySqlConnection(Properties.Settings.Default.pandidConnectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {
                            RibbonDropDownItem item = Globals.Factory.GetRibbonFactory().CreateRibbonDropDownItem();
                            item.Label = reader.GetString(col);
                            rbControl.Items.Add(item);
                        }
                    }
                }
            }
        }

    }
}
