using System;
using System.Collections.Generic;
using System.IO;

namespace FigureParams
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Znatok\Desktop\input.txt";
            string[] tmp;
            List<Figure> figures = new List<Figure>();

            try
            {
                string[] input = File.ReadAllLines(path);

                int n = Convert.ToInt32(input[0]);


                for(int i =1; i<=n; i++)
                {
                    tmp = input[i].Split();
                    switch (input[i][0])
                    {
                        case 'c':
                            figures.Add(new Circle(Convert.ToDouble(tmp[1])));
                            break;
                        case 'r':
                            figures.Add(new Rectangle(Convert.ToDouble(tmp[1]), Convert.ToDouble(tmp[2])));
                            break;
                        case 't':
                            figures.Add(new Triangle(Convert.ToDouble(tmp[1]), Convert.ToDouble(tmp[2]), Convert.ToDouble(tmp[3])));
                            break;
                        default:
                            throw new Exception(message: "Wrong figure input.");
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

           foreach(Figure f in figures)
            {
                f.Info();
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
