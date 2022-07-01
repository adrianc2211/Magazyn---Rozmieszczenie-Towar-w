using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn___Rozmieszczenie_Towarów.DTO_s
{
    public class towaryDTO
    {
        [Key]
        public Guid IdTowaru { get; set; }
        public string nazwa_towaru { get; set; }
        public int waga { get; set; }
    }
}
