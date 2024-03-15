namespace TestClassLibrary;

public class Example1
{
    public string Field1;
    public int Field2;

    public void Print()
    {
        Console.WriteLine($"{Field1} --- {Field2}");
        
        // чтобы сбилдить проект - нажмите build selected project
        // выходные файлы bin/Debug/net8.0 в файле dll
        
        // чтобы создать при помощи консоль (CLI)
        // dotnet new classlib - создание шаблона проекта (имя проекта будет по имени папки)
        // dotnet build - билд
        // dotnet add (путь до csproj проекта в который подключают) referens (путь до csproj который подключают) - добавить ссылку
        // dotnet remove (путь до csproj проекта в который подключают) referens (путь до csproj который подключают) - удалить ссылку
        // dotnet new sln - добавить решение
        // dotnet add имя файла (например test.csproj, class.cs и тд)
        
        //dotnet sln [путь_к_файлу_решения.sln] remove путь_к_файлу_csproj_удаляемого_проекта - удалить проект
        
        // почитать про консрольные комманды дотнет https://learn.microsoft.com/ru-ru/dotnet/core/tools/dotnet-sln
    }
}