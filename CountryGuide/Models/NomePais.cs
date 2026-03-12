using System.Text.Json.Serialization;

namespace CountryGuide.Models
{
    public class NomePais
    {
        [JsonPropertyName("common")]
        public string NomeConhecido { get; set; }
    }
}
