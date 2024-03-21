namespace BaseCSharp.Themes.Basic;

public class Literals
{
    public void Run()
    {
        Console.WriteLine("++++++++ ЛИТЕРАЛЫ ++++++++");
        // Литерал - это представление некоторого типа
        // например var variable = "Literal", где variable - переменная, а "Literal" - литерал
        
        // Литералы бывают:
        // Целочисленные, Вещественные, Символьные, Строковые, Логические, null
        
        // Логические литералы
        Console.WriteLine(true);
        Console.WriteLine(false);
        
        // Целочисленные литералы (десятичные, шестнадцатеричные, двоичный)
        Console.WriteLine("Положительные: " + 134);
        Console.WriteLine("Отрицательные: " + -32);
        Console.WriteLine("Шестнадцатеричные: " + Convert.ToString(0x0A, 16)); // шестнадцатеричный 0x0A
        Console.WriteLine("Двоичный: " + Convert.ToString(0b010, 2)); // двоичный 0b0000_0001
        
        // Вещественные литералы (с фиксированной запятой, экспонентальная форма)
        Console.WriteLine("Вещественные: " + 3.14);
        Console.WriteLine("Вещественные в экспонентной форме: " + 2.1e3); // 2.1 * 10 в 3 степени
        Console.WriteLine("Вещественные в экспонентной форме с отрцательной степенью: " + 3.12E-2); // 3.12 * 10 в -2 степени
        
        // Символьные литералы (в одинарных кавычках)
        Console.WriteLine("Буквы: " + 'A');
        Console.WriteLine("Знаки: " + '!');
        // Управляющие последовательности
        Console.WriteLine("Управляющие последовательности");
        Console.WriteLine("Перенос строки: " + '\n'); // перевод строки
        Console.WriteLine("Табуляция: " + '\t'); // табуляция
        // Шестнадцатеричный код
        Console.WriteLine("Шестнадцатеричный код");
        Console.WriteLine('\x78'); // x
        Console.WriteLine('\x5A'); // Z
        // Юникод
        Console.WriteLine("Юникод");
        Console.WriteLine('\u0420'); // P
        
        // Строковые литералы (массив символов)
        Console.WriteLine("Строковые");
        Console.WriteLine("Строка");
        Console.WriteLine("Строка с \"кавычками внутри\"");
        Console.WriteLine("Строка с \nУправляющей последовательностью");
        
        // null - значение не присвоино;
        //Console.WriteLine(null);
    }
}