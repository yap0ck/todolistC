int firstNumber, secondNumber;
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
if (EqualsCaseInsensitive(operation, "A"))
{
    var sum = firstNumber + secondNumber;
    PrintFinalEquation(firstNumber, secondNumber, sum, "+");
}
else if (EqualsCaseInsensitive(operation, "S"))
{
    var difference = firstNumber - secondNumber;
    PrintFinalEquation(firstNumber, secondNumber, difference, "-");
}
else if (EqualsCaseInsensitive(operation, "M"))
{
    var multiplied = firstNumber * secondNumber;
    PrintFinalEquation(firstNumber, secondNumber, multiplied, "*");
}
else
{
    Console.WriteLine("Invalid option");
}
Console.WriteLine("Press any key to close");
Console.ReadKey();

void PrintFinalEquation(int firstNumber, int secondNumber, int result, string @operator)
{
    Console.WriteLine(
        firstNumber + " " + @operator + " " + secondNumber + " = " + result);
}

bool EqualsCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}