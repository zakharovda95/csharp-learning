namespace BaseCSharp.Themes;

public class ArithmeticOperations
{
    public void Run()
    {
        // Операции применяются над операндами. Бывают унарные, бинарные и тернарные
        
        // Бинарные операции (к 2 операндам)
        // +
        const byte a = 10;
        var b = a + 20;
        Console.WriteLine(b);
        // -
        const sbyte c = -32;
        var d = c - 40;
        Console.WriteLine(d);
        // *
        const float e = 3.12F;
        var f = e * 7;
        Console.WriteLine(f);
        // / - для деления используем всегда числа типа double чтобы не потерять дробную часть даже для целых чисел
        const double g = 30.0;
        var h = g / 4.0;
        Console.WriteLine(h); // резыльтат 7.5 - все ок

        const byte i = 30;
        var j = i / 4;
        Console.WriteLine(j); // результат 7 - потеряли 0.5

        const double k = 10;
        var l = k / 3;
        Console.WriteLine(l); // все окей 3.33333
        
        // % - остаток от деления
        const int m = 10;
        var n = m % 3;
        Console.WriteLine(n); // 1 тк 10 % 3 = 10 - (3 * 3) = 1
        
        // Унарные операции (к 1 операнду)
        // Инкремент
        byte o = 10;
        var p = o++; // постфиксный - сначала присвоили потом увеличили
        Console.WriteLine("o " + o);
        Console.WriteLine("p " + p);
        byte q = 10;
        var r = ++q; // префиксный - сначала увелиили потом присвоили
        Console.WriteLine("q " + q);
        Console.WriteLine("r " + r);
        
        // Декремент
        byte s = 10;
        var t = s--; // постфиксный - сначала присвоили потом увеличили
        Console.WriteLine("s " + s);
        Console.WriteLine("t " + t);
        byte u = 10;
        var v = --u; // префиксный - сначала увелиили потом присвоили
        Console.WriteLine("u " + u);
        Console.WriteLine("v " + v);
        
        // Приоритет операций (все почти как в математике)
        // 1) Инкремент декремент - самый высокий
        // 2) Умножение деление остаток от деления - средний
        // 3) Сложение вычитание - низкий
        // Выражение в скобках высший приоритет
        // Одинаковые приоритеты считаются слева направо

        var w = 10;
        var x = 103;
        var y = 50;
        var z = w-- - x * y;
        Console.WriteLine(z);
    }
}