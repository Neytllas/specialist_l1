using System;

namespace ConsoleApp1
{
    class Program
    {            
        enum Figures
            {
                cone,
                helix,
                torus,
                cube
            }

        struct Fdata
            {
                public int x0, y0;

                public int color;

                public Figures type;
            }
        static void Main(string[] args)
        {
            Fdata fd;

            fd.x0 = 1; fd.y0 = 1;

            fd.color = 0x2727FF;

            fd.type = Figures.cube;
            
            
            Console.WriteLine($"Coords: ({fd.x0},{fd.y0}) " + $"Color: {fd.color} Type: { fd.type }");
        }
    }
}
