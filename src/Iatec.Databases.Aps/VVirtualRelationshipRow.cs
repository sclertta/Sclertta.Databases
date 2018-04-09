using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Iatec.Databases.Aps
{
    [Table("v_virtual_relationship_row")]
    public class VVirtualRelationshipRow
    {
        [Column("relationship_id_type_object")]
        public string RelationshipObjectType { get; set; }
        [Column("relationship_object")]
        public string RelationshipObject { get; set; }
        [Column("t1_id_type_object")]
        public string T1_id_type_object { get; set; }
        [Column("t1_object")]
        public string T1_object { get; set; }
        [Column("t2_id_type_object")]
        public string T2_id_type_object { get; set; }
        [Column("t2_object")]
        public string T2_object { get; set; }
        [Column("t3_id_type_object")]
        public string T3_id_type_object { get; set; }
        [Column("t3_object")]
        public string T3_object { get; set; }
        [Column("t4_id_type_object")]
        public string T4_id_type_object { get; set; }
        [Column("t4_object")]
        public string T4_object { get; set; }
        [Column("t5_id_type_object")]
        public string T5_id_type_object { get; set; }
        [Column("t5_object")]
        public string T5_object { get; set; }
        [Column("t6_id_type_object")]
        public string T6_id_type_object { get; set; }
        [Column("t6_object")]
        public string T6_object { get; set; }
        [Column("t1_cardinality")]
        public int? T1_cardinality { get; set; }
        [Column("t2_cardinality")]
        public int? T2_cardinality { get; set; }
        [Column("t3_cardinality")]
        public int? T3_cardinality { get; set; }
        [Column("t4_cardinality")]
        public int? T4_cardinality { get; set; }
        [Column("t5_cardinality")]
        public int? T5_cardinality { get; set; }
        [Column("t6_cardinality")]
        public int? T6_cardinality { get; set; }
        [Column("t1_id_object")]
        public int? T1_id_object { get; set; }
        [Column("t2_id_object")]
        public int? T2_id_object { get; set; }
        [Column("t3_id_object")]
        public int? T3_id_object { get; set; }
        [Column("t4_id_object")]
        public int? T4_id_object { get; set; }
        [Column("t5_id_object")]
        public int? T5_id_object { get; set; }
        [Column("t6_id_object")]
        public int? T6_id_object { get; set; }
        [Key, Column("id_virtual_relationship_row")]
        public long Id_virtual_relationship_row { get; set; }
        [Column("id_virtual_relationship")]
        public int Id_virtual_relationship { get; set; }
        [Column("T1_pk")]
        public long T1_pk { get; set; }
        [Column("T2_pk")]
        public long? T2_pk { get; set; }
        [Column("char_0")]
        public string Char_0 { get; set; }
        [Column("T3_pk")]
        public long? T3_pk { get; set; }
        [Column("T4_pk")]
        public long? T4_pk { get; set; }
        [Column("datetime_0")]
        public DateTime? DateTime_0 { get; set; }
        [Column("T5_pk")]
        public long? T5_pk { get; set; }
        [Column("char_1")]
        public string Char_1 { get; set; }
        [Column("T6_pk")]
        public long? T6_pk { get; set; }
        [Column("datetime_1")]
        public DateTime? DateTime_1 { get; set; }
        [Column("datetime_2")]
        public DateTime? DateTime_2 { get; set; }
        [Column("float_0")]
        public double? Float_0 { get; set; }
        [Column("float_1")]
        public double? Float_1 { get; set; }
        [Column("char_2")]
        public string Char_2 { get; set; }
        [Column("datetime_3")]
        public DateTime? DateTime_3 { get; set; }
        [Column("char_3")]
        public string Char_3 { get; set; }
        [Column("float_2")]
        public double? Float_2 { get; set; }
        [Column("money_0")]
        public decimal? Money_0 { get; set; }
        [Column("float_3")]
        public double? Float_3 { get; set; }
        [Column("money_1")]
        public decimal? Money_1 { get; set; }
        [Column("int_0")]
        public int? Int_0 { get; set; }
        [Column("int_1")]
        public int? Int_1 { get; set; }
        [Column("int_2")]
        public int? Int_2 { get; set; }
        [Column("int_3")]
        public int? Int_3 { get; set; }
        [Column("int_4")]
        public int? Int_4 { get; set; }
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
        [Column("text_0")]
        public string Text_0 { get; set; }

    }
}
