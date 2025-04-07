namespace OOPPrinciples.src.Coupling;

public class Order {

  private readonly INotificationService notificationService;

  public Order(INotificationService notificationService) {
    this.notificationService = notificationService;
  }

  public void PlaceBadOrder() {
    // Place order logic...

    // BadEmailSender class is tightly coupled to the Order class...
    BadEmailSender badEmailSender= new BadEmailSender();
    badEmailSender.SendEmail("Order placed successfully.");

  }

  public void PlaceGoodOrder() {
    // Place order logic...

    notificationService.SendNotification("Order placed successfully");

  }
}