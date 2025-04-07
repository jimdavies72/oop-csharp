// Inheritance involves creating derived or subclasses from an existing super or base class.
// Subclasses can inherit properties or behaviours from its superclass and can also add their own.

namespace OOPPrinciples.src.Inheritance;

public class RunInheritance {
  public static void VehicleInheritance() {
    var car = new Car();

    //inherited properties/methods
    car.Brand = "Ford";
    car.Model = "Capri";
    car.Year = 1982;
    car.Start();
    car.Stop();

    //unique properties accessible only by the Car class
    car.NumberOfDoors = 4;
    car.NumberOfWheels = 4;
  }
}