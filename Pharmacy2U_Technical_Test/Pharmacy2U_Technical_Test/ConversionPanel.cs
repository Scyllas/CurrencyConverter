using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pharmacy2U_Technical_Test
{
    public partial class ConversionPanel : Form
    {

        private List<Currency> BeforeCurrencies;
        private List<Currency> AfterCurrencies;
        private List<Log> Logs;

        public ConversionPanel()
        {
            InitializeComponent();

            BeforeCurrencies = ConversionPanelFunctions.SetUpCurrencies(SupportedCurrencies.GBP);
            AfterCurrencies = ConversionPanelFunctions.SetUpCurrencies(SupportedCurrencies.GBP, SupportedCurrencies.USD, SupportedCurrencies.AUD, SupportedCurrencies.EUR);

            Logs = new List<Log>();
        }

        private void ConversionPanel_Load(object sender, EventArgs e)
        {
            PopulateDropdown(cmb_beforeCurrency, BeforeCurrencies);
            PopulateDropdown(cmb_afterCurrency, AfterCurrencies);

            SelectEntryInDropdown(cmb_beforeCurrency);
            SelectEntryInDropdown(cmb_afterCurrency);
        }

        private void SelectEntryInDropdown(ComboBox comboBox)
        {
            try
            {
                comboBox.SelectedItem = SupportedCurrencies.GBP;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Given longer than 3 hours, I would have added text File Logging\n" + ex.Message);
            }
        }

        private void PopulateDropdown(ComboBox comboBox, List<Currency> CurrencyList)
        {
            foreach (Currency currency in CurrencyList)
            {
                comboBox.Items.Add(currency);
            }

        }

        private void Btn_Convert_Click(object sender, EventArgs e)
        {
            if (!DataValidation.ValidateStringIsDecimal(txt_beforeConversion.Text))
            {
                MessageBox.Show("Before Conversion not a valid input");
                return;
            }

            if (!DataValidation.ValidSelectedCurrency(cmb_beforeCurrency, BeforeCurrencies))
            {
                MessageBox.Show("Before Currency selected invalid");
                return;
            }

            if (!DataValidation.ValidSelectedCurrency(cmb_afterCurrency, AfterCurrencies))
            {
                MessageBox.Show("After Currency selected invalid");
                return;
            }

            Currency before = (Currency)cmb_beforeCurrency.SelectedItem;
            before.Value = Convert.ToDecimal(txt_beforeConversion.Text);

            Currency after = (Currency)cmb_afterCurrency.SelectedItem;
            after.Value = Currency.Convert(before, after);

            txt_afterConversion.Text = string.Format("{0}{1}", after.CurrencySymbol, after.Value.ToString());

            LogConversion(before, after);
        }

        private void LogConversion(Currency before, Currency after)
        {
            try
            {
                //personally I would write this to an SQL db table so I could query that
                Logs.Add(new Log(DateTime.Now, before, after));

                //repeating string format a lot, would likely make this a const
                dgv_live.Rows.Insert(0, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    before.Name, string.Format("{0:0.00000}", before.Value),
                    after.Name, string.Format("{0:0.00000}", after.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Given longer than 3 hours, I would have added text File Logging\n" + ex.Message);
            }
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime min = dtp_Min.Value;
                DateTime max = dtp_Max.Value;

                dgv_search.Rows.Clear();

                //this would then be returned as a Datatable from SQL 
                foreach (Log log in Logs)
                {
                    if (log.date >= min && log.date < max)
                    {
                        dgv_search.Rows.Insert(0, log.date.ToString("yyyy-MM-dd HH:mm:ss"),
                            log.beforeName, string.Format("{0:0.00000}", log.beforeValue),
                            log.afterName, string.Format("{0:0.00000}", log.afterValue));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Given longer than 3 hours, I would have added text File Logging\n" + ex.Message);
            }
        }
    }
}
