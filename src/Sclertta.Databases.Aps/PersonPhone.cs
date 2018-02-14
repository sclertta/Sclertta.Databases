using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sclertta.Databases.Personnel
{
    [Table("person_phone")]
    public class PersonPhone
    {
        [Key, Column("id_phone")]
        public int Id { get; set; }
        [ForeignKey("id_person")]
        public Person Person { get; set; }
        [Column("char_0")]
        public string Prefix { get; set; }
        [Column("char_1")]
        public string Number { get; set; }
        [Column("char_2")]
        public string AdditionalInfo { get; set; }
        [ForeignKey("id_status")]
        public Status Status { get; set; }
        [Column("bit_0")]
        public bool? Bool0 { get; set; }
        [Column("datetime_0")]
        public DateTime? Datetime0 { get; set; }
    }
}
