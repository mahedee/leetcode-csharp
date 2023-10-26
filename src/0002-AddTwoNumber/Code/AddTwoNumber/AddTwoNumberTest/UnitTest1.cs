using Xunit;

namespace AddTwoNumberTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ListNode l1;
            ListNode l2;
            ListNode expected;


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

            expected = new ListNode(8);
            expected.next = new ListNode(9);
            expected.next.next = new ListNode(9);
            expected.next.next.next = new ListNode(9);
            expected.next.next.next.next = new ListNode(0);
            expected.next.next.next.next.next = new ListNode(0);
            expected.next.next.next.next.next.next = new ListNode(0);
            expected.next.next.next.next.next.next.next = new ListNode(1);

            ListNode result = new Solution().AddTwoNumbers(l1, l2);

            //Assert.(expected == result);


        }
    }
}