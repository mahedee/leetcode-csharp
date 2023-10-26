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
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode result = null;
        while(head != null)
        {
            // For the first node
            if(result == null)
            {
                result = new ListNode(head.val);
                head = head.next;
            }
            else
            {

                ListNode temp = result;

                // Traverse to the last node
                while(temp.next != null)
                    temp = temp.next;

                // if last node's value and current value are not same
                if(temp.val != head.val)
                    temp.next = new ListNode(head.val);

                // change pointer for the next node to check value
                head = head.next;
            }
        }
        return result;
    }
}