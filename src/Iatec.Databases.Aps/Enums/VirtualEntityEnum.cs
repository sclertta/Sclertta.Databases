using System;
using System.Collections.Generic;
using System.Text;

namespace Iatec.Databases.Aps.Enums
{
    public class VirtualEntityEnum
    {
        private VirtualEntityEnum(string name)
        {
            this.Code = name;
        }

        public string Code { get; set; }

        public static VirtualEntityEnum EntityIp = new VirtualEntityEnum("ENTIDADES_IP");
        public static VirtualEntityEnum AcessoContrachequeInternet = new VirtualEntityEnum("ACESSO_CONTRACHEQUE_INTERNET");
        public static VirtualEntityEnum Vinculo = new VirtualEntityEnum("VINCULO");
        public static VirtualEntityEnum TipoSalario = new VirtualEntityEnum("TIPO_SALARIO");
    }
}
