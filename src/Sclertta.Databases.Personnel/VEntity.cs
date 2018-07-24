using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sclertta.Databases.Personnel
{
    [Table("v_entity")]
    public class VEntity
    {
        [Column("code_national")]
        public string NationalCode { get; set; }
        [Key, Column("id_entity")]
        public int Id { get; set; }
        [Column("datetime_0")]
        public DateTime? Datetime0 { get; set; }
        [Column("datetime_1")]
        public DateTime? Datetime1 { get; set; }
        [Column("datetime_2")]
        public DateTime? Datetime2 { get; set; }
        [Column("int_0")]
        public int? Int0 { get; set; }
        [Column("int_1")]
        public int? Int1 { get; set; }
        [Column("char_0")]
        public string Char0 { get; set; }
        [Column("char_1")]
        public string Char1 { get; set; }
        [Column("char_2")]
        public string Char2 { get; set; }
        [Column("char_3")]
        public string Char3 { get; set; }
        [Column("entity_code")]
        public string Code { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("abbreviation")]
        public string Abbreviation { get; set; }
        [Column("le_char_0")]
        public string LeChar0 { get; set; }
        [Column("signature1")]
        public byte[] Signature1 { get; set; }
        [Column("signature2")]
        public byte[] Signature2 { get; set; }
        [Column("signature2_id_employee")]
        public int? Signature2_EmployeeId { get; set; }
        [Column("signature1_id_employee")]
        public int? Signature1_EmployeeId { get; set; }
        [Column("employer_id_bank_account")]
        public int? EmployerBankAccountId { get; set; }
        [Column("e_char_0")]
        public string EChar0 { get; set; }
        [Column("e_char_1")]
        public string EChar1 { get; set; }
        [Column("e_char_2")]
        public string EChar2 { get; set; }
        [Column("e_char_3")]
        public string EChar3 { get; set; }
        [Column("e_char_4")]
        public string EChar4 { get; set; }
        [Column("e_char_5")]
        public string EChar5 { get; set; }
        [Column("e_char_6")]
        public string EChar6 { get; set; }
        [Column("e_char_7")]
        public string EChar7 { get; set; }

    }
}
