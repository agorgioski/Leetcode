namespace MedianOfTwoSortedArrays;

public class Solution
{
    public void Run()
    {
        int[] arr1 = Array.Empty<int>();
        int[] arr2 = Array.Empty<int>();

        string? rawInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(rawInput))
            arr1 = Array.ConvertAll(rawInput.Trim().Split(new char[] { ',', ' ' }), Convert.ToInt32);

        rawInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(rawInput))
            arr2 = Array.ConvertAll(rawInput.Trim().Split(new char[] { ',', ' ' }), Convert.ToInt32);

        Console.WriteLine(FindMedianSortedArrays(arr1, arr2));
    }

    public double FindMedianSortedArrays(int[] first, int[] second)
    {
        if (first.Length == 0)
        {
            if (second.Length % 2 == 0)
                return (double)(second[second.Length / 2] + second[second.Length / 2 - 1]) / 2;
            return second[second.Length / 2];
        }
        if (second.Length == 0)
        {
            if (first.Length % 2 == 0)
                return (double)(first[first.Length / 2] + first[first.Length / 2 - 1]) / 2;
            return first[first.Length / 2];
        }


        // int[] shorter, longer;
        // if (first.Length > second.Length)
        // {
        //     longer = first;
        //     shorter = second;
        // }
        // else
        // {
        //     longer = second;
        //     shorter = first;
        // }

        int middleCombined = (int)Math.Ceiling((double)(first.Length + second.Length) / 2) - 1;
        int sortedCount = 0;

        int l1 = 0; 
        int l2 = 0;
        int r1 = first.Length - 1;
        int r2 = second.Length - 1;

        int m1 = first[l1];
        int m2 = second[r1];
        

        //1. Compare first elements
        //2. Take larger, binary search smaller's array until larger
        //3. If sortedCount < middleCombined repeat 2
        //4. Take smaller, binary search larger's array until smaller
        //5. If sortedCount > middleCombined repeat 4
        //6. Repeat from 2 until sortedCount == middleCombined

        while (sortedCount != middleCombined)
        {
            // m1 = (l1 + r1) / 2;
            // m2 = (l2 + r2) / 2;
            
            if (first[m1] >= second[m2])
            {
                while (l2 <= r2)
                {
                    m2 = (l2 + r2) / 2;
                    if ()
                }
            }
            else 
            {

            }
        }


        // int longerIndex;

        // int middle = 0;
        // bool winnerWinner;

        // for (int i = 0; i < shorter.Length; i++)
        // {
        //     winnerWinner = false;
        //     longerIndex = middleCombined - i;

        //     List<int> subArray = new() { shorter[i], longer[longerIndex] };
        //     if (longerIndex - 1 >= 0) subArray.Add(longer[longerIndex - 1]);
        //     if (longerIndex + 1 < longer.Length) subArray.Add(longer[longerIndex + 1]);
        //     if (i - 1 >= 0) subArray.Add(shorter[i - 1]);
        //     if (i + 1 < shorter.Length) subArray.Add(shorter[i + 1]);

        //     subArray.Sort();

        //     for (int j = 0; j < subArray.Count - 1; j++)
        //     {
        //         if (subArray[j] == shorter[i] && subArray[j + 1] == longer[longerIndex]
        //             || subArray[j] == longer[longerIndex] && subArray[j + 1] == shorter[i])
        //         {
        //             winnerWinner = true;
        //             break;
        //         }
        //     }

        //     // if (shorter[i] >= longer[longerIndex - 1]
        //     //    && shorter[i] <= longer[longerIndex + 1]
        //     //    && longer[longerIndex] >= shorter[i - 1]
        //     //    && longer[longerIndex] <= shorter[i + 1])

        //     if (winnerWinner)
        //     {
        //         if ((shorter.Length + longer.Length) % 2 == 0)
        //             return (double)(shorter[i] + longer[longerIndex]) / 2;

        //         if (shorter[i] > longer[longerIndex])
        //             return longer[longerIndex];

        //         return shorter[i];
        //     }
        // }

        return 0;
    }
}