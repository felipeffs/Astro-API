﻿using Atv1Astrologia.Helpers;

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
            "Vodka",
            "Cerveja",
            "Caipirinha",
            "Caipivodka",
            "Cachaça da roça"
        };

        private readonly string[] element = new string[]
        {
            "Fogo",
            "Água",
            "Terra",
            "Madeira",
            "Vento",
            "Metal",
            "Luz",
            "Gelo",
            "Elétrico",
            "Normal"
        };

        private readonly string[] flower = new string[]
        {
            "Tulipa",
            "Margarida",
            "Girasol",
            "Rosas",
            "Violeta",
            "Copo de Leite",
            "Orquídeas",
            "Gardênias",
            "Delfino",
            "Agerato",
            "Rosa"
        };

        private readonly string[] love = new string[]
        {
            "Boa sorte",
            "Pode dar certo",
            "Ferrou! Vai dar tudo errado",
            "Você é corno(a)",
            "Vai dar casamento",
            "Vai achar o amor da sua vida",
            "Má sorte"
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

                number = random.Next(0, element.Length);
                string tempElement = element[number];

                number = random.Next(0, flower.Length);
                string tempFlower = flower[number];

                number = random.Next(0, love.Length);
                string tempLove = love[number];

                int tempNumber = random.Next(1, 100);

                SignData sd = new SignData(tempColor, tempDrink, tempNumber, tempElement, tempFlower, tempLove);

                Info.Add((ZodiacSign)sign, sd);
            }
        }

        public void Initialize(){}
    }
}
