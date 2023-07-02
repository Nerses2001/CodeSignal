using System;
using System.Linq;


namespace CodeSignal.TheCore
{
    class ListForestEdge
    {
        // Given an integer size, return array of length size filled with 1s.
        public int[] CreateArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; ++i)
            {
                ++arr[i];
            }
            return arr;

        }

        // Given an array of integers, replace all the occurrences of elemToReplace with substitutionElem
        public int[] ArrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)  => Array.ConvertAll(
            inputArray, x => x == elemToReplace ? x = substitutionElem : x);

        // Reversing an array can be a tough task, especially for a novice programmer.
        // Mary just started coding, so she would like to start with something basic at first.
        // Instead of reversing the array entirely,
        // she wants to swap just its first and last elements.
        // Given an array arr, swap its first and last elements and return the resulting array.
        public int[] FirstReverseTry(int[] arr)
        {
            if (arr.Length < 2) return arr;

            (arr[0], arr[arr.Length - 1]) = (arr[arr.Length - 1], arr[0]);

            return arr;

        }

        // Given two arrays of integers a and b, obtain the array formed by the elements of a followed by the elements of b.
        public int[] ConcatenateArrays(int[] a, int[] b) => a.Concat(b).ToArray();

        // Remove a part of a given array between given 0-based indexes l and r (inclusive).
        public int[] RemoveArrayPart(int[] inputArray, int l, int r) => inputArray.Where((num, index) => index < l || index > r).ToArray();

        // We define the middle of the array arr as follows:
        // if arr contains an odd number of elements,
        // its middle is the element whose index number is
        // the same when counting from the beginning of the array and from its end;
        // if arr contains an even number of elements, its middle is the sum of the
        // two elements whose index numbers when counting from the beginning and from the end of the array differ by one.
        // An array is called smooth if its first and its last elements are equal to one another and to the middle.
        // Given an array arr, determine if it is smooth or not.
        public bool IsSmooth(int[] arr)
        {
            return arr.Length % 2 == 0 ? arr[0] == arr[arr.Length / 2 - 1] + arr[arr.Length / 2] && arr[arr.Length / 2 - 1] + arr[arr.Length / 2] == arr[arr.Length - 1] : arr[0] == arr[arr.Length / 2] && arr[0] == arr[arr.Length - 1];
        }

        // We define the middle of the array arr as follows:
        // if arr contains an odd number of elements,
        // its middle is the element whose index number is
        // the same when counting from the beginning of the array and from its end;
        // if arr contains an even number of elements, its middle is the sum of the
        // two elements whose index numbers when counting from the beginning and from the end of the array differ by one.
        //Given array arr, your task is to find its middle, and, if it consists of two elements, replace those elements with
        //the value of middle. Return the resulting array as the answer.
        public int[] ReplaceMiddle(int[] arr)
        {
            int size = arr.Length;
            if (size % 2 == 0)
            {
                int mid = arr[size / 2 - 1] + arr[size / 2];
                return arr.Take(size / 2 - 1).Concat(new[] { mid }).Concat(arr.Skip(size / 2 + 1)).ToArray();
            }
            else
            {
                int mid = arr[size / 2];
                return arr.Take(size / 2).Concat(new[] { mid }).Concat(arr.Skip(size / 2 + 1)).ToArray();
            }
        }

        // Ratiorg got statues of different sizes as a present from CodeMaster
        // for his birthday, each statue having an non-negative integer size.
        // Since he likes to make things perfect, he wants to arrange them from smallest to largest so that
        // each statue will be bigger than the previous one exactly by 1.
        // He may need some additional statues to be able to accomplish that. Help him figure out the minimum number of additional statues needed.
        public int solution(int[] statues) => statues.Max() - statues.Min() + 1 - statues.Length;
        
    }
}
