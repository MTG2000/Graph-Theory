using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Theory_3
{
    class Utils
    {

        public static int[,] MultiplyTwoArrays(int[,] a1, int[,] a2, int m1, int n1, int m2, int n2)
        {
            int i, j;
            if (n1 != m2)
            {
                Console.WriteLine("Matrix multiplication not possible");
                return null;
            }
            else
            {
                int[,] c = new int[m1, n2];
                for (i = 0; i < m1; i++)
                {
                    for (j = 0; j < n2; j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < n1; k++)
                        {
                            c[i, j] += a1[i, k] * a2[k, j];
                        }
                    }
                }
                return c;
            }
        }

        public static int[,] MultiplyArrayNTime(int[,] a1,  int N)
        {
            int i, j;

            double tempLength = Math.Sqrt(a1.Length);
            if (tempLength % 1 == 0)     
            {
                int length = (int)tempLength;
                int[,] result = new int[length, length];
                int[,] aux = new int[length, length];

                Array.Copy(a1, aux, a1.Length);
                Array.Copy(a1, result, a1.Length);

                while (--N != 0)
                {
                    for (i = 0; i < length; i++)
                    {
                        for (j = 0; j < length; j++)
                        {
                            result[i, j] = 0;
                            for (int k = 0; k < length; k++)
                            {
                                result[i, j] += a1[i, k] * aux[k, j];
                            }
                        }
                    }

                    Array.Copy(result, aux, a1.Length);

                }
                return result;
            }

            return null;
        }


    }
}
