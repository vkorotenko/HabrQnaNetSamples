#region License
// // Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// // email: koroten@ya.ru
// // skype:vladimir-korotenko
// // https://vkorotenko.ru
// // Создано:  14.05.2020 14:03
#endregion

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Kvn.HabrQnaNetSamples.Dbl
{

    public class MySqlDataContext : DbContext
    {
        public class MysqlDataTestItem
        {
            [Key]
            public int Id { get; set; }
            [Display(Name = "Комментарии")]
            public string Comment { get; set; }
        }

        public MySqlDataContext()
        {
            Database.EnsureCreated();
            Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = "server=localhost;database=habrqna;uid=habrqna;pwd=habrqnahabrqna_";
            optionsBuilder.UseMySql(conn);
        }
        public DbSet<MysqlDataTestItem> Items { get; set; }
    }
}
