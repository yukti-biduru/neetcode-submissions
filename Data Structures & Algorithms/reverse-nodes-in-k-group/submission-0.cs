/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k)
       {
            ListNode curr = head;
            PriorityQueue<ListNode, int> nodes = new PriorityQueue<ListNode, int>();
            int count = k;
            ListNode newhead = new ListNode();
            ListNode lnode = newhead;
            ListNode savedNode = head;
            while (curr != null)
            {
                nodes.Enqueue(curr, count);
                count--;

                curr = curr.next;

                if (nodes.Count == k)
                {
                    while (nodes.Count > 0)
                    {
                        lnode.next = nodes.Dequeue();
                        lnode = lnode.next;
                    }
                    count = k;
                    savedNode = curr;
                }
            }

            if (nodes.Count > 0)
            {
                lnode.next = savedNode;
            }
            else
            {
                lnode.next = null;
            }


            return newhead.next;
        }
}
