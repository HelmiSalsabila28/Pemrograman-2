using System;

namespace TugasInheritance
{

    public class Pendidikan : Seseorang
    {

        public string sarjana1()
        {
            return "Saya sedang menempuh S1/D4";
        }

        public void sarjana2()
        {
            Console.WriteLine("Saya ingin bisa melanjutkan pendidikan S2");
        }

        public void sarjana3()
        {
            Console.WriteLine("Berharap sekali S3 pun bisa tercapai hingga lulus dan sukses. amin..yrb");
        }
    }
}