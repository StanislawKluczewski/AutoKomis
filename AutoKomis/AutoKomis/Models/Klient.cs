using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AutoKomis.Models
{
    public class Klient
    {

        [Key]
        [DisplayName("Id Klienta")]
        public int IdKlienta { get; set; }

        public Sprzedaz Sprzedaz { get; set; }

        public ICollection<Sprzedaz>Sprzedaze { get; set; }

        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        [DisplayName("Nr Dowodu")]
        public string NrDowodu { get; set; }
    }
}
