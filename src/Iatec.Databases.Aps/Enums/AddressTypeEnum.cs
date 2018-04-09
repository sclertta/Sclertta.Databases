using System;
using System.Collections.Generic;
using System.Text;

namespace Iatec.Databases.Aps.Enums
{
    public class AddressTypeEnum
    {
        private AddressTypeEnum(string value)
        {
            Code = value;
        }

        public string Code { get; }

        public static readonly AddressTypeEnum Mail = new AddressTypeEnum("C"); //Endereço de Correspondência
    }
}
