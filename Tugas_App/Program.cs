using System;

namespace Tugas_App
{
    class Program
    { 
        static void Main(string[] args)
        {
            MainMenu();
            int pilihan = InputConvert();
            switch (pilihan)
            {
                case 1:
                    ChooseFrame();
                    break;
                case 2:
                    ChooseRoda();
                    break;
                default:
                    Console.WriteLine("Anda memasukkan pilihan yang salah");
                    break;
            }
        }
        static void MainMenu()
        {
            Console.WriteLine("---TOKO SEPEDA MAJU MAKMUR---");
            Console.WriteLine("Pilihan Barang : ");
            Console.WriteLine("1. Frame Sepeda");
            Console.WriteLine("2. Roda Sepeda");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Pilihan Anda : ");
        }
        static public int InputConvert()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
        static void ChooseFrame()
        {
            Invoice NotaFrame = new Invoice();
            int harga_frame;
            //array daftar frame_sepeda
            string[] frame_sepeda = new string[3]
            {"1. Specialized = RP. 2000000",
            "2. Giant = RP. 3000000",
            "3. Bianchi = RP. 4000000"
             };
            Console.WriteLine("Pilihan Frame Sepeda : ");
            foreach (var n in frame_sepeda)
            {
                Console.WriteLine(n);
            }
            NotaFrame.Type = frame_sepeda;
            Console.WriteLine("Frame yang dipilih = ");
            int pilihan_frame = InputConvert() - 1;
            if (pilihan_frame == 0)
            {
                harga_frame = 2000000;
            }
            else if (pilihan_frame == 1)
            {
                harga_frame = 3000000;
            }
            else
            {
                harga_frame = 4000000;
            }
            NotaFrame.Choice = pilihan_frame;
            NotaFrame.Price = harga_frame;
            Console.WriteLine("Jumlah Frame Sepeda yang Dibeli : ");
            int jumlahan_frame = InputConvert();
            NotaFrame.Quantity = jumlahan_frame;
            NotaFrame.InvoicePembelian();
        }
        static void ChooseRoda()
        {
            Invoice NotaRoda = new Invoice();
            int harga_roda;
            //array daftar roda_sepeda
            string[] roda_sepeda = new string[3]
            {
            "1. Ring 19 = RP. 250000",
            "2. Ring 20 = RP. 350000",
            "3. Ring 21 = RP. 450000"
            };
            Console.WriteLine("Pilih Roda Sepeda : ");
            foreach (var n in roda_sepeda)
            {
                Console.WriteLine(n);
            }
            NotaRoda.Type = roda_sepeda;
            Console.WriteLine("Roda yang dipilih = ");
            int pilihan_roda = InputConvert() - 1;
            Console.WriteLine(roda_sepeda[pilihan_roda]);
            if (pilihan_roda == 0)
            {
                harga_roda = 250000;
            }
            else if (pilihan_roda == 1)
            {
                harga_roda = 350000;
            }
            else
            {
                harga_roda = 450000;
            }
            NotaRoda.Choice = pilihan_roda;
            NotaRoda.Price = harga_roda;
            Console.WriteLine("Jumlah Roda Sepeda yang Dibeli : ");
            int jumlahan_roda = InputConvert();
            NotaRoda.Quantity = jumlahan_roda;
            NotaRoda.InvoicePembelian();
        }
    }
}
