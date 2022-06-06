namespace Name
{
    class Program
    {
        public static double fact(int num)
        {
            if (num == 0 || num == 1)
                return 1;
            return num * fact(num - 1);
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Digite el valor de n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El factorial de {0} es: {1}", n, fact(n));
            Console.ReadKey();
        }
    }
}