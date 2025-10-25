using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace Infrastructure.Context
{
    public partial class GMDbContext : DbContext
    {
        public GMDbContext() : base("name=GMDbContext")
        {

        }
        public virtual DbSet<Guard> Guards { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<Zone> Zones { get; set; }
        public virtual DbSet<GuardShifts> GuardShifts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guard>()
                .HasKey(g => g.Id);
            modelBuilder.Entity<Shift>()
                .HasKey(s => s.Id);
            modelBuilder.Entity<Zone>()
                .HasKey(z => z.Id);
            modelBuilder.Entity<GuardShifts>()
                .HasKey(gs => gs.Id);

            // Foriegn Keys and Relationships can be configured here if needed
            modelBuilder.Entity<GuardShifts>()
                .HasRequired<Guard>(gs => gs.Guard)
                .WithMany()
                .HasForeignKey(gs => gs.GuardId);
            modelBuilder.Entity<GuardShifts>()
                .HasRequired<Zone>(gs => gs.Zone)
                .WithMany()
                .HasForeignKey(gs => gs.ZoneId);
            modelBuilder.Entity<GuardShifts>()
                .HasRequired<Shift>(gs => gs.Shift)
                .WithMany()
                .HasForeignKey(gs => gs.ShiftId);

            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }
}
