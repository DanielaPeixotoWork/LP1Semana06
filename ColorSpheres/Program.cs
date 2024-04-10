using System;

namespace ColorSpheres
{
    public class Color
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public int Alpha { get; set; }

        public Color(int red, int green, int blue, int alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Color(int red, int green, int blue) : this(red, green, blue, 255)
        {
        }

        public int GetGrey()
        {
            return (Red + Green + Blue) / 3;
        }
    }
    public class Sphere
    {

        public Color Color { get; }
        public double Radius { get; }
        public int TimesThrown { get; private set; }

        public Sphere(Color color, double radius)
        {
            Color = color;
            Radius = radius;
            TimesThrown = 0;
        }
    }
}

