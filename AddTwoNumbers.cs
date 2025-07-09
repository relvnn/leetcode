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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode preHead = new ListNode(-1);
        ListNode current = preHead;

        int remainder = 0;
        while (l1 != null || l2 != null || remainder > 0)
        {
            int d1 = 0;
            if (l1 != null)
            {
                d1 = l1.val;
                l1 = l1.next;
            }

            int d2 = 0;
            if (l2 != null)
            {
                d2 = l2.val;
                l2 = l2.next;
            }

            int newValue = d1 + d2 + remainder;
            current.next = new ListNode(newValue % 10);
            remainder = newValue / 10;
            
            current = current.next;
        }

        return preHead.next;
    }
}
