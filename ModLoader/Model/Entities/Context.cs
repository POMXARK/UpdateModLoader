using Microsoft.EntityFrameworkCore;
using ModLoader.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModLoader.Model.Entities
{
    public class Context: DbContext
    {
        public DbSet<Games> Games { get; set; }
        public DbSet<ModCollection> ModCollections { get; set; }
        public DbSet<Pack> Packs { get; set; }
        public DbSet<Mod> Mods { get; set; }
        public DbSet<WebResource> WebResources { get; set; }


        public DbSet<SynthiraRu> SynthiraRu { get; set; }


        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            string developBase = "C:\\Users\\User\\source\\repos\\ModLoader\\ModLoader\\products.db";

            optionsBuilder.UseSqlite("Data Source=" + developBase);

            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
