﻿using System;
using System.Collections.Generic;

namespace CodeSignal.InterviewPracticeArrays
{
    internal class FirstDuplicate
    {
        // Given an array a that contains only numbers in the range from 1 to a.length,
        // find the first duplicate number for which the second occurrence has the minimal index. In other words, if there are more than 1 duplicated numbers, return the number for which the second occurrence has a smaller index than the second occurrence of the other number does.
        // If there are no such elements, return -1
        public int Solution(int[] a)
        {
            if (new HashSet<int>(a).Count == a.Length)
                return -1;

            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < a.Length; ++i)
            {
                set.Add(a[i]);
                if (set.Count < i + 1)
                {
                    return a[i];
                }
            }
            return -1;




        }

    }
}
