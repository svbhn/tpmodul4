using tpmodul4_103022300081;

namespace tpmodul4_103022300081
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Table-Driven Implementation ===");
            KodePos kodePos = new KodePos();

            Console.WriteLine("Kode Pos Batununggal: " + kodePos.getKodePos("Batununggal"));
            Console.WriteLine("Kode Pos Kujangsari: " + kodePos.getKodePos("Kujangsari"));
            Console.WriteLine("Kode Pos Mengger: " + kodePos.getKodePos("Mengger"));
            Console.WriteLine("Kode Pos Wates: " + kodePos.getKodePos("Wates"));
            Console.WriteLine("Kode Pos Cijaura: " + kodePos.getKodePos("Cijaura"));
            Console.WriteLine("Kode Pos Jatisari: " + kodePos.getKodePos("Jatisari"));
            Console.WriteLine("Kode Pos Margasari: " + kodePos.getKodePos("Margasari"));
            Console.WriteLine("Kode Pos Sekejati: " + kodePos.getKodePos("Sekejati"));
            Console.WriteLine("Kode Pos Kebonwaru: " + kodePos.getKodePos("Kebonwaru"));
            Console.WriteLine("Kode Pos Maleer: " + kodePos.getKodePos("Maleer"));
            Console.WriteLine("Kode Pos Samoja: " + kodePos.getKodePos("Samoja"));

            Console.WriteLine("\n=== State-Based Implementation ===");

            DoorMachine door = new DoorMachine();

            Console.WriteLine("\nMencoba membuka pintu...");
            door.BukaPintu();

            Console.WriteLine("\nMencoba membuka pintu lagi...");
            door.BukaPintu();

            Console.WriteLine("\nMencoba mengunci pintu...");
            door.KunciPintu();

            Console.WriteLine("\nMencoba mengunci pintu lagi...");
            door.KunciPintu();

            Console.WriteLine("\nMencoba membuka pintu lagi...");
            door.BukaPintu();

            Console.WriteLine("\nState akhir: " +
                (door.GetCurrentState() == DoorMachine.State.Terkunci ? "Terkunci" : "Terbuka"));

            Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }
}
