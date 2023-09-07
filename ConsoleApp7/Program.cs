internal class Program
{
    private static void Main(string[] args)
    {
        int x = -5, y = 3, res = 0;

        Add(x, y, res);
    }
    private static int Add(int x, int y, int res)
    {
        for (int i = 0; i < Math.Abs(x); i++) res += y;

        if (y > 0 || x < 0 && y < 0)
            Console.WriteLine(res / -1);
        else
            Console.WriteLine(res);

        return res;
    }
}