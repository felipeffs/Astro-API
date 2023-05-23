namespace Atv1Astrologia.Model
{
    public class ZodiacProfilePostModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = "";
        public ZodiacSign Sign { get; set; }
    }
}
