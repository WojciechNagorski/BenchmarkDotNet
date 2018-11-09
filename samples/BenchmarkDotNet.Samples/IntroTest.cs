using System.Linq;
using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNet.Samples
{
    [CoreJob]
    [ClrJob]
    [MonoJob("mono", @"C:\Program Files\Mono\bin\mono.exe")]
    public class IntroTest
    {
        [Benchmark]
        public void ERange()
        {
            for (int i = 0; i < N; i++)
            {
                Enumerable.Range(0, N);
            }
        }

        public int N { get; set; } = 1000; 
    }
}
