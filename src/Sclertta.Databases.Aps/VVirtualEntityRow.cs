using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sclertta.Databases.Personnel
{
    [Table("v_virtual_entity_row")]
    public class VVirtualEntityRow
    {
        [Key, Column("id_virtual_entity_row")]
        public int Id { get; set; }
        [Column("entity_id_object")]
        public int Entity_id_object { get; set; }
        [Column("entity_id_type_object")]
        public string Entity_id_type_object { get; set; }
        [Column("entity_object")]
        public string EntityObject { get; set; }
        [Column("code")]
        public string Code { get; set; }
        [Column("id_virtual_entity")]
        public int VirtualEntityId { get; set; }
        [Column("char_0")]
        public string Char_0 { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("datetime_0")]
        public DateTime? Datetime_0 { get; set; }
        [Column("char_1")]
        public string Char_1 { get; set; }
        [Column("datetime_1")]
        public DateTime? Datetime_1 { get; set; }
        [Column("datetime_2")]
        public DateTime? Datetime_2 { get; set; }
        [Column("float_0")]
        public float? Float_0 { get; set; }
        [Column("float_1")]
        public float? Float_1 { get; set; }
        [Column("char_2")]
        public string Char_2 { get; set; }
        [Column("char_3")]
        public string Char_3 { get; set; }
        [Column("datetime_3")]
        public DateTime? Datetime_3 { get; set; }
        [Column("float_2")]
        public float? Float_2 { get; set; }
        [Column("float_3")]
        public float? Float_3 { get; set; }
        [Column("int_0")]
        public int? Int_0 { get; set; }
        [Column("int_1")]
        public int? Int_1 { get; set; }
        [Column("int_2")]
        public int? Int_2 { get; set; }
        [Column("money_0")]
        public decimal? Money_0 { get; set; }
        [Column("int_3")]
        public int? Int_3 { get; set; }
        [Column("money_1")]
        public decimal? Money_1 { get; set; }
        [Column("int_4")]
        public int? Int_4 { get; set; }
        [Column("money_2")]
        public decimal? Money_2 { get; set; }
        [Column("int_5")]
        public int? Int_5 { get; set; }
        [Column("bit_0")]
        public bool? Bit_0 { get; set; }
        [Column("bit_1")]
        public bool? Bit_1 { get; set; }
        [Column("bit_2")]
        public bool? Bit_2 { get; set; }
        [Column("bit_3")]
        public bool? Bit_3 { get; set; }

    }
}
