using System.Text.Json.Serialization;

namespace CountryGuide.Models
{
    public class Pais
    {
        [JsonPropertyName("name")]
        public NomePais Nome { get; set; }
        [JsonPropertyName("capital")]
        public List<string> Capital { get; set; }
        [JsonPropertyName("flag")]
        public string Bandeira { get; set; }
        [JsonPropertyName("languages")]
        public Dictionary<string, string> Idioma { get; set; }
        [JsonPropertyName("area")]
        public Double Area { get; set;}
        [JsonPropertyName("population")]
        public int Populacao { get; set;}
    }
}
