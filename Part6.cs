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
            print("input이 num보다 큽니다");
        }
        else if (input < num)
        {
            print("input이 num보다 작습니다");
        }
        else 
        {
            print("input이 num과 같습니다");
        }

        switch (input)
        {
            case 10:
                print("input의 값이 10입니다.");
                break;
            case 11:
                print("input의 값이 11입니다.");
                break;
            default:
                print("그 외의 경우");

                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
