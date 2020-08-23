using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pharmacy2U_Technical_Test
{
    class DataValidation
    {
        //0.00 is techincally a valid conversion, can't think of an edge case, this could cause (division?) but it exists
        private readonly static string REGEX_IS_DECIMAL = @"^[0-9]\d*(\.\d+)?$";

        internal static bool ValidateStringIsDecimal(string text)
        {
            Regex CheckForDecimal = new Regex(REGEX_IS_DECIMAL);

            return CheckForDecimal.IsMatch(text);
        }

        internal static bool ValidSelectedCurrency(ComboBox comboBox, List<Currency> ListOfCurrencies)
        {
            try
            {
                //hard casting not advised, but happens here as currency isn't a nullable type, try/catch to handle
                //but the list can only have currencies in it
                Currency currency = (Currency)comboBox.SelectedItem;

                //escape as soon as we find a match, rather than waiting till we iterate the whole list
                foreach (Currency listCurrency in ListOfCurrencies)
                {
                    if (currency == listCurrency)
                    {
                        return true;
                    }

                }
            }
            catch(Exception ex)
            {

                MessageBox.Show("Given longer than 3 hours, I would have added text File Logging\n" + ex.Message);

            }

            return false;

        }
    }
}
