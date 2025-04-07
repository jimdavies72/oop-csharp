// Composition involves creating complex objects by combining simple objects or components with each component mainting its own state and behaviour.

namespace OOPPrinciples.src.Composition;

public class RunComposition {
  
  public static void StartCar() {
    var car = new Car();
    car.StartCar();
  }
}