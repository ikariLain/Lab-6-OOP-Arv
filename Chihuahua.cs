using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    public class Chihuahua : Dog
    {
        public string tailLength { get; set; } = "Unknown";

        public Chihuahua(string name = "Unknown", int age = 0, string color = "Unknown", string birthplace = "Unknown", double weight = 0, string region = "Unknown", string dogRace = "Unknown", string tailLength = "Unknown")
           : base(name, age, color, birthplace, weight, dogRace)
        {
           
            this.tailLength = tailLength;
        }

        public override void makeSound()
        {
            Console.WriteLine("Chihuahua skäller med ett hög Yip yip!");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {name} + Age: {age} Color: {color} Birthplace: {birthplace} Weight {weight} Dograce: {dogRace} TailLength {tailLength}");
        }
        public void annoyingMeter(int newData)
        {
            int alreadyAnnoying = 50;

            if (newData + alreadyAnnoying >= 100)
            {
                Console.WriteLine("Insert Homer Simpsons & Bart reference");
                Console.WriteLine("Chihuahua is dead");
            }
            else
            {
                Console.WriteLine("It's still alive ");
            }
        }
    }
}
