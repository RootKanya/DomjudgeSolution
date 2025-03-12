using System;

class Program
{
    static void Main()
    {
        
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        string[] numbers = Console.ReadLine().Split();
        int count = 0;

        for (int i = 0; i < N; i++) {
            if (int.Parse(numbers[i]) == B) {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

