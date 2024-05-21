// See https://aka.ms/new-console-template for more information


using app2005;

public class Program()
{
    public static void Main()
    {
        //CreateList();
        //CreateDictionary();
        CreateStack();
        //CreateQueue();
        //CreateCombinations();
    }

    private static void CreateCombinations()
    {
        Combination combination = new Combination();

        for(int j = 0; j < 10; j++)
        {
            for (int i = 0; i < 10; i++)
            {
                Book book = new Book();
                book.title = "Book " + i;
                combination.Add("Genre " + j, book);
            }
            
        }

        //Print the combination
        combination.Print();


    }

    private static void CreateQueue()
    {
        throw new NotImplementedException();
    }

    private static void CreateStack()
    {
        ListDS stack = new ListDS();

        for (int i = 0; i < 10; i++)
        {
            stack.Add(i);
        }
    }

    private static void CreateDictionary()
    {
        Dictionary students = new Dictionary();

        students.Add(1, "John");
        students.Add(2, "Jane");
        students.Add(3, "Doe");
        students.Add(4, "Smith");
        students.Add(5, "Doe");

        //Print the dictionary
        students.Print();

        //Update grade of student with id 1
        students.UpdateGradeStudent(1, "Roberto");

        //Print the dictionary
        students.Print();
    }

    public static void CreateList()
    {
        ListDS list = new ListDS();

        for (int i = 0; i < 10; i++)
        {
            list.Add(i);
        }
        //Print the list
        list.Print();

        //Remove first element
        list.RemoveFirst();
        //Remove last element
        list.RemoveLast();

        //Print the list
        list.Print();

    }
}


