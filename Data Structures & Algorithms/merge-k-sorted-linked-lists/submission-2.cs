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

            var Minheap = new PriorityQueue<ListNode, int>();

            foreach (ListNode list in lists)
            {
                if (list != null)
                {
                    Minheap.Enqueue(list, list.val);
                }
            }

            var res = new ListNode(0);
            var cur = res;

            while (Minheap.Count > 0)
            {
                var node = Minheap.Dequeue();
                cur.next = node;
                cur = cur.next;

                node = node.next;

                if (node != null)
                {
                    Minheap.Enqueue(node, node.val);
                }
            }
            return res.next;
        }

}
