namespace BaseCSharp.Themes.Basic;

public class ParamsByRefOrValue
{
    public void Run()
    {
        Console.WriteLine("++++++++ ПЕРЕДАЧА ПАРАМЕТРОВ ПО ССЫЛКЕ И ПО ЗНАЧЕНИЮ ++++++++");
        // существует 2 способа передачи параметров - по ссылке и по значению
        
        // По значению - обычный способ передачи параметров
        int val1 = 2;
        int Sum(int a, int b)
        {
            a += 1;
            return a + b;
        }
        Console.WriteLine($"По значению - до инкремента: {val1}");
        Sum(val1, 5);
        Console.WriteLine($"По значению - после инкремента: {val1}"); // val1 не мутировался после инкремента
        // параметры переданные по значению не меняются тк получает не саму переменную а ее копию, независящую от нее
        
        
        // Передача параметров по ссылке Ref - применять когда нужно изменить внешнюю  переменную внутри какой то функции
        int val2 = 5; // - обязан быть проинициализирован тк присвоение значения в методе не обязательно
        int Sum1(ref int a, int b)
        {
            // присвоение значения a не обязательно
            a++;
            return a + b;
        }
        Console.WriteLine($"Ref - до инкремента: {val2}");
        Sum1(ref val2, 5);
        Console.WriteLine($"Ref - после инкремента: {val2}"); // мутировался потому что передан по ссылке
        // параметр переданныйчерез реф - передает не копию, а ссылку на переменную в памяти поэтому мутируется
        
        // Выходной параметр out - то же передача по ссылке 
        // применять когда нужно вернуть несколько параметров логически отличающиеся
        // (например успешно ли выполнение (bool) и сам результат выполнения (int string ...))
        int val3; // может быть не инициализирован тк в методе обязательно out присвоить значение
        int Sum2(int a, out int b)
        {
            b = a + 10; // обязательно присвоение значения выходному параметру
            return a + b;
        }
        Sum2(10, out val3);
        Sum2(20, out var Val4); // можно объявить out переменную прямо в вызове метода
        Console.WriteLine($"Out - После присвоения в методе: {val3}");
        // Несколько out параметров
        int Sum3(int a, out int b, out int c) // можно сколько угодно out параметров
        {
            c = b = a + 10;
            return a + b + c;
        }
        
        // Входной параметр с in - передается по ссылке - применять когда нужно явно запретить возможное изменение какого то параметра
        int Sum4(ref int a, in int b)
        {
            a++; // - меняется тк передан по ссылке с помощью ref
            //b--; - нельзя менять тк передан по ссылке с помощью in
            return a + b;
        }

        var val5 = 5;
        var val6 = 3;
        Sum4(ref val5, in val6);
        
        /*int Sum5(ref readonly int a, int b) // неизменяемые ref переменные (похоже на in)
        {
            return a + b;
        }*/ // вроде как доступен начиная C# 12 но что то не работает (да и не особо надо)
    }
}