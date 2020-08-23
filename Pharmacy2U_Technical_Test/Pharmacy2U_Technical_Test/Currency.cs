using System.Globalization;

namespace Pharmacy2U_Technical_Test
{

    struct Currency
    {
        //currencies should be immutable, value of how much is being transformed is the only thing subject to change
        //unless we plan for an interface to change exchange rate live

        internal string Name { get; } // 3 character acronym used to define the international standard EG: GBP, EUR, USD...
        internal decimal Value { get; set; } //Input value/Converted Value 
        internal decimal ExchangeRate { get; } // Conversion Rate of currency, stored to 5 decimal places
        internal string CurrencySymbol { get; } // Symbol of the currency,Typically only 1 char, but in some cases not, £, $, €, A$...
        internal CultureInfo CultureInfo { get; } // Related information to associate Currency with a culture

        public Currency(string name, decimal exchangeRate, string currencySymbol, CultureInfo cultureInfo)
        {
            Name = name;
            Value = 0.00m;
            ExchangeRate = exchangeRate;
            CurrencySymbol = currencySymbol;
            CultureInfo = cultureInfo;
        }

        //with more time, a full set of overloads would be nice, such as basic math on adding/subtracting two different currencies  adjusted for exchange rate

        //would also like overloads to do basic math with ints/doubles/decimals

        public static decimal Convert(Currency a, Currency b)
        {
            return a.Value * b.ExchangeRate;
        }

        //override needed for combobox text
        public override string ToString()
        {
            return Name;
        }

        public static decimal operator *(Currency a, decimal b)
        {
            return a.Value * b;
        }

        //break out as soon as we know it isn't a match
        public static bool operator ==(Currency a, Currency b)
        {
            if (a.Name != b.Name) return false;
            if (a.Value != b.Value) return false;
            if (a.ExchangeRate != b.ExchangeRate) return false;
            if (a.CurrencySymbol != b.CurrencySymbol) return false;
            if (a.CultureInfo != b.CultureInfo) return false;

            return true;
        }

        //so long as there is a snogle discrepancy, we know they're not a match
        public static bool operator !=(Currency a, Currency b)
        {
            if (a.Name != b.Name) return true;
            if (a.Value != b.Value) return true;
            if (a.ExchangeRate != b.ExchangeRate) return true;
            if (a.CurrencySymbol != b.CurrencySymbol) return true;
            if (a.CultureInfo != b.CultureInfo) return true;

            return false;
        }

        //same logic as == override
        public override bool Equals(object obj)
        {
            try
            {
                Currency Comparitor = (Currency)obj;

                if (Name != Comparitor.Name) return false;
                if (Value != Comparitor.Value) return false;
                if (ExchangeRate != Comparitor.ExchangeRate) return false;
                if (CurrencySymbol != Comparitor.CurrencySymbol) return false;
                if (CultureInfo != Comparitor.CultureInfo) return false;

                return true;
            }
            catch
            {
                //tried to compare something that wasn't a currency to currency
                return false;
            }
        }

        //equals needs hashcode, not doing anything hashcode related, so leaving it bare
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
