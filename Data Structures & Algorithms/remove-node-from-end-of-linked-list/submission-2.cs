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
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
            ListNode first = head;
            ListNode second = head;
            int index = 0;
            while (first != null)
            {
                first = first.next;

                if (index > n)
                {
                    second = second.next;
                }
                index++;
            }

            if (index == n)
            {
                head = head.next;
            }
            else
            {
                second.next = second.next.next;
            }


            return head;
        }
}
