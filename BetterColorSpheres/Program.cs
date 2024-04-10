using System;

public class Color
{
    
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }

    public Color(int red, int green, int blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }

    public void PrintColor()
    {
        Console.WriteLine($"RGB: ({Red}, {Green}, {Blue})");
    }
}

public class Sphere
{
    public double Radius { get; set; }

    private Color _color;
    public Color Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public double Volume { get; set; }

    public Sphere(double radius, Color color)
    {
        Radius = radius;
        Color = color;
        Volume = 4.0 / 3.0 * Math.PI * Math.Pow(Radius, 3);
    }

    public void PrintSphereInfo()
    {
        Console.WriteLine($"Sphere Radius: {Radius}");
        Color.PrintColor();
        Console.WriteLine($"Volume: {Volume}");
    }
}
