using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Structs
{
    internal class Rectangle
    {
		private double  width;
		private double  height;
		private double  area;
        public bool isParsed;
        public double  Width
		{
			get { return width; }
			set 
            {
                if (value < 0)
                {
                    Console.WriteLine("The width can't be nagative");
                    return;
                }
                else
                {
                    width = value;
                }
                ///To make user input the positive value
                //do
                //{
                //    if (value < 0)
                //    {
                //        Console.WriteLine("The width can't be negative. Please enter a positive height:");
                //        isParsed = false; 
                //        value = double.Parse(Console.ReadLine()); 
                //    }
                //    else
                //    {
                //        isParsed = true; 
                //    }
                //} while (!isParsed);

                //width = value;
            }
		}
        public double Hight
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("The height can't be nagative");
                    return;
                }
                else
                {
                    height = value;
                }

                //do
                //{
                //    if (value < 0)
                //    {
                //        Console.WriteLine("The height can't be negative. Please enter a positive height:");
                //        isParsed = false; 
                //        value = double.Parse(Console.ReadLine()); 
                //    }
                //    else
                //    {
                //        isParsed = true; 
                //    }
                //} while (!isParsed);

                //height = value;
            }
        }
        public double Area
        {

            get{
                return area=width*height;
            }

        }

        public void DisplayInfo()
        {
            Console.WriteLine($"The Rectangle dimensions width :{width} height: {height}\n" +
                $"Area: {area} ");

        }
    }
}
