using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sclertta.Databases.Personnel
{
    [Table("period")]
    public class Period
    {
        [Key, Column("id_period")]
        public int Id { get; set; }
        [Column("date_begining")]
        public DateTime Begin { get; set; }
        [Column("date_ending")]
        public DateTime End { get; set; }
        [Column("year")]
        public short Year { get; set; }
        [Column("period")]
        public byte Month { get; set; }

        public List<AllowanceAccumulator> AllowanceAccumulators { get; set; }
    }
}
