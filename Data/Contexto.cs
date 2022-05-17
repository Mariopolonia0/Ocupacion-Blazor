using Microsoft.EntityFrameworkCore;
using projectoOcupacion.Models;

namespace projectoOcupacion.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Ocupacion>? ocupacions {set; get;}

        protected override void OnConfiguring(DbContextOptionsBuilder builder){
            builder.UseSqlite(@"data source= DataBase\Ocupacion.db");
        }
    }
}