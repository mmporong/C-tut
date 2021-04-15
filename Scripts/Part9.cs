using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part9 : MonoBehaviour
{
    int[] exp = new int[5] { 1, 2, 3, 4, 5 };

    // 컬렉션 : 리스트, 큐, 스택. 해시테이블, ㄷ기셔너리, 어레이리스트

    // ArrayList

    ArrayList arrayList = new ArrayList();



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

    }


}
