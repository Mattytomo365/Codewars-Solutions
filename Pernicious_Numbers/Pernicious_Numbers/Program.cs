using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;

public class Kata
{
  public static object Pernicious(double n)
  {
    List<int> numbers = new List<int>();

    if (n <= 0){
        return "No pernicious numbers";
    }

    else if ((n % 1) != 0){
         n = Math.Floor(n);
    }

    for (int i =1; i<= n; i++){
        string binary = Convert.ToString(i, 2);
        int count = 0;

        foreach (char c in binary){
            if (c == '1'){
                count++;
            }
        }

        if (IsPrime(count)) {
            numbers.Add(i);
        }

    }

    if (numbers.Count == 0){
        return "No pernicious numbers";
    }

    return numbers.ToArray();

    }

    private static bool IsPrime(int number){
        if (number < 2){
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++){
            if (number % i == 0){
                return false;
            }
        }

        return true;
    }
}

public class Program{
    public static void Main(string [] args){
        int[] result = (int[])Kata.Pernicious(5);
        Console.WriteLine(string.Join(", ", result));

    }
}
