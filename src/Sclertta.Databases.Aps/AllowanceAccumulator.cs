using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sclertta.Databases.Personnel
{
    [Table("allowance_accumulator")]
    public class AllowanceAccumulator
    {
        [Column("id_period")]
        public int PeriodId { get; set; }
        [Column("PARENT_id_allowance")]
        public int ParentAllowanceId { get; set; }
        [Column("CHILD_id_allowance")]
        public int ChildAllowanceId { get; set; }

        public Period Period { get; set; }
        public Allowance ParentAllowance { get; set; }
        public Allowance ChildAllowance { get; set; }
    }
}
