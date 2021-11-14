using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_App
{
    //inheritance
    class Invoice : Payment
    {
        public string[] Type { get; set; }
        public int Choice { get; set; }

        public void InvoicePembelian()
        {
            Console.WriteLine("--- NOTA PEMBELIAN TOKO SEPEDA MAJU MAKMUR---");
            Console.WriteLine("Barang yang Dibeli : " + Type[Choice]);
            Console.WriteLine("Jumlah Barang : " + Quantity);
            TotalPrice();
            Console.WriteLine("--- JIKA PUAS, BERITAHU TEMAN ---");
            Console.WriteLine("--- JIKA TAK PUAS, BERITAHU KAMI ---");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
