namespace BaseCSharp.Themes.Basic;

public class MethodParameters
{
    public void Run()
    {
        Console.WriteLine("++++++++ ПАРАМЕТРЫ МЕТОДОВ ++++++++");
        
        // Параметры позволяют передавать в функцию некоторые данные извне
        
        // Метод с параметрами
        // Внутри функции называется параметрами или формальными параметрами (то же самое)
        void PrintMessage(string message)
        {
            // message - формальный параметр
            Console.WriteLine(message);
        }
        
        // Снаружи аргументами функции (но можно и назвать параметрами) или иногда фактическими параметрами
        // Hello, - аргумент или фактический параметр
        PrintMessage("Hello, ");
        // World! - аргумент или фактический параметр
        PrintMessage("World!");
        
        // Несколько параметров

        void Sum(byte a, byte b)
        {
            Console.WriteLine(a + b);
        }
        
        Sum(10, 15); // могут быть переданы фактические значения
        
        const byte val1 = 12, val2 = 17; 
        Sum(val1, val2); // могут быть переданы переменные - !!должны быть инициализированы
        
        Sum((byte)(val1 + 17), 10 + 2); // могут быть переданы выражения
        
        // Параметры в сокращенной записи методов - ни чем не отличаются
        void Sub(int a, int b) => Console.WriteLine(a - b);
        Sub(7, 2);
        Sub(-17, -18);
        
        // Тип передаваемых аргументов должен соответствовать типу параметров
        // Можем передать те типы которые могут быть безопасно преобразованы (выделено >= кол-во битов)
        const byte val3 = 120;
        const int val4 = 60;
        Sub(val3, val4); // без проблем тк byte безопасно преобразуется в int
        
        // В остальных случаях нужно явное приведение типов
        int val5 = 250;
        Sum((byte)val5, val3);
        
        // Необязательные параметры - должны рассполагаться после обязательных
        void ExampleMethod1(int a, string b, bool c = false, string d = "abc") => Console.WriteLine($"{a}, {b}, {c}, {d}");
        ExampleMethod1(37, "some string"); // если не передали необязательные - заменяться значением по умолчанию
        
        // Именованые параметры
        // При передаче параметров без имени важен их порядок
        // Можно передавать в любом порядке с именами параметров
        ExampleMethod1(1, "some string 2", true); // - без имен - важен порядок
        ExampleMethod1(b: "Теперь строка может быть первым параметром", a: 1, d: "abc", c: true);// не важен порядок
    }
}