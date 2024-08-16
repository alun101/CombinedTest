using dafnyModule1;

class Program
{
  static void Main(string[] args)
  {
    while (true)
    {
      Console.WriteLine($"{Environment.NewLine}Press <Enter> to exit or enter your first number and press <Enter>:");
      string? input = Console.ReadLine();
      if (string.IsNullOrEmpty(input)) break;
      var number1 = int.Parse(input);
      Console.WriteLine($"{Environment.NewLine}Press <Enter> to exit or enter your second number and press <Enter>:");
      string? input2 = Console.ReadLine();
      if (string.IsNullOrEmpty(input2)) break;
      var number2 = int.Parse(input2);
      var number3 = new C();
      Console.WriteLine($"{Environment.NewLine}The answer is " + number3.dafnyAdd(number1, number2) + Environment.NewLine);
    }
    return;
  }
}

