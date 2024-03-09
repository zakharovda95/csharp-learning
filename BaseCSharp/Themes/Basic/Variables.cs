namespace BaseCSharp.Themes.Basic;

public class Variables
{
    public void Run()
    {
        Console.WriteLine("++++++++ ПЕРЕМЕННЫЕ ++++++++");
        //Переменная - именованая область памяти для хранения значения определенного типа.
        
        // Определение переменной
        Console.WriteLine("Определение переменной");
        string name;
        string Name;
        
        // Присвоение значения
        Console.WriteLine("Присвоение значения");
        name = "Имя";
        Console.WriteLine("переменная name: " + name);
        
        Name = "Имя с другим регистром";
        Console.WriteLine("другая переменная Name: " + Name);
        
        // Инициализация переменной
        Console.WriteLine("Инициализация переменной");
        string lastName = "Объявили переменную и сразу присвоили значение";
        Console.WriteLine("инициализированая переменная lastName: " + lastName);
        
        // Изменение значения переменной
        Console.WriteLine("Изменение значения переменной");
        Name = "Измененное значение";
        Console.WriteLine("измененная переменная Name: " + Name);
        
        // Константы
        Console.WriteLine("Константы");
        const string CONSTANTA = "Это значение не может быть изменено";
        Console.WriteLine("КОНСТАНТА: " + CONSTANTA);
        
        //const string SOME_CONST; - нельзя нужно сразу присвоить значение
        //SOME_CONST = "Какое то значение"; - нельзя, нельзя изменять значение констант
        

    }
}