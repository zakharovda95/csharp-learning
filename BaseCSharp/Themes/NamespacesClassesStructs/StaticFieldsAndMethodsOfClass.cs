namespace BaseCSharp.Themes.NamespacesClassesStructs;

public class StaticFieldsAndMethodsOfClass
{
    
    // Статичный класс - имеет только статичные члены и не может иметь экземпляров
    
    internal static class ExampleStaticClass
    {
        internal static int Field1;
        // статичный конструктов - вызывается при обращении
        static ExampleStaticClass()
        {
            Field1 = 321; // проинициализирует поле
            Console.WriteLine(Field1);
        }

        internal static int StaticMethod(int field)
        {
            Field1 = field;
            Console.WriteLine(Field1);
            return Field1;
        }
    }
    
    // Обычный нестатичный класс
    internal class ExampleClass
    {
        
        // статичноен поле
        internal static int Field1 = 123;
        
        // счетчик для подсчета количества созданных экземпляров класса
        internal static int Counter { get; set; }

        private int _age;
        
        // статичный конструктор - не имеет модификатора доступа нет параметров нельзя вызывать
        // служит только для инициализации каких то СТАТИЧНЫХ данных
        static ExampleClass()
        {
           // _age = 0; - нельзя обращаться к нестатичным членам - ошибка!
            Counter = 0; // проинициализировали статичное свойство
        }

        // обычный конструктор
        internal ExampleClass()
        {
            // Увеличение счетчика при создании экземпляра
            Counter++;
            _age = 30;
        }

        // статичный метод - доступен для всего класса в целом не доступен для экземпляров класса
        internal static void SomeMethod(ExampleClass exClass) // для этого передать конкретный объект
        {
            // в статичных методах и конструкторах нельзя использовать ключевое слово this тк нет контекста объекта
            //Console.WriteLine(_age); - нельзя обращаться к НЕСТАТИЧЕСКИМ членам внутри СТАТИЧЕСКОГО метода
            Console.WriteLine(exClass._age); // обращение к нестатичному члену без проблем через переданный экземпляр класса
            Console.WriteLine(Counter); // обращение к статичному члену внутри статичного метода без проблем
        }

        // нестатичный метода - доступен для экземпляров класса не доступен для всего класса в целом
        internal void SomeMethod2()
        {
            Console.WriteLine("Нестатичный " + Field1); // можно использовать в нестатичных методах
        }
    }
    
    
    public void Run()
    {
        Console.WriteLine("++++++++ СТАТИЧЕСКИЕ ПОЛЯ И МЕТОДЫ КЛАССА ++++++++");
        
        // Статические поля и методы относятся не к отдельным объектам класса а ко ВСЕМУ КЛАССУ ВЦЕЛОМ
        // Для доступа к статическим членам класса не нужно создавать объект класса
        // Для статичных членов класса выделяется память в куче одно для всех объектов и даже если ни одного объекта нет

        var obj1 = new ExampleClass(); // нет доступа к статичным членам класса у объекта
        obj1.SomeMethod2(); // у конкретных объектов класса можно вызывать только нестатичные члены

        Console.WriteLine(ExampleClass.Field1);// есть доступ при обращении ко всему классу а не к конкретному его объекту
        ExampleClass.SomeMethod(obj1); // есть доступ при обращении ко всему классу а не к конкретному его объекту
        // Статические поля и методы нужны для каких то общих данных или хелперов относящихся к классу

        var obj2 = new ExampleClass(); // +1 к счетчику
        ExampleClass.SomeMethod(obj2); // нужно передать экземпляр для выполнения статичного метода

        ExampleStaticClass.StaticMethod(123);

    }
}