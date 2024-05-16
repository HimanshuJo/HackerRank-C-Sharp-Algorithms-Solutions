/*
https://www.hackerrank.com/challenges/icecream-parlor/problem?isFullScreen=true
*/

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
     * Complete the 'icecreamParlor' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER m
     *  2. INTEGER_ARRAY arr
     */

    public static List<int> icecreamParlor(int m, List<int> arr)
    {
      List<int>result=new List<int>();
      int sizeOfArr=arr.Count;
      for(int i=0; i<sizeOfArr; ++i){
        int currElementAtIndexI=arr[i];
        bool haveFoundPairOrNot=false;
        for(int j=0; j<sizeOfArr; ++j){
          if(i!=j){
            int otherPairMemberNeededToBeFound=m-currElementAtIndexI;;
            if(arr[j]==otherPairMemberNeededToBeFound){
              result.Add(i+1);
              result.Add(j+1);
              haveFoundPairOrNot=true;
              break;
            }
          }
        }
        if(haveFoundPairOrNot) break;
      }
      return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int m = Convert.ToInt32(Console.ReadLine().Trim());

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = Result.icecreamParlor(m, arr);

            textWriter.WriteLine(String.Join(" ", result));
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
