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

        [JsonPropertyName("element")]
        public string Element { get; set; }

        [JsonPropertyName("flower")]
        public string Flower { get; set; }

        [JsonPropertyName("love")]
        public string Love { get; set; }

        public SignData(string colorDay, string drink, int number, string element, string flower, string love)
        {
           ColorDay = colorDay;
           Drink = drink;
           Number = number;
           Element = element;
           Flower = flower;
           Love = love;     
        }

    }
}
