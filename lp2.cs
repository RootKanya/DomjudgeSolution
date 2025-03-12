using System;

class Program
{
  static void Main()
  {
    int N = int.Parse(Console.ReadLine());
    int sum = 0;
    int[] A = new int[N];

    string[] input = Console.ReadLine().Split();
    for (int i = 0; i < N; i++)
    {
      A[i] = int.Parse(input[i]);
    }

    for (int i = 1; i < N - 1; i++)
    {
      if (A[i] > A[i - 1] && A[i] > A[i + 1])
      {
        sum += A[i];
      }
    }

    Console.WriteLine(sum);
  }
}

