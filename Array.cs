using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[4] {9,1,2,1,5,4};
           
            int[,] mat = new int[2, 10]; //2 row and 5 columns
            Console.WriteLine(mat.Rank);
           

            #region
            Dictionary<int, int> d = new Dictionary<int, int>(); //key , value pairs

            for (int i=0; i<=10; i++)
            {
                d.Add(i, 0);
            }

     
            //iterate thorugh dictionary
            foreach ( KeyValuePair<int,int> vall in d)
            {
                Console.WriteLine(vall);
            }
            #endregion




            Console.ReadKey();
        }

        public static int[] swap ( int [] a)
        {
            int aux;
            aux = a[0];
            a[0] = a[a.Length - 1];
            a[a.Length - 1] = aux;

            return a;

        }

        /// <summary>
        /// BUBBLE SORT 
        /// </summary>
        /// <param name="arr"></param>
        public static void bubble_sort (int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length ; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        var aux = arr[i];
                        arr[i] = arr[j];
                        arr[j] = aux;
                    }
                }

            }
        }


        /// <summary>
        /// Get the number of apparitions
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int GetMajorityElement(params int[] x)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            int majority = x.Length / 2;

            //Stores the number of occcurences of each item in the passed array in a dictionary
            foreach (int i in x)
                if (d.ContainsKey(i))
                {
                    d[i]++;
                    //Checks if element just added is the majority element
                    if (d[i] > majority)
                        return i;
                }
                else
                    d.Add(i, 1);
            //No majority element
            throw new Exception("No majority element in array");
        }


    }
}
