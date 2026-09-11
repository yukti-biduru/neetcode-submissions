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
        public ListNode MergeKLists(ListNode[] lists)
                {
            if (lists.Length == 0)
                return null;

            var minHeap = new PriorityQueue<ListNode, int>();

            foreach(ListNode list in lists)
            {
                if(list != null)
                    minHeap.Enqueue(list, list.val);
            }

            ListNode head = new ListNode(0);
            ListNode curr = head;

            while (minHeap.Count > 0)
            {
                var node = minHeap.Dequeue();
                curr.next = node;
                curr = curr.next;

                node = node.next; 

                if(node != null)
                {
                    minHeap.Enqueue(node, node.val);
                }
            }

            return head.next;
        }

}
