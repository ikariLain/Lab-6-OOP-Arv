using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Initiera objekt för Bulldog och Chihuahua med deras egenskaper
            Bulldog bulldog = new Bulldog("Rex" ,7, "Brun", "Stockholm", 25.0, "Sverige", "Bulldog");

            Chihuahua chihuahua = new Chihuahua("Tiny", 3, "Vit", "Göteborg", 5.0, "Kattala", "Chihuahua", "Kort");

            // Visa information om Bulldog
            Console.WriteLine("Information om Bulldog:");
            bulldog.ShowInfo();
            bulldog.makeSound();
            bulldog.AmountShowerd(3); 

            Console.WriteLine();

            // Visa information om Chihuahua
            Console.WriteLine("Information om Chihuahua:");
            chihuahua.ShowInfo();
            chihuahua.makeSound();
            chihuahua.annoyingMeter(30);

            Console.ReadLine(); 

        }
    }
}
