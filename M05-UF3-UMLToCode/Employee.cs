using System;
using System.Collections.Generic;
using System.Text;

namespace M05_UF3_UMLToCode
{
    internal class Employee : Person
    {
        public enum DEPARTMENT_ENUM { X, Y, Z}

        public DEPARTMENT_ENUM department()
        {
            return DEPARTMENT_ENUM.X;
        }

        private float salary;
    }
}
