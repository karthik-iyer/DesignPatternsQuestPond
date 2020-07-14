using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var teaWithoutSugar = new TeaWithoutSugar();

            var tea = teaWithoutSugar.MakeTea();

            var teaWithSugarAndMilk = new TeaWithSugarAndMilk();
            var tea1 = teaWithSugarAndMilk.MakeTea();

            var teaWithoutMilk = new TeaWithoutMilk();
            var tea2 = teaWithoutMilk.MakeTea();


        }
    }
}