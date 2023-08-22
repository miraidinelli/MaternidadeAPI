using MaternidadeAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace MaternidadeAPI.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        public DbSet<MaeModel> Mae { get; set; }
        public DbSet<RecemNascidoModel> RecemNascido { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-QHFSSE2\\MSSQLSERVER01;database=maternidadedb;trusted_connection=true;TrustServerCertificate=True");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RecemNascidoModel>()
                .HasOne(r => r.Mae)
                .WithMany(m => m.Filhos)
                .HasForeignKey(m => m.Id);
        }
    }
}
