namespace Try.SingleLinkedList
{

    public class SinglyLinkedList
    {
        public Node Head { get; private set; }
        public Node Tail { get; private set; }

        public int Count { get; private set; }

        public bool IsEmpty => Count == 0;

        public void AddFirst(int value)
        {
            AddFirst(GetNewNode(value));
        }

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

        public void AddLast(int value)
        {
            AddLast(GetNewNode(value));
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

        public void InsertAt(int data, int position)
        {
            int counter = 1;
            Node currentNode = Head;
            Node newNode = GetNewNode(data);

            while (counter < position)
            {
                currentNode = currentNode.Next;
                counter++;
            }

            newNode.Next = currentNode.Next;
            currentNode.Next = newNode;
            Count++;
        }

        private Node GetNewNode(int data) => new(data);

    }

}
