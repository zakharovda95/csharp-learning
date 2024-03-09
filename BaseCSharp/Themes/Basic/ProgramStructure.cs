namespace BaseCSharp.Themes.Basic;

public class ProgramStructure
{
    public void Run()
    {
        // Файлы с расширением .cs , может быть много файлов
        
        // Блоки инструкций
        {
            Console.WriteLine("Привет!");
            Console.WriteLine("Добро пожаловать в C#");
        }

        // Может иметь внутренние блоки
        {
            Console.WriteLine("Внешний блок");

            {
                Console.WriteLine("Внутренний блок");
            }
        }

        // Однострочный комментарий

        /*Многострочный
        Комментарий*/
        
        // Настройки в файле имя_проекта.csproj
    }
}