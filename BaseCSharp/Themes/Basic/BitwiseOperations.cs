using System.Text;
namespace BaseCSharp.Themes.Basic;

public class BitwiseOperations
{
    public void Run()
    {
        Console.WriteLine("++++++++ ПОРАЗРЯДНЫЕ ОПЕРАЦИИ ++++++++");
        // & логическое И или логическое умножение - все входы 1 - выход 1
        // | логическое ИЛИ или логическое сложение - хотя бы 1 вход 1 - выход 1
        Console.WriteLine("Логическое И и ИЛИ");
        byte x1 = 2;
        byte x2 = 5;
        Console.WriteLine(x1 & x2); // 010 * 101 = 000 => 0 умножение
        Console.WriteLine(x1 | x2); // 010 + 101 = 111 => 7 сложение
        byte x3 = 4;
        byte x4 = 5;
        Console.WriteLine(x3 & x4); // 100 * 101 = 100 => 4  умножение
        Console.WriteLine(x3 | x4); // 100 + 101 = 101 => 5  сложение
        
        // ^ XOR - единица, когда входы имеют разные значения, и не имеют одинаковых значений 
        // те 0 и 1 => 1 , 1 и 0 => 1 , 0 и 0 => 0 , 1 и 1 => 0 
        // применяется для простого шифрования
        Console.WriteLine("XOR");
        
        // Простой шифратор - дешифратор XOR (искл ИЛИ)
        var key = "key";
        var codeText = XorEncoderDecoder("Hello World", key);
        Console.WriteLine(codeText);
        var encodeText = XorEncoderDecoder(codeText, key);
        Console.WriteLine(encodeText);
        
        // Шифратор - дешифратор чисел
        var num = 7; 
        var xorkey = 12;
        var code = num ^ xorkey; // 00111 ^ 1100 => 1011 => 11
        
        Console.WriteLine("Зашифрованое число: " + code );
        Console.WriteLine("Дешифрованое число: " + (code ^ xorkey));
        
        // ~ Логическое отрицание (инверсия) 
        Console.WriteLine("ИНВЕРСИЯ");
        Console.WriteLine(Convert.ToString(~10, 2)); // ~00001010 (10) => 11110101 (-11 или 245 без знака те 256 - 11 = 245)
        
        // Отрицательное представление чисел
        //Чтобы получить отрицательное представление числа нужно инвертировать + 1
        Console.WriteLine(~9 + 1); // -9 => ~00001001 => 11110110 + 00000001 = 11110111 (256 - 9 = 247)

        
        //Операции сдвига
        Console.WriteLine(3<<3); // 011 => 11000 24 =>  3 * 2 * 2 * 2 
        Console.WriteLine(30>>3); // 11110 => 11 => 30 / 2 / 2 / 2 по модулю
        
        // Если кратно двойке можно умножать и делить
        Console.WriteLine(2 << 2); // 8 => 2 * 2 * 2;
        Console.WriteLine(4 >> 1); // 4 => 4 / 2;
        
        // Для удобства можно записывать числа в двоичной системе через поджопник
        Console.WriteLine(0b0000_1111);
        
        // Пример применения => сохраним 3 числа в 1 для экономии места
        // Есть 3 числа и переменная для результата
        var num1 = 0b0000_0001;
        var num2 = 0b0000_0010;
        var num3 = 0b0000_0011;
        var res = 0b0000_0000;
        //Сложим результат и 1 и сдвинем на 2 разряда
        res |= num1; // 000 + 001 => 001
        res <<= 2; // 100
        // Сложим результат и 2 и опять сдвинем на 2 разряда
        res |= num2; // 100 + 010 => 110
        res <<= 2; // 11000
        // Сложим результат и 3 число
        res |= num3; // 11000 + 00011 => 11011
        Console.WriteLine(res);
        
        // Обратная операция
        const byte BYTWISE_MASK = 0b0000_0011; // _0011 потому что от 0-3 нужно 2 бита,
                                               // если бы нужно было например от 0-5 маска была бы _0111 итд 
        int newVal1 = res & BYTWISE_MASK; // результат умножаем на маску
        res >>= 2; // сдвигаем на 2 бита
        int newVal2 = res & BYTWISE_MASK; // то же
        res >>= 2; // то же
        int newVal3 = res & BYTWISE_MASK; // то же
        Console.WriteLine(newVal1 + " " + newVal2 + " " + newVal3);
        
        // Так же можно получить конкретное число (например получим 2)
        var result = 0b0011_1001;
        int recreatedValue1 = (result & 0b0011_0000) >> 4;
        Console.WriteLine(recreatedValue1);
    }

    private static string XorEncoderDecoder(string text, string key)
    {
        var textBytes = Encoding.Unicode.GetBytes(text);
        var keyBytes = Encoding.Unicode.GetBytes(key);

        for (var i = 0; i < textBytes.Length; i++)
        {
            textBytes[i] = (byte)(textBytes[i] ^ keyBytes[i % keyBytes.Length]);
        }

        return Encoding.Unicode.GetString(textBytes);
    }
}