using System;

class Program {
  public static void Main (string[] args) {
    
    
    
    
    Console.WriteLine("Enter a Number");
    int x = Convert.ToInt32(Console.ReadLine());
    for (int num = 2; num < x; num++)
    {
      if (x%num == 0)
      {
       Console.WriteLine("Number is Not Prime");
       {
         break;
       }
      }
      
      if (x%num != 0)
      {
        Console.WriteLine("Number is Prime");
        {
          break;
        }
      }
    }
  }
}