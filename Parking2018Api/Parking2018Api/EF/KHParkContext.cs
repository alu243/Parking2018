using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Parking2018Api.Models;

namespace Parking2018Api.EF
{
    public class KHParkContext : DbContext
    {

        public KHParkContext(DbContextOptions<KHParkContext> options) : base(options) { } // connction string name
        public KHParkContext() : base()
        {

        } // connction string name
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    connStr = optionsBuilder.Options.
        //    optionsBuilder.UseSqlServer(optionsBuilder.con.GetConnectionString("KHParkConnection"));
        //}

        public DbSet<M_AGECY_SYS_DATA> M_AGECY_SYS_DATA { get; set; }
        public DbSet<M_BILL> M_BILL { get; set; }
        public DbSet<M_BILL_REC> M_BILL_REC { get; set; }
        public DbSet<M_CAR_KIND> M_CAR_KIND { get; set; }
        public DbSet<M_CLASS> M_CLASS { get; set; }
        public DbSet<M_COLOR> M_COLOR { get; set; }
        public DbSet<M_DEFECTIVE_CAR> M_DEFECTIVE_CAR { get; set; }
        public DbSet<M_DEFECTIVE_USE> M_DEFECTIVE_USE { get; set; }
        public DbSet<M_FREE_CAR> M_FREE_CAR { get; set; }
        public DbSet<M_FREE_KIND> M_FREE_KIND { get; set; }
        public DbSet<M_GIRD> M_GIRD { get; set; }
        public DbSet<M_GIRD_TYPE> M_GIRD_TYPE { get; set; }
        public DbSet<M_KIND> M_KIND { get; set; }
        public DbSet<M_PDA_CLASS_WEAVE> M_PDA_CLASS_WEAVE { get; set; }
        public DbSet<M_PDA_GROUP> M_PDA_GROUP { get; set; }
        public DbSet<M_PDA_PARAMETER> M_PDA_PARAMETER { get; set; }
        public DbSet<M_PDA_PASSWORD> M_PDA_PASSWORD { get; set; }
        public DbSet<M_ROAD> M_ROAD { get; set; }
        public DbSet<M_SEQNO> M_SEQNO { get; set; }
        public DbSet<M_SPOILS_CAR> M_SPOILS_CAR { get; set; }
        public DbSet<M_SPOILSBILL> M_SPOILSBILL { get; set; }
        public DbSet<M_SYSTEM> M_SYSTEM { get; set; }
        public DbSet<M_TICKET> M_TICKET { get; set; }
        public DbSet<M_USERNM> M_USERNM { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // .HasAlternateKey = Unique Constraint
            // .HasIndex.IsUnique = Unique Index (must not null)
            modelBuilder.Entity<M_AGECY_SYS_DATA>().HasIndex(tb => tb.SEQ).IsUnique();

            modelBuilder.Entity<M_BILL>()
                .HasIndex(tb => new { tb.BT_NO, tb.BILL_NO }).IsUnique();
            modelBuilder.Entity<M_BILL_REC>()
                .HasIndex(tb => new { tb.SEQ_NO, tb.BILL_NO }).IsUnique();

            modelBuilder.Entity<M_CAR_KIND>()
                .HasIndex(tb => new { tb.CK_NO, tb.CK_NAME }).IsUnique();
            modelBuilder.Entity<M_CLASS>().HasIndex(tb => tb.CLASS_NO).IsUnique();
            modelBuilder.Entity<M_COLOR>().HasIndex(tb => tb.CLR_NO).IsUnique();

            modelBuilder.Entity<M_FREE_CAR>()
                .HasIndex(tb => new { tb.YEAR, tb.FK_NO, tb.PARK_NO }).IsUnique();
            modelBuilder.Entity<M_FREE_KIND>().HasIndex(tb => tb.FK_NO).IsUnique();

            modelBuilder.Entity<M_GIRD>().HasIndex(tb => tb.GIRD_NO).IsUnique();
            modelBuilder.Entity<M_GIRD_TYPE>().HasIndex(tb => tb.GT_NO).IsUnique();

            modelBuilder.Entity<M_KIND>().HasIndex(tb => tb.KIND_NO).IsUnique();

            modelBuilder.Entity<M_PDA_CLASS_WEAVE>()
                .HasIndex(tb => new { tb.C_DATE, tb.EMPY_NO, tb.ROAD_NO, tb.CLASS_NO }).IsUnique();
            modelBuilder.Entity<M_PDA_GROUP>()
                .HasIndex(tb => new { tb.PDA_NO, tb.EMPY_NO }).IsUnique();
            modelBuilder.Entity<M_PDA_PARAMETER>()
                .HasIndex(tb => new { tb.SYS_CODE, tb.CODE }).IsUnique();
            modelBuilder.Entity<M_PDA_PASSWORD>().HasIndex(tb => tb.C_DATE).IsUnique();

            modelBuilder.Entity<M_ROAD>().HasIndex(tb => tb.ROAD_NO).IsUnique();

            modelBuilder.Entity<M_SEQNO>().HasIndex(tb => tb.PDA_NO).IsUnique();

            modelBuilder.Entity<M_TICKET>()
                .HasIndex(tb => new { tb.YEAR, tb.IDENTITY_NO }).IsUnique();

            modelBuilder.Entity<M_USERNM>().HasIndex(tb => tb.EMPY_NO).IsUnique();
        }
    }
}
