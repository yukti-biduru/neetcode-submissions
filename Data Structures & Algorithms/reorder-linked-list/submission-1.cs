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
    public void ReorderList(ListNode head) 
            {
            head = Rec(head, head.next);
        }

        private ListNode Rec(ListNode root, ListNode curr)
        {
            if(curr == null)
            {
                return root;
            }

            root = Rec(root, curr.next);
            if(root == null)
            {
                return null; 
            }

            ListNode tmp = null; 
            if(root == curr || root.next == curr)
            {
                curr.next = null;
            }
            else
            {
                tmp = root.next;
                root.next = curr;
                curr.next = tmp; 
            }
            return tmp;
        }
}
