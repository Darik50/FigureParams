using System;
using System.Xml.Serialization;

[XmlIncludeAttribute(typeof(Circle)), XmlIncludeAttribute(typeof(Triangle)), XmlIncludeAttribute(typeof(Rectangle))]
[Serializable]
public abstract class Figure
{
    /// <summary> Returns perimeter </summary>
    public abstract double P { get; }

    /// <summary> Returns area </summary>
    public abstract double S { get; }

    /// <summary> Prints figure information to console </summary>
	public abstract void Info();
}
