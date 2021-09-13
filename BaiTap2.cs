// using System;

// namespace Học_C_
// {
//   class Number2
//   {
//     static void Main(string[] args)
//     {
//       Console.Write("Check prime number: ");
//       double num = double.Parse(Console.ReadLine());
//       if(isPrime(num)) Console.WriteLine(num + " is a prime.");
//       else Console.WriteLine(num + " is not a prime.");

//       Console.Write("Check square number: ");
//       double ber = double.Parse(Console.ReadLine());
//       if(isSquareNumber(ber)) Console.WriteLine(ber + " is a square number.");
//       else Console.WriteLine(num + " is not a square number.");
//     }

//     public static bool isPrime(double n) {
//       int sum = 0;
//       if(n >= 1 && (n%2 == 0 || n%2 == 1)) {
//         for(int i = 1; i <= Math.Sqrt(n); i++) {
//           if(n%i == 0) sum++;
//         } 
//         if(sum==1) return true;
//         else return false;
//       } else {
//         return false;
//       }
//     }

//     public static bool isSquareNumber(double n) {
//       if(n >= 1) {
//         double a = Math.Sqrt(n);
//         if(a%2 == 0 || a%2 ==1) return true;
//         else return false;
//       } else return false;
//     }
//   }
// }
