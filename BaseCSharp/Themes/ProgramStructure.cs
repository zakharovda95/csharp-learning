namespace BaseCSharp.Themes;

public class ProgramStructure
{
    public void Run()
    {
        // Вывод на консоль запуск приложения
        Console.WriteLine("Введите ваше имя");
        //var name = Console.ReadLine();
        var name = "ИМЯ";
        Console.WriteLine($"Ваше имя {name}");

        // Блоки инструкций
        {
            Console.WriteLine("Привет!");
            Console.WriteLine("Добро пожаловать в C#");
        }

        {
            Console.WriteLine("Внешний блок");

            {
                Console.WriteLine("Внутренний блок");
            }
        }

        // Комментарии

        // Однострочный комментарий

        /*Многострочный
        Комментарий*/
    }
}