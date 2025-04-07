namespace OOPPrinciples.src.Encapsulation;

public class BankAccount {
  // data is encapsulated inside of the class, preventing access from outside
  private decimal balance;

  public BankAccount(decimal balance)
  {
    Deposit(balance);
  }

  public void Deposit(decimal amount)
  {
    if (amount <= 0)
    {
      throw new ArgumentException("Amount must be greater than zero");
    }

    this.balance += amount;
  }

  public void Withdraw(decimal amount)
  {
    if (amount <= 0)
    {
      throw new ArgumentException("Withdrawl amount must be greater than zero");
    }

    if (amount > this.balance)
    {
      throw new InvalidOperationException("Insufficient funds");
    }

    this.balance -= amount;
  }

  public decimal GetBalance()
  {
    return this.balance;
  }
}