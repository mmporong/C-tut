using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part6 : MonoBehaviour
{
    int input = 5;
    int num = 10;

    bool result;


    // Start is called before the first frame update
    void Start()
    {
        result = input > num;

        if (result)
        {
            print("input�� num���� Ů�ϴ�");
        }
        else if (input < num)
        {
            print("input�� num���� �۽��ϴ�");
        }
        else 
        {
            print("input�� num�� �����ϴ�");
        }

        switch (input)
        {
            case 10:
                print("input�� ���� 10�Դϴ�.");
                break;
            case 11:
                print("input�� ���� 11�Դϴ�.");
                break;
            default:
                print("�� ���� ���");

                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
