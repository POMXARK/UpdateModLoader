using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModLoader.Model.Entities
{
    public class Context: DbContext
    {
        public DbSet<SynthiraRu> SynthiraRu { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            string devalopBase = "C:\\Users\\User\\source\\repos\\ModLoader\\ModLoader\\products.db";

            optionsBuilder.UseSqlite("Data Source=" + devalopBase);

            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
