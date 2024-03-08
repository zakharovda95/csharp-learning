namespace BaseCSharp.Themes;

public class Variables
{
    public void Run()
    {
        //Переменная - именованая область памяти для хранения значения определенного типа.
        
        // Определение переменной
        string name;
        string Name;
        
        // Присвоение значения
        name = "Имя";
        Name = "Имя с другим регистром";
        
        // Инициализация переменной
        string lastName = "Объявили переменную и сразу присвоили значение";

        // Изменение значения переменной
        Name = "Измененное значение";
        
        Console.WriteLine(Name);
        Console.WriteLine(name);
        Console.WriteLine(lastName);
        
        // Константы
        const string CONSTANTA = "Это значение не может быть изменено";
        
        //const string SOME_CONST; - нельзя нужно сразу присвоить значение
        //SOME_CONST = "Какое то значение"; - нельзя, нельзя изменять значение констант
        

    }
}