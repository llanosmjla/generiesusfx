using SimpleTextProcessingApplication;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        TextProcessor processor = new TextProcessor();
        string route = "C:/Users/LlanosJL70/OneDrive/Documentos/9NO SEMESTRE/backend/exercises/app2005/SimpleTextProcessingApplication/file.txt";
        processor.ProcessText(route);
    }

}