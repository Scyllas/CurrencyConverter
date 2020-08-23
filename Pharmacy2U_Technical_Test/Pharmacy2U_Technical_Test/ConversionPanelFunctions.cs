using System.Collections.Generic;

namespace Pharmacy2U_Technical_Test
{
    //class for utility functions specifically for the related class, contains functions that dont interact with form elements
    class ConversionPanelFunctions
    {

        internal static List<Currency> SetUpCurrencies(params Currency[] currencies)
        {
            List<Currency> outputCurrencyList = new List<Currency>();

            foreach(Currency currency in currencies)
            {
                outputCurrencyList.Add(currency);
            }

            return outputCurrencyList;
        }

    }
}
