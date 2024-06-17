
using LeetCode.Class;

class Program
{
    //Test
    public static void Main(String[] args)
    {
        ListNode node = new ListNode(1);
        node.next = new ListNode(2);
        node.next.next = new ListNode(3);

        ListNode nodeCurren = node;
        while (nodeCurren != null)
        {
            Console.WriteLine(nodeCurren.val);
            nodeCurren = nodeCurren.next;
        }
    }
    // Retos
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        return l1;
    }
    public static int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i<nums.Length; i++)
        {
            for(int j = 0+1; j<nums.Length; j++)
            {
                if (nums[i] + nums[j] == target) return new int[] { i, j }; 
            }
        }
        return new int[] { };
    }
}