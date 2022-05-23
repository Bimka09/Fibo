using System;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(PowerN_2LogN(3, 5));
            //Console.WriteLine(PowerLogN(3, 5));

            var fibo = new Fibo();
            Console.WriteLine(fibo.PowerLogN(24));
        }
        static long PowerN_2LogN(long a, long n)
        {
            bool firstCheck = true;
            long a1 = a;
            int j = 2;
            long b = n / 2;
            for (;j <= b; j *= 2)
            {
                if (firstCheck)
                {
                    a *= a;
                    firstCheck = false;
                }
                a *= a;
            }
            for (; j < n; j ++)
            {
                if (firstCheck)
                {
                    a *= a;
                    firstCheck = false;
                }
                a *= a1;
            }
            return a;
        }
        static long PowerLogN(long a, long n)
        {

            long p = 1;
            for(; n > 1; n /= 2)
            {
                if( n % 2 ==1)
                {
                    p *= a;
                }
                a *= a;
            }
            p *= a;
            return p;
        }
    }
}
