using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AutoKomis.Models
{
    public class Komis
    {
        [Key]
        public int Id { get; set; }

        public ICollection<Pracownik>Pracownicy{ get; set; }

        public ICollection<Auto>Auta { get; set; }

        public string Nazwa { get; set; }

        public string Miasto { get; set; }
        public string Ulica { get; set; }

        [DisplayName("Kod Pocztowy")]
        public string KodPocztowy { get; set; }

        public string KRS { get; set; }

        public string NIP { get; set; }

        [DisplayName("Imie Właściciela")]
        public string ImieWlasciciela { get; set; }

        [DisplayName("Nazwisko Właściciela")]
        public string NazwiskoWlasciciela { get; set; }

        [DisplayName("Miesięczne Koszty Utrzymania")]
        public decimal KosztyUtrzymanieMiesieczne { get; set; }
    }
}
