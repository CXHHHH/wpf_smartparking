using Microsoft.EntityFrameworkCore;
using ServerModel;
using System;

namespace ServerEFcore
{
    public class EFcoreContext:DbContext
    {
        public EFcoreContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=F:\\C#Study\\Project\\wpf_smartparking\\project.db");
        }

        public DbSet<UserModel> entities { get; set; }
    }
}
