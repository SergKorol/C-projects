using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NetCoreSqlServerDockerTutorial
{
    public partial class TutorialDatabaseContext : DbContext
    {
        public TutorialDatabaseContext()
        {
        }

        public TutorialDatabaseContext(DbContextOptions<TutorialDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TutorialTable> TutorialTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost,1433\\Catalog=tutorial_database;Database=TutorialDatabase;User=SA;Password=SuperSecurePassword!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TutorialTable>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
            });
        }
    }
}
