namespace Pharmacy2U_Technical_Test
{
    static class SupportedCurrencies
    {
        //Supported Currencies list
        internal static Currency GBP = new Currency("GBP", 1.00000m, "£", new System.Globalization.CultureInfo("en-GB", false));//Great Britain
        internal static Currency USD = new Currency("USD", 1.30905m, "$", new System.Globalization.CultureInfo("en-US", false));//United States
        internal static Currency AUD = new Currency("AUD", 1.82822m, "A$", new System.Globalization.CultureInfo("en-AU", false));//Australia
        internal static Currency EUR = new Currency("EUR", 1.10967m, "€", new System.Globalization.CultureInfo("de-DE", false));//Germany (one of many countries using Euros)
    }
}
