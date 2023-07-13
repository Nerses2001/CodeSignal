
using static CodeSignal.InterviewPractice.LinkedList.RemoveKFromList;
using System.Collections.Generic;

namespace CodeSignal.InterviewPractice.LinkedList
{
    internal class IsListPalindrome
    {
        // Note: Try to solve this task in O(n) time using O(1) additional space,
        // where n is the number of elements in l, since this is what you'll be asked to do during an interview.
        // Given a singly linked list of integers, determine whether or not it's a palindrome.
        // Note: in examples below and tests preview linked lists are presented as arrays just for simplicity of visualization:
        // in real data you will be given a head node l of the linked list
 
        
        // Singly-linked lists are already defined with this interface:
        public class ListNode<T> {
           public T Value { get; set; }
           public ListNode<T> Next { get; set; }
         }
        //
        public bool Solution(ListNode<int> l)
        {
            if (l == null || l.Next == null) return true;
            ListNode<int> slow = l;
            Stack<int> stack = new Stack<int>();

            while (slow != null)
            {
                stack.Push(slow.Value);
                slow = slow.Next;
            }

            while (l != null)
            {
                int i = stack.Pop();
                if (l.Value != i) return false;
                l = l.Next;
            }

            return true;


            /*    ListNode<int> currentNode = l.next;
                ListNode<int> prevNode = l;
                int count = 0;
                while(prevNode != null  && currentNode != null)
                {
                    if(prevNode.value > currentNode.value) ++count;
                    else if(prevNode.value < currentNode.value) -- count;

                    prevNode = currentNode;
                    currentNode = currentNode.next;
                }

                return count == 0; 
            */



        }

    }
}
