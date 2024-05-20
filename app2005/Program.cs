// See https://aka.ms/new-console-template for more information


//Lists
Console.WriteLine("------------Lists----------------------");
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine("Numbers: " + string.Join(", ", numbers));

numbers.Remove(numbers.First());
Console.WriteLine("Remove Firdt Numbers: " + string.Join(", ", numbers));
numbers.Remove(numbers.Last());
Console.WriteLine("Remove Last Numbers: " + string.Join(", ", numbers));


//Dictionaries   
Console.WriteLine("------------Dictionaries----------------------");
Dictionary<string, int> students = new Dictionary<string, int>();
students.Add("John", 25);
students.Add("Jane", 22);
students.Add("Doe", 20);
students.Add("Smith", 30);
students.Add("Alex", 35);


//Recorremos diccionario
foreach (var student in students)
{
    Console.WriteLine(student.Key + " - " + student.Value);
}

/*//Recorremos diccionario x Llave
foreach (var student in students.Keys)
{
   // Console.WriteLine("{0}", student);
    Console.WriteLine(student);
}*/

//update the grade of a student

students["John"] = 30;


//Remove a student
students.Remove("Jane");

Console.WriteLine("----------------New Dic---------------");
//Recorremos diccionario
foreach (var student in students)
{
    Console.WriteLine(student.Key + " - " + student.Value);
}



//Queues
Console.WriteLine("------------Queue----------------------");

Queue<string> customers = new Queue<string>();

customers.Enqueue("1. John");
customers.Enqueue("2. Jane");
customers.Enqueue("3. Doe");
customers.Enqueue("4. Smith");
customers.Enqueue("5. Alex");

//Recorremos cola
foreach (var customer in customers)
{
    Console.WriteLine(customer);
}

//Dequeue two customers from the queue

customers.Dequeue();
customers.Dequeue();

Console.WriteLine("------------New Queue----------------------");
foreach (var customer in customers)
{
    Console.WriteLine(customer);
}



//Stack
Console.WriteLine("------------Stack----------------------");

Stack<string> books = new Stack<string>();
books.Push("Book 1");
books.Push("Book 2");
books.Push("Book 3");
books.Push("Book 4");
books.Push("Book 5");

foreach (var book in books)
{
    Console.WriteLine(book);
}

// remove two books from the stack

books.Pop();
books.Pop();

Console.WriteLine("------------New Stack----------------------");
foreach (var book in books)
{
    Console.WriteLine(book);
}




