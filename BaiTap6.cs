using System;

namespace Học_C_
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Enter year: ");
          int year = int.Parse(Console.ReadLine());
          do {
            Console.Write("Enter year: ");
            year = int.Parse(Console.ReadLine());
          } while(year <= 0);
          calculateCanChi(year);
        }

        public static void calculateCanChi(int n) {
          string can = "";
          string chi = "";
          switch(n%10) {
            case 0:
              can = "Canh";
              break;
            case 1:
              can = "Tan";
              break;
            case 2:
              can = "Nham";
              break;
            case 3:
              can = "Quy";
              break;
            case 4:
              can = "Giap";
              break;
            case 5:
              can = "At";
              break;
            case 6:
              can = "Binh";
              break;
            case 7:
              can = "Dinh";
              break;
            case 8:
              can = "Mau";
              break;
            case 9:
              can = "Ky";
              break;
          }

          switch(n%12) {
            case 0:
              chi = "Than";
              break;
            case 1:
              chi = "Dau";
              break;
            case 2:
              chi = "Tuat";
              break;
            case 3:
              chi = "Hoi";
              break;
            case 4:
              chi = "Ty";
              break;
            case 5:
              chi = "Suu";
              break;
            case 6:
              chi = "Dan";
              break;
            case 7:
              chi = "Mao";
              break;
            case 8:
              chi = "Thin";
              break;
            case 9:
              chi = "Ti";
              break;
            case 10:
              chi = "Ngo";
              break;
            case 11:
              chi = "Mui";
              break;
          }

          Console.WriteLine("Nam " + n + " co can chi la: " + can + " " + chi);
        }
    }
}