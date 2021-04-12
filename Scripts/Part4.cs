using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test2
{
    private int d;
    public int c;
    public static int e; // 공유자원, 정적 변수

    public void abc3()
    {

    }

    private void abc4()
    {

    }
}

public class Part4 : MonoBehaviour
{
    Test2 a1 = new Test2();
    Test2 a2 = new Test2();
    Test2 a3 = new Test2();

    void abcd()
    {
        a1.c = 1;
        a2.c = 5;
        a3.c = 10;

        Test2.e = 100;

        print(a1.c);
        print(a2.c);
        print(a3.c);
        print(Test2.e);
    }

    void Start()
    {
        abcd();
    }

}
