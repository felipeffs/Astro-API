using Microsoft.AspNetCore.Components.Web;

namespace Atv1Astrologia.Model
{
    public class ZodiacProfilePostModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Description { get; set; } = "";
        public DateTime BirthDate { get; set; }
        public bool Membership { get; set; }
    }
}
