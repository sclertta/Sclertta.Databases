using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Iatec.Databases.Aps
{
    [Table("payment_item")]
    public class PaymentItem
    {
        [Key, Column("id_payment_item")]
        public int Id { get; set; }
        [ForeignKey("id_allowance")]
        public Allowance Allowance { get; set; }
        [ForeignKey("id_payment")]
        public Payment Payment { get; set; }
        [Column("value")]
        public decimal Value { get; set; }
        [Column("money_1")]
        public decimal? Money_1 { get; set; }
        [Column("datetime_0")]
        public DateTime? Datetime_0 { get; set; }
        [Column("money_2")]
        public decimal? Money_2 { get; set; }
        [Column("char_0")]
        public string Char_0 { get; set; }
        [Column("char_2")]
        public string Char_2 { get; set; }
        [Column("money_3")]
        public decimal? Money_3 { get; set; }
        [Column("char_1")]
        public string Char_1 { get; set; }
        [Column("int_0")]
        public int? Int_0 { get; set; }
        [Column("int_1")]
        public int? Int_1 { get; set; }
        [Column("money_0")]
        public decimal? Money_0 { get; set; }
        [Column("money_4")]
        public decimal? Money_4 { get; set; }
        [Column("money_5")]
        public decimal? Money_5 { get; set; }
        [Column("money_6")]
        public decimal? Money_6 { get; set; }
        [Column("money_7")]
        public decimal? Money_7 { get; set; }
        [Column("money_8")]
        public decimal? Money_8 { get; set; }
        [Column("money_9")]
        public decimal? Money_9 { get; set; }
        [Column("float_0")]
        public double? Float_0 { get; set; }
        [Column("float_1")]
        public double? Float_1 { get; set; }
        [Column("float_2")]
        public double? Float_2 { get; set; }
        [Column("float_3")]
        public double? Float_3 { get; set; }
        [Column("float_4")]
        public double? Float_4 { get; set; }
        [Column("typed")]
        public byte? Typed { get; set; }
        [Column("datetime_1")]
        public DateTime? Datetime_1 { get; set; }
    }
}
