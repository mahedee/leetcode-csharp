
//Node for linkedlist
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    // Append a new node at the end of the linkedlist
    public ListNode Append(int value, ListNode result)
    {
        ListNode head = result;

        // 1. Allocate a new node
        // 2. Put data in the node
        // 3. Set next as null

        ListNode newNode = new ListNode(value);

        
        // 4. if the linked list empty.
        // Make the new node as head
        
        if(head == null)
        {
            head = newNode;
            return head;
        }


        newNode.next = null;


        // 5. if linked list is not empty then iterate till last node
        // and add new node to the last node
        // last is used to iterate the linked list till last node
        // last is not changing the value of head because head is pointing to the first node
        // ListNode last = head; here you are not making a deep copy of the linked list

        ListNode last = head;
        while (last.next != null)
        {
            //This statement essentially reassigns the last reference to point to the next node in the list.
            //Importantly, this does not change the value of head; it only modifies the last reference.
            //because last and head are not making a deep copy of the linked list
            last = last.next;
        }
        
        // 6. Add new node as next of last node
        // means at the end of the list
        last.next = newNode;
        return head;

    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int carray = 0;
        ListNode? result = null;


        while (!(l1 == null && l2 == null))
        {
            int sum;
            if (l1 == null)
            {
                sum = carray + l2.val;
                l2 = l2.next;
            }
            else if (l2 == null)
            {
                sum = carray + l1.val;
                l1 = l1.next;
            }
            else
            {
                sum = l1.val + l2.val + carray;
                l1 = l1.next; l2 = l2.next;
            }

            carray = sum / 10;
            sum = sum % 10;

            result = Append(sum, result);
        }

        // if carray is not zero at the end 
        // append it to the result
        if (carray > 0)
        {
            result = Append(carray, result);
        }

        return result;

    }
}


public class Program
{
    
    // Test cases
    public static void Main()
    {
        ListNode l1;
        ListNode l2;


        l1 = new ListNode(9);
        l1.next = new ListNode(9);
        l1.next.next = new ListNode(9);
        l1.next.next.next = new ListNode(9);
        l1.next.next.next.next = new ListNode(9);
        l1.next.next.next.next.next = new ListNode(9);
        l1.next.next.next.next.next.next = new ListNode(9);

        l2 = new ListNode(9);
        l2.next = new ListNode(9);
        l2.next.next = new ListNode(9);
        l2.next.next.next = new ListNode(9);

        ListNode result = new Solution().AddTwoNumbers(l1, l2);

    }
}


// Further improvement use test project with test data