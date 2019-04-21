using BenchmarkDotNet.Running;
using System;

namespace VerifyIsLetter.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verify is letter benchmarks!");
            var summary = BenchmarkRunner.Run<VerifyBenchmarks>();

            Console.ReadKey();
        }



    }
}
