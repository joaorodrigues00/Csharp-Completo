using System;

public class Rectangle
{
    public double Height;
    public double Width;

    public double RectArea()
    {
        return Height * Width;
    }

    public double RectPerimeter()
    {
        return 2 * (Height + Width);
    }

    public double RectDiagonal()
    {
        return Math.Sqrt((Height * Height) + (Width * Width));
    }
}