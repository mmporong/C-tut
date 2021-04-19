using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part9 : MonoBehaviour
{
    int[] exp = new int[5] { 1, 2, 3, 4, 5 };

    // �÷��� : ����Ʈ, ť, ����. �ؽ����̺�, ����ųʸ�, ��̸���Ʈ

    // ArrayList

    ArrayList arrayList = new ArrayList();

    // List

    List<int> list = new List<int>(); // Ư�� ���ĸ� ����

    // HashTable

    Hashtable hashTable = new Hashtable();

    // Dictionary

    Dictionary<string, int> dictionary = new Dictionary<string, int>();

    // Queue, ���Լ���, FIFO, ���� ���� ����� (���� �����)

    Queue<int> queue = new Queue<int>();

    // Stack , ���Լ���, LIFO, �丮����(���� ������)

    Stack<int> stack = new Stack<int>();

    void Start()
    {
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add("����"); 
        arrayList.Remove("����");

        arrayList.Contains(2);

        print(arrayList.Count);  // 5

        for (int i = 0; i < arrayList.Count; i++)
        {
            print(arrayList[i]);
        }

        hashTable.Add("õ", 1000);
        hashTable.Add("��", 10000);

        print(hashTable["õ"]);

        dictionary.Add("õ", 1000);

        print(dictionary["õ"]);

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

