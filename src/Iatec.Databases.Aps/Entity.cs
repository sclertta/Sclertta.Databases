using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Iatec.Databases.Aps
{
    [Table("entity")]
    public class Entity
    {
        [Key, Column("id_entity")]
        public int Id_entity { get; set; }
        [Column("datetime_0")]
        public DateTime? Datetime_0 { get; set; }
        [Column("employer_id_bank_account")]
        public int? Employer_id_bank_account { get; set; }
        [Column("signature1_id_employee")]
        public int? Signature1_id_employee { get; set; }
        [Column("datetime_1")]
        public DateTime? Datetime_1 { get; set; }
        [Column("signature2_id_employee")]
        public int? Signature2_id_employee { get; set; }
        [Column("signature1")]
        public byte[] Signature1 { get; set; }
        [Column("datetime_2")]
        public DateTime? Datetime_2 { get; set; }
        [Column("int_0")]
        public int? Int_0 { get; set; }
        [Column("signature2")]
        public byte[] Signature2 { get; set; }
        [Column("int_1")]
        public int? Int_1 { get; set; }
        [Column("char_0")]
        public string Char_0 { get; set; }
        [Column("char_1")]
        public string Char_1 { get; set; }
        [Column("char_2")]
        public string Char_2 { get; set; }
        [Column("char_3")]
        public string Char_3 { get; set; }
        [Column("money_0")]
        public decimal? Money_0 { get; set; }
        [Column("money_1")]
        public decimal? Money_1 { get; set; }
        [Column("money_2")]
        public decimal? Money_2 { get; set; }
        [Column("float_0")]
        public float? Float_0 { get; set; }
        [Column("float_1")]
        public float? Float_1 { get; set; }
        [Column("char_4")]
        public string Char_4 { get; set; }
        [Column("char_5")]
        public string Char_5 { get; set; }
        [Column("char_6")]
        public string Char_6 { get; set; }
        [Column("int_2")]
        public int? Int_2 { get; set; }
        [Column("bit_0")]
        public bool? Bit_0 { get; set; }
        [Column("bit_1")]
        public bool? Bit_1 { get; set; }
        [Column("bit_2")]
        public bool? Bit_2 { get; set; }
        [Column("entity_accounting")]
        public string Entity_accounting { get; set; }
        [Column("SMTP")]
        public string SMTP { get; set; }
        [Column("SMTPUser")]
        public string SMTPUser { get; set; }
        [Column("SMTPPassword")]
        public string SMTPPassword { get; set; }
        [Column("SMTPUserEmail")]
        public string SMTPUserEmail { get; set; }
        [Column("SMTPPort")]
        public short? SMTPPort { get; set; }
        [Column("SMTPUseTLS")]
        public bool? SMTPUseTLS { get; set; }
        [Column("SMTPAuthType")]
        public byte? SMTPAuthType { get; set; }
        [Column("char_7")]
        public string Char_7 { get; set; }
        [Column("char_8")]
        public string Char_8 { get; set; }
        [Column("char_9")]
        public string Char_9 { get; set; }
        [Column("int_3")]
        public int? Int_3 { get; set; }
        [Column("ERGuide")]
        public string ERGuide { get; set; }
        [Column("account_server_type")]
        public int? Account_server_type { get; set; }
        [Column("account_database")]
        public string Account_database { get; set; }
        [Column("endpoint_address")]
        public string Endpoint_address { get; set; }
        [Column("datetime_3")]
        public DateTime? Datetime_3 { get; set; }
        [Column("float_2")]
        public float? Float_2 { get; set; }
        [Column("ano_ini_esocial")]
        public int? Ano_ini_esocial { get; set; }
        [Column("mes_ini_esocial")]
        public int? Mes_ini_esocial { get; set; }
        [Column("contrato_deficiente")]
        public int? Contrato_deficiente { get; set; }
        [Column("nr_proc_jud_deficiente")]
        public string Nr_proc_jud_deficiente { get; set; }
        [Column("situacaoPJ")]
        public int SituacaoPJ { get; set; }

    }
}
