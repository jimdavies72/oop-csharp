namespace OOPPrinciples.src.Polymorphism;

public class Car : Vehicle {
  public int NumberOFDoors { get; set; }

  public override void Start() {
    Console.WriteLine("Starting the car...");
  }

  public override void Stop() {
    Console.WriteLine("Stopping the car...");
  }
}