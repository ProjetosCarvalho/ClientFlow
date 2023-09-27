using Microsoft.EntityFrameworkCore;
using ProjetoCRUD_Mysql.Models;

namespace ProjetoCRUD_Mysql.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            :base(options) 
        {
            
        }
        public DbSet<Cliente> Cliente { get; set; }
    }
}
