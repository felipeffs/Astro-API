using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Atv1Astrologia.Model
{
    public class ZodiacProfile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ZodiacSign Sign { get; set; }
        public string ColorOfDay => AllZodiac.Instance.Info[Sign].colorDay;
    }

    public class AllZodiac : Singleton<AllZodiac>
    {
        private readonly string[] color = new string[]{
            "Abóbora",
            "Açafrão",
            "Amarelo",
            "Âmbar",
            "Ameixa",
            "Amêndoa",
            "Ametista",
            "Anil",
            "Azul",
            "Bege",
            "Bordô",
            "Branco",
            "Bronze",
            "Cáqui",
            "Caramelo",
            "Carmesim",
            "Carmim",
            "Castanho",
            "Cereja",
            "Chocolate",
            "Ciano",
            "Cinza",
            "Cinzento",
            "Cobre",
            "Coral",
            "Creme",
            "Damasco",
            "Dourado",
            "Escarlate",
            "Esmeralda",
            "Ferrugem",
            "Fúcsia",
            "Gelo",
            "Grená",
            "Gris",
            "Índigo",
            "Jade",
            "Jambo",
            "Laranja",
            "Lavanda",
            "Lilás",
            "Limão",
            "Loiro",
            "Magenta",
            "Malva",
            "Marfim",
            "Marrom",
            "Mostarda",
            "Negro",
            "Ocre",
            "Oliva",
            "Ouro",
            "Pêssego",
            "Prata",
            "Preto",
            "Púrpura",
            "Rosa",
            "Roxo",
            "Rubro",
            "Salmão",
            "Sépia",
            "Terracota",
            "Tijolo",
            "Turquesa",
            "Uva",
            "Verde",
            "Vermelho",
            "Vinho",
            "Violeta"
            };

        public Dictionary<ZodiacSign, CaptureInfo> Info = new Dictionary<ZodiacSign, CaptureInfo>();

        protected override void SingletonAwake()
        {
            foreach (var sign in Enum.GetValues(typeof(ZodiacSign)))
            {
                Random random = new Random();
                int colorNumber = random.Next(0, color.Length);
                string tempColor = color[colorNumber];
                CaptureInfo cp = new CaptureInfo(tempColor);

                Info.Add((ZodiacSign)sign, cp);
            }
        }

    }

    public struct CaptureInfo
    {
        public string colorDay;

        public CaptureInfo(string colorDay)
        {
            this.colorDay = colorDay;
        }
    }

    public abstract class Singleton<T> where T : class, new()
    {
        private static readonly Lazy<T> _instance = new Lazy<T>(() => new T());

        public static T Instance { get { return _instance.Value; } }

        protected Singleton()
        {
            SingletonAwake();
        }

        protected virtual void SingletonAwake() { }

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
