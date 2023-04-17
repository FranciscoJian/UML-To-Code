using System;
using System.Collections.Generic;
using System.Text;

namespace M05_UF3_UMLToCode
{
    internal abstract class Person
    {
        public Address adressClass;

        public int id;
        public string name;
        protected string phone;
        public string email;
    }
}
