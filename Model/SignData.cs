using System.Text.Json.Serialization;

namespace Atv1Astrologia.Model
{
    public struct SignData
    {
        [JsonPropertyName("colorDay")]
        public string ColorDay { get; set; }

        [JsonPropertyName("drink")]
        public string Drink { get; set; }

        [JsonPropertyName("number")]
        public int Number { get; set; }

        public SignData(string colorDay, string drink, int number)
        {
           ColorDay = colorDay;
           Drink = drink;
           Number = number;
        }

    }
}
