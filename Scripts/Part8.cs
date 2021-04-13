using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part8 : MonoBehaviour
{

    int[] exp = { 50, 100, 150, 200, 250 };
    int[] array = new int[10];

    // 2차원 배열
    int[,] array2 = { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 } };

    // Start is called before the first frame update
    void Start()
    {
        print(exp.Length);
        print(array2[1, 3]);
        print(array2[0, 1]);

        exp[4] = 300;
        print(exp[4]);
        
        for (int i = 0; i < exp.Length; i++)
        {
            print(exp[i]);
        }

        for (int i = 0; i < 10; i++)
        {
            array[i];
            print(array[i]);
        }
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
