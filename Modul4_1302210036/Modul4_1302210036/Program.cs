// See https://aka.ms/new-console-template for more information
using System.Data;

namespace Modul4_1302210036
{
    class mainprog
    {
        public static void Main(String[] args)
        {
            kodeBuah KB = new kodeBuah();
            PosisiKarakterGame PKG = new PosisiKarakterGame();
            Console.WriteLine("Semua Kode Buah");
            KB.getAllFCode();
            Console.WriteLine("\n");

            Console.WriteLine("Char Status");

            PKG.move();
        }
    }
    class kodeBuah
    {
        Dictionary<string, string> code_buah = new Dictionary<string, string>()
        {
            {"Apel", "A00" },
            {"Aprikot", "B00" },
            {"Alpukat", "C00" },
            {"Pisang", "D00" },
            {"Paprika", "E00" },
            {"Blackberry", "F00" },
            {"Ceri", "H00" },
            {"Kelapa", "I00" },
            {"Jagung", "J00" },
            {"Kurma", "K00" },
            {"Durian", "L00" },
            {"Anggur", "M00" },
            {"Melon", "N00" },
            {"Semangka", "O00" },
        };
        public void getKodeBuah(string code)
        {
            if (code_buah.ContainsKey(code))
            {
                Console.WriteLine(code + " : " + code_buah[code]);
            }
            else
            {
                Console.WriteLine(code + "kode tidak ditemukan");
            }
        }
        public void getAllFCode()
        {
            foreach(KeyValuePair<string, string> i in code_buah)
            {
                Console.WriteLine(i.Key+ " : " + i.Value);
            }
        }
    }
    class PosisiKarakterGame
    {
        enum state { Jongkok, Tengkurap, Berdiri, Terbang, Bawah, Atas, Keluar};

        public void move()
        {
            state state = state.Atas;

            string[] char_status = { "Jongkok", "Tengkurap", "Berdiri", "Terbang", "Atas", "Bawah" };
            do
            {
                Console.WriteLine("Karakter " + char_status[(int)state]);
                Console.Write("Press Button: ");
                string command = Console.ReadLine();
                switch (state)
                {
                    case state.Bawah:
                        if (command == "S")
                        {
                            state = state.Bawah;
                          
                        }
                        break;
                    case state.Atas:
                        if (command == "W")
                        {
                            state = state.Atas;
                        }
                        break;
                    case state.Keluar:
                        break;
                }
                if (command == "X")
                {
                    state = state.Keluar;
                }
            }while(state!= state.Keluar);
        }
    }
}