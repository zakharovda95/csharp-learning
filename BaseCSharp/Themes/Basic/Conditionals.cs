namespace BaseCSharp.Themes.Basic;

public class Conditionals
{
    public void Run()
    {
        Console.WriteLine("++++++++ Условные конструкции ++++++++");
        // Условная конструкция направляет по одному из путей в зависимости от условия
        
        // if...else...
        var num1 = 7;
        var num2 = 8;
        
        // if - выполнится если условие вернет true
        if (num1 < num2) // true тк 7 < 8
        {
            Console.WriteLine("Выполнится этот блок");
        }
        
        // Запись в без {} если в теле не больше 1 строки
        if (num1 < num2) Console.WriteLine("1 строка можно без скобок {}");
        
        // Либо с переносом на другую строку
        if (num1 < num2) 
            Console.WriteLine("1 строка можно без скобок {} и с переносом для красоты");
        
        // Несколько условий
        if (num1 < num2 && num1 == 7)
            Console.WriteLine("Выполняется этот блок");
        
        //else - выполнится если условие в if (и при наличии в else if) не выполнятся
        if (num1 == num2 || num2 == 9)
        {
            Console.WriteLine("Этот блок не выполнится");
        }
        else
        {
            Console.WriteLine("Этот блок выполнится если не выполнится if");
        }
        
        // Можно в 1 строку если блок из 1 строки
        if (num1 == num2 || num2 == 9) Console.WriteLine("Этот блок не выполнится");
        else Console.WriteLine("Этот блок выполнится если не выполнится if");
        
        // else if - выполнится если в if не выполнится но есть еще условия
        if (num1 > num2) Console.WriteLine("Не выполнится");
        else if (num1 == 7) Console.WriteLine("Выполнится");
        else Console.WriteLine("Не выполнится тк выполнился в else if");
        
        // Тернарное выражение val3 = val1 == 7 ? val1 : val2
        var num3 = 4;
        var num4 = 5;
        var num5 = num3 == 4 ? num3 + 1 : num4 * 7;
    }
}