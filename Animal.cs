using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Lab_6___OOP_Arv
{
    public abstract class Animal
    {
        // Egenskaper tilldelat med defaultvärde
        public string name { get; set; } = "noName";
        public int age { get; set; } = 0;
        public string color { get; set; } = "Unknown";
        public string birthplace { get; set; } = "Unknown";
        public double weight { get; set; } = 0.0;

        public Animal(string name, int age, string color, string birthplace, double weight)
        {
            this.name = name;
            this.age = age;
            this.color = color;
            this.birthplace = birthplace;
            this.weight = weight;
        }

        public void sleep(bool nosie)
        {
            if (nosie)
            {
                Console.WriteLine("Du väkte ditt djur");
            }
            else
            {
                Console.WriteLine("Zzz");
            }
        }
        public virtual void makeSound()
        {
            Console.WriteLine(" OoooooOOoooOOoo ");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {name} + Age: {age} Color: {color} Birthplace: {birthplace} Weight {weight}");
        }
    }
}
