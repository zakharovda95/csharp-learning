namespace BaseCSharp.Themes.Basic;

public class Variables
{
    public void Run()
    {
        Console.WriteLine("++++++++ ПЕРЕМЕННЫЕ ++++++++");
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
        
        // Константы
        const string CONSTANTA = "Это значение не может быть изменено";
        
        //const string SOME_CONST; - нельзя нужно сразу присвоить значение
        //SOME_CONST = "Какое то значение"; - нельзя, нельзя изменять значение констант
        

    }
}