using Microsoft.EntityFrameworkCore;
using ModLoader.Model.Entities.Tables;


namespace ModLoader.Model.Entities.Base
{
    public class Context : DbContext
    {
        public DbSet<Games> Games { get; set; }
        public DbSet<ModCollection> ModCollections { get; set; }
        public DbSet<Pack> Packs { get; set; }
        public DbSet<Mod> Mods { get; set; }
        public DbSet<WebResource> WebResources { get; set; }

        // Сделать модель правил установки( для особых случаев) Имя мода: список файлов, установка.
        // 
        // Обработать modfile по шаблону , ожидать , перегружать при ошибке.
        //
        // бд реализовать функционал запоминания обновленных данных
        // переработать пaрсер! РЕФАКТОРИНГ
        // доработать парсер ( возможно стоит вынести в python soup, нет двойная работа по ORM, и беспорядок в архитектуре )
        // обновлять поле update из кода при парсинге единожды , если нет изменений
        // бд не загружать файлы если запись уже есть в базе данных    
        // отвязать скачивание и распаковку от парсера (искользовать бд как источник)

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            string developBase = "C:\\Users\\User\\source\\repos\\POMXARK\\UpdateModLoader\\ModLoader\\products.db";

            optionsBuilder.UseSqlite("Data Source=" + developBase);

            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
