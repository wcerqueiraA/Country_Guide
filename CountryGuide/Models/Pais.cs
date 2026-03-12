using System.Text.Json.Serialization;

namespace CountryGuide.Models
{
    public class Pais
    {
        [JsonPropertyName("name")]
        public string Nome { get; set; }
        [JsonPropertyName("capital")]
        public string Capital { get; set; }
        [JsonPropertyName("languages")]
        public List<string> Idioma { get; set; }
        [JsonPropertyName("area")]
        public Double Area { get; set;}
        [JsonPropertyName("population")]
        public int Populacao { get; set;}
    }
}
