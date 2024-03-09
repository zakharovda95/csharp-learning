namespace BaseCSharp.Themes.Basic;

public class AssignmentOperation
{
    public void Run()
    {
        // = операция присваивания призваивает левому оператору значение правого,
        // причем левый только представляет значение правого оператора (переменную или выражение)

        var a = 123;

        int b, c, d;
        b = c = d = 27 * 3 / 2;
        Console.WriteLine(c + " " + c + " " + d);
        
        // У присваивания низкий приоритет поэтому выполняется справа налево

        int e = 2 + 3; // начала 2 + 3, потом присвоение

        
        // сокращенная запись операций с присвоением
        // +=
        var f = 10;
        var g = 2;
        Console.WriteLine(f += g); // f = f + g
        // -=
        Console.WriteLine(f -= g); // f = f - g;
        // *=
        Console.WriteLine(f *= g); // f = f * g;
        // /=
        Console.WriteLine(f /= g); // f = f / g;
        // %=
        Console.WriteLine(f %= g); // f = f % g;
        // &=
        Console.WriteLine(f &= g); // f = f & g;
        // |=
        Console.WriteLine(f |= g); // f = f | g;
        // ^=
        Console.WriteLine(f ^= g); // f = f ^ g;
        // <<=
        Console.WriteLine(f <<= g); // f = f << g;
        // >>= 
        Console.WriteLine(f >>= g); // f = f >> g;
        
        // Присвоения правоассоциативные те выполняются слева направо
        var h = 20;
        var i = 10;
        var j = h += i -= 5;
        // i = i - 5; i = 10 - 5 = 5
        // h = i + h; h =20 + 5 = 25
        // j = h; j = 25
        Console.WriteLine(j);
    }
}