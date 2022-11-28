using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class compare : IComparer
{

    // Call CaseInsensitiveComparer.Compare
    public int Compare(Object x, Object y)
    {
        return (new CaseInsensitiveComparer()).Compare(x, y);
    }
}

class GFG
{

    // Main Method
    public static void Main()
    {

        // Initializing array.
        String[] arr = {"A", "D", "B",
                  "E", "C", "F", "G"};

        // Instantiate the IComparer object
        IComparer cmp = new compare();

        // Display the original values of the array
        Console.WriteLine("The Original array:");
        display(arr);

        // Sort the entire array by using
        // the IComparer object
        // "cmp" is the IComparer object
        Array.Sort(arr, cmp);

        Console.WriteLine("\nAfter sorting the array" +
                             " using the IComparer:");
        display(arr);
    }

    // display function
    public static void display(String[] arr)
    {
        foreach (String a in arr)
            Console.WriteLine(a);
    }
}