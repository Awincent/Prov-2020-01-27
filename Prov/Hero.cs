using System;

namespace Prov
{
    class Hero
    {
        public string name;
        public int health;
        public int strength;
        
        public int type;
        public string _result; //temporary result for crl

        public Hero()
        {
            Console.WriteLine("Please name your hero.");
            name = Console.ReadLine();
            Console.WriteLine("Now choose a hero type:");
            wrong: //goto command because no time
            Console.WriteLine("V = Villan");
            Console.WriteLine("A = Alien");
            Console.WriteLine("D = Dog");

            _result = Console.ReadLine();
            Choosetype(); // Define wat type of hero from player choise

            //Slut på tid


        }

        public int Choosetype()
        {
            if (_result.ToUpper().Equals("V"))
            {
                Villan newHero = new Villan(); //Create new heroes of the right type
            }
            else if (_result.ToUpper().Equals("A"))
            {
                Alien newHero = new Alien();
            }
            else if (_result.ToUpper().Equals("D"))
            {
                Dog newHero = new Dog();
            }
            else
            {
                goto wrong;
            }
        }
    }
}
