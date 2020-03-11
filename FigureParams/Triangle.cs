using System;
public class Triangle : Figure
{
	private double a;
	private double b;
	private double c;

	/// <summary>Creates Triangle object based on given sides</summary>
	/// <param name="_a">Triangle side</param>
	/// <param name="_b">Triangle side</param>
	/// <param name="_c">Triangle side</param>
	public Triangle(double _a, double _b, double _c)
	{
		a = _a;
		b = _b;
		c = _c;
	}

	public override double P { get => a+b+c; }
	public override double S { get => Math.Sqrt(P / 2 * (P / 2 - a) * (P / 2 - b) * (P / 2 - c)); }

	public override void Info()
	{
		Console.WriteLine("Type: Triangle");
		Console.WriteLine("Sides: " + a + ", " + b + ", " + c);
		Console.WriteLine("Perimeter: " + P);
		Console.WriteLine("Area: " + S);

	}
}
