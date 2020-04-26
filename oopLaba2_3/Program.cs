using System;

namespace oopLaba2_3
{
    public partial class Program
    {
        /*Визначити 1) номер мінімального елемента масиву; 2) добуток елементів масиву,
        розташованих до першого нульового елемента*/
        static int product ( int [] nums ,int n)
        {
            int x = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    x *= nums[i];

                }
                else
                {
                    break;
                }

            }
            return x;


        }

      public   static int Min(int []nums, int n)
        {
            int min = nums[0];
            int y = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                    y = i;
                }
            }
            return min;
           
        }

        static void Main(string[] args)
        {

            Console.Write("N=");

            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];
            ////////////////////////
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Виводим масив =");
            for (int i = 0; i < nums.Length; i++)
            {
               
                Console.Write(nums[i] + " ");
            }
           
            int min = Min(nums,n);
            int x = product(nums, n);
            Console.WriteLine( " Номер мiнiмального числа="+ min);
            Console.WriteLine("Добуток до першого нуля="+x);

        }
    }
}
