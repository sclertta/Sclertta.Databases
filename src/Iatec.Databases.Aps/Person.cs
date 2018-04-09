using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Iatec.Databases.Aps
{
    [Table("person")]
    public class Person
    {
        [Key, Column("id_person")]
        public int Id { get; set; }
        [Column("datetime_0")]
        public DateTime? DateTime0 { get; set; }
        [Column("datetime_1")]
        public DateTime? DateTime1 { get; set; }
        [Column("datetime_2")]
        public DateTime? DateTime2 { get; set; }
        [Column("int_0")]
        public int? Int0 { get; set; }
        [Column("int_1")]
        public int? Int1 { get; set; }
        [Column("char_0")]
        public string Char0 { get; set; }
        [Column("char_1")]
        public string Password { get; set; }
        [Column("char_2")]
        public string Char2 { get; set; }
        [Column("char_3")]
        public string Char3 { get; set; }
        [ForeignKey("id_status")]
        public Status Status { get; set; }
        [Column("code_national")]
        public string DocumentNumber { get; set; }
        [Column("id_object_class")]
        public int? ObjectClassId { get; set; }
        [Column("bit_0")]
        public bool? Bit0 { get; set; }
        [Column("bit_1")]
        public bool? Bit1 { get; set; }

        public List<PersonEmail> Emails { get; set; }
        public List<PersonPhone> Phones { get; set; }
        public List<Enrollment> Enrollments { get; set; }
        public List<PersonAddress> Addresses { get; set; }

        public List<VAddress> VAddresses { get; set; }
    }
}
