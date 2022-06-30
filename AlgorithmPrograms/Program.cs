using System;

namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prime Numbers list from 0 to 1000
            primeNumber();

            //// Anagram
            //anagram();

            // creating the Array
            //int[] arr = { 12, 11, 13, 5, 6, 7 };
            //Console.WriteLine("Given Array");
            //printArray(arr);

            ////Getting Sorted Array by
            //sort(arr, 0, arr.Length - 1);
            //Console.WriteLine("\nSorted array");
            //printArray(arr);

            ////Insertion Sorting
            //bubbleSort();
            //Inserion sorting
            //insertionSort();
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

        //public static void insertionSort()
        //{
        //    //creating an arry of number
        //    int[] arr = { 12, 85, 96, 15, 45, 9 };

        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        int temp = arr[i];
        //        int j = i - 1;

        //        while (j >= 0 && arr[j] > temp)
        //        {
        //            arr[j + 1] = arr[j];
        //            j--;
        //        }
        //        arr[j + 1] = temp;
        //    }

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}

        //public static void bubbleSort()
        //{
        //    //creating an arry of number
        //    int[] arr = { 78, 55, 45, 98, 13 };

        //    //Creating temp variable
        //    int temp;

        //    for (int j = 0; j <= arr.Length - 2; j++)
        //    {
        //        for (int i = 0; i <= arr.Length - 2; i++)
        //        {
        //            if (arr[i] > arr[i + 1])
        //            {
        //                temp = arr[i + 1];
        //                arr[i + 1] = arr[i];
        //                arr[i] = temp;
        //            }
        //        }
        //    }
        //    Console.WriteLine("Sorted :");
        //    // Printing the sorted array
        //    foreach (int p in arr)
        //    {
        //        Console.Write(p + " ");
        //    }
        //}

        ////Creating the Merge Sort Method
        //public static void mergeSort(int[] arr, int l, int m, int r)
        //{

        //    int n1 = m - l + 1;
        //    int n2 = r - m;


        //    int[] L = new int[n1];
        //    int[] R = new int[n2];
        //    int i, j;

        //    for (i = 0; i < n1; ++i)
        //        L[i] = arr[l + i];
        //    for (j = 0; j < n2; ++j)
        //        R[j] = arr[m + 1 + j];


        //    i = 0;
        //    j = 0;

        //    int k = l;
        //    while (i < n1 && j < n2)
        //    {
        //        if (L[i] <= R[j])
        //        {
        //            arr[k] = L[i];
        //            i++;
        //        }
        //        else
        //        {
        //            arr[k] = R[j];
        //            j++;
        //        }
        //        k++;
        //    }

        //    while (i < n1)
        //    {
        //        arr[k] = L[i];
        //        i++;
        //        k++;
        //    }

        //    while (j < n2)
        //    {
        //        arr[k] = R[j];
        //        j++;
        //        k++;
        //    }
        //}
        ////Sorting the Array
        //public static void sort(int[] arr, int l, int r)
        //{
        //    if (l < r)
        //    {
        //        int m = l + (r - l) / 2;
        //        sort(arr, l, m);
        //        sort(arr, m + 1, r);
        //        mergeSort(arr, l, m, r);
        //    }
        //}
        ////printing the array
        //public static void printArray(int[] arr)
        //{
        //    int n = arr.Length;
        //    for (int i = 0; i < n; ++i)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }

        //    Console.WriteLine();
        //}

        //Creating the anagram Method
        //public static void anagram()
        //{
        //    string OP1, OP2;
        //    //Getting the  input From the user
        //    Console.WriteLine("Enter the First Word:");
        //    OP1 = Console.ReadLine();

        //    //Getting the  input From the user
        //    Console.WriteLine("Enter the Second Word:");
        //    OP2 = Console.ReadLine();

        //    //Converting the input Character into lowercase 
        //    char[] ch1 = OP1.ToLower().ToCharArray();
        //    char[] ch2 = OP2.ToLower().ToCharArray();

        //    //Sorting character of the input
        //    Array.Sort(ch1);
        //    Array.Sort(ch2);

        //    //Assigning the sorted char into string
        //    string val1 = new string(ch1);
        //    string val2 = new string(ch2);

        //    if (val1 == val2)
        //    {
        //        Console.WriteLine("Both the Words are Anagrams");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Both the Words are not Anagrams");
        //    }
        //}
        // Creating Prime Number Method
        public static void primeNumber()
        {
            bool isPrime = true;
            int i, j;

            Console.WriteLine("Prime Numbers are : ");

            for (i = 2; i <= 1000; i++)
            {
                for (j = 2; j <= 1000; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
        }
    }
}
