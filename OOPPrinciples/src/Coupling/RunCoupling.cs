// The degree of dependency between classes. 
// Tightly coupled - modifying one class could break the other.

using Microsoft.VisualBasic;

namespace OOPPrinciples.src.Coupling;

public class RunCoupling {

  public static void PlaceBadOrder() {
    //var order = new Order();
    //order.PlaceBadOrder();
  }

  public static void PlaceGoodOrder() {
    
    var order = new Order(new GoodEmailSender());
    order.PlaceGoodOrder();

    var order2 = new Order(new SMSSender());
    order2.PlaceGoodOrder();
  }
}