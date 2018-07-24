using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sclertta.Databases.Personnel
{
    [Table("v_payment")]
    public class VPayment
    {
        [Key, Column("id_payment")] public int Id { get; set; }
        [Column("id_entity")] public int Id_entity { get; set; }
        [Column("id_department")] public int Id_department { get; set; }
        [Column("entity_name")] public string Entity_name { get; set; }
        [Column("department_name")] public string DepartmentName { get; set; }
        [Column("entity_code_national")] public string Entity_code_national { get; set; }
        [Column("department_code_national")] public string Department_code_national { get; set; }
        [Column("entity_code")] public string Entity_code { get; set; }
        [Column("department_code")] public string Department_code { get; set; }
        [Column("employee_code_national")] public string Employee_code_national { get; set; }
        [Column("id_employee")] public int Id_employee { get; set; }
        [Column("prefix")] public string Prefix { get; set; }
        [Column("name_first")] public string Name_first { get; set; }
        [Column("name_midle")] public string Name_midle { get; set; }
        [Column("name_last")] public string Name_last { get; set; }
        [Column("sufix")] public string Sufix { get; set; }
        [Column("id_gender")] public int? Id_gender { get; set; }
        [Column("id_marital_status")] public int? Id_marital_status { get; set; }
        [Column("date_birth")] public DateTime? Date_birth { get; set; }
        [Column("name_regular")] public string Name_regular { get; set; }
        [Column("name_full")] public string FullName { get; set; }
        [Column("date_first_hire")] public DateTime? Date_first_hire { get; set; }
        [Column("id_enrollment")] public int EnrollmentId { get; set; }
        [Column("employee_id_department")] public int? Employee_id_department { get; set; }
        [Column("enrollment_code")] public string EnrollmentCode { get; set; }
        [Column("id_job_title")] public int? Id_job_title { get; set; }
        [Column("date_hired")] public DateTime Date_hired { get; set; }
        [Column("payment_method")] public byte Payment_method { get; set; }
        [Column("id_employee_group")] public int Id_employee_group { get; set; }
        [Column("group_code")] public string Group_code { get; set; }
        [Column("group_name")] public string Group_name { get; set; }
        [Column("assignment_name")] public string Assignment_name { get; set; }
        [Column("assignment_code")] public string Assignment_code { get; set; }
        [Column("job_title_name")] public string Job_title_name { get; set; }
        [Column("job_title_code")] public string Job_title_code { get; set; }
        [Column("carteira_trabalho_numero")] public string Carteira_trabalho_numero { get; set; }
        [Column("carteira_trabalho_serie")] public string Carteira_trabalho_serie { get; set; }
        [Column("date_termination")] public DateTime? Date_termination { get; set; }
        [Column("status_active")] public bool Status_active { get; set; }
        [Column("ee_int_0")] public int? Ee_int_0 { get; set; }
        [Column("ee_bit_0")] public bool? Ee_bit_0 { get; set; }
        [Column("ee_char_8")] public string Ee_char_8 { get; set; }
        [Column("id_period")] public int PeriodId { get; set; }
        [Column("id_type_payment")] public int PaymentTypeId { get; set; }
        [Column("payment_datetime_0")] public DateTime? Payment_datetime_0 { get; set; }
        [Column("payment_datetime_1")] public DateTime? Payment_datetime_1 { get; set; }
        [Column("payment_datetime_2")] public DateTime? Payment_datetime_2 { get; set; }
        [Column("payment_datetime_3")] public DateTime? Payment_datetime_3 { get; set; }
        [Column("payment_datetime_4")] public DateTime? Payment_datetime_4 { get; set; }
        [Column("payment_datetime_5")] public DateTime? Payment_datetime_5 { get; set; }
        [Column("payment_datetime_6")] public DateTime? Payment_datetime_6 { get; set; }
        [Column("payment_datetime_7")] public DateTime? Payment_datetime_7 { get; set; }
        [Column("payment_datetime_8")] public DateTime? Payment_datetime_8 { get; set; }
        [Column("payment_char_0")] public string Payment_char_0 { get; set; }
        [Column("payment_char_1")] public string Payment_char_1 { get; set; }
        [Column("payment_char_2")] public string Payment_char_2 { get; set; }
        [Column("payment_char_3")] public string Payment_char_3 { get; set; }
        [Column("payment_int_0")] public int? Payment_int_0 { get; set; }
        [Column("payment_int_1")] public int? Payment_int_1 { get; set; }
        [Column("payment_int_2")] public int? Payment_int_2 { get; set; }
        [Column("payment_int_3")] public int? Payment_int_3 { get; set; }
        [Column("payment_money_1")] public decimal? Payment_money_1 { get; set; }
        [Column("payment_money_0")] public decimal? Payment_money_0 { get; set; }
        [Column("id_accounting")] public string Id_accounting { get; set; }
        [Column("voided_id_accounting")] public string Voided_id_accounting { get; set; }
        [Column("payment_float_0")] public double? Payment_float_0 { get; set; }
        [Column("payment_float_1")] public double? Payment_float_1 { get; set; }
        [Column("id_payment_item")] public int id_payment_item { get; set; }
        [Column("id_allowance")] public int AllowanceId { get; set; }
        [Column("value")] public decimal Value { get; set; }
        [Column("item_datetime_0")] public DateTime? Item_datetime_0 { get; set; }
        [Column("item_char_0")] public string Item_char_0 { get; set; }
        [Column("item_char_1")] public string Item_char_1 { get; set; }
        [Column("item_char_2")] public string Item_char_2 { get; set; }
        [Column("item_int_0")] public int? Item_int_0 { get; set; }
        [Column("item_int_1")] public int? Item_int_1 { get; set; }
        [Column("item_money_0")] public decimal? Item_money_0 { get; set; }
        [Column("item_money_1")] public decimal? Item_money_1 { get; set; }
        [Column("item_money_2")] public decimal? Item_money_2 { get; set; }
        [Column("item_money_3")] public decimal? Item_money_3 { get; set; }
        [Column("item_money_4")] public decimal? Item_money_4 { get; set; }
        [Column("item_money_5")] public decimal? Item_money_5 { get; set; }
        [Column("item_money_6")] public decimal? Item_money_6 { get; set; }
        [Column("item_money_7")] public decimal? Item_money_7 { get; set; }
        [Column("item_money_8")] public decimal? Item_money_8 { get; set; }
        [Column("item_money_9")] public decimal? Item_money_9 { get; set; }
        [Column("item_float_0")] public double? Item_float_0 { get; set; }
        [Column("item_float_1")] public double? Item_float_1 { get; set; }
        [Column("item_float_2")] public double? Item_float_2 { get; set; }
        [Column("item_float_3")] public double? Item_float_3 { get; set; }
        [Column("item_float_4")] public double? Item_float_4 { get; set; }
        [Column("typed")] public byte? Typed { get; set; }
        [Column("allowance_code")] public string AllowanceCode{ get; set; }
        [Column("allowance_name")] public string AllowanceName { get; set; }
        [Column("regimen")] public byte Regimen { get; set; }
        [Column("salary")] public byte Salary { get; set; }
        [Column("stub")] public byte Stub { get; set; }
        [Column("allowance_char_0")] public string Allowance_char_0 { get; set; }
        [Column("signal")] public string Signal { get; set; }
        [Column("net_payment")] public bool IsNetPayment { get; set; }
        [Column("name")] public string Name { get; set; }
        [Column("type_payment")] public string PaymentTypeCode { get; set; }
        [Column("year")] public short PeriodYear { get; set; }
        [Column("period")] public byte PeriodMonth { get; set; }
        [Column("id_type_period")] public short Id_type_period { get; set; }
        [Column("date_payment")] public DateTime? Date_payment { get; set; }
        [Column("payment_id_job_title")] public int? Payment_id_job_title { get; set; }
        [Column("personal_account_code")] public string Personal_account_code { get; set; }
        [Column("calculated_by")] public string Calculated_by { get; set; }
        [Column("calculation_date")] public DateTime? Calculation_date { get; set; }
        [Column("authorized_by")] public string Authorized_by { get; set; }
        [Column("authorization_date")] public DateTime? Authorization_date { get; set; }
        [Column("posted_by")] public string Posted_by { get; set; }
        [Column("post_date")] public DateTime? Post_date { get; set; }

    }
}
