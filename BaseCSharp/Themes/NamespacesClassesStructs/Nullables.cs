// #nullable enable - нуллабл контекст только для этого файла (сначала нужно отключить в csproj)
namespace BaseCSharp.Themes.NamespacesClassesStructs;

public class Nullables
{

    internal struct ExampleStruct
    {
        internal ExampleStruct2? field1;
    }

    internal struct ExampleStruct2
    {
        internal string? field2;
    }
    
    public void Run()
    {
        Console.WriteLine("++++++++ NULL И ССЫЛОЧНЫЕ И ЗНАЧИМЫЕ ТИПЫ ++++++++");
        
        // null - означает отсутствие данных;
        string field = null; // до С#8 можно было присваивать null - теперь есть nullable типы - используем их
        string? field2 = null; // после типа ставится ? - значит может быть null
        
        // Необходимо всегда проверять на null
        // Nullables контекст включен по умолчанию для всего проекта отключить можно в .scproj
        // <Nullables>enable</Nullables> - включение
        // <Nullables>disable</Nullables> - отключение
        
        // Можно включать nullable тип только для одного файла через #nullable enable 
        
        // при отключенном nullable контексте можно включать его на отдельных участках кода
        #nullable enable
        string? s = null;
        #nullable restore
        
        // опреатор ! - позваляет сказать что это точно не null - отключаем ненужные предупреждения

        string? a = null;
        Console.WriteLine(a!); // указали что a точно не null - нужно быть осторожнее
        
        // Значимым типам нельзя присвоить null
        string str = null; // string - ссылочный тип можно присвоить но с предупреждением
        //int num = null; - значимым нельзя, используем nullable

        int? num1 = null; // все окей
        // ? - сокращеная форма можно Nullable<T>
        Nullable<int> num2 = null; // полная форма
        
        // Есть 2 свойства Value - свойство nullable типа и HasValue - true - если есть значение
        if (num2.HasValue) Console.WriteLine(num2.Value);
        else Console.WriteLine("Значения нет");
        
        // GetValueOrDefault - можно получить значение если оно есть иначе получить значение по умолчанию
        int defaultValue = 10;
        var res = num2.GetValueOrDefault(defaultValue);
        Console.WriteLine(res);
        
        // Преобразования nullable типов

        int? x = null;
        if (x.HasValue)
        {
            int y = (int) x; // явно преобразовали
        }

        int b = 4;
        int? c = b; // неявно преобразовали int к int?

        int d = 4;
        long? f = d; // неявное расширяющее

        long g = 10;
        int? h = (int)g; // yявное сужающее
        
        // Операции с nullable
        // Если в операции учавствует nullable то результат тоже nullable

        int? j = 4;
        //int k = j + 4; // нельзя тк результат должен быть nullable
        int? res2 = j + 4;// все окей
        
        // если один из операндов null - результат null
        int? l = null;
        int? m = l + 4; // null
        Console.WriteLine(m);
        
        //В сравнения кроме == и != если один из операндов null - то результат false
        int? n = null;
        Console.WriteLine(n > 4); // false
        
        // Для операторов != и == - работает стандартное сравнение
        int? o = null;
        Console.WriteLine(o != 4);
        Console.WriteLine(o == null);
        
        // Проверки на null (Null guard)
        // Есть следующие варианты проверки на null
        int? field1 = null;
        
        if (field1 != null) Console.WriteLine(field1); // оператор !=
        if (field1 is null) Console.WriteLine(field1); // оператор is или is not
        if (field1 is not null) Console.WriteLine(field1); // is not
        if (field1 is int) Console.WriteLine(field1); // is тип_данных - на соответствие типу данных (если не null то есть)
        
        // Оператор null объединения ?? - если слева null то выполнится значение справа (те установка по умолчанию)
        int? field3 = null;
        Console.WriteLine(field3 ?? 999); // если field3 - null то покажется 999
        // ?? - работает только с nullable типами
        int field4 = 4;
        //Console.WriteLine(field4 ?? 998); - нельзя field4 не nullable
        
        // Условный null - оператор ?. - если null прекращает выполнение без ошибки
        // Используется для краткой записи проверок
        int? field5 = 8;
        int? field6 = null;
        int? field7 = 11;
        
        // Такую проверку можно записать короче прямо внутри вывода на консоль
        var ex = new ExampleStruct();
        var ex2 = new ExampleStruct2();
        ex2.field2 = "Строка";
        ex.field1 = ex2;
        Console.WriteLine(ex.field1?.field2); // если одно из полей null то выйдет без ошибки
        Console.WriteLine(ex.field1?.field2 ?? "Строка по умолчанию"); // c null объединением

    }
}