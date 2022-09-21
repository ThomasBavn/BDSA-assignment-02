namespace Assignment2;

public class Delegates{

    public static Action<string> ReverseOrder = (string i) => Console.WriteLine(i.Reverse().ToArray()); 

    public static Func<double,double, double> ProductOfTwoDoubles = (double x, double y) => x * y;

    public static Func<int,string, bool> NumericallyEqual = (int i, string k) => i == double.Parse(k);
}