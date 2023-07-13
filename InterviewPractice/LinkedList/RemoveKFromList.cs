using System;

namespace CodeSignal.InterviewPractice.LinkedList
{
    internal class RemoveKFromList
    {
        // Note: Try to solve this task in O(n)
        // time using O(1) additional space, where n is the number of elements in the list,
        // since this is what you'll be asked to do during an interview.
        // Given a singly linked list of integers l and an integer k,
        // remove all elements from list l that have a value equal to k.



        // Singly-linked lists are already defined with this interface:
        public class ListNode<T> {
           public T Value { get; set; }
           public ListNode<T> Next { get; set; }
         }
        //
        public ListNode<int> Solution(ListNode<int> l, int k)
        {
            if (l == null)
                return null;

            while (l != null && l.Value.Equals(k))
            {
                l = l.Next;
            }

            ListNode<int> currentNode = l;

            while (currentNode != null && currentNode.Next != null)
            {
                if (currentNode.Next.Value.Equals(k))
                {
                    currentNode.Next = currentNode.Next.Next;
                }
                else
                {
                    currentNode = currentNode.Next;
                }
            }

            return l;
        }

    }
}
