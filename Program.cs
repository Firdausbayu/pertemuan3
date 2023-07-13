using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laprak3
{
    public class program
    {
        static void Main(string[] args)
        {
            mobil mobil1 = new mobil();
            mobil1.Merk = "Honda";
            mobil1.Warna = "Putih";
            mobil1.Model = "Brio";
            mobil1.Jumlahpintu = "5";
            mobil1.Tahunkeluaran = "2018";
            mobil1.Kecepatan = "145km/jam";

            mobil1.Kecepatanmobil();
            mobil1.Klaksonmobil();
            mobil1.Keterangan();
        }
    }
}