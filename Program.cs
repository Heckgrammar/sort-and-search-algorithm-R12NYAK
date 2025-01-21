using System.Diagnostics;
using System.Globalization;

namespace compare_algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random();
            Stopwatch sw = new Stopwatch();


        }
        static int[] CreateArray(int size, Random r)
        {

        }
        static void menu()
        {

        }

        static void BubbleSort(int[] a)
        {

        }
        static void Merge(int[] a, int low, int mid, int high)
        {
            int i, j, k;
            int num1 = mid - low + 1;
            int num2 = high - mid;
            int[] L = new int[num1];
            int[] R = new int[num2];
            for (i = 0; i < num1; i++)
            {
                L[i] = a[low + i];
            }
            for (j = 0; j < num2; j++)
            {
                R[j] = a[mid + j + 1];
            }
            i = 0;
            j = 0;
            k = low;
            while (i < num1 && j < num2)
            {
                if (L[i] <= R[j])
                {
                    a[k] = L[i];
                    i++;
                }
                else
                {
                    a[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < num1)
            {
                a[k] = L[i];
                i++;
                k++;
            }
            while (j < num2)
            {
                a[k] = R[j];
                j++; k++;
            }
        }
        static void MergeSortRecursive(int[] a, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSortRecursive(a, low, mid);
                MergeSortRecursive(a, mid + 1, high);
                Merge(a, low, mid, high);
            }
        }
        static bool LinearSearch(int[] a, int numToFind)
        {
            Console.WriteLine("How many numbers?");
            int length = Convert.ToInt16(Console.ReadLine());
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)

                Console.WriteLine("Enter your list of numbers");

            numbers[i] = Convert.ToInt16(Console.ReadLine());
        }




        static bool BubbleSort(int[] a, int numToFind)
        {

            Console.WriteLine("");


            bool swaps = false;

            do
            {
                swaps = false;
                for (int i = 0; i <= numbers.Length - 1; i++)
                {
                    if (numbers[j] > numbers[j + 1])
                   {
                       
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        swaps = true;

                   }
                   
                }
            } while (swaps);

            Console.WriteLine("The array is sorted");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);


               










            }
        }
    }
}
