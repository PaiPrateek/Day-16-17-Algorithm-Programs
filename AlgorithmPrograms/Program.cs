using System;

namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inserion sorting
            insertionSort();
            // String array which has different strings
            //String[] arr = {  "Suhas", "Prajwal", "Manjesh", "Prateek", "Rakesh", "Sanath" };

            // Searching "Prateek" string in the given array
            //String x = "Prateek";
            //int result = binarySearch(arr, x);

            //if (result == -1)
            //{
            //    Console.WriteLine("Element is not present");
            //}

            //else
            //{
            //    Console.WriteLine("Element found at index : " + result);
            //}

            // Permutation of String 

            //String str = "PAI";
            //int len = str.Length;
            //Console.WriteLine("All the permutations of the string are: ");
            //generatePermutation(str, 0, len);
        }

        //Function for swapping the characters 
        //public static String swapString(String a, int i, int j)
        //{
        //    char[] c = a.ToCharArray();
        //    char ch;
        //    ch = c[i];
        //    c[i] = c[j];
        //    c[j] = ch;

        //    //Converting characters from array into single string  
        //    return string.Join("", c);
        //}

        //Function for generating permutations
        //public static void generatePermutation(String str, int start, int end)
        //{
        //    //Prints the permutations  
        //    if (start == end - 1)
        //        Console.WriteLine(str);
        //    else
        //    {
        //        for (int i = start; i < end; i++)
        //        {
        //            //Swapping the string 
        //            str = swapString(str, start, i);

        //            //Recursively calling function generatePermutation() 
        //            generatePermutation(str, start + 1, end);

        //            str = swapString(str, start, i);
        //        }
        //    }
        //}
        // Method for searching the string in the string array
        //static int binarySearch(String[] arr, String x)
        //{
        //    int l = 0, r = arr.Length - 1;
        //    while (l <= r)
        //    {
        //        int m = l + (r - l) / 2;

        //        int res = x.CompareTo(arr[m]);

        //        if (res == 0)
        //        {
        //            return m;
        //        }

        //        if (res > 0)
        //        {
        //            l = m + 1;
        //        }

        //        else
        //        {
        //            r = m - 1;
        //        }
        //    }
        //    return -1;
        //}

        public static void insertionSort()
        {
            //creating an arry of number
            int[] arr = { 12, 85, 96, 15, 45, 9 };

            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
