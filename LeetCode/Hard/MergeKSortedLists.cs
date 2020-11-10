using System;
namespace LeetCode.Hard
{
    public static class MergeKSortedLists
    {
        public static ListNode MregeKLists(ListNode[] lists)
        {
            ListNode curr = null;
            ListNode head = null;
            bool done = false;

            while (!done)
            {
                done = true;
                int min = int.MaxValue;
                int minIndex = -1;
                int nodeCount = 0;
                for(int i = 0; i < lists.Length; i++)
                {
                    ListNode list = lists[i];

                    if (list != null) nodeCount++;
                    if (nodeCount > 1) done = false;

                    if (list != null && list.val < min)
                    {
                        min = list.val;
                        minIndex = i;
                    }
                }

                if (minIndex != -1 && lists[minIndex] != null)
                {
                    if(curr == null)
                    {
                        curr = new ListNode(lists[minIndex].val);
                        head = curr;
                    } else
                    {
                        curr.next = new ListNode();
                        curr = curr.next;
                        curr.val = lists[minIndex].val;
                    }

                    lists[minIndex] = lists[minIndex].next;
                }

            }

            return head;
            
        }
    }

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
}
