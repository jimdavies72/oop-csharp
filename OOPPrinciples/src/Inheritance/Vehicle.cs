namespace OOPPrinciples.src.Inheritance;

public class Vehicle {
  public string Brand { get; set; } = "";
  public string Model { get; set; } = "";
  public int Year { get; set; }

  public void Start() {
    Console.WriteLine("Starting the vehicle...");
  }

  public void Stop() {
    Console.WriteLine("Stopping the vehicle...");
  }
}