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
    public ListNode RemoveElements(ListNode head, int val) {
        
        ListNode result = null;
        while(head != null)
        {
            if(head.val != val)
            {
                if(result == null) 
                {
                    result = new ListNode(head.val);
                }
                else
                {
                    // traverse result to last node
                    ListNode temp = result;
                    while(temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = new ListNode(head.val);
                }
            }
            head = head.next;
        }

        return result;
    }
}