namespace BaseCSharp.Themes.Basic;

public class SwitchCase
{
    public void Run()
    {
        Console.WriteLine("++++++++ SWITCH... CASE... ++++++++");
        // switch case - сравнивает выражение с набором значений и при совпадении выполняет блок кода

        var name = "Tom"; // то что сравниваем - обычно используется при проверки на строгое равенство
        switch (name)
        {
            case "Bob": // то с чем сравниваем
                Console.WriteLine("Bob");
                break; // помимо break может быть return, goto case, throw
            case "Tom": // то с чем сравниваем
                Console.WriteLine("Tom");
                break;
            case "Mike": // то с чем сравниваем
                Console.WriteLine("Mike");
                break;
            default: // если нет совпадений - необязательный блок
                Console.WriteLine("Нет совпадений");
                break;
        }
        
        // варианты выхода из блоков case
        // break - переход к следующему блоку
        // return - выход (возможо с возвращаемым значением) дальше не сравнивается
        // goto case - переход к указанному блоку например goto case "Mike" - перейдет к майк пропустив все между ними
        // throw - проброс ошибки
        
        // пример goto case

        var val = 2;
        switch (val)
        {
            case 1:
                Console.WriteLine(1);
                break;
            case 2:
                Console.WriteLine(2);
                goto case 4; // при совпадении выполнит этот блок и перейдет и выполнит блок 4
            case 3:
                Console.WriteLine(3);
                break;
            case 4:
                Console.WriteLine(4);
                break;
            default:
                Console.WriteLine("Default");
                break;
        }
        
        // пример возвращаемого значения

        static int Operations(int op, int val1, int val2)
        {
            switch (op)
            {
                case 1:
                    return val1 + val2; // break не нужно
                case 2:
                    return val1 - val2;
                case 3:
                    return val1 * val2;
                case 4:
                    return val1 / val2;
                default:
                    return -1;
            }
        }
        
        Console.WriteLine(Operations(2, 10, 5));
        
        // получение значения напрямую в переменную
        static int Operations2(int op, int val1, int val2)
        {
            // то же только запись сокращенная и возврат прямо в переменную result
            var result = op switch
            {
                1 => val1 + val2,
                2 => val1 - val2,
                3 => val1 * val2,
                4 => val1 / val2,
                _ => -1 // значение по умолчанию - обязательное иначе не скомпилируется
            };
            return result;
        }
        
        Console.WriteLine(Operations2(3, 2, 2));
        
        // Можно еще сократить с помощью сокращенного синтаксиса функций

        static int Operations3(int op, int val1, int val2) => op switch
        {
            1 => val1 + val2,
            2 => val1 - val2,
            3 => val1 * val2,
            4 => val1 / val2,
            _ => -1 // значение по умолчанию - обязательное иначе не скомпилируется
        };
        
        Console.WriteLine(Operations3(4, 8, 2));
    }
}