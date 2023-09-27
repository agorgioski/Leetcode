using System.Collections;

namespace TwoSum;

public class Solution
{
    public void Run()
    {
        var rawInput = Console.ReadLine();
        var arr = Array.ConvertAll(rawInput.Trim().Split(new char[] { ',', ' ' }), Convert.ToInt32);
        var target = int.Parse(Console.ReadLine());
        Console.WriteLine(string.Join(' ', TwoSum(arr, target)));
    }

    public int[] TwoSum(int[] nums, int target)
    {
        Hashtable seen = new ();
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (!seen.ContainsKey(target - nums[i]))
                seen.Add(target - nums[i], i);
            if (seen.ContainsKey(nums[i + 1]))
                return new int[] { (int)seen[nums[i+1]], i+1 };
        }
        return null;
    }
}