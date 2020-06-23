using System;
using System.Globalization;

namespace DogsWithInterfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            var col = new Collie
            {
                Name = "Lassie",
                Color = "Light Brown",
                BarkSound = "Woof!"
            };
            // one of few times to put semi colon after curly brace
            col.Bark();

            var box = new Boxer
            {
                Name = "Rocky",
                Color = "Black",
                BarkSound = "Woof Woof!"
            };
            box.Bark();

            var chi = new Chihuahua
            {
                Name = "Killer",
                Color = "White",
                BarkSound = "Yip!"
            };
            chi.Bark();

            IDog[] dogs = new IDog[10];
            dogs[0] = col;
            dogs[1] = box;
            dogs[2] = chi;

            //if you use a foreach for a collection of things USE IT!, less code than a for loop

            foreach(var dog in dogs)
            {
                if (dog == null) continue;
                Console.WriteLine($"Name is {dog.Name}, color is {dog.Color}.");
                //, barkSound is {dog.BarkSound}
                dog.Bark();

            }
        }
    }
}
