using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Part12.OnStart += Abc;
    }

    public void Abc(int value)
    {
        print(value + "의 값이 증가했습니다");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
