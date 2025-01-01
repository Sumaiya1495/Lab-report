using System;
public static class BankAccount
{
 public static double Interest=0.05;
  public static double CalculateInterest(double balance)
  {
    return balance * Interest;
  }
  public static void UpdatedRate(double Newrate)
  {
    Interest=Newrate;
    Console.WriteLine("Interest rate updated to: " + (Interest * 100) + "%");
  }
}
class Program 
{

static void Main() 
{
Console.WriteLine("Default Interest Rate: " + (BankAccount.Interest * 100) + "%");

double balance = 1000;

double interest = BankAccount.CalculateInterest(balance);

Console.WriteLine("Interest on balance $" + balance + " is: $" + interest);


BankAccount.UpdatedRate(0.07); 

interest = BankAccount.CalculateInterest(balance);

Console.WriteLine("New interest on balance $" + balance + " is: $" + interest);

}

}
