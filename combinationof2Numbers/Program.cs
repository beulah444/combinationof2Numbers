//using System;
//using System.Collections.Generic;
//class Program
//{
//    static void Main(string[] args)
//    {

//        GetCombination(new List<int> { 1, 2,3},4);
//        Console.ReadKey();
//    }

//    static void GetCombination(List<int> list,int places)
//    {
//        double count1 = (list.Count + places - 1);
//        int SumCount1 = 1;
//        for(int i=1;i<=count1;i++)
//        {
//            SumCount1 *= i;
//        }
//        double count2 = (list.Count- 1);
//        int SumCount2 = 1;
//        for (int i = 1; i <= count2; i++)
//        {
//            SumCount2 *= i;
//        }
//        double count3 = places;
//        int SumCount3 = 1;
//        for (int i = 1; i <= count3; i++)
//        {
//            SumCount3 *= i;
//        }
//        int finalComb = SumCount1 / (SumCount2 * SumCount3);
//        double count = Math.Pow(2, list.Count);
//        for (int i = 1; i <= count; i++)
//        {
//            string str = Convert.ToString(i, 2).PadLeft(list.Count, '0');
//            for (int j = 0; j < str.Length; j++)
//            {
//                if (str[j] == '1')
//                {
//                    Console.Write(list[j]);
//                }
//            }
//            Console.WriteLine();
//        }
//    }
//}
/* *  Enumerates all subsets of n elements using recursion.
 *  Uses some String library functions.
 *
 *  Both functions (comb1 and comb2) print them in alphabetical
 *  order; comb2 does not include the empty subset.
 *
 *  Combinations 3
 *  
 *  a
 *  ab
 *  abc
 *  ac
 *  b
 *  bc
 *  c
 *
 *  a
 *  ab
 *  abc
 *  ac
 *  b
 *  bc
 *  c
 *
 *  Remark: this is, perhaps, easier by counting from 0 to 2^N - 1 by 1
 *  and looking at the bit representation of the counter. However, this
 *  recursive approach generalizes easily, e.g., if you want to print
 *  out all combinations of size k.*/

using System;
public class Combinations
{

    // print all subsets of the characters in s
    public static void comb1(String s) { comb1("", s); }

    // print all subsets of the remaining elements, with given prefix 
    private static void comb1(String prefix, String s)
    {
        if (s.Length > 0)
        {
            Console.WriteLine(prefix + s[0]);
            comb1(prefix + s[0], s.Substring(1));
            comb1(prefix, s.Substring(1));
        }
    }

    // alternate implementation
    public static void comb2(String s) { comb2("", s); }
    private static void comb2(String prefix, String s)
    {
        Console.WriteLine(prefix);
        for (int i = 0; i < s.Length; i++)
            comb2(prefix + s[i], s.Substring(i + 1));
    }


    // read in N from command line, and print all subsets among N elements
    public static void Main(string[] args)
    {
        Console.WriteLine("enter number");

        int n = int.Parse(Console.ReadLine());
        String alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        String elements = alphabet.Substring(0, n);

        // using first implementation
        comb1(elements);
        Console.WriteLine();

        //using second implementation
                comb2(elements);
        Console.WriteLine();
        Console.ReadKey();
    }
}
//using System;
//using System.Text;
//using System.Data;

//public class Combinations
//{
//    private StringBuilder output = new StringBuilder();
//    private  String inputstring;
//    public Combinations(String str )
//    {
//        inputstring = str;
//       Console.WriteLine("The input string  is  : " + inputstring);
//    }


//    public static void Main()
//    {
//        Combinations combobj = new Combinations("12");
//        Console.WriteLine("");
//        Console.WriteLine("");
//        Console.WriteLine("All possible combinations are :  ");
//        Console.WriteLine("");
//        Console.WriteLine("");
//        combobj.combine();
//        Console.ReadKey();
//    }

//    public void combine() { combine(0); }
//    private void combine(int start)
//    {
//      for (int i = start; i < inputstring.Length; ++i)
//        {
//            output.Append(inputstring[i]);
//            Console.WriteLine(output);
//            if (i < inputstring.Length)
//                combine(i + 1);
//            output.EnsureCapacity(output.Length- 1);
//        }
//    }
//}