using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace Izpitvane_8_mart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers: ");
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int avg = Sumofnums(numbers);
            int zero = Howmanyzero(numbers);

            Console.WriteLine();
            Console.WriteLine($"The count of the zeros is {zero}");
            Console.WriteLine();
            Console.WriteLine($"the sum is {avg}");
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();
            Allnubersprint(numbers);
            Console.WriteLine();
            Closest(numbers);

            int diff = 0;
            int mindiff = 0;
            int index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                diff = avg - numbers[i];
                if (diff <= mindiff)
                {
                    mindiff = diff;
                    index = i;
                }               
            }
            Console.WriteLine($"[{index}] ==> {numbers[index]}");

        }
        static int Sumofnums(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            int avg = sum / nums.Length;

            return avg;
        }
        static int Howmanyzero(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    count++;
                }
            }

            return count;
        }
        static void Allnubersprint(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"on index => [{i}] is number {nums[i]}");
            }


        }
        static void Closest(int[] numbers)
        {

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            int avg = sum / numbers.Length;


            int diff = 0;
            int mindiff = 0;
            int index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                diff = avg - numbers[i];
                if (diff <= mindiff)
                {
                    mindiff = diff;
                    index = i;
                }
            }
            Console.WriteLine($"[{index}] ==> {numbers[index]}");
        }
    }
}
