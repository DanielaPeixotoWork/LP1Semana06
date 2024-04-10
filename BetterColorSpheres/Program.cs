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
