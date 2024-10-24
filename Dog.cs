using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    public class Dog : Animal
    {
        // Unik egenskap 
        public string dogRace { get; set; } = "Unknown";

        //Ctor + bas
        public Dog(string name = "Unknown", int age = 0, string color = "Unknown", string birthplace = "Unknown", double weight = 0.0, string dogRace = "Unknown")
            : base(name, age, color, birthplace, weight)
        {
            this.name = name;
            this.age = age;
            this.color = color;
            this.birthplace = birthplace;
            this.weight = weight;
            this.dogRace = dogRace;
        }

        public override void makeSound()
        {
            Console.WriteLine("Hunden skäller: Woof woof ");
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {name} + Age: {age} Color: {color} Birthplace: {birthplace} Weight {weight} Dograce: {dogRace}");
        }

    }
}
