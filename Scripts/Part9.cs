using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part9 : MonoBehaviour
{
    int[] exp = new int[5] { 1, 2, 3, 4, 5 };

    // �÷��� : ����Ʈ, ť, ����. �ؽ����̺�, ����ųʸ�, ��̸���Ʈ

    // ArrayList

    ArrayList arrayList = new ArrayList();



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

    }


}
