using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using System;

namespace Domain.Repositories
{
    public partial class Context : DbContext
    {
        public virtual DbSet<TestTable> TestTable { get; set; }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder
        //        .Entity<BankRecAnalystRecomandationOverview>(br =>
        //        {
        //            br.HasNoKey();
        //        });
        //}
    }
}
