using System;

namespace DataTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = DateTime.Now;

            var formatada = String.Format("{0: dd/MM/yyyy hh:mm:ss z}", data);
            Console.WriteLine(formatada);
        }
    }
}
