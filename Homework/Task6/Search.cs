using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Search
    {
            public static int LinearSearch(int[] array, int target)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == target)
                    {
                        return i;
                    }
                }
                return -1;
            }

            public static int BinarySearch(int[] array, int target)
            {
                int left = 0;
                int right = array.Length - 1;

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;

                    if (array[mid] == target)
                    {
                        return mid;
                    }
                    else if (array[mid] < target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }

                return -1;
            }

            public static int BinarySearch(string[] array, string target)
            {
                int left = 0;
                int right = array.Length - 1;

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    int compareResult = string.Compare(array[mid], target, StringComparison.Ordinal);

                    if (compareResult == 0)
                    {
                        return mid;
                    }
                    else if (compareResult < 0)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }

                return -1;
            }
        
    }
}



