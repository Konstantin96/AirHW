using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIR.LIB
{
    public partial class MyAir
    {
        MyAir() : this(ConsoleColor.White, "Boing-747", "800", "USA", DateTime.Now){}
        MyAir(ConsoleColor ColorCar, string AirPassanger, string ModelAir, string MadeIn, DateTime Year)
        {
            this.ColorCar = ColorCar;
            this.AirPassanger = AirPassanger;
            this.ModelAir = ModelAir;
            this.MadeIn = MadeIn;
            this.Year = Year;

        }
        static MyAir()
        {
            Price = 0;
            Discount = 0;
            Purchase_Price = 0;
        }
        private ConsoleColor ColorCar;
        private string AirPassanger;
        private string ModelAir;
        private string MadeIn;
        private DateTime Year;

        public ConsoleColor GetColor()
        {
            return ColorCar;
        }
        public string GetAirPassenger()
        {
            return AirPassanger;
        }
        public string GetModelAir()
        {
            return ModelAir;
        }
        public string GetMadeIn()
        {
            return MadeIn;
        }
        public DateTime GetYear()
        {
            return Year;
        }

        public void Copy(ref MyAir obj)
        {
            ColorCar = obj.GetColor();
            AirPassanger = obj.GetAirPassenger();
            ModelAir = obj.GetModelAir();
            MadeIn = obj.GetMadeIn();
            Year = obj.GetYear();
        }

        static public int Price { get; set; }
        static public int Discount { get; set; }
        static public int Purchase_Price { get; set; }

    }
}

