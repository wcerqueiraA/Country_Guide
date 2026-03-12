namespace CountryGuide.Models
{
    public class Pais
    {
        public string Nome { get; set; }
        public string Capital { get; set; }
        public List<string> Idioma { get; set; }
        public Double Area { get; set;}
        public Double Populacao { get; set;}
    }
}
