
using System.Security.Cryptography;
using System;
using System.Collections.Generic;

namespace CodeSignal.InterviewPracticeArrays
{
    internal class Sudoku2
    {
        // Sudoku is a number-placement puzzle. The objective is to fill a 9 × 9 grid with numbers in such a way that each column,
        // each row, and each of the nine 3 × 3 sub-grids that compose the grid all contain all of the numbers from 1 to 9 one time.
        // Implement an algorithm that will check whether the given grid of numbers represents a valid Sudoku
        // puzzle according to the layout rules described above.Note that the puzzle represented by grid does not have to be solvable.
        public bool Solution(char[][] grid)
        {
            HashSet<char>[] rows = new HashSet<char>[9];
            HashSet<char>[] cols = new HashSet<char>[9];
            HashSet<char>[] boxes = new HashSet<char>[9];

            for (int i = 0; i < 9; i++)
            {
                rows[i] = new HashSet<char>();
                cols[i] = new HashSet<char>();
                boxes[i] = new HashSet<char>();
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    char current = grid[i][j];
                    if (current != '.')
                    {
                        if (!Char.IsDigit(current) || current < '1' || current > '9')
                        {
                            return false;
                        }

                        if (!rows[i].Add(current) || !cols[j].Add(current) || !boxes[(i / 3) * 3 + j / 3].Add(current))
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }


    }
}

