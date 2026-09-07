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
        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> cycle = new HashSet<ListNode>();
            ListNode curr = head;
            int index = 0;
            while (curr != null)
            {
                if (cycle.Contains(curr))
                {
                    return true;
                }
                else
                {
                    cycle.Add(curr);
                }
                curr = curr.next;
            }
            return false;
        }
}
