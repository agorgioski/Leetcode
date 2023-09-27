namespace AddTwoNumbers;

public class Solution
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public void Run()
    {
        ListNode l1 = FillList();
        ListNode l2 = FillList();

        PrintLinkedList(AddTwoNumbers(l1, l2));
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode firstNode = l1;
        bool carryOver = false;

        while (l1 != null && l2 != null)
        {
            carryOver = AddNodes(ref l1, ref l2, carryOver);

            if (l1.next == null && l2.next != null)
            {
                l1 = l1.next = l2.next;
                break;
            }

            if (l2.next == null && l1.next != null)
            {
                l1 = l1.next;
                break;
            }

            if (l1.next == null && l2.next == null && carryOver)
            {
                l1.next = new(1);
                return firstNode;
            }

            l1 = l1.next;
            l2 = l2.next;
        }

        while (carryOver)
        {
            carryOver = false;
            if (++l1.val > 9)
            {
                l1.val -= 10;
                carryOver = true;
            }
            if (l1.next == null && carryOver)
            {
                l1.next = new(1);
                break;
            }
            l1 = l1.next;
        }

        return firstNode;
    }

    private bool AddNodes(ref ListNode l1, ref ListNode l2, bool carryOver)
    {
        int currentSum = l1.val + l2.val;
        if (carryOver)
            currentSum++;

        if (currentSum > 9)
        {
            l1.val = currentSum - 10;
            carryOver = true;
        }
        else
        {
            l1.val = currentSum;
            carryOver = false;
        }

        return carryOver;
    }

    private ListNode FillList()
    {
        var rawInput = Console.ReadLine();
        var arr = Array.ConvertAll(rawInput.Trim().Split(new char[] { ',', ' ' }), Convert.ToInt32);

        ListNode list = new();
        ListNode firstNode = new(arr[0]);

        if (arr.Length <= 1)
            return firstNode;

        firstNode.next = list;

        for (int i = 1; i < arr.Length; i++)
        {
            list.val = arr[i];
            if (i != arr.Length - 1)
            {
                list.next = new ListNode();
                list = list.next;
            }
        }

        return firstNode;
    }

    private void PrintLinkedList(ListNode list)
    {
        while (true)
        {
            Console.Write(list.val + " ");

            if (list.next == null) break;

            list = list.next;
        }
    }
}