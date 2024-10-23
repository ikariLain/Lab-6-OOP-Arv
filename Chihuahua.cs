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

        public Chihuahua(string name, int age, string color, string birthplace, double weight, string region, string dogRace, string tailLength)
           : base(name, age, color, birthplace, weight, dogRace)
        {
            this.name = name;
            this.age = age;
            this.color = color;
            this.birthplace = birthplace;
            this.weight = weight;
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
