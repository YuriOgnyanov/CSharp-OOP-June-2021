using System;
using System.Collections.Generic;
using WildFarm.Model.Animal;
using WildFarm.Model.Food;
using System.Linq;

namespace WildFarm
{
    public class Startup
    {
        static void Main(string[] args)
        {
            Stack<Animal> animals = new Stack<Animal>();

            string input = Console.ReadLine();

            int counter = 0;

            while (input != "End")
            {
                counter++;


                if (counter % 2 != 0)
                {
                    //animal
                    string[] cmdArgs = input
                        .Split();
                    string type = cmdArgs[0];
                    ValidateTypeAnimals(animals, cmdArgs, type);
                }
                else
                {
                    //food
                    string[] cmdArgs = input
                       .Split();
                    string type = cmdArgs[0];
                    ValidateFoodType(animals, cmdArgs, type);
                }

                input = Console.ReadLine();
            }

            foreach (var animal in animals.Reverse())
            {
                Console.WriteLine(animal.ToString());
            }
        }

        private static void ValidateFoodType(Stack<Animal> animals, string[] cmdArgs, string type)
        {
            if (type is "Vegetable")
            {
                Food vegetables = new Vegetable(int.Parse(cmdArgs[1]));
                SoundWithEat(animals, vegetables);
            }
            else if (type is "Meat")
            {
                Food meat = new Meat(int.Parse(cmdArgs[1]));
                SoundWithEat(animals, meat);
            }
            else if (type is "Seeds")
            {
                Food seeds = new Seeds(int.Parse(cmdArgs[1]));
                SoundWithEat(animals, seeds);
            }
            else if (type is "Fruit")
            {
                Food fruit = new Fruit(int.Parse(cmdArgs[1]));
                SoundWithEat(animals, fruit);
            }
        }

        private static void ValidateTypeAnimals(Stack<Animal> animals, string[] cmdArgs, string type)
        {
            if (type is "Cat")
            {
                Animal cat = new Cat(cmdArgs[1], double.Parse(cmdArgs[2]), cmdArgs[3], cmdArgs[4]);
                animals.Push(cat);
            }
            else if (type is "Tiger")
            {
                Animal tiger = new Tiger(cmdArgs[1], double.Parse(cmdArgs[2]), cmdArgs[3], cmdArgs[4]);
                animals.Push(tiger);
            }
            else if (type is "Dog")
            {
                Animal dog = new Dog(cmdArgs[1], double.Parse(cmdArgs[2]), cmdArgs[3]);
                animals.Push(dog);
            }
            else if (type is "Hen")
            {
                Animal hen = new Hen(cmdArgs[1], double.Parse(cmdArgs[2]), double.Parse(cmdArgs[3]));
                animals.Push(hen);
            }
            else if (type is "Mouse")
            {
                Animal mouse = new Mouse(cmdArgs[1], double.Parse(cmdArgs[2]), cmdArgs[3]);
                animals.Push(mouse);
            }
            else if (type is "Owl")
            {
                Animal owl = new Owl(cmdArgs[1], double.Parse(cmdArgs[2]), double.Parse(cmdArgs[3]));
                animals.Push(owl);
            }
        }

        private static void SoundWithEat(Stack<Animal> animals, Food food)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Sound());
                animal.Eat(food);
                break;
            }
        }
    }
}
