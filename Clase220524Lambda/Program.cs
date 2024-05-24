// See https://aka.ms/new-console-template for more information

using System.Reflection;

class LearningLambda
{
    static void Main(string[] args)
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Using lambda expression
        Func<int, bool> GetPairs = n => n % 2 == 0;
        Func<int[], int> Sum = n => n.Sum();

        var pairs = numbers.Where(GetPairs);

        Console.WriteLine(Sum(numbers.ToArray()));

        /*foreach (var item in pairs)
        {
            Console.WriteLine(item);
        }*/
    }
}
