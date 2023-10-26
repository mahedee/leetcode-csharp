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
    public ListNode AppendNode(int val, ListNode result)
    {
        ListNode head = result;

        // if linked list is empty then create new node and return
        if (head == null)
        {
            head = new ListNode(val);
            return head;
        }

        // if linked list is not empty then iterate till last node
        // and add new node to the last node
        // temp is used to iterate the linked list till last node
        // temp is not changing the value of head because head is pointing to the first node
        // ListNode temp = head; here you are not making a deep copy of the linked list

        ListNode temp = head;
        while (temp.next != null)
        {
            //This statement essentially reassigns the temp reference to point to the next node in the list.
            //Importantly, this does not change the value of head; it only modifies the temp reference.
            //because temp and head are not making a deep copy of the linked list
            temp = temp.next;
        }

        // add new node to the last node
        // this will change the value of head because head is pointing to the first node
        // and temp is now pointing to the last node of the list
        temp.next = new ListNode(val);

        return head;
    }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode resultNode = null;
        int minVal = -101;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                resultNode = AppendNode(list1.val, resultNode);
                list1 = list1.next;
            }
            else
            {
                resultNode = AppendNode(list2.val, resultNode);
                list2 = list2.next;
            }
        }

        while (list1 != null)
        {
            resultNode = AppendNode(list1.val, resultNode);
            list1 = list1.next;
        }

        while (list2 != null)
        {
            resultNode = AppendNode(list2.val, resultNode);
            list2 = list2.next;
        }
        return resultNode;
    }
}