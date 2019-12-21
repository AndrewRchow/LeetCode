using System;

namespace Easy_csharp
{
    public static class GetDecimalValue
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public static int Solution(ListNode head)
        {
            ListNode currentNode = head;
            string stringBinary = "";
            while(currentNode!=null){
                stringBinary += currentNode.val.ToString();
                currentNode = currentNode.next;
            }
            int output = Convert.ToInt32(stringBinary, 2);
            return output;
        }
    }
}
