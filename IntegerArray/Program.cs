using System;
using System.Collections.Generic;

class Program
{
    static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int num in nums)
        {
            if (set.Contains(num))
            {
                return true;
            }
            set.Add(num);
        }

        return false;
    }

    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 1 };
        bool hasDuplicates = ContainsDuplicate(nums);

        Console.WriteLine(hasDuplicates ? "true" : "false");
        Console.ReadLine();
    }
}
