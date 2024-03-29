namespace BaseCSharp.Themes.NamespacesClassesStructs;

public class AccessModifiers
{
    public void Run()
    {
        Console.WriteLine("++++++++ МОДИФИКАТОРЫ ДОСТУПА ++++++++");
        
        // Модификатор доступа - определяет контекст в котором видно класс метод или переменную
        // Существуют следующие модификаторы доступа:
        
        // - private - только в текущем классе
        // - private protected - только в текущем классе и производных классах той же сборки
        // - file (C# 11) - только в текущем модуле
        // - protected - только в классе и производных классах
        // - internal - только в текущей сборке
        // - protected internal - только в текущей сборке и производных классах в текущей и других сборках
        // - public - общедоступный
        
        // структуры не могут иметь модификаторы все которые содержат protected (тк не могут наследоваться)
        
        // !!! классы и структуры вне других классов и структур могут иметь только public internal file !!!
        
        // Итого:
        // Внешние классы и структуры имеют только модификаторы PUBLIC FILE INTERNAL
        // Внутренние классы и члены классов могут иметь все модификаторы
        // Внутренние структуры не могут иметь модификаторы в которых есть PROTECTED тк нет наследования
        // если без явного указания внешние классы и структуры имеют модификатор INTERNAL
        // внутренние классы структуры и их члены имеют модификатор PRIVATE
        
        
    }
}