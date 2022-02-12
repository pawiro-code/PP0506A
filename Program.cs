using System;

namespace PP0506A
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[][] ciag = new string[n][];

            int k = 0;

            for (int i = 0; i < n; i++)
            {
                if (i > 0)
                {
                    Console.ReadLine();
                }
                int m = int.Parse(Console.ReadLine());
                string[][] przepisanie = new string[m][];
                int[] x = new int[m];
                double[] wyniki = new double[m];
                x[0] = 0;
                for (int j = 0; j < m; j++)
                {

                    przepisanie[j] = new string[m];
                    przepisanie[j] = Console.ReadLine().Split();
                    wyniki[j] = Math.Sqrt(Math.Pow(int.Parse(przepisanie[j][1]), 2) + Math.Pow(int.Parse(przepisanie[j][2]), 2));
                                  

                }
                

                Array.Sort(wyniki);
                ciag[k] = new string[m];
                int z = 0;
                int b = 0;
                do
                {
                    for (z = 0; z < m; z++)
                    {
                        
                        if (wyniki[b] == Math.Sqrt(Math.Pow(int.Parse(przepisanie[z][1]), 2) + Math.Pow(int.Parse(przepisanie[z][2]), 2)))
                            x[b] = z;
                        else
                            continue;
                            

                    }
                    ciag[k][b] = przepisanie[x[b]][0] + " " + przepisanie[x[b]][1] + " " + przepisanie[x[b]][2];
                    b++;
                } while (b < m);
                k++;
                
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < ciag[i].Length; j++)
                {
                    Console.WriteLine(ciag[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
