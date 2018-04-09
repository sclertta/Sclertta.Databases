using Iatec.Databases.Aps;
using Microsoft.EntityFrameworkCore;

namespace Iatec.Databases
{
    public class ApsDbContext : DbContext
    {
        public ApsDbContext(DbContextOptions<ApsDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AllowanceAccumulator>().HasKey(c => new { c.PeriodId, c.ParentAllowanceId, c.ChildAllowanceId });
            modelBuilder.Entity<AllowanceAccumulator>().HasOne(x => x.Period).WithMany(x => x.AllowanceAccumulators).HasForeignKey(x => x.PeriodId);
        }
        // Table Mappings
        public DbSet<Allowance> Allowances { get; set; }
        public DbSet<AllowanceAccumulator> AllowanceAccumulators { get; set; }
        public DbSet<Entity> Entities { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentItem> PaymentItems { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonAddress> PersonAddresses { get; set; }
        public DbSet<PersonEmail> PersonEmails { get; set; }
        public DbSet<PersonPhone> PersonPhones { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<TypeAllowance> TypeAllowances { get; set; }

        // View Mappings
        public DbSet<VAddress> VAddresses { get; set; }
        public DbSet<VEmployee> VEmployees { get; set; }
        public DbSet<VEntity> VEntities { get; set; }
        public DbSet<VLocality> VLocality { get; set; }
        public DbSet<VTypePayment> VTypePayments { get; set; }
        public DbSet<VPayment> VPayments { get; set; }
        public DbSet<VVirtualEntityRow> VVirtualEntityRows { get; set; }
        public DbSet<VVirtualRelationshipRow> VVirtualRelationshipRows { get; set; }
    }
}
