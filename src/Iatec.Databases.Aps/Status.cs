using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Iatec.Databases.Aps
{
    [Table("status")]
    public class Status
    {
        [Key, Column("id_status")]
        public short Id { get; set; }
        [Column("code")]
        public string Code { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("person")]
        public bool Person { get; set; }
        [Column("enrollment")]
        public bool Enrollment { get; set; }
        [Column("address")]
        public bool Address { get; set; }
        [Column("phone")]
        public bool Phone { get; set; }
        [Column("email")]
        public bool Email { get; set; }
        [Column("is_unique")]
        public bool IsUnique { get; set; }
        [Column("bank_account")]
        public bool BankAccount { get; set; }
        [Column("ACTIVE")]
        public bool Active { get; set; }

    }
}
