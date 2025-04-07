// The ability of an object to take many forms. 
// Polymorphism allows us to treat different classes as if they are the same base class.

namespace OOPPrinciples.src.Polymorphism;

public class RunPolymorphism() {

  public static void AddVehicles() {

    List<Vehicle> vehicles = new List<Vehicle>();
    vehicles.Add(new Car{ Brand = "Toyota", Model = "Camry", Year = 2020, NumberOFDoors = 4 }); 
    vehicles.Add(new Motorcycle{ Brand = "Honda", Model = "VT250", Year = 2019 });  

    // vehicle inspection
     foreach (var vehicle in vehicles) {
      vehicle.Start();
      vehicle.Stop();
     }
  }

}