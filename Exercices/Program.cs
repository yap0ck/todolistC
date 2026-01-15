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