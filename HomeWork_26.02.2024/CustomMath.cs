
namespace HomeWork_26._02._2024
{
    internal class CustomMath
    {
        public int GetSumOfArrayItems(int[] nums) => nums.Where(m => m % 2 == 1).Sum();
        
        public string CheckNumber(int n) => n % 2 == 0 ? "Even" : "Odd";
        
        public double SquareOfEvenNumbers(int[] nums) => Math.Pow(nums.Where(m => m % 2 == 0).Sum(), 2);
      
        public int MultipleOfNumbers(int n)
        {
            int multiplier = 1;
            for(int i = 1;  i <= n; i++)
            {
                multiplier *= i;
            }
            return multiplier;
        }
    }
}
