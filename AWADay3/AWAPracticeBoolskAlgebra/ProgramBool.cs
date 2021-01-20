using System;
using System.Collections.Generic;

namespace AWAPracticeBoolskAlgebra
{
    class ProgramBool
    {
        static void Main(string[] args)
        {
            Frukt[] frukter = new Frukt[8];

            Frukt frukt = new Frukt();
            frukt.FruktTyp = "Banan";
            frukt.FruktNamn = "Chiquita";
            frukt.PrisPerKg = 22;
            frukter[0] = frukt;

            frukt = new Frukt();
            frukt.FruktTyp = "Banan";
            frukt.FruktNamn = "Dole";
            frukt.PrisPerKg = 25;
            frukter[1] = frukt;

            frukt = new Frukt();
            frukt.FruktTyp = "Banan";
            frukt.FruktNamn = "Del monte";
            frukt.PrisPerKg = 30;
            frukter[2] = frukt;

            frukt = new Frukt();
            frukt.FruktTyp = "Apelsin";
            frukt.FruktNamn = "Valencia";
            frukt.PrisPerKg = 24;
            frukter[3] = frukt;

            frukt = new Frukt();
            frukt.FruktTyp = "Apelsin";
            frukt.FruktNamn = "Mandarin";
            frukt.PrisPerKg = 30;
            frukter[4] = frukt;

            frukt = new Frukt();
            frukt.FruktTyp = "Apelsin";
            frukt.FruktNamn = "Blod";
            frukt.PrisPerKg = 27;
            frukter[5] = frukt;

            frukt = new Frukt();
            frukt.FruktTyp = "Päron";
            frukt.FruktNamn = "Anjou";
            frukt.PrisPerKg = 19;
            frukter[6] = frukt;

            frukt = new Frukt();
            frukt.FruktTyp = "Päron";
            frukt.FruktNamn = "Bartlett";
            frukt.PrisPerKg = 32;
            frukter[7] = frukt;

            //4. Skapa en for loop som endast listar samtliga frukter med ett pris lägre än 30
            //kronor.

            Console.WriteLine($"Frukter under 30: ");

            for (int i = 0; i < frukter.Length; i++)
            {
                if (frukt.PrisPerKg < 30)
                {
                    Console.WriteLine($"{frukter[i].FruktTyp} av typen {frukter[i].FruktNamn}");
                }
            }

            //5. Skapa en for loop som endast listar samtliga apelsiner som kostar mer än 25
            //kronor.

            Console.WriteLine($"Apelsinsorter över 25: ");

            for (int i = 0; i < frukter.Length; i++)
            {
                if (frukt.FruktTyp == "Apelsin" && frukt.PrisPerKg > 25)
                {
                    Console.WriteLine($"{frukt.FruktNamn}");
                }
            }

        }
    }
}
