// INTERFACES

// Defining an Interface
public interface ILoyaltyCardHolder
{
   int TotalPoints { get; }
   int AddPoints(decimal transactionValue);
   void ResetPoints();
}

// TWO POSSIBLE WAYS TO IMPLEMENT

// one --> Implementing an Interface Implicitly
public class Customer : ILoyaltyCardHolder
{
   private int totalPoints;
   public int TotalPoints
   {
      get { return totalPoints; }
   }
   public int AddPoints(decimal transactionValue)
   {
      int points = Decimal.ToInt32(transactionValue);
      totalPoints += points;
      return totalPoints;
   }
   public void ResetPoints()
   {
      totalPoints = 0;
   }
   // Other members of the Customer class.   
}

// two --> Implementing an Interface Explicitly
public class Coffee : IBeverage
{
   private int servingTempWithoutMilk { get; set; }
   private int servingTempWithMilk { get; set; }
   public int IBeverage.GetServingTemperature(bool includesMilk)
   {
      if(includesMilk)
      {
          return servingTempWithMilk;
      }
      else
      {
         return servingTempWithoutMilk;
      }
   }
   public bool IBeverage.IsFairTrade { get; set; }
   // Other non-interface members.
}