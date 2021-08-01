using System;
using System.Linq;
using static System.Console;

namespace Try.SingleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList _singlyLinkedList = new();

            InitializeSinglyLinkedList(_singlyLinkedList);

            string nodeInformation = "5,1";
            int[] nodeDetails = nodeInformation.Split(',').Select(int.Parse).ToArray();

            AddValuetoSinglyLinkedList(_singlyLinkedList, nodeDetails[0], --nodeDetails[1]);

            nodeInformation = "9,7";
            nodeDetails = nodeInformation.Split(',').Select(int.Parse).ToArray();

            AddValuetoSinglyLinkedList(_singlyLinkedList, nodeDetails[0], --nodeDetails[1]);

            nodeInformation = "99,3";
            nodeDetails = nodeInformation.Split(',').Select(int.Parse).ToArray();

            AddValuetoSinglyLinkedList(_singlyLinkedList, nodeDetails[0], --nodeDetails[1]);

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

        private static void AddValuetoSinglyLinkedList(SinglyLinkedList _singlyLinkedList, int value, int position)
        {
            if (position == 0)
            {
                _singlyLinkedList.AddFirst(value);
            }
            else if (position == _singlyLinkedList.Count)
            {
                _singlyLinkedList.AddLast(value);
            }
            else
            {
                _singlyLinkedList.InsertAt(value, position);
            }
        }

        private static void InitializeSinglyLinkedList(SinglyLinkedList _singlyLinkedList)
        {
            // Initial List 1 -> 5 -> 10 -> 3 -> 6
            _singlyLinkedList.AddLast(1);
            _singlyLinkedList.AddLast(5);
            _singlyLinkedList.AddLast(10);
            _singlyLinkedList.AddLast(3);
            _singlyLinkedList.AddLast(6);
        }
    }
}
