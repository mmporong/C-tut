using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part1  : MonoBehaviour
{
    // byte (0 ~ 255) 1byte
    // short (-3�� ~ 3��) 2byte
    // integer (-20�� ~ 20��) 4byte
    // long 8byte

    float f = 4.000001f;
    double d = 4.00001;
    decimal m = 4.0000001m;

    // float �Ǽ� �ڷ��� 0.000000000001
    // double �Ǽ� �ڷ��� 0.000000000000000000000001
    // decimal �Ǽ� �ڷ���

    string s = "aedfadg";
    // char c = 'A'; // 0095

    // ���� �ڷ���

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

        print(e); // ���ڿ� 100

        g = int.Parse(h);

        print(g); // ���ڿ� 100

    }

    // Update is called once per frame
    void Update()
    {

    }
}
