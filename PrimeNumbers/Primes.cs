using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    public class Primes
    {
        long[] primes;
        public void Start()
        {
            Stopwatch clock = new Stopwatch();
            for(long N = 10; N < 1000_000_000; N*=10)
            {
                clock.Start();
                long q = CountPrimes(N);
                clock.Stop();
                Console.WriteLine($"{N} - {q} {clock.ElapsedMilliseconds} ms" );
            }
        }
        private long CountPrimes(long N)
        {
            long count = 0;
            primes = new long[N / 2];
            primes[count++] = 2;
            for (int i = 3; i <= N; i++)
            {
                if (IsPrime(i))
                {
                    primes[count++] = i;
                }
            }
            return count;
        }
        private bool IsPrime(long N)
        {;
            long sqrtN = (long)Math.Sqrt(N);
            for(int i = 0; primes[i] <= sqrtN; i ++)
            {
                if(N % primes[i] == 0) 
                    return false;   
            }
            return true;
        }
    }
}
