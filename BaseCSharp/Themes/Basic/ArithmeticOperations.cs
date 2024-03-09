namespace BaseCSharp.Themes.Basic;

public class ArithmeticOperations
{
    public void Run()
    {
        Console.WriteLine("++++++++ АРИФМЕТИЧЕСКИЕ ОПЕРАЦИИ ++++++++");
        // Операции применяются над операндами. Бывают унарные, бинарные и тернарные
        
        // Бинарные операции (к 2 операндам)
        // +
        Console.WriteLine("Сложение");
        const byte a = 10;
        var b = a + 20;
        Console.WriteLine("+: " + b);
        // -
        Console.WriteLine("Вычитание");
        const sbyte c = -32;
        var d = c - 40;
        Console.WriteLine("-: " +  d);
        // *
        Console.WriteLine("Умножение");
        const float e = 3.12F;
        var f = e * 7;
        Console.WriteLine("*: " +  f);
        // / - для деления используем всегда числа типа double чтобы не потерять дробную часть даже для целых чисел
        Console.WriteLine("Деление");
        const double g = 30.0;
        var h = g / 4.0;
        Console.WriteLine("/: " + h); // резыльтат 7.5 - все ок

        const byte i = 30;
        var j = i / 4;
        Console.WriteLine("/ с потерей: " +  j); // результат 7 - потеряли 0.5

        const double k = 10;
        var l = k / 3;
        Console.WriteLine("/ без потерь: " + l); // все окей 3.33333
        
        // % - остаток от деления
        Console.WriteLine("Остаток от деления");
        const int m = 10;
        var n = m % 3;
        Console.WriteLine("%: " + n); // 1 тк 10 % 3 = 10 - (3 * 3) = 1
        
        // Унарные операции (к 1 операнду)
        // Инкремент
        Console.WriteLine("Инкремент");
        byte o = 10;
        var p = o++; // постфиксный - сначала присвоили потом увеличили
        Console.WriteLine("o: " + o);
        Console.WriteLine("p = o++: " + p);
        byte q = 10;
        var r = ++q; // префиксный - сначала увелиили потом присвоили
        Console.WriteLine("q: " + q);
        Console.WriteLine("r = ++q: " + r);
        
        // Декремент
        Console.WriteLine("Декремент");
        byte s = 10;
        var t = s--; // постфиксный - сначала присвоили потом увеличили
        Console.WriteLine("s: " + s);
        Console.WriteLine("t = s--: " + t);
        byte u = 10;
        var v = --u; // префиксный - сначала увелиили потом присвоили
        Console.WriteLine("u: " + u);
        Console.WriteLine("v = --u: " + v);
        
        // Приоритет операций (все почти как в математике)
        // 1) Инкремент декремент - самый высокий
        // 2) Умножение деление остаток от деления - средний
        // 3) Сложение вычитание - низкий
        // Выражение в скобках высший приоритет
        // Одинаковые приоритеты считаются слева направо

        Console.WriteLine("Приоритет операций");
        var w = 10;
        var x = 103;
        var y = 50;
        var z = w-- - x * y;
        Console.WriteLine(z);
    }
}