// Note: Your solution should have O(l1.length + l2.length) time complexity, since this is what you will be asked to
// accomplish in an interview.
// Given two singly linked lists sorted in non-decreasing order, your
// task is to merge them. In other words, return a singly linked list,
// also sorted in non-decreasing order, that contains the elements from both original lists.

namespace CodeSignal.InterviewPractice.LinkedList
{
    internal class MergeTwoLinkedLists
    {
        // Singly-linked lists are already defined with this interface:
         public class ListNode<T> {
           public T Value { get; set; }
           public ListNode<T> Next { get; set; }
         }
        //
        public ListNode<int> Solution(ListNode<int> l1, ListNode<int> l2)
        {
            ListNode<int> result = null;

            ListNode<int> current = null;

            while (l1 != null && l2 != null)
            {
                if (l1.Value <= l2.Value)
                {
                    if (result == null)
                    {
                        result = new ListNode<int>();
                        current = result;
                    }
                    else
                    {
                        current.Next = new ListNode<int>();
                        current = current.Next;
                    }

                    current.Value = l1.Value;
                    l1 = l1.Next;
                }
                else
                {
                    if (result == null)
                    {
                        result = new ListNode<int>();
                        current = result;
                    }
                    else
                    {
                        current.Next = new ListNode<int>();
                        current = current.Next;
                    }

                    current.Value = l2.Value;
                    l2 = l2.Next;
                }
            }

            if (l1 != null)
            {
                if (result == null)
                {
                    result = l1;
                }
                else
                {
                    current.Next = l1;
                }
            }
            else if (l2 != null)
            {
                if (result == null)
                {
                    result = l2;
                }
                else
                {
                    current.Next = l2;
                }
            }

            return result;
        }
    }
}
