using System;
using System.Collections.Generic;
using System.Text;

namespace Sclertta.Databases.Personnel.Enums
{
    public class PhoneTypeEnum
    {
        private PhoneTypeEnum(string value)
        {
            Code = value;
        }

        public string Code { get; }

        public static readonly PhoneTypeEnum Inactive = new PhoneTypeEnum("I");    //Inativo
        public static readonly PhoneTypeEnum Home = new PhoneTypeEnum("F1");       //Fone Residencial
        public static readonly PhoneTypeEnum Business = new PhoneTypeEnum("F2");   //Fone Comercial
        public static readonly PhoneTypeEnum Mobile = new PhoneTypeEnum("F3");     //Celular
        public static readonly PhoneTypeEnum Friend = new PhoneTypeEnum("F4");     //Fone Recado
        public static readonly PhoneTypeEnum Fax = new PhoneTypeEnum("Fax");       //Fax
    }
}
