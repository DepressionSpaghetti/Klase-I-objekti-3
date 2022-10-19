using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseIobjekti2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaC klasaC = new KlasaC();
            int[] polje = new int[5];
            int zbroj;
            double prosjek;

            Console.WriteLine("Upišite 5 cijelih brojeva");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Upišite " + (i+1) + ". cijeli broj.");
                polje[i] = Convert.ToInt32(Console.ReadLine());

            }

            zbroj = KlasaC.Zbroj(polje);
            prosjek = KlasaC.Prosjek(polje);

            Console.WriteLine("Zbroj: " + zbroj);
            Console.WriteLine("Prosjek " + prosjek);

            Console.ReadKey();
        }
    }
    public class KlasaC
    {


        public static int Zbroj(int[] zb)
        {
            int zbrojPolja = zb.Sum();

            return zbrojPolja;
        }

        public static double Prosjek(int[] polj)
        {
            int zbroj = polj.Sum();
            double pros = (double)zbroj / polj.Length;

            return pros;
        }

    }
}
