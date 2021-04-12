using System;

namespace virtualFish
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            string [] names = {"Guppy", "Beta", "Catfish", "Tilapia", "Crab", "Cod" };
            int chance = generator.Next(0,101);

            Fish f1 = new Fish(); 
            f1.Name = f1.GetName(names[0]);
            f1.odds = f1.setOdds (90); 
            f1.catchRate = f1.setCatchRate(10);

            int amountOfFish = 0; 


            for (int i = 0; i < f1.catchRate; i++){
                if (chance < f1.odds){
                    amountOfFish++; 
                    chance = generator.Next(0,101);
                }
            } // make this a method : ) 

            System.Console.WriteLine(amountOfFish);
            

            System.Console.WriteLine(f1.Name);
            Console.ReadLine();
        }
    }
}
