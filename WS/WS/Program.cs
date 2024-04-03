//Фешкин Евгений группа 22ит35 вариант 16  найти ((x-1)^2n+1)/(2n+1)((x+1)^2n+1
internal class Program
{
    private static void Main(string[] args)
    {
        double N = Convert.ToDouble(Console.ReadLine());
        double x = Convert.ToDouble(Console.ReadLine());
        double result = 2;
        for(int i = 0;i<=N;i++)
        {
            result += (Math.Pow(x-1, 2*i + 1)) / ((2 * i + 1) * Math.Pow(x+1, 2 * i + 1));
        }
        Console.WriteLine(result);
    }
}