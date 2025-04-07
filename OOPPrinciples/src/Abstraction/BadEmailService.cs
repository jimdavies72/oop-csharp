namespace OOPPrinciples.src.Abstraction;

public class BadEmailService {
  public void SendEmail() {
    Console.WriteLine("Sending email...");
  }

  public void Connect() {
    Console.WriteLine("Connecting to email server...");
  }

  public void Authenticate() {
    Console.WriteLine("Authenticating with email server...");
  }

  public void Disconnect() {
    Console.WriteLine("Disconnecting from email server...");
  }
}