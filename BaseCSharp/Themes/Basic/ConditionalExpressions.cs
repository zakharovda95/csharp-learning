namespace BaseCSharp.Themes.Basic;

public class ConditionalExpressions
{
    public void Run()
    {
        Console.WriteLine("++++++++ ЛОГИЧЕСКИЕ ВЫРАЖЕНИЯ ++++++++");
        // условные выражения возвращают true/false - операции сравнения и логические операции
        
        Console.WriteLine(" - Операции сравнения");
        // Операции сравнения
        const byte a = 100;
        const byte b = 101;
        // ==
        Console.WriteLine("==: " + (a == b)); // false тк 100 не равно 101
        // !=
        Console.WriteLine("!=: " + (a != b)); // true тк 100 не равно 101
        // >=
        Console.WriteLine(">=: " + (a >= b)); // false тк 100 не меньше или равно 101
        // <=
        Console.WriteLine("<=: " + (a >= b)); // false тк 100 не меньше или равно 101
        // >
        Console.WriteLine(">: " + (a >= b)); // false тк 100 меньше 101
        // <
        Console.WriteLine("<: " + (a >= b)); // true тк 100 меньше 101
        
        // >= <= > < - имеют больший приоритет чем == !=
        
        Console.WriteLine(" - Логические операции");
        const bool c = 100 < 101;
        const bool d = 10 == 10 - 1;
        // |
        Console.WriteLine("|: " + (c | d)); // true => тк true и false
        // &
        Console.WriteLine("&: " + (c & d)); // false => тк true и false
        // ||
        Console.WriteLine("||: " + (c || d)); // true => тк true
        // &&
        Console.WriteLine("&&: " + (c & d)); // false => тк true и false
        // !
        Console.WriteLine("!: " + !c); // false тк !true == false
        // ^
        Console.WriteLine("^: " + (c ^ d)); // true тк с - true, а d - false
        
        
        // | - выполнит вычисления над всеми операндами даже если уже один будет true
        // || - выполнит вычисления до первого true и возвратит его (и закончит)
        // & - выполнит вычисления над всеми операндами даже если встретит false
        // && - выполнит вычисления до первого false и возвратит его (и закончит)
        
        
    }
}