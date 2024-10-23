using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    public class Bulldog : Dog
    {
        // Unik egenskap
        public string region { get; set; } = "Unknown";

        // Ctor + bas
        public Bulldog(string name, int age, string color, string birthplace, double weight, string region, string dogRace)
            : base(name, age, color, birthplace, weight, dogRace)
        {
            this.name = name;
            this.age = age;
            this.color = color;
            this.birthplace = birthplace;
            this.weight = weight;
            this.region = region;
        }

        public void AmountShowerd(int showered)
        {
            
            string text= $" Din bulldog har duschad {showered} antal gånger";

        }

        public override void makeSound()
        {
            Console.WriteLine("Bulldog Skäller med ett djupt: WOOF WOOF! ");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {name} + Age: {age} Color: {color} Birthplace: {birthplace} Weight {weight} Dograce: {dogRace} Region: {region}");
        }
    }
}
