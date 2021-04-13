using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part7 : MonoBehaviour
{
    int num = 0;
    string text = "가나다라마바사";

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            num = i;
            print(num);
        }

        foreach(char a in text)
        {
            print(a);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
