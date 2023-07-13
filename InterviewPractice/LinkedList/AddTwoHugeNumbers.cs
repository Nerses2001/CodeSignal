

namespace CodeSignal.InterviewPractice.LinkedList
{
    internal class AddTwoHugeNumbers
    {
        // You're given 2 huge integers represented by linked lists. Each linked list element is a number from 0 to 9999 that represents a number with exactly 4 digits.
        // The represented number might have leading zeros. Your task is to add up these huge integers and return the result in the same format.
        // Singly-linked lists are already defined with this interface:
        public class ListNode<T> 
        {
           public T Value { get; set; }
           public ListNode<T> Next { get; set; }
         }
        //
        public ListNode<int> Solution(ListNode<int> a, ListNode<int> b)
        {
            ListNode<int> sum = null;
            int carry = 0;

            var currentA = ReverseList(a);
            var currentB = ReverseList(b);

            while (currentA != null || currentB != null)
            {
                var nodeSum = carry;
                if (currentA != null)
                {
                    nodeSum += currentA.Value;
                    currentA = currentA.Next;
                }

                if (currentB != null)
                {
                    nodeSum += currentB.Value;
                    currentB = currentB.Next;
                }

                carry = nodeSum / 10000;
                sum = new ListNode<int>
                {
                    Value = nodeSum % 10000,
                    Next = sum
                };
            }

            if (carry > 0)
            {
                sum = new ListNode<int>
                {
                    Value = carry,
                    Next = sum
                };
            }

            return sum;
        }

        private ListNode<T> ReverseList<T>(ListNode<T> list)
        {
            ListNode<T> reversed = null;

            for (var current = list; current != null; current = current.Next)
            {
                reversed = new ListNode<T>
                {
                    Value = current.Value,
                    Next = reversed
                };
            }

            return reversed;
        }

    }
}
