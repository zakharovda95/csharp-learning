namespace BaseCSharp.Themes;

public class DataTypes
{
    public void Run()
    {
        // bool System.Boolean 1bit
        bool isTrue = true;
        System.Boolean isFalse = false;
        Console.WriteLine(isTrue);
        Console.WriteLine(isFalse);
        
        // тк в 1 байте 8 бит то байт может хранить 255 значений (кол-во вариантов в 8 битном числе 00000000-11111111)
        // byte System.Byte 1bit от 0 - 255
        byte minByte = 0;
        System.Byte maxByte = 255;
        Console.WriteLine(minByte);
        Console.WriteLine(maxByte);
        
        // sbyte Sysyem.SByte 1byte от -128-127
        sbyte minSByte = -128;
        System.SByte maxSByte = 127;
        Console.WriteLine(minSByte);
        Console.WriteLine(maxSByte);
        
        //short System.Int16 2byte хранит от -32768 - 32767 (тк в 2 байтах 16 бит а кол-во вариаций в 16-битном числе 65536)
        short minShort = -32768;
        System.Int16 maxShort = 32767;
        Console.WriteLine(minShort);
        Console.WriteLine(maxShort);
        
        // ushort System.UInt16 2byte хранит от 0 -65535
        ushort minUShort = 0;
        System.UInt16 maxUShort = 65535;
        Console.WriteLine(minUShort);
        Console.WriteLine(maxUShort);
        
        // int System.Int32 4byte хранит -2147483648 до 2147483647 тк в 4 байтах 32 бита
        int minInt = -2147483648;
        System.Int32 maxInt = 2147483647;
        Console.WriteLine(minInt);
        Console.WriteLine(maxInt);
        
        // uint System.UInt32 4byte хранит от 0 - 4294967295
        uint minUInt = 0U;
        System.UInt32 maxUInt = 4294967295U;
        Console.WriteLine(minUInt);
        Console.WriteLine(maxInt);
        
        // long System.Int64 8byte хранит от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807
        long minLong = -9223372036854775808L;
        System.Int64 maxLong = 9223372036854775807L;
        Console.WriteLine(minLong);
        Console.WriteLine(maxLong);
        
        // ulong System.UInt64 8byte хранит от 0 - 18446744073709551615
        ulong minULong = 0UL;
        System.UInt64 maxULong = 18446744073709551615UL;
        Console.WriteLine(minULong);
        Console.WriteLine(maxULong);
        
        // float System.Single 4byte от -3.4*10^38 до 3.4*10^38
        float minFloat = -3.4e38F;
        System.Single maxFloat = 3.4E38F;
        Console.WriteLine(minFloat);
        Console.WriteLine(maxFloat);
        
        // double System.Double 8byte от ±5.0*10-324 до ±1.7*10308 
        double minDoublePlus = 5.0E-324;
        double maxDoublePlus = 1.7E308;
        System.Double minDoubleMinus = -5.0e-324;
        System.Double maxDoubleMinus = -1.7e-308;
        Console.WriteLine(minDoublePlus);
        Console.WriteLine(maxDoublePlus);
        Console.WriteLine(minDoubleMinus);
        Console.WriteLine(maxDoubleMinus);
        
        // decimal System.Decimal 16byte от ±1.0*10-28 до ±7.9228*1028 16 знаков после запятой
        // используется для финансовых операций или операций с повышенной точностью 
        decimal minDecimalPlus = 1.0e-28M;
        decimal maxDecimalPlus = 7.9e28M;
        System.Decimal minDecimalMinus = -1.0e-28M;
        System.Decimal maxDecimalMinus = -7.9e28M;
        Console.WriteLine(minDecimalPlus);
        Console.WriteLine(maxDecimalPlus);
        Console.WriteLine(minDecimalMinus);
        Console.WriteLine(maxDecimalMinus);
        
        // char System.Char 2byte - хранит литералы символов
        char a = 'A';
        System.Char b = '\x5A';
        Console.WriteLine(a);
        Console.WriteLine(b);
        
        // string System.String - хранит строковые литералы
        string str = "Строка";
        System.String str2 = "Тоже строка";
        Console.WriteLine(str);
        Console.WriteLine(str2);
        
        // object Sysyem.Object - 4byte на 32 разрядных системах 8 - на 64.
        // Базовый класс для всех объектов, хранит объекты любого типа
        object strObj = "Строка";
        System.Object numObj = 123;
        Console.WriteLine(strObj);
        Console.WriteLine(numObj);
        
        // Неявная типизация var
        var str3 = "Строка с неявной типизацией"; // должна быть сразу проинициализирована
        //var nullIserror = null; - нельзя присваивать нулл
    }
}