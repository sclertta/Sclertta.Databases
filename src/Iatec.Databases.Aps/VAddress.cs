using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Iatec.Databases.Aps
{
    [Table("v_address")]
    public class VAddress
    {
        [Key, Column("id_address")]
        public int Id { get; set; }
        [ForeignKey("id_person")]
        public Person Person { get; set; }
        [Column("id_locality")]
        public int LocalityId { get; set; }
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
        [Column("char_6")]
        public string Char6 { get; set; }
        [Column("id_status")]
        public short StatusId { get; set; }
        [Column("id_country")]
        public short ContryId { get; set; }
        [Column("code")]
        public string Code { get; set; }
        [Column("level")]
        public byte Level { get; set; }
        [Column("level_name")]
        public string LevelName { get; set; }
        [Column("name")]
        public string City { get; set; }
        [Column("locality_name")]
        public string LocalityName { get; set; }
        [Column("locality_state")]
        public string LocalityState { get; set; }
        [Column("status_code")]
        public string StatusCode { get; set; }
        [Column("description")]
        public string Description { get; set; }
    }
}
