using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoKomis.Models
{
    public class Pracownik
    {
        [Key]
        public int IdPracownika { get; set; }
        
        [ForeignKey("IdKomisu")]
        public int IdKomisu { get; set; }
        public Komis Komis { get; set; }

        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Stanowisko { get; set; }

        [DisplayName("Numer Dowodu")]
        public string NrDowodu { get; set; }
    }
}
