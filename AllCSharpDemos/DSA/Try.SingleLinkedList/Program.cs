using static System.Console;

namespace Try.SingleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList _singlyLinkedList = new();

            _singlyLinkedList.InitializeSinglyLinkedList();

            string nodeInformation = "5,1";
            _singlyLinkedList.AddDataToSinglyLinkedList(nodeInformation);

            nodeInformation = "9,7";
            _singlyLinkedList.AddDataToSinglyLinkedList(nodeInformation);

            nodeInformation = "99,3";
            _singlyLinkedList.AddDataToSinglyLinkedList(nodeInformation);

            nodeInformation = "999,-3";
            _singlyLinkedList.AddDataToSinglyLinkedList(nodeInformation);

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

        //private static void AddValuetoSinglyLinkedList(SinglyLinkedList _singlyLinkedList, int data, int position)
        //{
        //    if (position == 0)
        //    {
        //        _singlyLinkedList.AddFirst(data);
        //    }
        //    else if (position == _singlyLinkedList.Count)
        //    {
        //        _singlyLinkedList.AddLast(data);
        //    }
        //    else
        //    {
        //        _singlyLinkedList.InsertAt(data, position);
        //    }
        //}

        //private static void InitializeSinglyLinkedList(SinglyLinkedList _singlyLinkedList)
        //{
        //    // Initial List 1 -> 5 -> 10 -> 3 -> 6
        //    _singlyLinkedList.AddLast(1);
        //    _singlyLinkedList.AddLast(5);
        //    _singlyLinkedList.AddLast(10);
        //    _singlyLinkedList.AddLast(3);
        //    _singlyLinkedList.AddLast(6);
        //}
    }
}

// int[] nodeDetails = nodeInformation.Split(',').Select(int.Parse).ToArray();
// AddValuetoSinglyLinkedList(_singlyLinkedList, nodeDetails[0], --nodeDetails[1]);

// nodeDetails = nodeInformation.Split(',').Select(int.Parse).ToArray();
// AddValuetoSinglyLinkedList(_singlyLinkedList, nodeDetails[0], --nodeDetails[1]);

// nodeDetails = nodeInformation.Split(',').Select(int.Parse).ToArray();
// AddValuetoSinglyLinkedList(_singlyLinkedList, nodeDetails[0], --nodeDetails[1]);
