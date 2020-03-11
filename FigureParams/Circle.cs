using System;

[Serializable]
public class Circle : Figure
{
	private double r;

	public Circle()
	{
		r = 0;
	}

	/// <summary>Creates Circle object based on given radius</summary>
	/// <param name="_r">Radius</param>
	public Circle(double _r)
	{
		r = _r;
	}


	public override double P { get => 2 * r * 3.14; }
	public override double S { get => r * r * 3.14; }

	public override void Info()
    {
		Console.WriteLine("Type: Triangle");
		Console.WriteLine("Radius: " + r);
		Console.WriteLine("Perimeter: " + P);
		Console.WriteLine("Area: " + S);

	}
}
