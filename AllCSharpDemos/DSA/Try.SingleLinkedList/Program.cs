using DSA.SingleLinkedList;

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

    }

}
