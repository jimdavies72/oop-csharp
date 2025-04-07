namespace OOPPrinciples.src.Abstraction;

public class GoodEmailService
{
  public void SendEmail()
  {
    Connect();
    Authenticate();
    Console.WriteLine("Sending email...");
    Disconnect();
  }

  private void Connect()
  {
    Console.WriteLine("Connecting to email server...");
  }

  private void Authenticate()
  {
    Console.WriteLine("Authenticating with email server...");
  }

  private void Disconnect()
  {
    Console.WriteLine("Disconnecting from email server...");
  }
}
