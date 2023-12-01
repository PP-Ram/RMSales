using System.Diagnostics;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace RMSales
{
    public enum TableType
    {
        Sales,
        SalesItem,
        Product,
        Purchase,
        PurchaseItem,
        Investment,
        Expenses,
        Supplier,
        Technician,
        Stock
    }

    public class Utilities
    {
        public const string AppName = "Smart Forex App";
        public const string DateFormat = "dd-MMM-yyyy";
        public static List<string> MonthsFull = new List<string>
        {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"
         };

        public Utilities() { }
        public string GetConfigValue(string v)
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            return appSettings[v].ToString();
        }
        public void ShowMessage(string v, string type = "i")
        {
            MessageBoxIcon mi = (type == "i") ? MessageBoxIcon.Information : MessageBoxIcon.Error;
            MessageBox.Show(v, AppName, MessageBoxButtons.OK, mi);
        }
        public DialogResult ShowQuestion(string v)
        {
            return MessageBox.Show(v, AppName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
        private static void HeaderDraw(object sender, DrawListViewColumnHeaderEventArgs e, Color backColor, Color foreColor)
        {
            using (SolidBrush backBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }

            using (SolidBrush foreBrush = new SolidBrush(foreColor))
            {
                e.Graphics.DrawString(e.Header.Text, e.Font, foreBrush, e.Bounds);
            }
        }
        private static void BodyDraw(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}