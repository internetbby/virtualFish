using System;

namespace virtualFish
{
    class Program
    {
        static void Main(string[] args)

        {
            Random generator = new Random();
            string [] names = {" Guppy", " Beta", " Catfish", " Tilapia", " Crab", " Cod" };
            int chance = generator.Next(0,101);

            Fish f1 = new Fish(); 
            f1.Name = f1.GetName(names[0]);
            f1.odds = f1.setOdds (90); 
            f1.catchRate = f1.setCatchRate(10);
            f1.amountOfFish = 0;

            Fish f2 = new Fish();
            f2.Name = f2.GetName(names[1]);
            f2.odds = f2.setOdds(70);
            f2.catchRate = f2.setCatchRate(7);
            f2.amountOfFish = 0;


            System.Console.WriteLine("Type fish/f to fish"); //make a loop function 
            string playerAnswer = Console.ReadLine();

            

            if(playerCheck(playerAnswer,"f","fish")){
                f1.amountOfFish =  Fishing( chance, f1.catchRate, f1.odds, f1.amountOfFish);
                f2.amountOfFish = Fishing (chance, f2.catchRate, f2.odds, f2.amountOfFish);
            }

           

            System.Console.WriteLine(f1.amountOfFish + f1.Name);
            System.Console.WriteLine(f2.amountOfFish + f2.Name);

            System.Console.WriteLine("type Sell or S, no/n to not sell "); //add a check to see if its no 


            if (playerCheck(playerAnswer,"s","sell")){ //add selling method

            }
            

            Console.ReadLine();
        }

        static bool playerCheck(string playerInput, string requiredInput, string requiredInputLong){
            playerInput.ToLower(); 
            bool playerChecked = false;

            while (playerInput != requiredInput && playerInput != requiredInputLong){
                System.Console.WriteLine("invalid input");

                playerInput = Console.ReadLine();
                playerChecked = false;
            }
            if (playerInput == requiredInput || playerInput == requiredInputLong){
                playerChecked = true;
            }


            return playerChecked; 
        }

        static int Fishing(int chance, int fishCatchRate, int fishOdds, int amountOfFish){
            Random generator = new Random();
      
            chance = 0;
            for (int i = 0; i < fishCatchRate; i++){
                if (chance < fishOdds){
                    amountOfFish++; 
                    chance = generator.Next(0,101);
                }
            }

            return  amountOfFish; 
        }

        
    }

}

