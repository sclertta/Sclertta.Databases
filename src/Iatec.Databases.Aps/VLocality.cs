using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Iatec.Databases.Aps
{
    [Table("v_locality")]
    public class VLocality
    {
        [Key, Column("id_locality")]
        public int Id { get; set; }
        [Column("id_country")]
        public short CountryId { get; set; }
        [Column("code")]
        public string Code { get; set; }
        [Column("level")]
        public byte? Level { get; set; }
        [Column("level_name")]
        public string LevelName { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("locality_name")]
        public string LocalityName { get; set; }
        [Column("locality_state")]
        public string LocalityState { get; set; }
    }
}
