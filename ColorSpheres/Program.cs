using System;

namespace ColorSpheres
{
    public class Color
    {
        public int Red { get; }
        public int Green { get; }
        public int Blue { get; }
        public int Alpha { get; }

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
        public readonly Color Color;
        public double Radius { get; private set; }
        public int TimesThrown { get; private set; }

        private const int MaxColorIntensity = 255;

        public Sphere(Color color, double radius)
        {
            Color = color;
            Radius = radius;
            TimesThrown = 0;
        }

        public void Pop()
        {
            Radius = 0;
        }

        public void Throw()
        {
            if (Radius > 0)
            {
                TimesThrown++;
            }
        }

        public int GetTimesThrown()
        {
            return TimesThrown;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sphere sphere1 = new Sphere(new Color(255, 0, 0), 5.0);
            Sphere sphere2 = new Sphere(new Color(0, 255, 0), 7.0);
            Sphere sphere3 = new Sphere(new Color(0, 0, 255), 6.0);

            sphere1.Throw();
            sphere2.Throw();
            sphere3.Throw();

            sphere1.Pop();

            Console.WriteLine("Sphere 1: Color (R: {0}, G: {1}, B: {2}), Radius: {3}, Times Thrown: {4}",
                              sphere1.Color.Red, sphere1.Color.Green, sphere1.Color.Blue,
                              sphere1.Radius, sphere1.GetTimesThrown());
            Console.WriteLine("Sphere 2: Color (R: {0}, G: {1}, B: {2}), Radius: {3}, Times Thrown: {4}",
                              sphere2.Color.Red, sphere2.Color.Green, sphere2.Color.Blue,
                              sphere2.Radius, sphere2.GetTimesThrown());
            Console.WriteLine("Sphere 3: Color (R: {0}, G: {1}, B: {2}), Radius: {3}, Times Thrown: {4}",
                              sphere3.Color.Red, sphere3.Color.Green, sphere3.Color.Blue,
                              sphere3.Radius, sphere3.GetTimesThrown());
        }
    }
}
