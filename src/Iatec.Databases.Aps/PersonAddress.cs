using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Iatec.Databases.Aps
{
    [Table("person_address")]
    public class PersonAddress
    {
        [Key, Column("id_address")]
        public int Id { get; set; }
        [ForeignKey("id_person")]
        public Person Person { get; set; }
        [ForeignKey("id_locality")]
        public VLocality Locality { get; set; }
        [Column("char_0")]
        public string Street { get; set; }
        [Column("char_1")]
        public string Number { get; set; }
        [Column("char_2")]
        public string Neighborhood { get; set; }
        [Column("char_3")]
        public string Supplement { get; set; }
        [Column("char_4")]
        public string ZipCode { get; set; }
        [Column("char_5")]
        public string Char5 { get; set; }
        [ForeignKey("id_status")]
        public Status Status { get; set; }
        [Column("char_6")]
        public string Char6 { get; set; }
        [Column("int_0")]
        public int? Int0 { get; set; }
        [Column("int_1")]
        public int? Int1 { get; set; }
        [Column("datetime_0")]
        public DateTime? ModifiedDate { get; set; }
    }
}
