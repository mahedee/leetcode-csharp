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
    public bool IsPalindrome(ListNode head) {

        ListNode root = head;
        ListNode reverseList = null;
        int length = 0;

        while(head != null)
        {
            if(reverseList == null)
            {
                reverseList = new ListNode(head.val);
            }
            else
            {
                ListNode temp = reverseList;
                reverseList = new ListNode(head.val);
                reverseList.next = temp;
            }
            head = head.next;
            length++;
        }
        
        if(length == 1) return true;
        int count = 0;
        while(count <= length/2)
        {
            if (root.val != reverseList.val) return false;
            else 
            {
                root = root.next;
                reverseList = reverseList.next;
                count++;
            }
        }

        return true;
    }
}