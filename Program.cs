﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace pierwszy_algorytm_bez_instrumentacji
{
    class Program
    {
        public static BigInteger[] arr = {1619, 100913, 1009139, 10091401, 100914061, 1009140611, 10091406133, 100914061337, 1009140613399 }; //243 liczba nie bedzie zaliczana w wynikach 
        static bool IsPrime(BigInteger Num)
        {
            if (Num < 2) return false;
            else if (Num < 4) return true;
            else if (Num % 2 == 0) return false;
            else for (BigInteger u = 3; u < Num / 2; u += 2)
                    if (Num % u == 0) return false;
            return true;
        }
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            

            for (int i = 0; i < 9; i++)
            {
                stopwatch.Start();
                Console.Write(i+" "+IsPrime(arr[i])+" ");
                stopwatch.Stop();
                Console.WriteLine(stopwatch.ElapsedMilliseconds);
                stopwatch.Reset();
            }
            
            Console.ReadKey();

        }

    }
}
