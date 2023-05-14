namespace Atv1Astrologia.Model
{
    public class Zodiac
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ZodiacSign Sign{get; set;}

    }

public enum ZodiacSign
{
    Aries,
    Touro,
    Gemeos,
    Cancer,
    Leao,
    Virgem,
    Libra,
    Escorpiao,
    Sagitario,
    Capricornio,
    Aquario,
    Peixes
}
}
