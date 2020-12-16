using System;
using System.Linq;

namespace ListComparator.Library.Tests
{
    public class ListComparer
    {
        public int Compare(int[] arr1, int[] arr2)
        {
            return arr1.Intersect(arr2).Count();
        }
    }
}