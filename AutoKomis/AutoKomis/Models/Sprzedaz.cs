using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoKomis.Models
{
    public class Sprzedaz
    {
        [Key]
        public int IdSprzedazy { get; set; }
        [ForeignKey("IdSamochodu")]
        public int IdSamochodu { get; set; }
        [ForeignKey("IdPracownika")]
        public int IdPracownika { get; set; }
        [ForeignKey("IdKlienta")]
        public int IdKlienta { get; set; }

        public ICollection<Auto> Auta { get; set; }

        public Klient Klient{ get; set; }

        public DateTime DataZawarciaUmowy{ get; set; }
        public decimal Kwota{ get; set; }
    }
}
