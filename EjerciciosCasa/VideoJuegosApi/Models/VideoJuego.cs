namespace VideoJuegosApi.Models
{
    public class VideoJuego
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public int YearLanzamiento { get; set; }
        public int EdadMin { get; set; }
        public string Company { get; set; }
    }
}