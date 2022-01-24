using System;

public class SinglyLinkedListTest
{

    public void Run()
    {
        Node head = Build();
        Print(head);
        head = Reverse(head);
        Print(head);
    }

    private Node Build()
    {
        //items: 3,8,-1,5
        Node n1 = new Node();
        n1.Value = 3;

        Node n2 = new Node();
        n2.Value = 8;

        Node n3 = new Node();
        n3.Value = -1;

        Node n4 = new Node();
        n4.Value = 5;

        n1.Next = n2;
        n2.Next = n3;
        n3.Next = n4;
        n4.Next = null;

        return n1;
    }

    private void Print(Node head)
    {
        Node cur = head;
        Console.WriteLine("Printing List:");
        while (cur != null)
        {
            Console.WriteLine(cur.Value.ToString());
            cur = cur.Next;
        }
    }

    private Node Reverse(Node head)
    {
        Node prev = null;
        Node cur = head;
        Node next = null;

        while (cur != null)
        {
            next = cur.Next;
            cur.Next = prev;
            prev = cur;
            cur = next;
        }
        return prev;
    }

}