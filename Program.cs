internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap vao so luong so nguyen to can in ra:");
        int numbers = Convert.ToInt32(Console.ReadLine());

        int count = 0;

        int N = 2;

        while (count < numbers)
        {
            if (IsPrime(N))
            {
                Console.WriteLine(N);
                count++;
            }
            N++;
        }
    }
    static bool IsPrime(int n)
    {
        if (n <= 1) return false; 
        for (int i = 2; i <= Math.Sqrt(n); i++) 
        {
            if (n % i == 0) return false; 
        }
        return true; 
    }
}