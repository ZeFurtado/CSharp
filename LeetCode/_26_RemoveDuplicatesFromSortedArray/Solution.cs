namespace _26_RemoveDuplicatesFromSortedArray;


static class Solution
{
    public static int RemoveDuplicates(params int[] nums)
    {
        int a = 0;
        int b = 1;

        do
        {
            if (nums[a] == nums[b])
            {
                nums[b] = nums[b + 1];
            }
            else
            {
                a++;
                b++;
            }

            Console.WriteLine("Loop?");
        } while (b < nums.Length);

        //0,0,1,1,1,2,2,3,3,4

        foreach (int n in nums)
        {
            Console.WriteLine("- " + n);
        }

        return 5;
    }
    

}