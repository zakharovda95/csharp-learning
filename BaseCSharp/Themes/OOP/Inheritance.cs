namespace BaseCSharp.Themes.OOP;

public class Inheritance
{
    internal class Person
    {
        private string _name;

        public Person() {} // чтобы не обязательно прокидывать через base можно объявить пустой конструктор без параметров
        // если объявлены только конструкторы с параметрами то в потомке нужно будет прокинуть данные через :base(параметры)
        public Person(string name)
        {
            _name = name;
        }

        public void Log()
        {
            Console.WriteLine(_name);
        }
    }
    
    internal class Employee : Person // наследуется от Person и имеет весь его функционал кроме конструкторов с параметрами!
    {
        private int _age;
        
        private protected string field1 = "123123123";
        
        public Employee() {}
        public Employee(string name, int age) : base(name) // если в базовом классе есть ТОЛЬКО конструкторы С ПАРАМЕТРАМИ
                                                     // мы обязаны вызвать их (base), или объявить конструктор без параметров 
        {
            _age = age;
        }

        public void Log2()
        {
            Console.WriteLine(_age);
        }
    }
    
    // sealed - говорит что не может от него быть наследников, но сам он может иметь родителя
    //public sealed class MyClass : Employee - ошибка тк этот класс public более доступен чем родитель (internal)
    internal sealed class MyClass : Employee // internal или private - работают прекрасно
    {
        internal MyClass() {}
        
        public void Run()
        {
            Console.WriteLine("От меня не может бытть наследников");
            //Console.WriteLine(_age); - нельзя тк private поля родителя не видны в наследниках
            Console.WriteLine(field1); // - private protected и выше - можно
            // protected - значит доступен в наследниках
        }
    }
    
    
    public void Run()
    {
        Console.WriteLine("++++++++ НАСЛЕДОВАНИЕ ++++++++");
        // Наследование - механизм при котором функционал класса-родителя передается классу-потомку
        // Класс от которого происходит наследование называется Базовым

        Person person = new Person("Дима");
        Person employee = new Employee("Дима", 29); // тк Person базовый класс то производный может иметь его тип
        Employee employee2 = new Employee("Вова", 31); // те может иметь тип Employee и Person (и другие в цепочке)
        //Employee person2 = new Person("Дима"); - нельзя тк Employee потомок а тип потомок не может иметь объект родитель
        
        // Все классы неявно являются потомками класса Object 
        object employee3 = new Employee("Евгений", 56); // любой класс может иметь тип Object тк он родитель всего
        
        // Модификаторы доступа при наследовании:
        // Модификатор потомка может быть такой же или строже но не наоборот
        // те если родитель internal то потомок не может быть public, а только на понижение 
        
        // sealed - модификатор запрещающий наследование
        
        // С# не поддерживает множественное наследование те можно иметь только 1 родителя
        
        // порядок вызова конструкторов сначала вызывается конструктор объекта который передает через base потом в Object и обратно
    }
}