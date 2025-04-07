namespace OOPPrinciples.src.Polymorphism;

public class Vehicle {
  public string Brand { get; set; } = "";
  public string Model { get; set; } = "";
  public int Year { get; set; } = 0;

  public virtual void Start() {
    Console.WriteLine("Starting the vehicle...");
  }

  public virtual void Stop() {
    Console.WriteLine("Stopping the vehicle...");
  }
}