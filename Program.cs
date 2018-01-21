using System;

namespace c_7outvariabledemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //old way of using out variable
            DateTime dt1;
            if(DateTime.TryParse("12/12/2014",out dt1))
            Console.WriteLine("Date Time Parsed in old way is {0}",dt1);

            //New way of using out variable in c# 7

            if(DateTime.TryParse("12/12/2014",out var dt2))
            Console.WriteLine("Date Time parsed in new way is {0}",dt2);

            Console.ReadLine();
        }
    }
}
