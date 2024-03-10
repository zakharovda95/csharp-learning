namespace BaseCSharp.Themes.Basic;

public class Cycles
{
    public void Run()
    {
        Console.WriteLine("++++++++ ЦИКЛЫ ++++++++");
        // Циклы - повторяют блок кода n раз
        // Бывают for foreach while do..while..
        
        // for
        // 1 часть - действия до выполнения, 2 часть - условие выполнения, 3 часть - действия после выполнения
        for (var i = 0; i < 5; i++) // i - счетчик i < 5 - условие выведет 0-4 i увеличивается на 1 после каждой итерации
        {
            Console.WriteLine(i);
        }
        
        // В одну строку
        for (int i = 5, k = 7; i >= 0 && k >= 2; i--, k--) Console.WriteLine(i + k);
        
        // Без каких то блоков
        var j = 0;
        for (; j < 3 ;)
        {
            Console.WriteLine(j);
            j++;
        }
        
        
        // Do... While...
        do
        {
            Console.WriteLine("Выполнится хотябы 1 раз");
            j++;
        } 
        while (j < 0);
        
        //While...
        while (j < 5)
        {
            Console.WriteLine(j);
            j++;
        }
        
        // foreach - для коллекций
        var str = "ARRAY";
        foreach (var el in str)
        {
            Console.WriteLine(el);
        }
        
        
        // Continue - для пропуска итерации по условию (не выйдет полностью из цикла)
        for (int i = 0; i <= 5; i++)
        {
            if (i == 3) continue; // пропускаем итерацию но не выходим из цикла
            Console.WriteLine(i);
        }
        
        // Break - для выхода из цикла
        for (int i = 0; i <= 5; i++)
        {
            if (i == 3) break; // выходим из цикла (полностью)
            Console.WriteLine(i);
        }
        
        // Вложенные циклы - в одном цикле может быть 1 и более вложенных циклов
        // Используется для прохода или построения таблиц, сеток, матриц и тд
        for (var i = 0; i < 5; i++)
        {
            Console.WriteLine($"Строка (внешний цикл) {i}");
            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine($"Столбик (внутренний цикл) {k} ");
            }
            Console.WriteLine("\n");
        }
        
    }
}