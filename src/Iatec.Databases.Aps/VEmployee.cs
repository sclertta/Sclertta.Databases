using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Iatec.Databases.Aps
{
    [Table("v_employee")]
    public class VEmployee
    {
        [Column("code_national")]
        public string NationalCode { get; set; }
        [ForeignKey("id_employee")]
        public Person Person { get; set; }
        [Column("datetime_0")]
        public DateTime? Datetime_0 { get; set; }
        [Column("datetime_1")]
        public DateTime? Datetime_1 { get; set; }
        [Column("datetime_2")]
        public DateTime? Datetime_2 { get; set; }
        [Column("int_0")]
        public int? Int_0 { get; set; }
        [Column("int_1")]
        public int? Int_1 { get; set; }
        [Column("char_0")]
        public string Char_0 { get; set; }
        [Column("char_1")]
        public string Password { get; set; }
        [Column("char_2")]
        public string Char_2 { get; set; }
        [Column("char_3")]
        public string Char_3 { get; set; }
        [Column("prefix")]
        public string Prefix { get; set; }
        [Column("name_first")]
        public string FirstName { get; set; }
        [Column("name_midle")]
        public string MiddleName { get; set; }
        [Column("name_last")]
        public string LastName { get; set; }
        [Column("sufix")]
        public string Suffix { get; set; }
        [Column("id_gender")]
        public int? GenderId { get; set; }
        [Column("id_marital_status")]
        public int? MaritalStatusId { get; set; }
        [Column("date_birth")]
        public DateTime? BirthDate { get; set; }
        [Column("birth_id_locality")]
        public int? Birth_id_locality { get; set; }
        [Column("citizenship_id_country")]
        public short? Citizenship_id_country { get; set; }
        [Column("np_char_0")]
        public string Np_char_0 { get; set; }
        [Column("np_char_1")]
        public string Np_char_1 { get; set; }
        [Column("np_char_2")]
        public string Np_char_2 { get; set; }
        [Column("np_char_3")]
        public string Np_char_3 { get; set; }
        [Column("np_char_4")]
        public string Np_char_4 { get; set; }
        [Column("np_char_5")]
        public string Np_char_5 { get; set; }
        [Column("np_datetime_0")]
        public DateTime? Np_datetime_0 { get; set; }
        [Column("np_datetime_1")]
        public DateTime? Np_datetime_1 { get; set; }
        [Column("np_datetime_2")]
        public DateTime? Np_datetime_2 { get; set; }
        [Column("np_datetime_3")]
        public DateTime? Np_datetime_3 { get; set; }
        [Column("np_datetime_4")]
        public DateTime? Np_datetime_4 { get; set; }
        [Column("np_datetime_5")]
        public DateTime? Np_datetime_5 { get; set; }
        [Column("np_int_0")]
        public int? Np_int_0 { get; set; }
        [Column("np_int_1")]
        public int? Np_int_1 { get; set; }
        [Column("np_int_2")]
        public int? Np_int_2 { get; set; }
        [Column("np_int_3")]
        public int? Np_int_3 { get; set; }
        [Column("np_int_4")]
        public int? Np_int_4 { get; set; }
        [Column("np_int_5")]
        public int? Np_int_5 { get; set; }
        [Column("name_regular")]
        public string Name_regular { get; set; }
        [Column("name_full")]
        public string FullName { get; set; }
        [Column("date_first_hire")]
        public DateTime? Date_first_hire { get; set; }
        [Column("e_char_0")]
        public string E_char_0 { get; set; }
        [Column("e_char_1")]
        public string E_char_1 { get; set; }
        [Column("e_char_2")]
        public string E_char_2 { get; set; }
        [Column("e_char_3")]
        public string E_char_3 { get; set; }
        [Column("e_char_4")]
        public string E_char_4 { get; set; }
        [Column("e_char_5")]
        public string E_char_5 { get; set; }
        [Column("e_char_6")]
        public string E_char_6 { get; set; }
        [Column("e_char_7")]
        public string E_char_7 { get; set; }
        [Column("e_char_8")]
        public string E_char_8 { get; set; }
        [Column("e_char_9")]
        public string E_char_9 { get; set; }
        [Column("e_datetime_0")]
        public DateTime? E_datetime_0 { get; set; }
        [Column("e_datetime_1")]
        public DateTime? E_datetime_1 { get; set; }
        [Column("e_datetime_10")]
        public DateTime? E_datetime_10 { get; set; }
        [Column("e_datetime_11")]
        public DateTime? E_datetime_11 { get; set; }
        [Column("e_datetime_12")]
        public DateTime? E_datetime_12 { get; set; }
        [Column("e_datetime_13")]
        public DateTime? E_datetime_13 { get; set; }
        [Column("e_datetime_14")]
        public DateTime? E_datetime_14 { get; set; }
        [Column("e_datetime_2")]
        public DateTime? E_datetime_2 { get; set; }
        [Column("e_datetime_3")]
        public DateTime? E_datetime_3 { get; set; }
        [Column("e_datetime_4")]
        public DateTime? E_datetime_4 { get; set; }
        [Column("e_datetime_5")]
        public DateTime? E_datetime_5 { get; set; }
        [Column("e_datetime_6")]
        public DateTime? E_datetime_6 { get; set; }
        [Column("e_datetime_7")]
        public DateTime? E_datetime_7 { get; set; }
        [Column("e_datetime_8")]
        public DateTime? E_datetime_8 { get; set; }
        [Column("e_datetime_9")]
        public DateTime? E_datetime_9 { get; set; }
        [Column("e_float_0")]
        public double? E_float_0 { get; set; }
        [Column("e_float_1")]
        public double? E_float_1 { get; set; }
        [Column("e_int_0")]
        public int? E_int_0 { get; set; }
        [Column("e_int_1")]
        public int? E_int_1 { get; set; }
        [Column("e_int_2")]
        public int? E_int_2 { get; set; }
        [Column("e_int_3")]
        public int? E_int_3 { get; set; }
        [Column("e_int_4")]
        public int? E_int_4 { get; set; }
        [Column("e_int_5")]
        public int? E_int_5 { get; set; }
        [Column("e_int_6")]
        public int? E_int_6 { get; set; }
        [Column("e_int_7")]
        public int? E_int_7 { get; set; }
        [Column("e_int_8")]
        public int? E_int_8 { get; set; }
        [Column("e_int_9")]
        public int? E_int_9 { get; set; }
        [Column("e_money_0")]
        public decimal? E_money_0 { get; set; }
        [Column("e_money_1")]
        public decimal? E_money_1 { get; set; }
        [Column("e_bit_0")]
        public bool? E_bit_0 { get; set; }
        [Column("e_bit_1")]
        public bool? E_bit_1 { get; set; }
        [Column("e_bit_2")]
        public bool? E_bit_2 { get; set; }
        [Column("employee_code")]
        public string Employee_code { get; set; }
        [Key, Column("id_enrollment")]
        public int EnrollmentId { get; set; }
        [Column("id_entity")]
        public int Entityid { get; set; }
        [Column("id_department")]
        public int? DepartmentId { get; set; }
        [Column("id_status")]
        public short StatusId { get; set; }
        [Column("status_code")]
        public string Status_code { get; set; }
        [Column("status_active")]
        public bool IsActive { get; set; }
        [Column("entity_code")]
        public string EntityCode { get; set; }
        [Column("entity_name")]
        public string EntityName { get; set; }
        [Column("department_code")]
        public string DepartmentCode { get; set; }
        [Column("department_name")]
        public string DepartmentName { get; set; }
        [Column("enrollment_code")]
        public string EnrollmentCode { get; set; }
        [Column("id_job_title")]
        public int Id_job_title { get; set; }
        [Column("payment_method")]
        public byte Payment_method { get; set; }
        [Column("date_hired")]
        public DateTime AdmissionDate { get; set; }
        [Column("date_termination")]
        public DateTime? TerminationDate { get; set; }
        [Column("id_employee_group")]
        public int Id_employee_group { get; set; }
        [Column("group_code")]
        public string Group_code { get; set; }
        [Column("group_name")]
        public string Group_name { get; set; }
        [Column("job_title_name")]
        public string Job_title_name { get; set; }
        [Column("job_title_code")]
        public string Job_title_code { get; set; }
        [Column("carteira_trabalho_numero")]
        public string Carteira_trabalho_numero { get; set; }
        [Column("carteira_trabalho_serie")]
        public string Carteira_trabalho_serie { get; set; }
        [Column("ee_char_0")]
        public string Ee_char_0 { get; set; }
        [Column("ee_char_1")]
        public string Ee_char_1 { get; set; }
        [Column("ee_char_2")]
        public string Ee_char_2 { get; set; }
        [Column("ee_char_3")]
        public string Ee_char_3 { get; set; }
        [Column("ee_char_4")]
        public string Ee_char_4 { get; set; }
        [Column("ee_char_5")]
        public string Ee_char_5 { get; set; }
        [Column("ee_char_6")]
        public string Ee_char_6 { get; set; }
        [Column("ee_char_7")]
        public string Ee_char_7 { get; set; }
        [Column("ee_char_8")]
        public string Ee_char_8 { get; set; }
        [Column("ee_char_9")]
        public string Ee_char_9 { get; set; }
        [Column("ee_char_10")]
        public string Ee_char_10 { get; set; }
        [Column("ee_char_11")]
        public string Ee_char_11 { get; set; }
        [Column("ee_char_12")]
        public string Ee_char_12 { get; set; }
        [Column("ee_char_13")]
        public string Ee_char_13 { get; set; }
        [Column("ee_char_14")]
        public string Ee_char_14 { get; set; }
        [Column("ee_char_15")]
        public string Ee_char_15 { get; set; }
        [Column("ee_char_16")]
        public string Ee_char_16 { get; set; }
        [Column("ee_datetime_0")]
        public DateTime? Ee_datetime_0 { get; set; }
        [Column("ee_datetime_1")]
        public DateTime? Ee_datetime_1 { get; set; }
        [Column("ee_datetime_10")]
        public DateTime? Ee_datetime_10 { get; set; }
        [Column("ee_datetime_11")]
        public DateTime? Ee_datetime_11 { get; set; }
        [Column("ee_datetime_12")]
        public DateTime? Ee_datetime_12 { get; set; }
        [Column("ee_datetime_13")]
        public DateTime? Ee_datetime_13 { get; set; }
        [Column("ee_datetime_14")]
        public DateTime? Ee_datetime_14 { get; set; }
        [Column("ee_datetime_2")]
        public DateTime? Ee_datetime_2 { get; set; }
        [Column("ee_datetime_3")]
        public DateTime? Ee_datetime_3 { get; set; }
        [Column("ee_datetime_4")]
        public DateTime? Ee_datetime_4 { get; set; }
        [Column("ee_datetime_5")]
        public DateTime? Ee_datetime_5 { get; set; }
        [Column("ee_datetime_6")]
        public DateTime? Ee_datetime_6 { get; set; }
        [Column("ee_datetime_7")]
        public DateTime? Ee_datetime_7 { get; set; }
        [Column("ee_datetime_8")]
        public DateTime? Ee_datetime_8 { get; set; }
        [Column("ee_datetime_9")]
        public DateTime? Ee_datetime_9 { get; set; }
        [Column("ee_float_0")]
        public double? Ee_float_0 { get; set; }
        [Column("ee_float_1")]
        public double? Ee_float_1 { get; set; }
        [Column("ee_float_2")]
        public double? Ee_float_2 { get; set; }
        [Column("ee_float_3")]
        public double? Ee_float_3 { get; set; }
        [Column("ee_int_0")]
        public int? Ee_int_0 { get; set; }
        [Column("ee_int_1")]
        public int? Ee_int_1 { get; set; }
        [Column("ee_int_2")]
        public int? Ee_int_2 { get; set; }
        [Column("ee_int_3")]
        public int? Ee_int_3 { get; set; }
        [Column("ee_int_4")]
        public int? Ee_int_4 { get; set; }
        [Column("ee_int_5")]
        public int? Ee_int_5 { get; set; }
        [Column("ee_int_6")]
        public int? Ee_int_6 { get; set; }
        [Column("ee_int_7")]
        public int? Ee_int_7 { get; set; }
        [Column("ee_int_8")]
        public int? Ee_int_8 { get; set; }
        [Column("ee_int_9")]
        public int? Ee_int_9 { get; set; }
        [Column("ee_money_0")]
        public decimal? Ee_money_0 { get; set; }
        [Column("ee_money_1")]
        public decimal? Ee_money_1 { get; set; }
        [Column("ee_bit_0")]
        public bool? Ee_bit_0 { get; set; }
        [Column("ee_bit_1")]
        public bool? Ee_bit_1 { get; set; }
        [Column("ee_bit_2")]
        public bool? Ee_bit_2 { get; set; }
        [Column("ee_bit_3")]
        public bool? Ee_bit_3 { get; set; }
    }
}
