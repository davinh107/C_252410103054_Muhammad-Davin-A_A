using System.Reflection.Metadata;

namespace C_252410103054_Muhammad_Davin_A_A
{
    //1. 
    public class Sekolah
    {
        public string idSekolah;
        public string namaSekolah;
        public int jumlahPaketDiterima;

        public Sekolah (string idskul, string namaskul, int jumpkttrima)
        {
            this.idSekolah = idskul;
            this.namaSekolah = namaskul;
            this.jumlahPaketDiterima = jumpkttrima;
        }
        public void Tampilinfo()
        {
            Console.WriteLine($"Sekolah {namaSekolah} ID sekolah ini adalah: {idSekolah} Jumlah Paketnya {jumlahPaketDiterima}");
        }
    }
    class Program
    {
        static void Main()
        {
            Sekolah sekolah1 = new Sekolah("ABA223", "Esdeh12", 122);
            sekolah1.Tampilinfo();

            Sekolah sekolah2 = new Sekolah("ADE561", "Esdeh67", 78);
            sekolah2.Tampilinfo();
        }
    }
    // 2. Encapsulation 
    public class PaketMbg
    {
        private string idPaket; 
        private string namaPaket;
        private int stokDapur;

        public PaketMbg (string idPaket, string namaPaket, int stokDapur    )
        {
            this.idPaket = idPaket;
            this.namaPaket = namaPaket;
            this.stokDapur = stokDapur;
        }
        public void KurangiStok(int jumlah)
        {
            "HEYY ANTEK ANTEK ASENG"
        }
        
    }
    class Program
    {
        static int Main()
        {
            if (PaketMbg.stokDapur < 0)
                Console.WriteLine("Stok Tidak Boleh NEGATIF !!!");
            else
        }
    }
    //3. inheritance 
    class PaketReguler
    {
        public string harga;

    }
    //4. Polymorphism
    class program
    {
        static void Main(string[] args)
        {

        }
    }
    //5. Abstract Class
    class program
         static void Main(string[] args)
    {

    }
    //6. Interface 
    ui ux :, )
            
}
