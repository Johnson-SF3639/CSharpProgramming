using System;
namespace Interface{
    class Program{
        public static void Main(string[] args)
        {
            Draw draw = new Draw();
            draw.GetData(13,2);
            draw.CalculateArea();
        }
    }
}