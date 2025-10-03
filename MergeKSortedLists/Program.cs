
using System.Collections.Generic;
using System.Collections.Immutable;

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


public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        var merged = new List<int>();
        foreach (var list in lists) merged.AddRange(Parse(list));
        merged.Sort();
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        foreach (var val in merged)
        {
            current.next = new ListNode(val);
            current = current.next;
        }

        return dummy.next;
    }

    static List<int> Parse(ListNode ln)
    {
        var result = new List<int>();
        while (ln != null)
        {
            result.Add(ln.val);
            ln = ln.next;
        }
        return result;
    }

}

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