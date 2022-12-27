namespace AutoKomis.DTO.Request
{
    public class KomisRequest
    {
        public int Id { get; set; }
        public string ImieWlasciciela { get; set; }
        public string NazwiskoWlasciciela { get; set; }
        public decimal KosztyUtrzymanieMiesieczne { get; set; }
    }
}
