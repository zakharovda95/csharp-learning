namespace BaseCSharp.Themes.Basic;

public class InputOutputWithConsole
{
    public void Run()
    {
        // Вывод информации
        Console.WriteLine("Вывод с переносом на другую строку");
        Console.Write("Вывод без на другую строку");

        // С интерполяцией
        var val1 = 123;
        var val2 = 2.12F;
        Console.WriteLine($"Val1: {val1}, Val2 {val2}");
        
        // С плейсхолдерами
        var val3 = 4 + 7;
        var val4 = "Тест";
        Console.WriteLine("Val 3 {0}, Val 4 {1}", val3, val4); // нумерация с 0
        
        // Ввод информации
        //var rlValStr = Console.ReadLine();
        var rlValStr = "Значение из консоли";
        Console.WriteLine(rlValStr);

        //var rlValInt = Convert.ToInt32(Console.ReadLine()); - конвертация строки в Int32 int
        //var rlValDecimal = Convert.ToDecimal(Console.ReadLine()); //- конвертация строки в decimal разделитель . или , в зависимости от культуры
       // Console.WriteLine(rlValDecimal); - выдвет ошибку если null


    }
}