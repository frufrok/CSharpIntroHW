using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using ListOfSortingAlgorithms;
using TestSortingList;

namespace TestSortList
{
    class Program
    {
        static void Main(string[] args) 
        {
            BenchmarkRunner.Run<ListOfSortingBenchmarks>();
        }
        public class Config : ManualConfig
        {
            public Config()
            {
                // Using the WithOptions() factory method:
                this.WithOptions(ConfigOptions.JoinSummary)
                    .WithOptions(ConfigOptions.DisableLogFile)
                    .WithOptions(ConfigOptions.DisableOptimizationsValidator);

                // Or (The ConfigOptions Enum is defined as a BitField)
                this.WithOptions(ConfigOptions.JoinSummary | ConfigOptions.DisableLogFile);

            }
        }
    }
}