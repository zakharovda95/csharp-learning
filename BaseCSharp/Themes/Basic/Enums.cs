namespace BaseCSharp.Themes.Basic;

public class Enums
{
    enum DayTime : int // состояния дня int - тип по умолчанию
    {
        Morning,
        Afternoon,
        Evening,
        Night,
    }

    enum Operations: byte // состояния операций - можно поменять тип (только целочисленные типы)
    {
        Add = 2, // начинается с 0, но если указать только у первого элемента значение то последующие будут идти с него например 2 3 4 и тд
        Subtract = 3, // могут иметь одинаковые значения
        Multiply = 5, // можно явно присвоить значение даже не попорядку
        Divide = 4 // чтобы получить числовое значение константы нужно привести к числовому типу (в данном случае к byte)
    }

    enum Test
    {
        Val1 = 3,
        Val2 = Val1, // можно присвоить значение другой константы этого енама
        Val3
    }
    public void Run()
    {
        Console.WriteLine("++++++++ ПЕРЕЧИСЛЕНИЯ ENUMS ++++++++");
        // Enum - перечисление - набор логически связанных констант

        // Enum - это тип данных такой же как и int object и тд со всеми вытекающими последствиями
        // можно использовать в качестве констант, переменных, параметров методов и тд
        
        const DayTime dayTime = DayTime.Morning;

        if (dayTime == DayTime.Morning)
            Console.WriteLine("Сейчас утро");
        else
            Console.WriteLine("Сейчас не утро");
        
        // Хранение состояния
        // Часто выступают для хранения констант состояний чтобы при сравнении при совпадении выполнять какие то действия
        var now = DayTime.Evening;

        static void ShowDayTime(DayTime time)
        {
            switch (time)
            {
                case DayTime.Morning:
                    Console.WriteLine("Сейчас утро");
                    break;
                case DayTime.Afternoon:
                    Console.WriteLine("Сейчас день");
                    break;
                case DayTime.Evening:
                    Console.WriteLine("Сейчас вечер");
                    break;
                case DayTime.Night:
                    Console.WriteLine("Сейчас вечер");
                    break;
                default:
                    Console.WriteLine("Не определено");
                    break;
            }
        }
        
        ShowDayTime(now);
        
        // Еще пример

        static void DoOperation(double x, double y, Operations op)
        {
            var result = op switch
            {
                Operations.Add => x + y,
                Operations.Subtract => x - y,
                Operations.Multiply => x * y,
                Operations.Divide => x / y,
                _ => -1 // по умолчанию
            };
            
            Console.WriteLine(result);
        }

        DoOperation(3.0, 3.5, Operations.Multiply);
        
        // Тип и значения констант перечисления
        // Тип должен быть целочисленным (int, byte, sbyte, short ,long итд) - по умолчанию int
        
        // Можно привести к числовому типу и получить значение
        Console.WriteLine((byte)Operations.Multiply);
        
        // Присвоить числовое значение НЕ МОЖЕМ
        //Operations multip = 2; - не можем присвоить число несмотря на то что тип енама числовой 
    }
}