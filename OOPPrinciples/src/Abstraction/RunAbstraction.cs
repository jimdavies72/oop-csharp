// Reduce complexity by hiding unessary details

namespace OOPPrinciples.src.Abstraction;

public class RunAbstraction {
  
  public static void BadEmailService() {

    BadEmailService badEmailService = new BadEmailService();
    badEmailService.Connect();
    badEmailService.Authenticate();
    badEmailService.SendEmail();
    badEmailService.Disconnect();
  }

  public static void GoodEmailService() {
    // by making the methods private we can hide the implementation details
    
    GoodEmailService goodEmailService = new GoodEmailService();
    goodEmailService.SendEmail();
  }
}