//var list = new List<int> { 1, 5, 10, 8, 12, 4, 5 };
//var result = list.TakeEverySecond();
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
//Console.ReadKey();

//public static class ListExtension
//{
//    public static List<int> TakeEverySecond(this List<int> input)
//    {
//        var result = new List<int>() { };
//        if (input.Count == 0) 
//        { 
//            return input; 
//        }
//        for (int i = 0; i < input.Count; i+=2)
//        {
//            result.Add(input[i]);
//        }
//        return result; 
//    }
//}




//public static class Exercise
//{
//    public static int Transform(
//        int number)
//    {
//        var transformations = new List<INumericTransformation>
//            {
//                new By1Incrementer(),
//                new By2Multiplier(),
//                new ToPowerOf2Raiser()
//            };

//        var result = number;
//        foreach (var transformation in transformations)
//        {
//            result = transformation.Transform(result);
//        }
//        return result;
//    }
//}

//public interface INumericTransformation
//{
//    public int Transform(int input);
//}

//public class By1Incrementer : INumericTransformation
//{
//    public int Transform(int input)
//    {
//        return input +1;
//    }
//}

//public class By2Multiplier : INumericTransformation
//{
//    public int Transform(int input)
//    {
//        return input * 2; 
//    }
//}

//public class ToPowerOf2Raiser : INumericTransformation
//{
//    public int Transform(int input)
//    {
//        return input * input;
//    }
//}

//public static class ExceptionsDivisionExercise
//{
//    public static int DivideNumbers(int a, int b)
//    {
//        try
//        {
//            return a / b;
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Division by zero");
//            return 0;
//        } finally {
//            Console.WriteLine("The DivideNumbers method ends."); 
//        }

//    }
//}

//public static class ExceptionsRethrowing
//{
//    public static int GetMaxValue(List<int> numbers)
//    {
//        try
//        {
//            return numbers.Max();
//        }
//        catch(ArgumentNullException ex)
//        {
//            Console.WriteLine("The numbers list cannot be null.");
//            throw;
//        }catch(InvalidOperationException ex)
//        {
//            Console.WriteLine("The numbers list cannot be empty.");
//            throw;
//        }
//    }
//}

//public class InvalidTransactionException : Exception
//{
//    public TransactionData TransactionData { get; }

//    public InvalidTransactionException() { }
//    public InvalidTransactionException(string message) : base(message) { }
//    public InvalidTransactionException(string message, TransactionData transactionData) : base(message) 
//    {
//        TransactionData = transactionData;
//    }
//    public InvalidTransactionException(string message, Exception innerException) : base(message, innerException) { }
//    public InvalidTransactionException(string message, TransactionData transactionData, Exception innerException) : base(message, innerException)
//    {
//        TransactionData = transactionData;
//    }
//}

