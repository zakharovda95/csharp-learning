namespace BaseCSharp.Themes.Basic;

public class MethodsReturnValue
{
    public void Run()
    {
        Console.WriteLine("++++++++ ВОЗВРАЩАЕМЫЕ ЗНАЧЕНИЯ МЕТОДОВ ++++++++");
        // Методы могут возвращать какое то значение, результат выполнения и тд

        string GetMessage(string message)
        {
            return message; // оператор return завершает выполнение метода ивозвращает значение
        }
        
        Console.WriteLine(GetMessage("Возвращаемое сообщение"));
        
        // Если указан тип возвращаемого значение (не void) - метод обязан вернуть значение иначе ошибка
        /*string GetString()
        {
            Console.WriteLine("Нужно вернуть строку"); // будет ошибка
        }*/
        
        // Можем присвоить переменной возвращаемое значение
        var message = GetMessage("Сообщение"); // результат сохранится в переменной
        
        // Можем передать в качестве аргуметра возвращаемое значение
        GetMessage(GetMessage("Сообщение"));
        
        // Можно возвращать целые сложные выражения
        byte Sum(byte a, byte b = 10)
        {
            if (a + b > 255) return 255;
            return (byte)(a + b);
        }

        Console.WriteLine(Sum(255));
        Console.WriteLine(Sum(30, 30));
        
        // Сокращенная запись - функции из одной строчки може без скобок и return
        int Sub(int a, int b) => a - b;
        Console.WriteLine(Sub(10, 5));
        
        // Выход из функции которая ничего н евозвращает
        
        void ExampleFunc (int val)
        {
            if (val <= 0) return; // можем просто выйти по условию без возвращаемого значения
            Console.WriteLine(val / 2);
        }

        ExampleFunc(2);

    }
}