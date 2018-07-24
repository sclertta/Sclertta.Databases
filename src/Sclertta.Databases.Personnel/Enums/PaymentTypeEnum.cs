using System;
using System.Collections.Generic;
using System.Text;

namespace Sclertta.Databases.Personnel.Enums
{
    public class PaymentTypeEnum
    {
        private PaymentTypeEnum(string value)
        {
            Code = value;
        }
                
        public string Code { get; }

        public static readonly PaymentTypeEnum ReligiousVacation = new PaymentTypeEnum("DESCANSO_ANUAL_RELIGIOSO");
        public static readonly PaymentTypeEnum WageInAdvance = new PaymentTypeEnum("ADIANTAMENTO_SALARIO");
        public static readonly PaymentTypeEnum TransportationVoucher = new PaymentTypeEnum("Vale_Transporte");
        public static readonly PaymentTypeEnum TravelReimbursement = new PaymentTypeEnum("Reembolso_Despesa_Viagem");
        public static readonly PaymentTypeEnum StandardPaycheck = new PaymentTypeEnum("CONTRA_CHEQUE");
        public static readonly PaymentTypeEnum ThirteenthPaycheck = new PaymentTypeEnum("DECIMO_TERCEIRO");
        public static readonly PaymentTypeEnum Vacation = new PaymentTypeEnum("FERIAS");
        public static readonly PaymentTypeEnum ReligiousChristmasBonus = new PaymentTypeEnum("GRATIFICACAO_NATAL_RELIGIOSO");
        public static readonly PaymentTypeEnum Termination = new PaymentTypeEnum("RESCISAO");
        public static readonly PaymentTypeEnum MoneyInAdvance = new PaymentTypeEnum("ADIANTAMENTO");
        public static readonly PaymentTypeEnum ReligiousMaintenance = new PaymentTypeEnum("AUXILIO_MANUTENCAO_RELIGIOSO");
        public static readonly PaymentTypeEnum AJUSTE_FINAL_RELIGIOSO = new PaymentTypeEnum("AJUSTE_FINAL_RELIGIOSO");
    }
}
