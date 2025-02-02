namespace HNGStageOne.API.Utilities
{
    public class NumberUtils
    {
        // Function to check if a number is prime
        public static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        // Function to check if a number is perfect (sum of divisors excluding itself equals the number)
        public static bool IsPerfect(int num)
        {
            int sum = 1;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                    if (i != num / i) sum += num / i;
                }
            }
            return sum == num && num != 1;
        }

        // Function to check if a number is an Armstrong number
        public static bool IsArmstrong(int num)
        {
            int originalNum = num, sum = 0, digits = num.ToString().Length;
            while (num > 0)
            {
                int digit = num % 10;
                sum += (int)Math.Pow(digit, digits);
                num /= 10;
            }
            return sum == originalNum;
        }
    }
}
