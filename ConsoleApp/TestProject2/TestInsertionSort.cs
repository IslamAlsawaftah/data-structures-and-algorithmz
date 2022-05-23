using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ConsoleApp.Challenges.insertion_sort;

namespace TestProject2
{
    public class TestInsertionSort
    {
        [Fact]
        public void Test1()
        {
            int[] array = { 12, 11, 13, 5, 6 };
            int[] result = { 5, 6, 11, 12, 13 };

            InsertionSort sort = new InsertionSort();
            sort.Insertionsort(array);
            Assert.Equal(result , sort.PrintArray(array));
           
        }

        [Fact]
        public void Test2()
        {
            int[] array = { 12, 11, 13, 5, 6 };
            int[] result = { 12, 11, 13, 5, 6 };

            InsertionSort sort = new InsertionSort();
            sort.Insertionsort(array);
            Assert.NotEqual(result, sort.PrintArray(array));

        }
        
        [Fact]
        public void Test3()
        {
            int[] array = { 5,12,7,5,5,7 };
            int[] result = { 5, 5, 5, 7, 7,12 };

            InsertionSort sort = new InsertionSort();
            sort.Insertionsort(array);
            Assert.Equal(result, sort.PrintArray(array));

        }

        [Fact]
        public void Test4()
        {
            int[] array = { 2 ,3, 5, 7, 13, 11 };
            int[] result = { 2, 3, 5, 7, 11, 13 };

            InsertionSort sort = new InsertionSort();
            sort.Insertionsort(array);
            Assert.Equal(result, sort.PrintArray(array));

        }
        [Fact]
        public void Test5()
        {
            int[] array = { 20, 18, 12, 8, 5, -2 };
            int[] result = { -2, 5, 8, 12, 18, 20 };

            InsertionSort sort = new InsertionSort();
            sort.Insertionsort(array);
            Assert.Equal(result, sort.PrintArray(array));

        }
    }
}
