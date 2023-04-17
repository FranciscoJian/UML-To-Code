using System;
using System.Collections.Generic;
using System.Text;

namespace M05_UF3_UMLToCode
{
    internal class Account
    {
        public string iban;
        protected float amount;

        public bool transaction(string str)
        {
            return true;
        }
    }
}
