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
        Console.WriteLine("Логические");
        Console.WriteLine(true);
        Console.WriteLine(false);
        
        // Целочисленные литералы (десятичные, шестнадцатеричные, двоичный)
        Console.WriteLine("Целочисленные");
        Console.WriteLine("Положительные: " + 134);
        Console.WriteLine("Отрицательные: " + -32);
        Console.WriteLine("Шестнадцатеричные: " + Convert.ToString(0x0A, 16)); // шестнадцатеричный
        Console.WriteLine("Двоичный: " + Convert.ToString(011, 2)); // двоичный
        
        // Вещественные литералы (с фиксированной запятой, экспонентальная форма)
        Console.WriteLine("Вещественные: " + 3.14);
        Console.WriteLine("Вещественные в экспонентной форме: " + 2.1e3); // 2.1 * 10 в 3 степени
        Console.WriteLine("Вещественные в экспонентной форме с отрцательной степенью: " + 3.12E-2); // 3.12 * 10 в -2 степени
        
        // Символьные литералы (в одинарных кавычках)
        Console.WriteLine("Символьные");
        Console.WriteLine('A');
        Console.WriteLine('!');
        // Управляющие последовательности
        Console.WriteLine("Управляющие последовательности");
        Console.WriteLine('\n'); // перевод строки
        Console.WriteLine('\t'); // табуляция
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