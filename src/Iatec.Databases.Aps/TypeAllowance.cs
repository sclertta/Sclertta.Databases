using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Iatec.Databases.Aps
{
    [Table("type_allowance")]
    public class TypeAllowance
    {
        [Key, Column("id_type_allowance")]
        public short Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("signal")]
        public string Signal { get; set; }
        [Column("code")]
        public string Code { get; set; }
        [Column("int_1")]
        public int? Int_1 { get; set; }
        [Column("net_payment")]
        public bool IsNetPayment { get; set; }
        [Column("int_2")]
        public int? Int_2 { get; set; }
        [Column("int_3")]
        public int? Int_3 { get; set; }
        [Column("datetime_1")]
        public DateTime? Datetime_1 { get; set; }
        [Column("float_0")]
        public double? Float_0 { get; set; }
        [Column("datetime_2")]
        public DateTime? Datetime_2 { get; set; }
        [Column("money_0")]
        public decimal? Money_0 { get; set; }
        [Column("float_1")]
        public double? Float_1 { get; set; }
        [Column("float_2")]
        public double? Float_2 { get; set; }
        [Column("money_1")]
        public decimal? Money_1 { get; set; }
        [Column("money_2")]
        public decimal? Money_2 { get; set; }
        [Column("char_0")]
        public string Char_0 { get; set; }
        [Column("money_3")]
        public decimal? Money_3 { get; set; }
        [Column("char_1")]
        public string Char_1 { get; set; }
        [Column("money_4")]
        public decimal? Money_4 { get; set; }
        [Column("char_2")]
        public string Char_2 { get; set; }
        [Column("money_5")]
        public decimal? Money_5 { get; set; }
        [Column("user_can_modify")]
        public bool User_can_modify { get; set; }
        [Column("bit_0")]
        public bool? Bit_0 { get; set; }
        [Column("bit_1")]
        public bool? Bit_1 { get; set; }
    }
}
