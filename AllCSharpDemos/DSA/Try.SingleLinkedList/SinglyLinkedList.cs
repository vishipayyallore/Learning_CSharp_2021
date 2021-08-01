namespace Try.SingleLinkedList
{

    public class SinglyLinkedList
    {
        public Node Head { get; private set; }

        public Node Tail { get; private set; }

        public int Count { get; private set; }

        public bool IsEmpty => Count == 0;

        public void AddFirst(int data)
        {
            AddFirst(GetNewNode(data));
        }

        public void AddLast(int data)
        {
            AddLast(GetNewNode(data));
        }

        public void InsertAt(int data, int position)
        {
            int counter = 1;
            Node currentNode = Head;

            while (counter < position)
            {
                currentNode = currentNode.Next;
                counter++;
            }

            Node newNode = GetNewNode(data);
            newNode.Next = currentNode.Next;

            currentNode.Next = newNode;
            Count++;
        }

        private static Node GetNewNode(int data) => new(data);

        private void AddFirst(Node newHead)
        {
            Node currentHead = Head;

            Head = newHead;

            Head.Next = currentHead;

            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
        }

        private void AddLast(Node newTail)
        {
            if (IsEmpty)
            {
                Head = newTail;
            }
            else
            {
                Tail.Next = newTail;
            }

            Tail = newTail;

            Count++;
        }

    }

}
