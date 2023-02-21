using System;
using System.Collections.Generic;

public class generic
{
    public static void BlankSpace()
    {
        Console.WriteLine(" ");
    }

    #region Array List : Duplicable , Iterative
    public static void ArrayList()
    {
        var namesArray = new List<string>() { "Dhruv" , "Vinayak" , "Nishtaa" , "Sameera" };
        

        foreach (var name in namesArray)
        {
            Console.WriteLine(name);
        }
    }
    #endregion

    #region HashSet : No Duplicates, Iterative
    public static void HashSet()
    {
        var namesHashSet = new HashSet<string>() { "Walter", "Mike", "Saul", "Gus" };

        foreach (var name in namesHashSet)
        {
            Console.WriteLine(name);
        }
    }
    #endregion

    #region Sorted Set : No Duplicates , Iterative , Ascending
    public static void SortedSet()
    {
        var nameSortedSet = new SortedSet<string>() { "White", "Black", "Yellow", "Red" };

        foreach (var name in nameSortedSet)
        {
            Console.WriteLine(name);    
        }
    }
    #endregion

    #region Stack : Duplicable , Iterative , LIFO(Last In First Out)
    public static void Stack()
    {
        Stack<string> names = new Stack<string>();
        names.Push("one");
        names.Push("two");
        names.Push("three");
        names.Push("four");
        names.Push("five");

        Console.WriteLine(names.Peek());
        Console.WriteLine(names.Pop());
        Console.WriteLine(names.Peek());
    }
    #endregion

    #region Queue : Duplicable, Iterative, FIFO(First In First Out)
    public static void Queue()
    {
        Queue<string> namesQueue = new Queue<string>();

        namesQueue.Enqueue("one");
        namesQueue.Enqueue("two");
        namesQueue.Enqueue("three");
        namesQueue.Enqueue("four");

        Console.WriteLine(namesQueue.Peek());
        Console.WriteLine(namesQueue.Dequeue());
        Console.WriteLine(namesQueue.Peek());
    }
    #endregion

    #region Linked List : Duplicable , Iterative , Selective
    public static void LinkedList()
    {
        var linkedNames = new LinkedList<string>();
        linkedNames.AddLast("Orange");
        linkedNames.AddFirst("Mango");
        LinkedListNode<string> node = linkedNames.Find("Mango");
        linkedNames.AddBefore(node, "Apple");

        foreach(string name in linkedNames)
        {
            Console.WriteLine(name);
        }
    }
    #endregion

    #region Dictionary : No Duplicates, Searchable, Selective
    public static void Dictionary()
    {
        Dictionary<string, string> dictionaryNames = new Dictionary<string, string>();
        dictionaryNames.Add("1" , "tshirt");
        dictionaryNames.Add("2" , "pants");
        dictionaryNames.Add("3" , "socks");
        dictionaryNames.Add("4" , "shoes");

        foreach (KeyValuePair <string,string> name in dictionaryNames) {
            Console.WriteLine(name.Key + " " +name.Value);
        }
    }
    #endregion

    public static void Main(string[] args)
    {
        generic random = new generic();
        var arr = new List<Action>()
        {
            () => generic.ArrayList() ,
            () => generic.HashSet() ,
            () => generic.SortedSet() ,
            () => generic.Stack(),
            () => generic.Queue(),
            () => generic.LinkedList(),
            () => generic.Dictionary()
        };
        foreach (Action i in arr)
        {
            i.Invoke();
            generic.BlankSpace();
        }        
    }
}
