// See https://aka.ms/new-console-template for more information


public class DelegateActivity
{
    public delegate int MathOperation(int a, int b);
    public static void Main()
    {
        MathOperation mathOperation = Add;

        Console.WriteLine(mathOperation(1, 5));
        Console.WriteLine("--------------------------");
        mathOperation = Subtract;
        Console.WriteLine(mathOperation(4, 6));

        //Multicast delegate
        Console.WriteLine("------------MC--------------");
        MathOperation mathOpeMul = Add;
        mathOpeMul += Subtract;

        Console.WriteLine(mathOpeMul(10, 5));

    }

    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }   


}
