namespace BaseCSharp.Themes.Basic;

public class Methods
{
    public void Run()
    {
        Console.WriteLine("++++++++ МЕТОДЫ ++++++++");
        // Метод - именованный блок кода который выполняет некоторые действия
        
        // Определение метода

        void SayHelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }
        // Вызов метода
        SayHelloWorld();

        
        // Пример
        void SayHelloWirldRu()
        {
            Console.WriteLine("Привет, Мир!");
        }
        
        void SayHelloWorldEn()
        {
            Console.WriteLine("Hello, World!");
        }

        void SayHelloWorldFr()
        {
            Console.WriteLine("Bonjour le monde!");
        }

        var lang = "Fr";
        switch (lang)
        {
            case "Ru":
                SayHelloWirldRu();
                break;
            case "En":
                SayHelloWorldEn();
                break;
            default:
                SayHelloWorldFr();
                break;
        }
        
        // Сокращенная запись
        
        // Не лямбда функция, а просто сокращенная запись с использованием синтаксиса лямбда-выражения
        // Лямбда выражения это анонимные функции/делегаты например string strFunc = () => "Строка"
        // В данной ситуации она именованая, поэтому просто сокращенный лямбда-синтаксис
        void SayHelloWorldDe () => Console.WriteLine("Hallo, Welt!"); // сокращенная запись
        SayHelloWorldDe();
    }
}