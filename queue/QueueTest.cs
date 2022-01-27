public class QueueTest
{
    public void Run()
    {
        Queue q = new Queue();
        q.Enqueue(3);
        q.Enqueue(8);
        q.Enqueue(-1);
        q.Enqueue(5);
        q.Sort();

        int topVal = q.Dequeue();
        topVal = q.Dequeue();
        topVal = q.Dequeue();
        topVal = q.Dequeue();
        //q.Dequeue();//raises exception    
    }
}