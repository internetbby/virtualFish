public class Fish{
 public string Name = "";
  public string GetName(string name)
  {
    Name = name; 
    return name;
  }  //this sets the name of the fish type

    public int odds = 0; 

    public int setOdds(int newOdds){
        odds = newOdds;
        return newOdds; 
    }

  public int amountOfFish = 0; 
    
    public int catchRate = 0; 

    public int setCatchRate(int newCatchRate){
        catchRate = newCatchRate;
        return newCatchRate; 
    }
}
