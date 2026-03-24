using System;

public class Circle
{
    private double _radius;

    public double Radius
    {
        get => _radius;
        set
        {
            if (value > 0)
                _radius = value;
            else
                throw new ArgumentException("Radius must be greater than zero.");
        }
    }

    public double Area => Math.PI * Math.Pow(_radius, 2);

    public double Circumference => 2 * Math.PI * _radius;
}
