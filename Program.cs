using System.Diagnostics;

namespace DataStructuresAndAlgorithms;

public class Program
{

    static public void Main()
    {
        //Dynamic Array
        DynamicArray numbers = new DynamicArray(3);
        
        for (int i = 0; i < 5; ++i)
        {
            numbers.Insert(i);
        }

        numbers.Delete(3);

        Console.WriteLine("Dynamic Array: ");
        numbers.Print();

        //Linked List
        var list = new LinkedList();
        list.AddLast(2);
        list.AddLast(3);
        list.AddLast(4);
        list.AddLast(5);
        list.AddFirst(1);

        Console.WriteLine("\n" + "\n" + "Linked List: "); 
        list.Print();
        Console.WriteLine("\n" + "Head: " + list.GetHead()); 
        Console.WriteLine("Tail : " + list.GetTail()); 
        Console.WriteLine("Size: " + list.Size());

        list.Reverse();
        Console.WriteLine("\n" + "\n" + "Linked List Reversed: ");
        list.Print();
        Console.WriteLine("\n" + "Head: " + list.GetHead()); 
        Console.WriteLine("Tail : " + list.GetTail()); 
        Console.WriteLine("Size: " + list.Size());

    }
}
