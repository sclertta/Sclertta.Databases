using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sclertta.Databases.Personnel
{
    [Table("payment")]
    public class Payment
    {
        [Key, Column("id_payment")]
        public int Id { get; set; }
        [Column("id_enrollment")]
        public int EnrollmentId { get; set; }
        [Column("id_type_payment")]
        public int PaymentTypeId { get; set; }
        [ForeignKey("id_period")]
        public Period Period { get; set; }
        [Column("id_department")]
        public int Id_department { get; set; }
        [Column("datetime_0")]
        public DateTime? DateTime_0 { get; set; }
        [Column("id_job_title")]
        public int? Id_job_title { get; set; }
        [Column("payment_form")]
        public string Payment_form { get; set; }
        [Column("datetime_1")]
        public DateTime? DateTime_1 { get; set; }
        [Column("datetime_2")]
        public DateTime? DateTime_2 { get; set; }
        [Column("datetime_3")]
        public DateTime? DateTime_3 { get; set; }
        [Column("datetime_4")]
        public DateTime? DateTime_4 { get; set; }
        [Column("datetime_5")]
        public DateTime? DateTime_5 { get; set; }
        [Column("char_0")]
        public string Char_0 { get; set; }
        [Column("char_1")]
        public string Char_1 { get; set; }
        [Column("char_2")]
        public string Char_2 { get; set; }
        [Column("char_3")]
        public string Char_3 { get; set; }
        [Column("int_0")]
        public int? Int_0 { get; set; }
        [Column("int_1")]
        public int? Int_1 { get; set; }
        [Column("int_2")]
        public int? Int_2 { get; set; }
        [Column("int_3")]
        public int? Int_3 { get; set; }
        [Column("money_1")]
        public decimal? decimal_1 { get; set; }
        [Column("money_0")]
        public decimal? decimal_0 { get; set; }
        [Column("old_id_payment")]
        public int? Old_id_payment { get; set; }
        [Column("voided")]
        public bool? Voided { get; set; }
        [Column("voided_id_accounting")]
        public string Voided_id_accounting { get; set; }
        [Column("id_accounting")]
        public string Id_accounting { get; set; }
        [Column("datetime_6")]
        public DateTime? DateTime_6 { get; set; }
        [Column("datetime_7")]
        public DateTime? DateTime_7 { get; set; }
        [Column("datetime_8")]
        public DateTime? DateTime_8 { get; set; }
        [Column("float_0")]
        public double? double_0 { get; set; }
        [Column("float_1")]
        public double? double_1 { get; set; }
        [Column("calculated_by")]
        public string Calculated_by { get; set; }
        [Column("calculation_date")]
        public DateTime? Calculation_date { get; set; }
        [Column("authorized_by")]
        public string Authorized_by { get; set; }
        [Column("authorization_date")]
        public DateTime? Authorization_date { get; set; }
        [Column("posted_by")]
        public string Posted_by { get; set; }
        [Column("post_date")]
        public DateTime? Post_date { get; set; }
        [Column("bit_0")]
        public bool? bool_0 { get; set; }
        [Column("bit_1")]
        public bool? bool_1 { get; set; }
        [Column("bit_2")]
        public bool? bool_2 { get; set; }
        [Column("char_4")]
        public string Char_4 { get; set; }
        [Column("voided_by")]
        public string Voided_by { get; set; }
        [Column("voided_date")]
        public DateTime? Voided_date { get; set; }
        [Column("id_locality")]
        public int? Id_locality { get; set; }

        public List<PaymentItem> PaymentItems { get; set; }
    }
}
