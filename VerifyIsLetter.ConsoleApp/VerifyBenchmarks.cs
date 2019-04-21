using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace VerifyIsLetter.ConsoleApp
{
    [MemoryDiagnoser]
    //ClrJob(baseline: true), CoreJob, MonoJob, CoreRtJob]
    //[RPlotExporter, RankColumn]
    public class VerifyBenchmarks
    {
        private const string StringToVerify = "The Force will be with you always";
        private static readonly Verify VerifyInstance = new Verify();

        [Benchmark(Baseline = true)]
        public void WithRegEx()
        {
            VerifyInstance.WithRegEx(StringToVerify);
        }

        [Benchmark]
        public void WithCharIsLetter()
        {
            VerifyInstance.WithCharIsLetter(StringToVerify);
        }

        [Benchmark]
        public void WithForCompareAsciiValue()
        {
            VerifyInstance.WithForCompareAsciiValue(StringToVerify);
        }
    }
}
