using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part1  : MonoBehaviour
{
    // byte (0 ~ 255) 1byte
    // short (-3만 ~ 3만) 2byte
    // integer (-20억 ~ 20억) 4byte
    // long 8byte

    float f = 4.000001f;
    double d = 4.00001;
    decimal m = 4.0000001m;

    // float 실수 자료형 0.000000000001
    // double 실수 자료형 0.000000000000000000000001
    // decimal 실수 자료형

    string s = "aedfadg";
    // char c = 'A'; // 0095

    // 문자 자료형

    int a = 100;
    float b = 100.15f;

    int sum;
    float sum2;

    int c = 100;
    string e;

    int g;
    string h = "100";

    // Start is called before the first frame update
    void Start()
    {
        sum = (int)(a + b);
        sum2 = a + b;

        print(sum);
        print(sum2);

        e = c.ToString();

        print(e); // 문자열 100

        g = int.Parse(h);

        print(g); // 숫자열 100

    }

    // Update is called once per frame
    void Update()
    {

    }
}
