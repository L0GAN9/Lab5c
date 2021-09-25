using System;

class Program {
  public static void Main (string[] args) {
    
    
    
    
    Console.WriteLine("Enter a Number");
    int x = Convert.ToInt32(Console.ReadLine());
    for (int num = 1; num < x; ++num) // Conditions and Loop
    {
      if (x%num == 0) // Conditons to be met for a Non Prime Number
      {
       Console.WriteLine("Number is Not Prime");
       {
         break;
       }
      }
      
      if (x%num != 0) // Condition to be met for a Prime Number
      {
        Console.WriteLine("Number is Prime");
        {
          break;
        }
      }
    }
  }
}