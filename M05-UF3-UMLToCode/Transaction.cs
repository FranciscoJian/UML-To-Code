using System;
using System.Collections.Generic;
using System.Text;

namespace M05_UF3_UMLToCode
{
    internal struct Transaction
    {
        public Account accountClass;

        public string from;
        public string to;
        public float amount;
        public DateTime request;
    }
}
