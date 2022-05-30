using ConsoleApp.Challenges.sorting.quick;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject2
{
    public  class TestQuickSort
    {
        [Fact]
        public void Test1()
        {
            int[] array = { 0,0,0,0,0 };
            int[] result = { 0, 0, 0, 0, 0 };

            QuickSort sort = new QuickSort();
            sort.Quicksort(array, 0, array.Length - 1);
            Assert.Equal(result, sort.PrintArray(array));

        }
        [Fact]
        public void Test2()
        {
            int[] array = { 12, 11, 13, 5, 6 };
            int[] result = { 5, 6, 11, 12, 13 };

            QuickSort sort = new QuickSort();
            sort.Quicksort(array, 0, array.Length - 1);
            Assert.Equal(result, sort.PrintArray(array));

        }
        [Fact]
        public void Test3()
        {
            int[] array = { 20, 18, 12, 8, 5, -2 };
            int[] result = { -2, 5, 8, 12, 18, 20 };

            QuickSort sort = new QuickSort();
            sort.Quicksort(array, 0, array.Length - 1);
            Assert.Equal(result, sort.PrintArray(array));

        }
        [Fact]
        public void Test4()
        {
            int[] array = { 5, 12, 7, 5, 5, 7 };
            int[] result = { 5, 5, 5, 7, 7, 12 };

            QuickSort sort = new QuickSort();
            sort.Quicksort(array, 0, array.Length - 1);

        }
        [Fact]
        public void Test5()
        {
            int[] array = { 2, 3, 5, 7, 13, 11 };
            int[] result = { 2, 3, 5, 7, 11, 13 };

            QuickSort sort = new QuickSort();
            sort.Quicksort(array, 0, array.Length - 1);
            Assert.Equal(result, sort.PrintArray(array));

        }
    }
}
