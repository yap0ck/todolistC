int firstNumber, secondNumber, result;
String operation;

Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number:");
secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubstract");
Console.WriteLine("[M]ultiply");
operation = Console.ReadLine();
if (operation == "a" || operation == "A")
{
    Console.WriteLine(firstNumber + " + " + secondNumber + " = " + Add(firstNumber, secondNumber));
}
else if (operation == "s" || operation == "S")
{
     Console.WriteLine(firstNumber + " - " + secondNumber + " = " + Substract(firstNumber, secondNumber));
}
else if (operation == "M" || operation == "m")
{
    Console.WriteLine(firstNumber + " * " + secondNumber + " = " + Multiply(firstNumber, secondNumber));
}
else
{
    Console.WriteLine("Invalid option");
}
Console.WriteLine("Press any key to close");
Console.ReadKey();

    int Add(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }

int Substract(int firstNumber, int secondNumber)
{
    return firstNumber - secondNumber;
}
int Multiply(int firstNumber, int secondNumber)
{
    return firstNumber * secondNumber;
}