namespace BaseCSharp.Themes.Basic;

public class Params
{
    public void Run()
    {
        Console.WriteLine("++++++++ МАССИВ ПАРАМЕТРОВ params ++++++++");
        // params позволяет передать массив параметров с неопределенным количеством

        int Sum(params int[] elems) // массив чисел строк и тд с модификатором params
        {
            var result = 0;
            foreach (var el in elems)
            {
                result += el;
            }

            return result;
        }
        
        Console.WriteLine(Sum(1, 5, 7)); // отдельные значения
        int[] nums = { 1, 5, 7, 10, 12 };
        Console.WriteLine(Sum(nums)); // массив значений
        Console.WriteLine(Sum()); // бе параметров
        
        int Sum1(int initial, params int[] elems) // другие параметры должны быть до массива параметров
        {
            var result = initial;
            foreach (var el in elems)
            {
                result += el;
            }

            return result;
        }
        
        Console.WriteLine(Sum1(10, nums));
        
        int Sum2(int initial, int[] elems, int val) // без парамс - просто массив параметров - может находится в любом месте
        {
            var result = initial;
            foreach (var el in elems)
            {
                result += el + val;
            }

            return result;
        }
        
        Console.WriteLine(Sum2(10, nums, 5));
    }
}