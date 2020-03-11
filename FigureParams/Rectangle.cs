using System;
public class Rectangle : Figure
{
	private double a;
	private double b;

	/// <summary>Creates Rectangle object based on given sides</summary>
	/// <param name="_a">Rectangle side</param>
	/// <param name="_b">Rectangle side</param>
	public Rectangle(double _a, double _b)
	{
		a = _a;
		b = _b;
	}

	public override double P { get => a + b; }
	public override double S { get => a*b; }

	public override void Info()
	{
		Console.WriteLine("Type: Rectangle");
		Console.WriteLine("Sides: " + a + ", " + b);
		Console.WriteLine("Perimeter: " + P);
		Console.WriteLine("Area: " + S);

	}
}
