
using System;
using System.Runtime.Intrinsics.X86;

public class Program
{
    public static void printArray(int[] array, int x)
    {

        //Console.WriteLine("Imprimiendo arreglo: " + x);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();

    }

    public static void printVector(String[] array)
    {

        //Console.WriteLine("Imprimiendo arreglo: " + x);
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i] + " ");
        }

        Console.WriteLine();

    }

    

    public static int climbStairs(int n)
    {
        if (n == 1) return 1;
        else if (n == 2) return 2;
        return climbStairs(n - 1) + climbStairs(n - 2);

    }
    public static void Main()
    {
        string palabra = "3A4F";
        Console.WriteLine(10 + ('F' - 'A'));
        Console.WriteLine('F'-1);
        
        /*
        string ejemplo = "     Ejemplo numero eins     ";
        string ejemplo2 = "     Ejemplo numero eias     ";

        Console.WriteLine(ejemplo.Length);
        printVector(newSplit(ejemplo, ' '));
        Console.WriteLine();  

        */
        //Console.WriteLine(newIndexOf(ejemplo, '5'));
        //Console.WriteLine(newTrim(ejemplo));


        //Console.WriteLine(FactRec(5));
        //Console.WriteLine(FiboRec(9)); 
 
    }

}
