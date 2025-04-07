namespace OOPPrinciples.src.Coupling;

public class BadEmailSender {

  public void SendEmail(string message) {
    // Email sending logic...
    
    Console.WriteLine("Sending email: " + message);
  }
}
