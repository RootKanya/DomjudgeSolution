using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        
        int jumlahGenap = 0;
        int jumlahGanjil = 0;

        for (int i = 0; i < n; i++) {
            int angka = int.Parse(input[i]);
            if (angka % 2 == 0) {
                jumlahGenap += angka;
            }
            else {
                jumlahGanjil += angka;
            }
        }
        Console.WriteLine(jumlahGenap + " " + jumlahGanjil);
    }
}

