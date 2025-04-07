namespace OOPPrinciples.src.Coupling;

public class GoodEmailSender : INotificationService
{

  public void SendNotification(string message)
  {
    // Email sending logic...

    Console.WriteLine("Sending email: " + message);
  }
}
