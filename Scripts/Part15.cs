using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Record
{
    public int[] temp = new int[5];

    public int this[int index]
    {
        get
        {
            if(index >= temp.Length)
            {
                Debug.Log("�ε����� �ʹ� Ů�ϴ�.");
                return 0;
            }
            else
            {
                return temp[index];

            }
        }
        set
        {
            if (index >= temp.Length)
            {
                Debug.Log("�ε����� �ʹ� Ů�ϴ�.");

            }
            else
            {
                temp[index] = value;
            }
        }

    }
}

public class Part15 : MonoBehaviour
{
    Record record = new Record();

    // Start is called before the first frame update
    void Start()
    {
        record[3] = 5;
        record[5] = 5;

        print(record[3]);
        print(record[5]);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
