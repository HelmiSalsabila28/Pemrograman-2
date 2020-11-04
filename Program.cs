//1194018 Helmi Salsabila 

using System;

namespace TugasInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Pendidikan joni = new Pendidikan();
            Pendidikan heri = new Pendidikan();
            heri.bernafas();
            Console.WriteLine(joni.sarjana1());
            joni.sarjana2();

            Sukses hels = new Sukses();
            hels.berhasil();
            Console.WriteLine(hels.sarjana1());
            hels.sarjana3();
        }
    }
}
