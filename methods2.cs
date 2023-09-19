//Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
using System;
public class methods2 {
  public static void Main (string [] args){
    Console.Write("Enter a number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The sum of the digits in the number is: " + sumofdigits(num));
  }
  public static int sumofdigits(int num){
    int sum=0;
    while (num/10>0){
      sum+=num%10;
      num=num/10;
    }
    return sum;
  }
}
