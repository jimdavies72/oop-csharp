namespace OOPPrinciples.src.Coupling;

public class SMSSender : INotificationService
{

  public void SendNotification(string message)
  {
    // SMS sending logic...

    Console.WriteLine("Sending SMS Message: " + message);
  }
}
