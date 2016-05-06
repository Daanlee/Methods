using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Mergesort_
{
    class Program
    {
        static int[] sieve(int n)
        {
            int[] primes = new int[n];
            bool[] sieve = new bool[n];

            for (int i = 2; i < n / 2; i++)
            {

                for (int j = i + i; j < n; j = j + i)
                {
                    sieve[j] = true;
                }
                sieve[0] = sieve[1] = true;
            }
            int l = 0;
            for (int k = 0; k < n; k++)
            {
                if (!sieve[k])
                {
                    primes[l] = k;
                    l++;
                }

            }
            return primes;
        }

        /*static unsafe void swap(int* x, int* y)
        {
            int temp = *x;
            *x = *y;
            *y = temp;
        }*/

        /*static int[] mergesort(int[] unsorted, int start, int end)
        {
            int middle = (start + end) / 2;
            //Sort the left half
            mergesort()

            return newarray;
        }*/

        static int[] Bubblesort(int[] unsorted)
        {
            for (int i = 0; i < unsorted.Length; i++)
            {
                for (int j = 0; j < unsorted.Length; j++)
                {
                    if (unsorted[i] < unsorted[j])
                    {
                        int temp = unsorted[i];
                        unsorted[i] = unsorted[j];
                        unsorted[j] = temp;
                    }
                }
            }
            return unsorted;
        }

        static int[] Insertionsort(int[] unsorted)
        //Places each element where it belongs in the array
        {
            for (int i = 1; i < unsorted.Length; i++)
            {
                int j = i;
                while (j > 0)
                //Find where element at j goes
                {
                    if (unsorted[j - 1] > unsorted[j])
                    {
                        //Swap elements until the element at j is in the correct place
                        int temp = unsorted[j - 1];
                        unsorted[j - 1] = unsorted[j];
                        unsorted[j] = temp;
                    }
                    j--;
                }
            }
            return unsorted;
        }

        static int[] Selectionsort(int[] unsorted)
        //Finds smallest value in the array and swaps it with the ith element
        {
            for (int i = 0; i < (unsorted.Length); i++)
            {
                int minindex = i;
                for (int j = 0; j < unsorted.Length; j++)
                {
                    if (unsorted[minindex] < unsorted[j])
                    {
                        minindex = j;
                    }
                    //Swap elements - use temp varaible, not bitwise
                    if (minindex != i)
                    {
                        int temp = unsorted[i];
                        unsorted[i] = unsorted[minindex];
                        unsorted[minindex] = temp;
                    }

                }

            }
            return unsorted;
        }

        static void Main(string[] args)
        {
            int six = 6;
            int ten = 10;
            //swap(&six, &ten);
            //System.Console.WriteLine(ten);
            //System.Console.WriteLine(six);
            int[] vals = { 3, 6, 9, 12, 4, 46, 3, 9, 1, 10 };
            //MessageBox.show(toString(vals[0]));
            //System.Console.WriteLine("This is a string");
            //System.Console.WriteLine(vals[0]);
            //vals = Bubblesort(vals);
            //vals = Selectionsort(vals);
            //vals = Insertionsort(vals);
            Console.Write("Enter a number n: ");
            int x = Convert.ToInt32(Console.ReadLine());
            //sieve(5)

            int[] prime = new int[x];
            prime = sieve(x);

            foreach (int j in prime)
            {
                if (j == 0)
                {
                    break;
                }
                System.Console.WriteLine(j);

            }

            foreach (int i in vals)
            {
                System.Console.WriteLine(i);
            }

            return;

        }
    }
}
