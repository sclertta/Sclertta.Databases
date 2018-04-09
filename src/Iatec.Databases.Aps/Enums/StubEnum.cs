using System;
using System.Collections.Generic;
using System.Text;

namespace Iatec.Databases.Aps.Enums
{
    public class StubEnum
    {
        private StubEnum(byte value)
        {
            Code = value;
        }

        public byte Code { get; }

        public static readonly StubEnum DontPrintInPaycheck = new StubEnum(0);
        public static readonly StubEnum PrintInPaycheck = new StubEnum(1);
        public static readonly StubEnum Voided = new StubEnum(2);
    }
}
