using System;

namespace ClassBoxData
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal length = decimal.Parse(Console.ReadLine());
            decimal width = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());

            try
            {
                Box figure = new Box(length, width, height);
                Console.WriteLine($"Surface Area - {figure.SurfaceArea():F2}");
                Console.WriteLine($"Lateral Surface Area - {figure.LateralSurfaceArea():F2}");
                Console.WriteLine($"Volume - {figure.Volume():F2}");                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }            
        }
    }
}