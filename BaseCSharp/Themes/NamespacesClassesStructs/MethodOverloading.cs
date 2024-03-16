namespace BaseCSharp.Themes.NamespacesClassesStructs;

public class MethodOverloading
{
    internal class ExampleClass
    {
        
        internal void Test()
        {
            Console.WriteLine("Первая перегрузка");
        }
        
        internal void Test(int a)
        {
            Console.WriteLine("Вторая перегрузка");
        }
        
        internal void Test(byte a) // параметр другого типа
        {
            Console.WriteLine("Третья перегрузка");
        }
        
        internal void Test(byte a, int b) // разное кол-во параметров
        {
            Console.WriteLine("Четвертая перегрузка");
        }
        
        internal void Test(ref byte a, int b) // добавлен модификатор
        {
            Console.WriteLine("Пятая перегрузка");
        }
        
        internal void Test(int b, ref byte a) // дрйгой порядок
        {
            Console.WriteLine("Пятая перегрузка");
        }
        
        /*internal void Test(ref byte c, int d) // ошибка - имена параметров не влияют
        {
            Console.WriteLine("Пятая перегрузка");
        }*/
    }
    
    public void Run()
    {
        Console.WriteLine("++++++++ ПЕРЕГРУЗКА МЕТОДОВ ++++++++");
        
        // Перегрузка методов позволяет сделать несколько версий одного метода в зависимости от переданных параметров
        // Перегрузка определяется по сигнатуре
        // Сигнатура состоит из количества параметров порядок параметров и модификаторов параметров
        // ВОЗВРАЩАЕМОЕ ЗНАЧЕНИЕ НЕ ВХОДИТ В СИГНАТУРУ
        // Имя метода должно быть одинаковое
        // Имя метода и возвращаемый тип не основание для создания перегрузки!!!

        var obj = new ExampleClass();
        obj.Test(); // 1
        obj.Test(123);//2
        obj.Test((byte) 123);// 3
        obj.Test((byte) 123, 123); // 4
        byte field = 123;
        obj.Test(ref field, 123); // 5


    }
}