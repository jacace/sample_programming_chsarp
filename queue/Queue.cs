public class Queue
{

    private Node head;
    private Node tail;

    public void Enqueue(int num)
    {
        Node n = new Node();
        n.Value = num;
        n.Next = null;

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
                    break;
                }
                else
                {
                    cur = cur.Next;
                }
            }
        }
    }

    public object Dequeue()
    {
        return null;
    }

    public int Top()
    {
        return head.Value;
    }

    public void Sort()
    {
        //TODO
    }

}