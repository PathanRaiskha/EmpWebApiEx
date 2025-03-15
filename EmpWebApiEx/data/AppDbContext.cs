using EmpWebApiEx.model.entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EmpWebApiEx.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<employ> employ { get; set; }
    }

}
