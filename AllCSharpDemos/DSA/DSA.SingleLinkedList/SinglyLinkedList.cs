using System.Linq;

namespace DSA.SingleLinkedList
{

    public class SinglyLinkedList
    {
        public Node Head { get; private set; }

        public Node Tail { get; private set; }

        public int Count { get; private set; }

        public bool IsEmpty => Count == 0;

        public void InitializeSinglyLinkedList()
        {
            // Initial List 1 -> 5 -> 10 -> 3 -> 6
            AddLast(GetNewNode(1));
            AddLast(GetNewNode(5));
            AddLast(GetNewNode(10));
            AddLast(GetNewNode(3));
            AddLast(GetNewNode(6));
        }

        public void AddDataToSinglyLinkedList(string nodeInformation)
        {
            int[] nodeDetails = nodeInformation.Split(',').Select(int.Parse).ToArray();

            int data = nodeDetails[0];
            int position = --nodeDetails[1];

            // As we are having 1 as starting Index.
            position = (IsEmpty || (nodeDetails[1] < 0)) ? 0 : (position > Count) ? Count : position;

            if (position == 0)
            {
                AddFirst(GetNewNode(data));
            }
            else if (position == Count)
            {
                AddLast(GetNewNode(data));
            }
            else
            {
                InsertAt(data, position);
            }
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

        private void InsertAt(int data, int position)
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
