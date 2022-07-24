using System;
using System.Collections.Generic;

namespace EXO1
{
    class Program
    {

        static Dictionary<string, int[][]> matrices = new Dictionary<string, int[][]>
        {
            ["A"] = new[]
            {
                new[] { 1, 2, 3, 4 },
                new[] { 4, 3, 2, 1 }
            },
            ["B"] = new[]
            {
                new[] { 5, 6, 7, 8 },
                new[] { 8, 7, 6, 5 }
            },
        };

        static void Main(string[] args)
        {
            CheckMatrices(matrices, 25);
        }

        static void CheckMatrices(Dictionary<string, int[][]> matrixLookup, int target)
        {
            foreach (var (key, matrix) in matrixLookup)
            {
                for (int row = 0; row < matrix.Length; row++)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        if (matrix[row][col] == target)
                        {
                            goto Found;
                        }
                    }
                }
                Console.WriteLine($"Not found {target} in matrix {key}.");
                continue;

            Found: Console.WriteLine($"Found {target} in matrix {key}.");
            }
        }
    }
}


// Erreur
// Result : 1 Found et  1 not found