using System;

public class Queue
{

    private Node head;
    private Node tail;
    private int size = 0;

    public void Enqueue(int num)
    {
        Node n = new Node();
        n.Value = num;
        n.Next = null;
        size++;

        if (head == null)
        {
            head = n;
        }
        else
        {
            Node cur = head;
            while (cur != null)
            {
                if (cur.Next == null)
                {
                    cur.Next = n;
                    tail = n;
                    break;
                }
                else
                {
                    cur = cur.Next;
                }
            }
        }
    }

    public int Dequeue()
    {
        if (tail != null)
        {
            Node cur = head;
            int returnVal = tail.Value;

            if (tail == head)
            {
                head = null;
                tail = null;
            }
            else
            {
                while (cur != null)
                {
                    if (cur.Next == tail)
                    {
                        cur.Next = null;
                        tail = cur;
                        break;
                    }
                    else
                    {
                        cur = cur.Next;
                    }
                }
            }

            size--;
            return returnVal;
        }
        else
        {
            throw new Exception("Queue is empty");
        }
    }

    public int Top()
    {
        return head.Value;
    }

    public void Sort()
    {
        //there are limited options incl:
        // move to a linear structure, sort and copy back
        // quadratic/recursive
        // keep it sorted (during insertion)
        //that's because we're using singly linked list (no indexes)

        int[] tempArr = new int[size];
        Node cur = head;
        int i = 0;

        while (cur != null)
        {
            tempArr[i] = cur.Value;
            i++;
            cur = cur.Next;
        }

        Array.Sort(tempArr);
        cur = head;
        i = 0;

        while (cur != null)
        {
            cur.Value=tempArr[i];
            i++;
            cur = cur.Next;
        }

    }

}