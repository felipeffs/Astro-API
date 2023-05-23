﻿namespace Atv1Astrologia.Model
{
    public class ZodiacProfile
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = "";
        public ZodiacSign Sign { get; set; }
        public string SignName => Sign.ToString();
        public SignData SignData => HoroscopeManager.Instance.Info[Sign];

    }
}
