using Newtonsoft.Json;

namespace BaseCSharp.Themes.NamespacesClassesStructs;

public class NugetPackages
{
    public class ExampleClass
    {
        public string Name { get; init; }
        public string LName { get; init; }
        public int Age { get; init; }
        public string FullInfo => $"Имя: {Name} Фамилия: {LName} Возраст: {Age}";
    }
    
    public void Run()
    {
        Console.WriteLine("++++++++ ПАКЕТЫ NUGET ++++++++");
        var obj = new ExampleClass { Name = "Дмитрий", LName = "Захаров", Age = 28 };
        var json = JsonConvert.SerializeObject(obj); // для сеарилизации объект должен быть public
        Console.WriteLine(obj.FullInfo);
        Console.WriteLine(json);
    }
}