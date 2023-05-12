using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionPunto18
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 287;
            int K = 4;

            string result = BaseK(X, K);
            Console.Write("Resultado: " + result);
            Console.ReadKey();
        }


        // Función que devuelve el valor en base K
        public static string BaseK(int X, int K)
        {
            string result = string.Empty;
            do
            {
                result = "0123456789ABCDEF"[X % K] + result;
                X /= K;
            }
            while (X > 0);

            return result;
            //int cociente = 0;
            //int residuo = 0;

            //while (cociente != 1)
            //{
            //    cociente = X / K;
            //    residuo = X % K;
            //}
            //return cociente;
        }
    }
}
