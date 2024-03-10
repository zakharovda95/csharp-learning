namespace BaseCSharp.Themes.Basic;

public class Arrays
{
    public void Run()
    {
        Console.WriteLine("++++++++ МАССИВЫ ++++++++");
        //Массивы - коллекции однотипных данных

        int[] nums;
        nums = new int[4]; // заполнено значениями по умолчанию для int - 0; [0, 0, 0, 0]
        
        // Можно сразу указать значения для массивов
        // Возможные записи
        int[] nums2 = new int[3] { 1, 3, 7 }; // полная запись
        int[] nums3 = new int[] { 1, 8, 77 }; // без длины - изменить длину нельзя
        int[] nums4 = new[] { 8, 11, 69 }; // сокращенная без int
        int[] nums5 = { 1, 3, 7, 99 }; // только инициализатор
        
        //int[] nums6 = [ 1, 3, 7, 99 ]; // литерал - доступно только с .NET 8 С# 12
        //int[] nums6 = []; // литерал - доступно только с .NET 8 С# 12

        // массив строк
        string[] strs = { "One", "Two", "Three" };
        
        // Индекс - для получения элемента массива начинается с 0
        var el = nums5[2]; // читаем элемент по индексу

        nums5[2] = 606; // Меняем значение по индексу
        
        // Устанавливаем новое значение для массива nums
        nums[0] = 12;
        nums[1] = 12;
        nums[2] = 12;
        nums[3] = 12;

        //nums[6] = 1010; - ошибка длина массива только 4
        
        // Длина массива
        var length = nums3.Length;

        // Получение элементов с конца массива
        var last = nums2[nums2.Length - 1]; // последний тк последний индекс это длина массива - 1 (тк индекс идет с 0)
        var last2 = nums2[nums2.Length - 2]; // предпоследний тк индекс длина массива - 2 и тд
        
        // Получение элементов с конца массива - новый синтаксис .NET 8
        var lastNew = nums4[^1]; // последний с конца
        var lastNew2 = nums4[^3]; // 3-ий с конца и тд
        
        // Перебор массивов в циклах
        
        // foreach
        foreach (var str in strs)
            Console.WriteLine(str);
        
        // for
        for (int i = 0; i < strs.Length; i++)
            Console.WriteLine(strs[i]);

        // while
        var it = 0;
        while (it < strs.Length)
        {
            Console.WriteLine(strs[it]);
            it++;
        }

        // Многомерные массивы - имеют больше одного ранга (измерения) [,,]
        // Варианты записи
        // Количество элементов в элементе в измерении должно одинаково {123},{123} - можно {123},{1234} - нельзя
        int[,] nums7;
        int[,] nums8 = new int[2, 3];
        int[,] nums9 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
        int[,] nums10 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] nums11 = { { 1, 2 }, { 3, 4 } };
        
        // Трехмерный массив
        int[,,] nums12 = new int[2, 3, 4];
        
        // Количество измерений массива
        var dimensionsCount = nums12.Rank;
        
        // длина измерения массива
        var dimensionLength = nums12.GetUpperBound(0) + 1;
        
        // Перебор многомерных массивов
        // Длина многомерного массива - сумма всех элементов
        foreach (var elem in nums10)
            Console.WriteLine(elem); // выведет все 8 элементов без учетов измерений
        
        // Чтобы пройтись по измерению нужно получить его длину через метод GetUpperBound(0)
        var rows = nums10.GetUpperBound(0) + 1; // получили индекс последнего элемента 0 измерения + 1 (длина)
        var columns = nums10.GetUpperBound(1) + 1; // получили индекс последнего элемента во вложенном массиве + 1
        // var columns = nums10.Length / rows - то же самое

        for (int i1 = 0; i1 < rows; i1++)
        {
            for (int j1 = 0; j1 < columns; j1++)
            {
                Console.WriteLine(nums10[i1, j1]);
            }
        }
        
        // Массив массивов (зубчатый массив) - не путать с многомерными
        // Отличие в том что многомерный массив по структуре многомерный, но это 1 массив
        // Массив массивов - это массив содержащий другие массивы
        
        // Варианты записи
        int[][] nums13 = new int[3][];
        nums13[0] = new int[] { 1, 2, 3 };
        nums13[1] = new int[] { 1, 2, 3, 4 };
        nums13[2] = new int[] { 1, 2, 3, 4, 5 }; // длина отдельных элементов может быть разной

        int[][] nums14 =
        {
            new int[] { 1, 2 },
            new int[] { 1, 2, 3, 4 },
            new int[] { 1 }
        };
        
        // Перебор вложенных массивов
        Console.WriteLine("________");
        for (int i2 = 0; i2 < nums14.Length; i2++)
        {
            for (int j2 = 0; j2 < nums14[i2].Length; j2++)
            {
                Console.WriteLine(nums14[i2][j2]);
            }
        }
        Console.WriteLine("________");
        foreach (var elem2 in nums13)
        {
            foreach (var elem3 in elem2)
            {
                Console.WriteLine(elem3);
            }
        }
        
        // Задачи с массивами
        Console.WriteLine("Задача: колич положительных чисел в массиве");
        // Определим количество положительных чисел
        int[] array1 = { -20, 3, 44, -135, -10, 11, -10, -2 };
        var aboveZeroCount = 0;
        foreach (var el4 in array1)
            if (el4 > 0)
                aboveZeroCount += 1;
        Console.WriteLine($"Колич положительных чисел {aboveZeroCount}");
        
        Console.WriteLine("Задача: инверсия массива");
        
        // Инверсия массива
        sbyte[] array2 = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
        var length2 = array2.Length;
        var mid2 = length2 / 2;
        sbyte temp1;
        for (var i = 0; i < mid2; i++)
        {
            temp1 = array2[length2 - 1 - i]; // сохраняем последний элемент в промежуточную переменную
            array2[length2 - 1 - i] = array2[i]; // меняем последний элемент первым
            array2[i] = temp1; // меняем первый элемент значением из промежуточной переменной

            // решение через XOR - без доп переменной (по закону ассоциативности)
            //array2[i] ^= array2[^(i + 1)];
            //array2[^(i + 1)] ^= array2[i];
            //array2[i] ^= array2[^(i + 1)];
        }

        foreach (var elem3 in array2)
            Console.WriteLine(elem3);
        
        Console.WriteLine("Задача: сортировка по возрастанию");
        
        // Сортировка массива по возрпастанию
        sbyte[] array3 = { -3, 77, 1, 2, 0, -1, 44, -44, 8 };
        sbyte temp;
        for (int i = 0; i < array3.Length - 1; i++) // с первого элемента
        {
            for (int j = i + 1; j < array3.Length; j++) // со второго элемента
            {
                if (array3[i] > array3[j]) // сравниваем если 1 элемент больше второго
                {
                    //temp = array3[i]; // сохраняем 1 элемент в промежуточном значении
                    //array3[i] = array3[j]; // меняем первый элемент вторым
                    //array3[j] = temp; // второй элемент первым
                    
                    // так же можно решить без доп переменной через XOR
                    array3[i] ^= array3[j];
                    array3[j] ^= array3[i];
                    array3[i] ^= array3[j];
                }
            }
        }

        foreach (var el4 in array3)
            Console.WriteLine(el4);
    }
}