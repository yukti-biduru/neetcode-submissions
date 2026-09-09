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
            List<ListNode> nodes = new List<ListNode>();
            int index = 0;
            ListNode curr = head;
            while (curr != null)
            {
                nodes.Add(curr);
                index++;
                curr = curr.next;
            }

            if (index > n)
            {
                ListNode savednode = nodes[index - n - 1];
                if (savednode.next != null)
                    savednode.next = savednode.next.next;
            }
            else if (index == n)
            {
                ListNode savednode = nodes[index - n];
                if (head != null)
                    head = head.next;
            }
            else
            { return null; }


            return head;
        }
}
