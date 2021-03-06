﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sclertta.Databases.Personnel.Enums
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
