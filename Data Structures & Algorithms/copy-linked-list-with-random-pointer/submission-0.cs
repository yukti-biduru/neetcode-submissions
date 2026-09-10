/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    
        Dictionary<Node, Node> dict = new Dictionary<Node, Node>();
        public Node copyRandomList(Node head)
        {
            if (head == null)
                return null;

            if (dict.ContainsKey(head))
                return dict[head];
            
            Node copy = new Node(head.val);
            dict[head] = copy;
            copy.next = copyRandomList(head.next);

            if(head.random != null)
            {
                copy.random = copyRandomList(head.random);
            }
            else
            {
                copy.random = null;
            }
            return copy;
        }
}
