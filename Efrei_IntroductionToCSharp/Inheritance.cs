using System;
using System.Collections.Generic;

namespace Efrei_IntroductionToCSharp
{
    /// <Important>
    ///
    /// Please note that for this specific inheritance file, I have
    /// put interfaces, abstract classes and classes side by side
    /// in the same file. Each of those should be in their own,
    /// separate file, as having many classes in the same file
    /// in considered a bad practice.
    /// 
    /// </Important>
    public class Inheritance : IExemple
    {
        public void Run()
        {
            // These won't work : interfaces and abstract classes cannot be called with new
            // and as whole cannot be directly instantiated
            //var heroOfLegend = new IHeroOfLegend();
            //var chosenOne = new AChosenOne(); 

            MightyPaladin paladin = new MightyPaladin();
            paladin.HeroicGreeting();

            StrongWarrior strongWarrior = new StrongWarrior("Ragnar Lothbrok");
            // Age is not accessible as a parameter for StrongWarrior
            //var strongWarrior2 = new StrongWarrior("Ragnar Lothbrok", 24);
            strongWarrior.HeroicGreeting();
            strongWarrior.Attack();

            var powerfulMage = new PowerfulMage("Gandalf", 33);
            powerfulMage.HeroicGreeting();
            powerfulMage.Attack();
            powerfulMage.CastMagic();
            
            var heroList = new List<IHeroOfLegend>
            {
                paladin, 
                strongWarrior, 
                powerfulMage
            };

            var chosenOneList = new List<AChosenOne>
            {
                strongWarrior,
                powerfulMage,
                //paladin       // paladin only inherits IHeroOfLegend, not AChosenOne
            };

            foreach (var hero in heroList)
            {
                Console.Write($"[{hero.GetType().Name}] ");
                hero.HeroicGreeting();
            }

            foreach (var chosenOne in chosenOneList)
            {
                Console.Write($"[{chosenOne.GetType().Name}] ");
                chosenOne.Attack();
            }
        }

        public string DisplayExempleName()
        {
            return "Inheritance";
        }

        /// <summary>
        /// Interface IHeroOfLegend
        /// Defines only prototype members, without accessibility modifiers
        /// </summary>
        private interface IHeroOfLegend
        {
            void HeroicGreeting();
        }
        
        /// <summary>
        /// Abstract class AChosenOne
        /// Cannot be instantiated like a normal class.
        /// Used to define behavior as well as members for child classes
        /// </summary>
        private abstract class AChosenOne : IHeroOfLegend
        {
            private string Name { get; }
            protected int Age { get; set; } 
            
            protected AChosenOne(string name, int age = 20)
            {
                Name = name;
                Age = age;
            }
            
            public virtual void HeroicGreeting()
            {
                Console.WriteLine($"Hello, I am the hero {Name}, to serve you !");
            }

            public virtual void Attack()
            {
                Console.WriteLine("I attack !");
            }
        }
        
        // MightyPaladin only inherits from IHeroOfLegend
        private class MightyPaladin : IHeroOfLegend
        {
            public void HeroicGreeting()
            {
                Console.WriteLine("Hello, I am a mighty paladin, so step aside...");
            }
        }

        private class StrongWarrior : AChosenOne
        {
            // This constructor send the "name" parameter to the base class
            // (here, AChosenOne) in order to use the default constructor of this class
            public StrongWarrior(string name) : base(name)
            {
            }

            // Note that HeroicGreeting() method is not override. Base method will be used.
            
            // Keyword override is used to override the base Attack() method
            public override void Attack()
            {
                Console.WriteLine("I will crush your skull in a single blow !");
            }
        }
        
        private interface IMage
        {
            void CastMagic();
        }

        private class PowerfulMage : AChosenOne, IMage
        {
            // While name is still not accessible (as it is a private member of AChosenOne),
            // Age is, and can be accessed by child classes 
            public PowerfulMage(string name, int age) : base(name)
            {
                Age = age * 3;
            }

            public override void HeroicGreeting()
            {
                Console.WriteLine($"I might be {Age} old, but wisdom is my strenght.");
            }
            
            // Once again, note that the Attack() method was not override
            
            // CastMagic comes from the IMage interface
            public void CastMagic()
            {
                Console.WriteLine("Whoopily, you're now a bowl of spaghetti !!!");
            }
        }
    }
}

