using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part9 : MonoBehaviour
{
    int[] exp = new int[5] { 1, 2, 3, 4, 5 };

    // 컬렉션 : 리스트, 큐, 스택. 해시테이블, ㄷ기셔너리, 어레이리스트

    // ArrayList

    ArrayList arrayList = new ArrayList();

    // List

    List<int> list = new List<int>(); // 특정 형식만 가능

    // HashTable

    Hashtable hashTable = new Hashtable();

    // Dictionary

    Dictionary<string, int> dictionary = new Dictionary<string, int>();

    // Queue, 선입선출, FIFO, 포션 제작 대기줄 (은행 대기줄)

    Queue<int> queue = new Queue<int>();

    // Stack , 후입선출, LIFO, 요리게임(접시 설거지)

    Stack<int> stack = new Stack<int>();

    void Start()
    {
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add("가나"); 
        arrayList.Remove("가나");

        arrayList.Contains(2);

        print(arrayList.Count);  // 5

        for (int i = 0; i < arrayList.Count; i++)
        {
            print(arrayList[i]);
        }

        hashTable.Add("천", 1000);
        hashTable.Add("만", 10000);

        print(hashTable["천"]);

        dictionary.Add("천", 1000);

        print(dictionary["천"]);

        queue.Enqueue(5);
        queue.Enqueue(10);

        if(queue.Count != 0)
            print(queue.Dequeue());
        if (queue.Count != 0)
            print(queue.Dequeue());
        if (queue.Count != 0)
            print(queue.Dequeue());

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        if(stack.Count != 0)
            print(stack.Pop());
        if (stack.Count != 0)
            print(stack.Pop());
        if (stack.Count != 0)
            print(stack.Pop());
        if (stack.Count != 0)
            print(stack.Pop());
    }


}

