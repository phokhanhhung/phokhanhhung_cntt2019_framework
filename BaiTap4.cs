using System;

namespace Học_C_
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Check an array having this many of elements: ");
      int n = int.Parse(Console.ReadLine());
      double[] a = new double[n];
      for(int i =0; i < a.Length; i++) {
        a[i] = double.Parse(Console.ReadLine());
      }
      Console.WriteLine("Max: " + findMax(a));
      Console.WriteLine("Min: " + findMin(a));
      Console.WriteLine("Average: " + calculateAverage(a));
      Console.WriteLine("Median: " + findMedian(a));
    }

    public static double findMin(double[] a) {
      double min = a[0];
      for( int i = 0; i < a.Length; i++) {
        if(min >= a[i]) {
          min = a[i];
        }
      }
      return min;
    }

    public static double findMax(double[] a) {
      double max = a[0];
      for( int i = 0; i < a.Length; i++) {
        if(max <= a[i]) {
          max = a[i];
        }
      }
      return max;
    }

    public static double calculateAverage(double[] a) {
      double sum = 0;
      for( int i = 0; i < a.Length; i++) {
        sum += a[i];
      }
      return sum/a.Length;
    }

    public static double findMedian(double[] a) {
      for( int i = 0; i < a.Length; i++) {      
        double min = a[i];
        for( int j = i+1; i < a.Length; i++) {
          if(min >= a[j]) {
            a[i] = a[j];
            a[j] = min;
          }
        }
      }
      if(a.Length%2 == 0) {
          return (a[(a.Length/2)-1] + a[a.Length/2])/2;
      } else return a[(a.Length-1)/2];
    }

  }
}