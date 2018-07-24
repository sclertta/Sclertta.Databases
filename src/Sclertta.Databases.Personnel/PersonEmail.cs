using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sclertta.Databases.Personnel
{
    [Table("person_email")]
    public class PersonEmail
    {
        [Key, Column("id_email")]
        public int Id { get; set; }
        [ForeignKey("id_person")]
        public Person Person { get; set; }
        [Column("char_0")]
        public string Email { get; set; }
        [Column("char_1")]
        public string Observation { get; set; }
        [Column("char_2")]
        public string Char2 { get; set; }
        [ForeignKey("id_status")]
        public Status Status { get; set; }
        [Column("bit_0")]
        public bool? Bool0 { get; set; }
        [Column("datetime_0")]
        public DateTime? Datetime0 { get; set; }
    }
}
