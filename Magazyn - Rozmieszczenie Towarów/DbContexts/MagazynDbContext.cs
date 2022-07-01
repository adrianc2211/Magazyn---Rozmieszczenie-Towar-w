using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazyn___Rozmieszczenie_Towarów.DTO_s;
using Microsoft.EntityFrameworkCore;

namespace Magazyn___Rozmieszczenie_Towarów.DbContexts
{
    public class MagazynDbContext:DbContext
    {
        //DTO- data transfer object - przenosi dane między bazą danych a aplikacją
        public DbSet<towaryDTO> Towary { get; set; }
        
    }
}
