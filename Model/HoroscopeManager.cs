using Atv1Astrologia.Helpers;

namespace Atv1Astrologia.Model
{
    public class HoroscopeManager : Singleton<HoroscopeManager>
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
        private readonly string[] drinks = new string[]
        {
            "Conhaque",
            "Rum",
            "Uísque",
            "Lícor de Chocolate",
            "Lícor 96%",
            "Lícor de Maracuja",
            "Cachaça",
            "Vodka"
        };

        public Dictionary<ZodiacSign, SignData> Info = new Dictionary<ZodiacSign, SignData>();

        protected override void SingletonAwake()
        {
            foreach (var sign in Enum.GetValues(typeof(ZodiacSign)))
            {
                Random random = new Random();
                int number = random.Next(0, color.Length);
                string tempColor = color[number];

                number = random.Next(0, drinks.Length);
                string tempDrink = drinks[number];

                int tempNumber = random.Next(1, 100);

                SignData sd = new SignData(tempColor, tempDrink, tempNumber);

                Info.Add((ZodiacSign)sign, sd);
            }
        }

        public void Initialize(){}
    }
}
