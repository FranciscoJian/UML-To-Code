using System;
using System.Collections.Generic;
using System.Text;

namespace M05_UF3_UMLToCode
{
    internal struct Address
    {

        public Person personClass;

        public string street;
        public string city;
        public string state;
        public int postalCode;
        public string country;

        public bool calidate()
        {
            return true;
        }
    }
}
