// Encapsulation provides clear separation between the public interface and the internal implementation of the class

namespace OOPPrinciples.src.Encapsulation;

public class RunEncapsulation {
  public static void BadBankAccount() {
    // balance is public and is accessible within code for modification
    
    BadBankAccount badAccount = new BadBankAccount();
    badAccount.balance = 200;
    Console.WriteLine(badAccount.balance);
  }

  public static void GoodBankAccount() {
    // balance is private and is accessible only through construction or methods and connot be 
    // violated by its client. We do not need to know the internal implementation details of the class.

    BankAccount goodAccount = new BankAccount(200);
    Console.WriteLine(goodAccount.GetBalance());

    goodAccount.Deposit(50);
    Console.WriteLine(goodAccount.GetBalance());

    goodAccount.Withdraw(100);
    Console.WriteLine(goodAccount.GetBalance());
  }
}