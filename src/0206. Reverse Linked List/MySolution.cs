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
    public ListNode ReverseList(ListNode head) {
        
        ListNode result = null;
        while(head != null)
        {
            if(result == null) 
            {
                result = new ListNode(head.val);
            }
            else
            {
                // keep result node to temp variable
                // result node is replaced with a new node
                // previous result node which is now in temp will be the next node of the new node
                // Means each time I iterate the node will be the first node and previous nodes will be the next node
                ListNode temp = result;
                result = new ListNode(head.val);
                result.next = temp;
            }

            head = head.next;
        }

        return result;
    }
}