using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        string[] input = Console.ReadLine().Split();

        for (int i = 0; i < n; i++) {
            arr[i] = int.Parse(input[i]);
        }

        int totalMaksimum = arr[0];
        int jumlahBaru = arr[0];
        int awal = 0, akhir = 0, awalSementara = 0;

        for (int i = 1; i < n; i++) {
            if (jumlahBaru + arr[i] < arr[i]) {
                jumlahBaru = arr[i];
                awalSementara = i;
            }
            else {
                jumlahBaru += arr[i];
            }

            if (jumlahBaru > totalMaksimum) {
                totalMaksimum = jumlahBaru;
                awal = awalSementara;
                akhir = i;
            }
        }
        Console.WriteLine(totalMaksimum);
        Console.WriteLine(awal + " " + akhir);
    }
}

