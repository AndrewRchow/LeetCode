using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace Easy_csharp
{
    public static class MergeTwoLists1
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode dummyNode = new ListNode(0);
            ListNode cur = dummyNode;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    cur.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    cur.next = l2;
                    l2 = l2.next;
                }

                cur = cur.next;
            }

            while (l1 != null)
            {
                cur.next = l1;
                l1 = l1.next;
            }

           while (l2 != null)
            {
                cur.next = l2;
                l2 = l2.next;
            }
            

            return dummyNode.next;
        }

        public static ListNode MergeTwoLists2(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;

            var tmp1 = l1.next;
            var tmp2 = l2.next;
            if (l2.val > l1.val)
            {
                l1.next = MergeTwoLists(tmp1, l2);

                return l1;
            }

            l2.next = MergeTwoLists(l1, tmp2);
            return l2;
        }

        
        public static void Test()
        {

        }
    }
}
