namespace BaseCSharp.Themes.Basic;

public class LocalFunctions
{
    public void Run()
    {
        Console.WriteLine("++++++++ ЛОКАЛЬНЫЕ ФФУНКЦИИ ++++++++");
        // локальные методы (функции) используются внутри метода для избежания повтора кода
        // если необходимо выполнить одинаковые действия

        void Compare(int[] arr1, int[] arr2)
        {
            int Calculate(int[] arr) // локальная функция работающая только внутри этого метода
            {
                var arrSum = 0;
                foreach (var el in arr)
                    arrSum += el;
                return arrSum;
            }

            var arr1Sum = Calculate(arr1);
            var arr2Sum = Calculate(arr2);

            if (arr1Sum > arr2Sum) Console.WriteLine("массив 1 больше массива 2");
            else if (arr1Sum < arr2Sum) Console.WriteLine("массив 2 больше массива 2");
            else Console.WriteLine("массивы равны");
        }

        int[] arr1 = { 1, 2, 3, 5, 8 };
        int[] arr2 = { 2, 7, 10 };
        Compare(arr1: arr1, arr2: arr2);
        
        // Статические локальные функции - не могут обращаться к внешней области видимости
        
        int Sum(int[] numbers)
        {
            var result = 0;
            var minValue = 0;
            foreach (var el in numbers)
                if (IsPassed(el))
                    result += el;
            
            // нестатичная функция может образаться к переменным во внешней области видимости
            bool IsPassed(int el)
            {
                return el >= minValue;
            }
            
            return result;
        }

        int[] arr3 = { -2, 0, 77, 11 };
        Console.WriteLine(Sum(arr3));
        
        int Sum2(int[] numbers)
        {
            var result = 0;
            var minValue = 0;
            foreach (var el in numbers)
                if (IsPassed(el, minValue))
                    result += el;
            
            // статичная функция не может образаться к переменным во внешней области видимости
            static bool IsPassed(int el, int lim)
            {
                //return el >= minValue; - ошибка - не можем обратиться к внешней переменной
                return el >= lim; // - передаем параметром
            }
            
            return result;
        }
        
        var arr4 = new [] { -2, -10, 60, 5, 3 };
        Console.WriteLine(Sum2(arr4));
    }
}