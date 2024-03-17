namespace BaseCSharp.Themes.NamespacesClassesStructs;

using printer = System.Console; // Создали псевдоним для Console
using static System.Console; // для подключения класса как статичного
using static UsingStaticUsing.ExampleClass; // импортируем только статическую функциональность класса (можно не указывать имя класса)

public class UsingStaticUsing
{
    internal class ExampleClass
    {
        internal static int StaticField = 123;
        internal int NonStaticField = 123;
    }
    
    public void Run()
    {
        Console.WriteLine("++++++++ USING И USING STATIC ++++++++");
        
        // Псевдоним для Console
        printer.WriteLine("Хех");
        
        WriteLine(3 + 4); // при using static можно не указывать имя класса

        WriteLine(StaticField); // не указываем имя класса 

    }
}