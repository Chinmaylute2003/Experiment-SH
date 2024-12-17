using CRM.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTestApp
{

    public interface IHasId
    {
        int Id { get; set; }
    }
    public class CollectionContext<T> : DbContext where T : class, IHasId
    {
        private readonly string tableName;
        public DbSet<T> Users { get; set; }
        public CollectionContext(string tableName)
        {
            this.tableName = tableName;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString = "data source=shc-sql-01.database.windows.net ; database=HangFireCatalog_VG; User Id=tmgreadonly; Password=#p7P>Wzs;";
            optionsBuilder.UseSqlServer(conString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<T>((e) =>
            {
                e.HasKey(e => e.Id);
            });
            modelBuilder.Entity<T>().ToTable(tableName);
        }
    }
}
