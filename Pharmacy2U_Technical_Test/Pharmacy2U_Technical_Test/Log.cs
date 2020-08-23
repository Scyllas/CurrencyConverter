using System;

namespace Pharmacy2U_Technical_Test
{
    struct Log
    {

        internal DateTime date;
         
        internal decimal beforeValue;
        internal string beforeName;
         
        internal decimal afterValue;
        internal string afterName;

        public Log(DateTime dateLogged, Currency before, Currency after)
        {
            date = dateLogged;
            beforeValue = before.Value;
            beforeName = before.Name;
            afterValue = after.Value;
            afterName = after.Name;
        }
    }
}
