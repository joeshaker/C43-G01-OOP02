using OOP2.Structs;

namespace OOP2
{

    internal class Program
    {
        #region Function of Q2
        //static public decimal GetDistance(Point p1, Point p2)
        //{
        //    return (decimal)Math.Sqrt(((p1.X - p2.X) * (p1.X - p2.X)) + ((p1.Y - p2.Y) * (p1.Y - p2.Y)));
        //}
        #endregion
        #region Function of Q3
        //static void GetOldAge(NPerson p1, NPerson p2, NPerson p3)
        //{
        //    if (p1.Age > p2.Age)
        //    {
        //        if (p1.Age > p3.Age)
        //        {
        //            Console.WriteLine($"The details of Oldest Person is \n Name: {p1.Name}" +
        //                $" Age: {p1.Age}");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"The details of Oldest Person is \n " +
        //                 $"Name: {p3.Name}" +
        //                  $" Age: {p3.Age}");

        //        }
        //    }
        //    else
        //    {
        //        if (p2.Age > p3.Age)
        //        {
        //            Console.WriteLine($"The details of Oldest Person is \n " +
        //            $"Name: {p2.Name}" +
        //            $" Age: {p2.Age}");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"The details of Oldest Person is \n " +
        //            $"Name: {p3.Name}" +
        //            $" Age: {p3.Age}");
        //        }
        //    }
        //} 
        #endregion
        static void Main(string[] args)
        {
            #region Q1
            //Person person1=new Person(Name:"Youssef Shaker",Age:23);
            //Person person2 = new Person(Name:"Ali Ahmed", Age: 21);
            //Person person3 = new Person(Name:"Rodina Mohamed", Age: 35);
            //Person[] Arr = new Person[3];
            //person1.ToString();
            //Arr = [person1, person2, person3];

            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    Console.WriteLine($"The details of Person{i}");
            //    Console.WriteLine(Arr[i].ToString());

            //}


            #endregion
            #region Q2
            //Point p1 = new Point();
            //Point p2 = new Point();
            //Point[] Arr = [p1, p2];
            //decimal result;
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine($"Enter the Point{i}");
            //    Arr[i].X = int.Parse(Console.ReadLine());
            //    Arr[i].Y = int.Parse(Console.ReadLine());
            //}
            //result = GetDistance(p1, p2);
            //Console.WriteLine("the distanse between p1 and p2 = " + result);
            #endregion
            #region Q3
            //NPerson person1 = new NPerson();
            //NPerson person2 = new NPerson();
            //NPerson person3 = new NPerson();
            //NPerson[] Arr = [person1, person2, person3];
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    Console.WriteLine($"Enter the details of person{i}");
            //    Console.WriteLine("His Name");
            //    Arr[i].Name = Console.ReadLine();
            //    Console.WriteLine("His Age");
            //    Arr[i].Age = int.Parse(Console.ReadLine());
            //}
            //GetOldAge(person1, person2, person3); 
            #endregion
            #region Q4
            //Rectangle R1 = new Rectangle();
            //Console.WriteLine("Enter the width of rectangle");
            //R1.Width = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the height of rectangle");
            //R1.Hight = int.Parse(Console.ReadLine());
            //R1.Area.ToString();
            //R1.DisplayInfo();
            #endregion


        }
    }
}
