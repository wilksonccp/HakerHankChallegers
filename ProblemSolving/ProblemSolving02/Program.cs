using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int n = arr.Count();
        int pos = 0;
        int neg = 0;
        int zero = 0;

        for (int i = 0; i<n; i++)
        {
            if (arr[i] > 0)
            {
                pos++;
            }
            else if (arr[i] < 0)
            {
                neg++;
            }
            else
            {
                zero++;
            }
        }
            Console.WriteLine($"{(double)pos / n:f6}");
            Console.WriteLine($"{(double)neg / n:f6}");
            Console.WriteLine($"{(double)zero / n:f6}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
