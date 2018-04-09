using System;
using System.Collections.Generic;
using System.Text;

namespace Iatec.Databases.Aps.Enums
{
    public class ObjectEnum
    {
        private ObjectEnum(string type)
        {
            Code = type;
        }

        public string Code { get; }

        public static ObjectEnum COD_TIPO_PAGAMENTO_FERIAS = new ObjectEnum("COD_TIPO_PAGAMENTO_FERIAS");
        public static ObjectEnum ENROLLMENT_EMPLOYEE__VINCULO = new ObjectEnum("ENROLLMENT_EMPLOYEE/VINCULO");
        public static ObjectEnum ENROLLMENT_EMPLOYEE__TIPO_SALARIO = new ObjectEnum("ENROLLMENT_EMPLOYEE/TIPO_SALARIO");
    }
}
