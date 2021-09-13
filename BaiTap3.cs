// using System;

// namespace Number3
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Console.WriteLine("Find the greatest common divisor");
//       Console.Write("Enter the fisrt number: ");
//       int a = int.Parse(Console.ReadLine());
//       Console.Write("Enter the second number: ");
//       int b = int.Parse(Console.ReadLine());
//       Console.WriteLine("The gratest common divior is: " + findTheGratestCommonDivisor(a, b));
      
//       Console.WriteLine("Find the least common multiple");
//       Console.Write("Enter the fisrt number: ");
//       int c = int.Parse(Console.ReadLine());
//       Console.Write("Enter the second number: ");
//       int d = int.Parse(Console.ReadLine()); 
//       Console.WriteLine("The least common multiple is: " + findTheLeastCommonMultiple(c, d));
//     }

//     public static int findTheGratestCommonDivisor(int a, int b) {
//       if(a%b == 0) return b;
//       else if(b%a == 0) return a;
//       else if(a <= b){
//         int k = 0;
//         for(int i = 1; i <= Math.Sqrt(a); i++) {
//           if(a%i == 0 && b%i == 0) k = i;
//         }
//         return k;
//       } else {
//         int k = 0;
//         for(int i = 1; i <= Math.Sqrt(b); i++) {
//           if(a%i == 0 && b%i == 0) k = i;
//         }
//         return k;
//       }
//     }

//     public static int findTheLeastCommonMultiple(int a, int b) {
//       if(a%b == 0) return a;
//       else if(b%a == 0) return b;
//       else return a*b;
//     }
//   }
// }