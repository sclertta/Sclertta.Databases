using System;
using System.Collections.Generic;
using System.Text;

namespace Sclertta.Databases.Personnel.Enums
{
    public class EmailTypeEnum
    {
        private EmailTypeEnum(string value)
        {
            Code = value;
        }

        public string Code { get; }

        public static readonly EmailTypeEnum Primary = new EmailTypeEnum("E1"); //1º e-mail
        public static readonly EmailTypeEnum Secondary = new EmailTypeEnum("E2"); //2º e-mail
    }
}
