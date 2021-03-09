using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Okoronko
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите количество элементов массива: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите элементы массива, которые являются целыми числами: ");
            int[] A = new int[N];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Вид массива до сортировки: ");
            for (int k = 0; k < A.Length; k++)
            {
                Console.Write(A[k] + " ");
            }
            Console.WriteLine();
            // Сортировка элементов в массиве
            for (int i = 1; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length - i; j++)
                {
                    if (A[j] < A[j + 1])
                    {
                        n = A[j + 1];
                        A[j + 1] = A[j];
                        A[j] = n;
                    }
                }
            }
            Console.WriteLine("Элементы массива в порядке убывания: ");
            for (int k = 0; k < A.Length; k++)
            {
                Console.Write(A[k]+ " ");
                Console.ReadLine();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
