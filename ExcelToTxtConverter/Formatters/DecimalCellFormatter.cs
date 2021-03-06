﻿using System.Globalization;

namespace ExcelToTxtConverter
{
    public class DecimalCellFormatter : ICellValueFormatter
    {
        public static string Identifier = "3";

        const NumberStyles numStyle = NumberStyles.AllowThousands;
        CultureInfo culture = new CultureInfo("en-US");

        public string ApplyFormatToValue(string cellValue)
        {
            decimal.TryParse(cellValue, out decimal retValue);

            return string.Format("{0:G29}", retValue);
        }
    }
}
