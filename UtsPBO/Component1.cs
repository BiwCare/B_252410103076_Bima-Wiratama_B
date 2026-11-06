using System;
using UtsPBO;
using static System.Net.Mime.MediaTypeNames;



namespace UtsPBO
{
    //public class Agen
    //{
    //    public string idAgen;
    //    public string namaAgen;
    //    public int stokAgen;

    //    public void Tampilaninfo()
    //    {
    //        string idAgen = ("01");
    //        string namaAgen = ("Budi");
    //        int stokAgen = (2);
    //        Console.WriteLine("idAgen: " + idAgen);
    //        Console.WriteLine("namaAgen: " + namaAgen);
    //        Console.WriteLine("stokAgen: " + stokAgen);
    //    }


    //    }

    public class produkGalon
    {
        produkGalon produk = new produkGalon();
        produk.Tampilaninfo();
        
        private string idProduk;
        private string namaProduk;
        private int stokProduk;
        public void Tampilaninfo()
        {
            string idProduk = "01";
            string namaProduk = "Aqua";
            int stokProduk = 10;
            int kurangiStok = stokProduk - 1;
            if (stokProduk > 0)
            {
                Console.WriteLine("idProduk: " + idProduk);
                Console.WriteLine("namaProduk: " + namaProduk);
                Console.WriteLine("stokProduk: " + stokProduk);
            }
            else
            {
                Console.WriteLine("Stok produk habis.");
            }
        }
        static void Main(string[] args)
        {
        class galonAqua : produkGalon
        {
            static void Main(string[] args)
            {
                galonAqua produk = new galonAqua();
                int abstract HargaGalonAqua = 20000;
                produk.Tampilaninfo();
            }
    }
    class galonBerkeran : produkGalon
    {
        static void Main(string[] args)
        {
            galonBerkeran produk = new galonBerkeran();
            int abstract HargaGalonBerkeran = stokProduk* 12000;
                produk.Tampilaninfo();
            }
}
    }
    };


};
