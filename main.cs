using System;

class Program {
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Enter temperture in Celcius");
    int temperture = Convert.ToInt32(Console.ReadLine());
    int Farenheit = ((temperture * 9/5) + 32);
    Console.WriteLine ("Farenheit equivalent for " + temperture + " degrees Celcius is " + Farenheit);

    if (Farenheit > 212)
    {
      Console.WriteLine ("This temperture is above boiling temperture of 212 degrees Farenheit");
    }
  }
}