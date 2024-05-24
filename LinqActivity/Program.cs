class LinqActivity
{
    static void Main(string[] args)
    {
        var numbers1 = new int[] { 1, 2, 3, 4, 5, 6 };
        //var numbers2 = new int[] { 6, 7, 8, 9, 10 };
        var numberWords = new string[] { "one", "two", "three", "four", "five"};


        // union of two arrays
        //var numbersUnion = numbers1.Union(numbers2);
        /*numbersUnion.ToList().ForEach(n =>
            {
                Console.WriteLine(n);
            });*/
        var numbersWithZip = numbers1.Zip(numberWords, (n, w) =>
        {
            return n + " " + w;
        });

        numbersWithZip.ToList().ForEach(n =>
        {
            Console.WriteLine(n);
        });
    }
}