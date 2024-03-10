namespace BaseCSharp.Themes.Basic;

public class RecursiveFunctions
{
    public void Run()
    {
        Console.WriteLine("++++++++ РЕКУРСИВНЫЕ ФУНКЦИИ ++++++++");
        // Функция вызывающая саму себя
        // Обязательно условие выхода из функции
        
        int Factorial(int n)
        {
            if (n == 1) return 1; // условие выхода из функции
            var el = n * Factorial(n - 1);
            Console.WriteLine(el);
            return el;
        }

        Factorial(12);
        
        Console.WriteLine("_________");

        int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;
            var el = Fibonachi(n - 1) + Fibonachi(n - 2);
            Console.WriteLine(el);
            return el;
        }

        Fibonachi(6);
    }
}