using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sclertta.Databases.Personnel
{
    [Table("allowance")]
    public class Allowance
    {
        [Key, Column("id_allowance")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("datetime_0")]
        public DateTime? Datetime_0 { get; set; }
        [Column("datetime_1")]
        public DateTime? Datetime_1 { get; set; }
        [ForeignKey("id_type_allowance")]
        public TypeAllowance Type { get; set; }
        [Column("abbreviation")]
        public string Abbreviation { get; set; }
        [Column("code")]
        public string Code { get; set; }
        [Column("datetime_2")]
        public DateTime? Datetime_2 { get; set; }
        [Column("int_0")]
        public int? Int_0 { get; set; }
        [Column("stub")]
        public byte Stub { get; set; }
        [Column("regimen")]
        public byte Regimen { get; set; }
        [Column("int_1")]
        public int? Int_1 { get; set; }
        [Column("salary")]
        public byte Salary { get; set; }
        [Column("char_0")]
        public string Char_0 { get; set; }
        [Column("manual")]
        public string Manual { get; set; }
        [Column("money_0")]
        public decimal? Money_0 { get; set; }
        [Column("char_1")]
        public string Char_1 { get; set; }
        [Column("float_0")]
        public double? Float_0 { get; set; }
        [Column("char_2")]
        public string Char_2 { get; set; }
        [Column("float_1")]
        public double? Float_1 { get; set; }
        [Column("char_3")]
        public string Char_3 { get; set; }
        [Column("money_1")]
        public decimal? Money_1 { get; set; }
        [Column("money_2")]
        public decimal? Money_2 { get; set; }
        [Column("manual_cascade")]
        public string Manual_cascade { get; set; }
        [Column("has_courtesy")]
        public bool? Has_courtesy { get; set; }

    }
}
