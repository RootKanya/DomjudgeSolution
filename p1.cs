using System;

class Program
{
    static void Main()
    {
        string[] ukuran = Console.ReadLine().Split();
        int jumlahA = int.Parse(ukuran[0]);
        int jumlahB = int.Parse(ukuran[1]);

        int[] angkaA = new int[jumlahA];
        string[] inputA = Console.ReadLine().Split();
        for (int i = 0; i < jumlahA; i++) {
            angkaA[i] = int.Parse(inputA[i]);
        }

        int[] angkaB = new int[jumlahB]; 
        string[] inputB = Console.ReadLine().Split();
        for (int i = 0; i < jumlahB; i++) {
            angkaB[i] = int.Parse(inputB[i]);
        }
        string hasil = " ";
        for (int i = 0; i < jumlahA; i++) {
            bool ketemuDiB = false; 
            for (int j = 0; j < jumlahB; j++) {
                if (angkaA[i] == angkaB[j]) {
                    ketemuDiB = true; 
                    break; 
                }
            }
            if (!ketemuDiB) {
                hasil += angkaA[i] + " "; 
            }
        }

        if (hasil.Length > 0) {
            Console.WriteLine(hasil);
        }
    }
}