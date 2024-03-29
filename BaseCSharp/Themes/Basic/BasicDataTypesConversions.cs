namespace BaseCSharp.Themes.Basic;

public class BasicDataTypesConversions
{
    public void Run()
    {
        Console.WriteLine("++++++++ ПРЕОБРАЗОВАНИЯ БАЗОВЫХ ТИПОВ ++++++++");
        // все целочисленные типы по умолчанию int (4byte)

        byte a = 3;
        int b = a + 100;
        
        //byte d = c + 100; 110 => ошибка тк c + 100 возвращает тип int и уже занимает 4 байта памяти
        //те не влезает хотя число входит в диапазон, но теоретически может быть больше 256 поэтому и ошибка
        byte c = 10;
        byte d = (byte)(c + 100); // приведение к byte => теперь занимает 1 байт памяти - все окей
        
        // Расширяющие преобразования (обычно не требуют явного указания преобразования тк нельзя потерять данные)
        // От меньшего к большему (безопасные) byte -> ushort -> uint -> ulong  
        byte e = 4; // 0b0000_0100; - 1 байт
        short f = e; // 0b0000_0000_0000_0100; - 2 байта данные не могут потеряться
        Console.WriteLine("0b0000_0000_0000_0100: {0}", Convert.ToString(f, 2));
        
        // Сужающие преобразования (требуют явное указание, на ответственности программиста)
        // от большего к меньшему (опасные) long -> int -> short -> sbyte
        ushort g = 4; // 0b0000_0000_0000_0100 - 2 байта
        byte h = (byte) g; // 0b0000_0100 - 1 байт - если бы g занимал больше 1 байта (>256) могли бы потерять данные
        Console.WriteLine("0b0000_0100: {0}", Convert.ToString(h, 2));
        
        // Неявные преобразования - без указания приведения для чисел > 0 заполняется нулями, <0 единицами
        // Те копируется знаковый бит - самый крайний левый бит и заполняет новое пустое место
        byte i = 4; // 0-255 0b0000_0100
        ushort j = i; // 0-65535 0b0000_0000_0000_0100 => заполнилось нулями тк > 0
        Console.WriteLine("4: {0}", Convert.ToString(j, 2));

        sbyte k = -4; // -128-127 0b1111_1100
        short l = k; // -32768 - 32767 0b1111_1111_1111_1100 - заполнилось единицами тк < 0
        Console.WriteLine("-4: {0}", Convert.ToString(l, 2));

        short m = -10;
        float n = m; // - безопасно тк float 4b

        int o = -100;
        float p = o; // - безопасно тк int 4b

        sbyte q = -100;
        //ushort r = q; нельзя тк ushort не может хранить отрицательные значения

        float s = 3.0F;
        decimal t = (decimal) s; // к decimal нужно приводить явно даже если объем позволяет тк decimal более точный тип

        // Итог: преобразование безопасно если позволяет объем выделенной памяти
    }
}