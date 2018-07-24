using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sclertta.Databases.Personnel
{
    [Table("enrollment")]
    public class Enrollment
    {
        [Key, Column("id_enrollment")]
        public int Id { get; set; }
        [Column("code")]
        public string Code { get; set; }
        [Column("id_department")]
        public int? DepartmentId { get; set; }
        [ForeignKey("id_person")]
        public Person Person { get; set; }
        [ForeignKey("id_status")]
        public Status Status { get; set; }

        [Column("modified_by")]
        public string ModifiedBy { get; set; }
        [Column("date_modification")]
        public DateTime ModificationDate { get; set; }

        [Column("authorize")]
        public bool? Authorized { get; set; }
        [Column("authorized_by")]
        public string AuthorizedBy { get; set; }
        [Column("date_authorization")]
        public DateTime? AuthorizationDate { get; set; }
    }
}
