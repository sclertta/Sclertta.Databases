using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sclertta.Databases.Personnel
{
    [Table("v_type_payment")]
    public class VTypePayment
    {
        [Key, Column("id_type_payment")]
        public int Id { get; set; }
        [Column("id_type_object")]
        public string IdTypeObject { get; set; }
        [Column("object")]
        public string Object { get; set; }
    }
}
