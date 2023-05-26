using Microsoft.Build.ObjectModelRemoting;

namespace Atv1Astrologia.Model
{
    public class ZodiacProfile
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Description { get; set; } = "";
        public DateTime BirthDate { get; set; }
        public bool Membership { get; set; }
        public ZodiacSign Sign => DateCalc(BirthDate);
        public string SignName => Sign.ToString();
        public SignData SignData => HoroscopeManager.Instance.Info[Sign];
        
        private ZodiacSign DateCalc(DateTime birthDate)
        {
            var day = birthDate.Day;
            var month = birthDate.Month;
            switch (day)
            {
                case >=21 when month==03:
                case <=20 when month==04:
                    return ZodiacSign.Aries;

                case >= 21 when month == 04:
                case <= 20 when month == 05:
                    return ZodiacSign.Touro;

                case >= 21 when month == 05:
                case <= 20 when month == 06:
                    return ZodiacSign.Gemeos;

                case >= 21 when month == 06:
                case <= 22 when month == 07:
                    return ZodiacSign.Cancer;

                case >= 23 when month == 07:
                case <= 22 when month == 08:
                    return ZodiacSign.Leao;

                case >= 23 when month == 08:
                case <= 22 when month == 09:
                    return ZodiacSign.Virgem;

                case >= 23 when month == 09:
                case <= 22 when month == 10:
                    return ZodiacSign.Libra;

                case >= 23 when month == 10:
                case <= 21 when month == 11:
                    return ZodiacSign.Escorpiao;

                case >= 22 when month == 11:
                case <= 21 when month == 12:
                    return ZodiacSign.Sagitario;

                case >= 22 when month == 12:
                case <= 20 when month == 01:
                    return ZodiacSign.Capricornio;

                case >= 21 when month == 01:
                case <= 19 when month == 02:
                    return ZodiacSign.Aquario;

                case >= 19 when month == 02:
                case <= 20 when month == 03:
                    return ZodiacSign.Peixes;

                default:
                    return 0;
            }
        }
        /*private SignData IsMember(ZodiacSign sign, bool membership)
        {
            SignData data = new SignData();
            data = HoroscopeManager.Instance.Info[Sign];
            if (!membership)
            {
                data.Drink = "";
            }
            return data;
        }*/
    }
}
