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
            //fill the various fields from the SQL database
            fillRibonDropDown(ref dropDownDiagrams, "SELECT name FROM diagrams where useincalcsheet!=0",  "name");
            fillRibonDropDown(ref dropDownProject, "SELECT * FROM projects", "number");
            RibbonDropDownItem selectedItem = dropDownProject.Items[0];
            fillLabel(ref labelCustomer, "SELECT customer FROM projects where number=" + selectedItem.Label);
            fillLabel(ref labelClass, "SELECT classsoc FROM projects where number=" + selectedItem.Label);
            fillRibonDropDown(ref dropDownFluid, "SELECT DISTINCT type FROM pandid.diagrams ORDER BY type ASC", "type");
            fillRibonDropDown(ref dropDownType, "SELECT DISTINCT Type FROM pandid.complookup ORDER BY Type ASC", "Type");
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
        }

        private void dropDownType_SelectionChanged(object sender, RibbonControlEventArgs e)
        {
            RibbonDropDown rb = (RibbonDropDown)sender;
            string searchstr = rb.SelectedItem.Label;

            fillRibonDropDown(ref dropDownComponent, "SELECT DISTINCT SuppCode FROM pandid.complookup WHERE Type LIKE \'" + searchstr + "%\' ORDER BY SuppCode ASC", "SuppCode");
        }
    }
}
