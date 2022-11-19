namespace AutoKomis.DTO.Response
{
    public class SprzedazRespone
    {
        public int IdSamochodu { get; set; }
        public int IdPracownika { get; set; }
        public int IdKlienta { get; set; }
        public DateTime DataZawarciaUmowy { get; set; }
        public decimal Kwota { get; set; }
    }
}
