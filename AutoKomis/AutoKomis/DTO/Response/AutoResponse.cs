using System.ComponentModel;

namespace AutoKomis.DTO.Response
{
    public class AutoResponse
    {
        [DisplayName("Marka")]
        public string Marka { get; set; }

        [DisplayName("Model")]
        public string Model { get; set; }

        [DisplayName("Rok produkcji")]
        public string RokProdukcji { get; set; }
        public string Vin { get; set; }
        public string Przebieg { get; set; }
        public string Cena { get; set; }
        public string Kolor { get; set; }

        [DisplayName("Pojemność Silnika")]
        public double PojemnoscSilnika { get; set; }

        [DisplayName("Typ Nadwozia")]
        public string TypNadwozia { get; set; }

        [DisplayName("Rodzaj Paliwa")]
        public string RodzajPaliwa { get; set; }
        public char Segment { get; set; }

        [DisplayName("Ilość Drzwi")]
        public int IloscDrzwi { get; set; }

        [DisplayName("Czy Dostępny")]
        public bool CzyDostepny { get; set; }
    }
}
