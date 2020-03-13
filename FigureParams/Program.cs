using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

namespace FigureParams
{
    class Program
    {
        static void Main(string[] args)
        { 
            string inputFile = @"C:\Users\Znatok\Desktop\input.txt";
            string serialFile = @"C:\Users\Znatok\Desktop\output.txt";
            string logFile = @"C:\Users\Znatok\Desktop\log.txt";
            string[] tmp;
            List<Figure> figures = new List<Figure>();
            TextWriter serialWriter = new StreamWriter(serialFile);
            TextWriter logWriter = new StreamWriter(logFile);

            XmlSerializer ser = new XmlSerializer(typeof(Figure));

            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.Listeners.Add(new TextWriterTraceListener(logWriter));
            Trace.AutoFlush = true;
            Trace.Indent();

            Trace.WriteLine("Entering Main");

            try
            {
                Trace.WriteLine("Reading file");
                string[] input = File.ReadAllLines(inputFile);

                Trace.WriteLine("Analyzing input data");
                int n = Convert.ToInt32(input[0]);
                Trace.WriteLine(n + " figures expected");

                Trace.Indent();
                for (int i = 1; i <= n; i++)
                {
                    tmp = input[i].Split();
                    switch (input[i][0])
                    {
                        case 'c':
                            Trace.WriteLine("Circle added");
                            figures.Add(new Circle(Convert.ToDouble(tmp[1])));
                            break;
                        case 'r':
                            Trace.WriteLine("Rectangle added");
                            figures.Add(new Rectangle(Convert.ToDouble(tmp[1]), Convert.ToDouble(tmp[2])));
                            break;
                        case 't':
                            Trace.WriteLine("Triangle added");
                            figures.Add(new Triangle(Convert.ToDouble(tmp[1]), Convert.ToDouble(tmp[2]), Convert.ToDouble(tmp[3])));
                            break;
                        default:
                            Trace.WriteLine("Wrong figure found. Throwing exception");
                            throw new Exception(message: "Wrong figure input.");
                    }
                }
                Trace.Unindent();

                Trace.WriteLine("Showing figures info");

                foreach (Figure f in figures)
                {
                    f.Info();
                    Console.WriteLine();
                }

                Trace.WriteLine("Serializing figures");
                foreach (Figure f in figures)
                {
                    ser.Serialize(serialWriter, f);
                }
            }
            catch (Exception e)
            {
                Trace.WriteLine("!!! - Exception caught. Showing message");
                Console.WriteLine(e.Message + " >");
                Console.WriteLine("  " + e.InnerException.Message);
            }

            //Console.ReadKey();
            //Trace.WriteLine("Exiting Main");
            //Trace.Unindent();  
        }
    }
}
