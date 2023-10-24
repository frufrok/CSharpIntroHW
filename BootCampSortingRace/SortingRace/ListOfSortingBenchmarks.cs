using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using ListOfSortingAlgorithms;

namespace TestSortingList
{
    [MemoryDiagnoser]
    [RankColumn]
    public class ListOfSortingBenchmarks
    {
        private static readonly int[] arr = new int[1000];

        static ListOfSortingBenchmarks()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Random.Shared.Next(0, 100000);
            }
        }

        public int[] GetArr()
        {
            var res = new int[arr.Length];
            Array.Copy(arr, res, arr.Length);
            return res;
        }

        [Benchmark]
        public void TestQuickSort()
        {
            var testArr = GetArr();
            ListOfSortingAlgs.QickSort(testArr);
        }


        [Benchmark]
        public void TestBubbleSort()
        {
            var testArr = GetArr();
            ListOfSortingAlgs.BubbleSort(testArr);
        }


        [Benchmark]
        public void TestCountingSort()
        {
            var testArr = GetArr();
            ListOfSortingAlgs.CountingSort(testArr);
        }


        [Benchmark]
        public void TestSelectionSort()
        {
            var testArr = GetArr();
            ListOfSortingAlgs.SelectionSort(testArr);
        }


        [Benchmark]
        public void TestShakerSort()
        {
            var testArr = GetArr();
            ListOfSortingAlgs.ShakerSort(testArr);
        }

        [Benchmark]
        public void TestNativeSort()
        {
            var testArr = GetArr();
            Array.Sort(testArr);
        }
    }
}
