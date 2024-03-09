namespace BaseCSharp.Themes.Basic;

public class Literals
{
    public void Run()
    {
        // Литерал - это представление некоторого типа
        // например var variable = "Literal", где variable - переменная, а "Literal" - литерал
        
        // Литералы бывают:
        // Целочисленные, Вещественные, Символьные, Строковые, Логические, null
        
        
        // Логические литералы
        Console.WriteLine(true);
        Console.WriteLine(false);
        
        // Целочисленные литералы (десятичные, шестнадцатеричные, двоичный)
        Console.WriteLine(134);
        Console.WriteLine(-32);
        Console.WriteLine(0x0A); // шестнадцатеричный
        Console.WriteLine(0b11); // двоичный
        
        // Вещественные литералы (с фиксированной запятой, экспонентальная форма)
        Console.WriteLine(3.14);
        Console.WriteLine(2.1e3); // 2.1 * 10 в 3 степени
        Console.WriteLine(3.12E-2); // 3.12 * 10 в -2 степени
        
        // Символьные литералы (в одинарных кавычках)
        Console.WriteLine('A');
        Console.WriteLine('!');
        // Управляющие последовательности
        Console.WriteLine('\n'); // перевод строки
        Console.WriteLine('\t'); // табуляция
        // Шестнадцатеричный код
        Console.WriteLine('\x78'); // x
        Console.WriteLine('\x5A'); // Z
        // Юникод
        Console.WriteLine('\u0420'); // P
        
        // Строковые литералы (массив символов)
        Console.WriteLine("Строка");
        Console.WriteLine("Строка с \"кавычками внутри\"");
        Console.WriteLine("Строка с \nУправляющей последовательностью");
        
        // null - значение не присвоино;
        //Console.WriteLine(null);
    }
}