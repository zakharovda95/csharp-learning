//namespace BaseCSharp.Themes.NamespacesClassesStructs; - если одно пространство имен на весь файл

    // пространство имен - контейнер который объединяет логически какой то функционал
    // пространство имен можно указывать явно или он будет по находящемуся пути модуля
    // в разных частях проекта может быть одно пространство имен в разных местах
    // чтобы подключить пространство имен используется директива using либо полное имя

namespace BaseCSharp.Themes.NamespacesClassesStructs
{
    using B; // нужно импортировать неймспейс
    public class Namespaces
    {
        public void Run()
        {
            Console.WriteLine("++++++++ ПРОСТРАНСТВА ИМЕН ++++++++");

           // var cl = new ExampleClass();  - ошибка не видит клас во вложенном неймспейсе тк другой
           var cl = new ExampleClass(); // теперь окей
           // либо
           var cl2 = new B.ExampleClass(); // полное имя вместе с неймспейсом
        }
    }

    namespace B
    {
        public class ExampleClass
        {
            public void Test()
            {
                var cl = new Namespaces(); // можно так как вложенный неймспейс
            }
        }
    }
    
    // глобальные пространства имен - using подключается один раз в файле GlobalUsing.cs и доступен по всему проету
    
    //var cl = new ExampleClass(); // доступно без using тк есть глобальный файл импортов
    
    // пространства имен по умолчанию
    // в файле проекта имя_файла.csproj есть строчки для подключения самых популярных пространств имен
    //<ImplicitUsings>enable</ImplicitUsings> - включено (по умолчанию)
    // <ImplicitUsings>disablr</ImplicitUsings> - выключено
    
    // После билда можно посмотреть включеные импорты по адресу obj/Debug/net8.0/имя_проекта.GlobalUsings.g.cs
    
    // можно подключать в настройках по отдельности отключив популярные юзинги и подключив ниже нужные по отдельности
    
    // Пример:
    // Подключение по одному директива Include
    /*<ItemGroup>
        <Using Include="System" />
        <Using Include="System.Threading.Tasks" />
    </ItemGroup>*/
    // Отключение по одному - директива Remove
    /*<ItemGroup>
        <Using Remove="System" />
        <Using Remove="System.Threading.Tasks"/>
    </ItemGroup>*/
    
}